using System;
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

            static void test()
            {
                DataTable dt = new DataTable();
                
            }
        }
    }
}
