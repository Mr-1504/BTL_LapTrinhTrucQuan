using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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
            public static void BLL_GetPrecalResult(ref List<string> dishIDs, ref List<int> out_dishCount, ref List<string> out_lowIngredientNames)
            {
                string dishList = MakeStringForSQLQuery(dishIDs);
                DataGridView temp = new DataGridView();
                temp.DataSource = SqlHelper.ExecuteReader(
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
                     "select TenNguyenLieu, InStock.MaNguyenLieu, cast((TrongKho / CanDung) as int) as Precal " +
                     "from InStock join Requiring on InStock.MaNguyenLieu = Requiring.MaNguyenLieu " +
                     "order by Precal ASC", new object[] { });

                // todo: xuất tên với số đĩa tính được ra 2 List<> bên trên
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
