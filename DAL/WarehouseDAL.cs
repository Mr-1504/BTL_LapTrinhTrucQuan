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
            public static string DAL_CheckInformant(string key, int informantValue)
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

            public static int DAL_UpdateField(Dictionary<string, string> formData)
            {
                string command = string.Empty;
                switch (formData["tableName"])
                {
                    case "NguyenLieu":
                        command = "update NguyenLieu set " +
                                   $"TenNguyenLieu = N'{formData["TenNguyenLieu"]}', " +
                                   $"DonViTinh = N'{formData["DonViTinh"]}', " +
                                   $"CongDung = N'{formData["CongDung"]}', " +
                                   $"YeuCau = N'{formData["YeuCau"]}', " +
                                   $"ChongChiDinh = N'{formData["ChongChiDinh"]}', " +
                                   $"Soluong = {float.Parse(formData["Soluong"])} " +
                                   $"where MaNguyenLieu = N'{formData["MaNguyenLieu"]}'";
                        break;
                    case "NhaCungCap":
                        command = "update NhaCungCap set " +
                                   $"TenNhaCungCap = N'{formData["TenNhaCungCap"]}', " +
                                   $"DiaChi = N'{formData["DiaChi"]}', " +
                                   $"DienThoai = N'{formData["DienThoai"]}', " +
                                   $"TrangThai = N'{formData["TrangThai"]}' " +
                                   $"where MaNhaCungCap = N'{formData["MaNhaCungCap"]}'";
                        break;
                    case "HoaDonNhap":
                        command = "update HoaDonNhap set " +
                                   $"MaNhanVien = N'{formData["MaNhanVien"]}', " +
                                   $"MaNhaCungCap = N'{formData["MaNhaCungCap"]}', " +
                                   $"NgayNhap = '{formData["NgayNhap"]}' " +
                                   $"where MaHoaDonNhap = N'{formData["MaHoaDonNhap"]}'";
                        break;
                    case "ChiTietHoaDonNhap":
                        DAL_DeleteField(formData);
                        return DAL_AddField(formData);
                }
                return SqlHelper.ExecuteNonQuery(command, new object[] { });
            }
            public static int DAL_DeleteField(Dictionary<string, string> formData)
            {
                string command = string.Empty;
                switch (formData["tableName"])
                {
                    case "NguyenLieu":
                        command = $"delete from NguyenLieu where MaNguyenLieu = N'{formData["MaNguyenLieu"]}'";
                        break;
                    case "NhaCungCap":
                        command = $"delete from NhaCungCap where MaNhaCungCap = N'{formData["MaNhaCungCap"]}'";
                        break;
                    case "HoaDonNhap":
                        command = $"delete from HoaDonNhap where MaHoaDonNhap = N'{formData["MaHoaDonNhap"]}'";
                        break;
                    case "ChiTietHoaDonNhap":
                        command = $"delete from ChiTietHoaDonNhap where MaHoaDonNhap = N'{formData["old_MaHoaDonNhap"]}' and MaNguyenLieu = N'{formData["old_MaNguyenLieu"]}'";
                        break;
                }
                return SqlHelper.ExecuteNonQuery(command, new object[] { });
            }

            private const int GID_SIZEOFNL = 4;
            private const int GID_SIZEOFNCC = 4;
            private const int GID_SIZEOFHDN = 6;
            private static string GenerateNextID(string tableName)
            {
                string res = string.Empty;
                DataTable tempQuery = null;
                switch (tableName)
                {
                    case "NguyenLieu":
                        res = "NL";
                        tempQuery = SqlHelper.ExecuteReader("select top 1 MaNguyenLieu from NguyenLieu where MaNguyenLieu like N'NL%' order by MaNguyenLieu DESC", new object[] { });
                        if (tempQuery != null && tempQuery.Rows.Count > 0)
                        {
                            string numStr = tempQuery.Rows[0][0].ToString().Substring(2);
                            int numInt = -1;
                            int.TryParse(numStr, out numInt);
                            numInt += 1;
                            res += (new string('0', GID_SIZEOFNL - numInt.ToString().Length)) + numInt.ToString();
                        }
                        else res += "0001";
                        break;
                    case "NhaCungCap":
                        res = "NCC";
                        tempQuery = SqlHelper.ExecuteReader("select top 1 MaNhaCungCap from NhaCungCap where MaNhaCungCap like N'NCC%' order by MaNhaCungCap DESC", new object[] { });
                        if (tempQuery != null && tempQuery.Rows.Count > 0)
                        {
                            string numStr = tempQuery.Rows[0][0].ToString().Substring(4);
                            int numInt = -1;
                            int.TryParse(numStr, out numInt);
                            numInt += 1;
                            res += (new string('0', GID_SIZEOFNCC - numInt.ToString().Length)) + numInt.ToString();
                        }
                        else res += "0001";
                        break;
                    case "HoaDonNhap":
                        res = "HDN";
                        tempQuery = SqlHelper.ExecuteReader("select top 1 MaHoaDonNhap from HoaDonNhap where MaHoaDonNhap like N'HDN%' order by MaHoaDonNhap DESC", new object[] { });
                        if (tempQuery != null && tempQuery.Rows.Count > 0)
                        {
                            string numStr = tempQuery.Rows[0][0].ToString().Substring(4);
                            int numInt = -1;
                            int.TryParse(numStr, out numInt);
                            numInt += 1;
                            res += (new string('0', GID_SIZEOFHDN - numInt.ToString().Length)) + numInt.ToString();
                        }
                        else res += "000001";
                        break;
                }
                return res;
            }
            public static int DAL_AddField(Dictionary<string, string> formData)
            {
                string command = string.Empty;
                switch (formData["tableName"])
                {
                    case "NguyenLieu":
                        command = "insert into NguyenLieu(MaNguyenLieu, TenNguyenLieu, DonViTinh, CongDung, YeuCau, ChongChiDinh, Soluong) values " +
                                   $"(N'{GenerateNextID("NguyenLieu")}', N'{formData["TenNguyenLieu"]}', N'{formData["DonViTinh"]}', N'{formData["CongDung"]}', N'{formData["YeuCau"]}', N'{formData["ChongChiDinh"]}', {float.Parse(formData["Soluong"])})";
                        break;
                    case "NhaCungCap":
                        command = "insert into NhaCungCap(MaNhaCungCap, TenNhaCungCap, DiaChi, DienThoai, TrangThai) values " +
                                   $"(N'{GenerateNextID("NhaCungCap")}', N'{formData["TenNhaCungCap"]}', N'{formData["DiaChi"]}', N'{formData["DienThoai"]}', {int.Parse(formData["TrangThai"])})";
                        break;
                    case "HoaDonNhap":
                        command = "insert into HoaDonNhap(MaHoaDonNhap, MaNhanVien, MaNhaCungCap, NgayNhap) values " +
                                   $"(N'{GenerateNextID("HoaDonNhap")}', N'{formData["MaNhanVien"]}', N'{formData["MaNhaCungCap"]}', '{formData["NgayNhap"]}')";
                        break;
                    case "ChiTietHoaDonNhap":
                        command = "insert into ChiTietHoaDonNhap(MaHoaDonNhap, MaNguyenLieu, SoLuong, DonGia) values " +
                                   $"(N'{formData["MaHoaDonNhap"]}', N'{formData["MaNguyenLieu"]}', {float.Parse(formData["SoLuong"])}, {float.Parse(formData["DonGia"])})";
                        break;
                }
                return SqlHelper.ExecuteNonQuery(command, new object[] {});
            }
        }
    }
}
