using System;
using System.Collections.Generic;
using System.Data;
using Utilities;

namespace BLL
{
    
    public static class WarehouseBLL
    {
        public static class ListAll
        {
            private static string TableQuery = "select MaNguyenLieu, TenNguyenLieu, DonViTinh, Soluong from NguyenLieu";
            private static string SearchQuery = string.Empty;
            private static string OrderQuery = string.Empty;

            public static void BLL_SetValueDefault()
            {
                TableQuery = "select MaNguyenLieu, TenNguyenLieu, DonViTinh, Soluong from NguyenLieu";
                SearchQuery = string.Empty;
                OrderQuery = string.Empty;
            }

            public static DataTable BLL_GetTable() 
            { 
                return SqlHelper.ExecuteReader(TableQuery + SearchQuery + OrderQuery, new object[] { }); 
            }
            public static DataTable BLL_SearchKeywordInColumn(string colName = "", string keyword = "")
            {
                if (!string.IsNullOrEmpty(colName) && !string.IsNullOrEmpty(keyword))
                {
                    SearchQuery = $" where {colName} like N'%{keyword}%'";
                }
                else
                {
                    SearchQuery = string.Empty;
                }
                return BLL_GetTable();
            }
            public static DataTable BLL_OrderByColumn(string colName, Boolean ascend)
            {
                OrderQuery = $" order by {colName} {(ascend ? "ASC" : "DESC")}";
                return BLL_GetTable();
            }
        }
        public static class ServingPrecal
        {
            private static string MenuQuery = "select MaMonAn, TenMonAn, DonGia from MonAn where TrangThai = 1";
            private static string SearchQuery = string.Empty;

            public static DataTable BLL_GetMenu()
            {
                return SqlHelper.ExecuteReader(MenuQuery + SearchQuery, new object[] { });
            }
            public static DataTable BLL_SearchFromMenu(string keyword)
            {
                SearchQuery = string.IsNullOrEmpty(keyword) ? string.Empty : $" and (MaMonAn like N'%{keyword}%' or TenMonAn like N'%{keyword}%' or DonGia like N'%{keyword}%')";
                return BLL_GetMenu();
            }
            public static void BLL_GetPrecalResult(List<string> dishIDs, ref List<int> out_dishCount, ref List<string> out_lowIngredientNames)
            {
                string dishList = MakeStringForSQLQuery(dishIDs);
                DataTable precalTable = SqlHelper.ExecuteReader(
                    "with InStock as (" +
                        "select NguyenLieu.TenNguyenLieu, NguyenLieu.MaNguyenLieu, NguyenLieu.SoLuong as TrongKho " +
                        "from NguyenLieu join NguyenLieuMonAn on NguyenLieu.MaNguyenLieu = NguyenLieuMonAn.MaNguyenLieu " +
                       $"where MaMonAn in {dishList} " +
                    "), Requiring as ( " +
                        "select MaNguyenLieu, sum(SoLuong) as CanDung " +
                        "from NguyenLieuMonAn " +
                       $"where MaMonAn in {dishList} " +
                        "group by MaNguyenLieu " +
                     ") " +
                     "select InStock.MaNguyenLieu, min(cast((TrongKho / CanDung) as int)) as Precal, TenNguyenLieu " +
                     "from InStock join Requiring on InStock.MaNguyenLieu = Requiring.MaNguyenLieu " +
                     "group by TenNguyenLieu, InStock.MaNguyenLieu " +
                     "order by Precal ASC", new object[] { });

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

        public static string MakeStringForSQLQuery(List<string> daList)
        {
            string res = "(";
            foreach(string s in daList) res += "'" + s + "',";
            res = res.Substring(0, res.Length - 1) + ")";
            return res;
        }
    }
}
