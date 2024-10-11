using System;
using System.Collections.Generic;
using System.Data;
using static DAL.WarehouseDAL;
using Utilities;
using DAL;

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
    }
}
