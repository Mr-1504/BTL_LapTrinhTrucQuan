using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DAL;
using Utilities;

namespace BLL
{
    
    public static class WarehouseBLL
    {
        public static class ListAll
        {
            public static DataTable BLL_GetTable() 
            {
                return WarehouseDAL.ListAll.DAL_GetTable(); 
            }
            public static DataTable BLL_SearchKeywordInColumn(string colName = "", string keyword = "")
            {
                return WarehouseDAL.ListAll.DAL_SearchKeywordInColumn(colName, keyword);
            }
            public static DataTable BLL_OrderByColumn(string colName, Boolean ascend)
            {
                return WarehouseDAL.ListAll.DAL_OrderByColumn(colName, ascend);
            }
        }
        public static class ServingPrecal
        {
            public static DataTable BLL_GetMenu()
            {
                return WarehouseDAL.ServingPrecal.DAL_GetMenu();
            }
            public static DataTable BLL_SearchFromMenu(string keyword)
            {
                return WarehouseDAL.ServingPrecal.DAL_SearchFromMenu(keyword);
            }
            public static void BLL_GetPrecalResult(List<string> dishIDs, ref List<int> out_dishCount, ref List<string> out_lowIngredientNames)
            {
                DataTable precalTable = WarehouseDAL.ServingPrecal.DAL_GetPrecalResult(dishIDs);

                //  * trong trường hợp precalTable có data == đang có món cần tính
                /*
                 * giái thích cách tính:
                 * precalTable trên tính lượng đĩa có thể phục vụ trên tổng lượng mỗi nguyên liệu cần thiết
                 * lấy danh sách nguyên liệu trong precalTable làm danh mục tìm kiếm (ingrIDs)
                 * lập query nguyên liệu cần thiết để nấu món A, kiểm tra xem món A dùng nguyên liệu nào trong ingrIDs, lấy index tìm kiếm và gán giá trị
                 * thuật toán sử dụng là tham lam, tỉ lệ sử dụng nguyên liệu giữa hai đĩa trùng nguyên liệu là 1:1
                 */
                if (precalTable != null)
                {
                    int assigningIndex = 0;
                    foreach (string dishID in dishIDs)
                    {
                        //  lấy danh sách nguyên liệu của món
                        DataTable dishIngrList = SqlHelper.ExecuteReader($"select MaNguyenLieu from NguyenLieuMonAn where MaMonAn = N'{dishID}'", new object[] { });
                        List<string> dishIngrs = new List<string>();
                        foreach(DataRow it in dishIngrList.Rows) dishIngrs.Add(it[0].ToString());
                        
                        //  kiểm tra sự xuất hiện của nguyên liệu theo thứ tự tham lam
                        foreach(DataRow it in precalTable.Rows)
                            if (dishIngrs.Contains(it[0].ToString()))
                            {
                                out_dishCount[assigningIndex] = int.Parse(it[1].ToString());
                                out_lowIngredientNames[assigningIndex] = it[2].ToString();
                                break;
                            }

                        assigningIndex++;
                    }
                }
            }
        }
        public static class EditData
        {
            public static DataTable BLL_GetTable(string tableName)
            {
                if (string.IsNullOrEmpty(tableName)) return null;
                return WarehouseDAL.EditData.DAL_GetTable(tableName);
            }
            public static DataTable BLL_SearchInTable(string keyword)
            {
                return WarehouseDAL.EditData.DAL_SearchInTable(keyword);
            }

            public const int IFM_NHANVIEN = 0;
            public const int IFM_NHACUNGCAP = 1;
            public const int IFM_NGUYENLIEU = 2;
            public const int IFM_DONVI = 3;
            public const int IFM_NGAYNHAP = 4;
            public static string BLL_CheckInformant(string key, int informantValue)
            {
                return WarehouseDAL.EditData.DAL_CheckInformant(key, informantValue);
            }

            public const int ERR_NOERROR = 1;
            public const int ERR_FIELDVALUENULL = -2;
            public const int ERR_DEPENDENTNULL = -3;
            public const int ERR_NUMBERFORMAT = -4;
            public const int ERR_IDNONEXIST = -5;
            private static int BLL_CheckFieldValueStandard(Dictionary<string, string> formData)
            {
                //  first check: all field need to have data
                foreach (var it in formData) if (string.IsNullOrEmpty(it.Value))
                    {
                        return ERR_FIELDVALUENULL;
                    }

                //  third check: number format check
                switch (formData["tableName"])
                {
                    case "NguyenLieu":
                        if (!float.TryParse(formData["Soluong"], out float tempF)) return ERR_NUMBERFORMAT;
                        break;
                    case "ChiTietHoaDonNhap":
                        if (!float.TryParse(formData["SoLuong"], out tempF)) return ERR_NUMBERFORMAT;
                        if (!float.TryParse(formData["DonGia"], out tempF)) return ERR_NUMBERFORMAT;
                        break;
                }

                return ERR_NOERROR;
            }
            private static int BLL_CheckFieldValueDependancy(Dictionary<string, string> formData)
            {
                //  second check: dependents in existance
                switch (formData["tableName"])
                {
                    case "HoaDonNhap":
                        if (
                            string.IsNullOrEmpty(BLL_CheckInformant(formData["MaNhanVien"], IFM_NHANVIEN)) ||
                            string.IsNullOrEmpty(BLL_CheckInformant(formData["MaNhaCungCap"], IFM_NHACUNGCAP)))
                            return ERR_DEPENDENTNULL;
                        break;
                    case "ChiTietHoaDonNhap":
                        if (
                            string.IsNullOrEmpty(BLL_CheckInformant(formData["MaHoaDonNhap"], IFM_NGAYNHAP)) ||
                            string.IsNullOrEmpty(BLL_CheckInformant(formData["MaNguyenLieu"], IFM_NGUYENLIEU)))
                            return ERR_DEPENDENTNULL;
                        break;
                }
                return ERR_NOERROR;
            }
            private static int BLL_CheckFieldValueExistance(Dictionary<string, string> formData)
            {
                switch (formData["tableName"])
                {
                    case "NguyenLieu":
                        if (string.IsNullOrEmpty(BLL_CheckInformant(formData["MaNguyenLieu"], IFM_NGUYENLIEU))) return ERR_IDNONEXIST;
                        break;
                    case "NhaCungCap":
                        if (string.IsNullOrEmpty(BLL_CheckInformant(formData["MaNhaCungCap"], IFM_NHACUNGCAP))) return ERR_IDNONEXIST;
                        break;
                    case "HoaDonNhap":
                        if (string.IsNullOrEmpty(BLL_CheckInformant(formData["MaHoaDonNhap"], IFM_NGAYNHAP))) return ERR_IDNONEXIST;
                        break;
                    case "ChiTietHoaDonNhap":
                        if (string.IsNullOrEmpty(BLL_CheckInformant(formData["MaHoaDonNhap"], IFM_NGAYNHAP))) return ERR_IDNONEXIST;
                        if (string.IsNullOrEmpty(BLL_CheckInformant(formData["MaNguyenLieu"], IFM_NGUYENLIEU))) return ERR_IDNONEXIST;
                        break;
                }
                return ERR_NOERROR;
            }
            public static int BLL_UpdateField(Dictionary<string, string> formData)
            {
                int status = BLL_CheckFieldValueStandard(formData);
                if (status == ERR_NOERROR) status = BLL_CheckFieldValueDependancy(formData);
                if (status == ERR_NOERROR) status = BLL_CheckFieldValueExistance(formData);
                if (status == ERR_NOERROR)
                {
                    status = WarehouseDAL.EditData.DAL_UpdateField(formData);
                }
                return status;
            }
            public static int BLL_DeleteField(Dictionary<string, string> formData)
            {
                int status = BLL_CheckFieldValueStandard(formData);
                if (status == ERR_NOERROR) status = BLL_CheckFieldValueExistance(formData);
                if (status == ERR_NOERROR)
                {
                    status = WarehouseDAL.EditData.DAL_DeleteField(formData);
                }
                return status;
            }
            public static int BLL_AddField(Dictionary<string, string> formData)
            {
                int status = BLL_CheckFieldValueStandard(formData);
                if (status == ERR_NOERROR) status = BLL_CheckFieldValueDependancy(formData);
                if (status == ERR_NOERROR)
                {
                    status = WarehouseDAL.EditData.DAL_AddField(formData);
                }
                return status;
            }
        }
    }
}
