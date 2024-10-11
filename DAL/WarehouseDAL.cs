using System;
using System.Collections.Generic;
using System.Data;
using Utilities;

namespace DAL
{
    public static class WarehouseDAL
    {
        public static class ListAll
        {
            private static string TableQuery = "select MaNguyenLieu, TenNguyenLieu, DonViTinh, Soluong from NguyenLieu";
            private static string SearchQuery = string.Empty;
            private static string OrderQuery = string.Empty;

            public static void DAL_SetValueDefault()
            {
                TableQuery = "select MaNguyenLieu, TenNguyenLieu, DonViTinh, Soluong from NguyenLieu";
                SearchQuery = string.Empty;
                OrderQuery = string.Empty;
            }

            public static DataTable DAL_GetTable()
            {
                return SqlHelper.ExecuteReader(TableQuery + SearchQuery + OrderQuery, new object[] { });
            }
            public static DataTable DAL_SearchKeywordInColumn(string colName = "", string keyword = "")
            {
                if (!string.IsNullOrEmpty(colName) && !string.IsNullOrEmpty(keyword))
                {
                    SearchQuery = $" where {colName} like N'%{keyword}%'";
                }
                else
                {
                    SearchQuery = string.Empty;
                }
                return DAL_GetTable();
            }
            public static DataTable DAL_OrderByColumn(string colName, Boolean ascend)
            {
                OrderQuery = $" order by {colName} {(ascend ? "ASC" : "DESC")}";
                return DAL_GetTable();
            }
        }
        public static class ServingPrecal
        {
            private static string MenuQuery = "select MaMonAn, TenMonAn, DonGia from MonAn where TrangThai = 1";
            private static string SearchQuery = string.Empty;

            public static DataTable DAL_GetMenu()
            {
                return SqlHelper.ExecuteReader(MenuQuery + SearchQuery, new object[] { });
            }
            public static DataTable DAL_SearchFromMenu(string keyword)
            {
                SearchQuery = string.IsNullOrEmpty(keyword) ? string.Empty : $" and (MaMonAn like N'%{keyword}%' or TenMonAn like N'%{keyword}%' or DonGia like N'%{keyword}%')";
                return DAL_GetMenu();
            }
            public static DataTable DAL_GetPrecalResult(List<string> dishIDs)
            {
                string dishList = MakeStringForSQLQuery(dishIDs);
                return SqlHelper.ExecuteReader(
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
            }
        }

        public static string MakeStringForSQLQuery(List<string> daList)
        {
            string res = "(";
            foreach (string s in daList) res += "'" + s + "',";
            res = res.Substring(0, res.Length - 1) + ")";
            return res;
        }
    }
}
