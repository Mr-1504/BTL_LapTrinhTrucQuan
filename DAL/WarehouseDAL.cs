using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
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
                string dishList = MakeSQLStringOfList(dishIDs);
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

        private static string MakeSQLStringOfList(List<string> daList)
        {
            string res = "(";
            foreach (string s in daList) res += "'" + s + "',";
            res = res.Substring(0, res.Length - 1) + ")";
            return res;
        }

        public static class EditData
        {
            private static string TableQuery = string.Empty;
            private static string SearchQuery = string.Empty;
            private static string tableName = string.Empty;
            private static List<string> tableColNames = new List<string>();

            private static DataTable DAL_GetTable() {
                if (!string.IsNullOrEmpty(TableQuery)) return SqlHelper.ExecuteReader(TableQuery + SearchQuery, new object[] { });
                else return null;
            }
            public static DataTable DAL_GetTable(string tableName)
            {
                EditData.tableName = tableName;
                TableQuery = $"select * from {tableName}";
                return DAL_GetTable();
            }
            private static List<string> GetCurrentTableColumnNamesList()
            {
                DataTable tb = DAL_GetTable();
                if (tb != null)
                {
                    List<string> res = new List<string>();
                    res.Add(tableName);
                    foreach(DataColumn it in tb.Columns)
                    {
                        res.Add(it.ColumnName);
                    }
                    return res;
                }
                else return null;
            }
            private static void UpdateColNames()
            {
                tableColNames = GetCurrentTableColumnNamesList();
            }
            public static DataTable DAL_SearchInTable(string keyword)
            {
                if (string.IsNullOrEmpty(tableName)) return null;
                if (string.IsNullOrEmpty(keyword))
                {
                    SearchQuery = string.Empty;
                }
                else
                {
                    if (tableColNames.Count == 0 || tableColNames[0] != tableName) UpdateColNames();
                    SearchQuery = " where ";
                    for (int i = 1; i < tableColNames.Count - 1; i++) SearchQuery += $"{tableColNames[i]} like N'%{keyword}%' or ";
                    SearchQuery += $"{tableColNames[tableColNames.Count - 1]} like N'%{keyword}%'";
                }
                return DAL_GetTable();
            }

            public const int IFM_NHANVIEN = 0;
            public const int IFM_NHACUNGCAP = 1;
            public const int IFM_NGUYENLIEU = 2;
            public const int IFM_DONVI = 3;
            public const int IFM_NGAYNHAP = 4;
            public static string DAL_InformantCheck(string key, int informantValue)
            {
                string query =
                    informantValue == IFM_NHANVIEN ?
                        $"select TenNhanVien from NhanVien where MaNhanVien = N'{key}'"
                    : informantValue == IFM_NHACUNGCAP ?
                        $"select TenNhaCungCap from NhaCungCap where MaNhaCungCap = N'{key}'"
                    : informantValue == IFM_NGUYENLIEU ?
                        $"select TenNguyenLieu from NguyenLieu where MaNguyenLieu = N'{key}'"
                    : informantValue == IFM_DONVI ?
                        $"select DonViTinh from NguyenLieu where MaNguyenLieu = N'{key}'"
                    :
                        $"select NgayNhap from HoaDonNhap where MaHoaDonNhap = N'{key}'";
                DataTable dt = SqlHelper.ExecuteReader(query, new object[] { });
                return (dt != null && dt.Rows.Count > 0) ? dt.Rows[0][0].ToString() : string.Empty;
            }
        }
    }
}
