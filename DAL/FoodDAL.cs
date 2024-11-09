using DTO;
using System;
using System.Data;
using Utilities;

namespace DAL
{
    public class FoodDAL
    {
        private int GetFoodCount(FoodType prefix)
        {
            string query = "SELECT COUNT(*) FROM MonAn WHERE MaMonAn LIKE @Prefix + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix.GetEnumDescription() });
        }

        public int AddNewFood(FoodType prefix, FoodDTO food)
        {
            int count = GetFoodCount(prefix) + 1;
            if (count == 0)
                return -1;

            string foodId = prefix.GetEnumDescription() +  new string('0', 4 - count.ToString().Length) + count.ToString();
            string query = "INSERT INTO MonAn (MaMonAn, TenMonAn, CachLam, DonGia, TrangThai) VALUES ( @foodId , @foodName , @foodMakeing , @foodUnitPrice , @status )";

            return SqlHelper.ExecuteNonQuery(query, new object[] { foodId, food.FoodName, food.FoodMaking, food.FoodUnitPrice, (int)food.Status });
        }

        public int IsExistFoodId(string foodId)
        {
            string query = "SELECT COUNT(*) FROM MonAn WHERE MaMonAn = @foodId";
            return SqlHelper.ExecuteScalar(query, new object[] { foodId });
        }

        public int IsExistFoodName(string foodName)
        {
            string query = "SELECT COUNT(*) FROM MonAn WHERE TenMonAn = @foodName";
            return SqlHelper.ExecuteScalar(query, new object[] { foodName });
        }

        public int UpdateFood(FoodDTO food)
        {
            string query = "UPDATE MonAn SET TenMonAn = @foodName , CachLam = @foodMaking , Dongia = @foodUnitPrice WHERE MaMonAn = @foodId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { food.FoodName, food.FoodMaking, food.FoodUnitPrice, food.FoodId });
        }

        public int ChangeFoodStatus(string foodId, Status status)
        {
            string query = "UPDATE MonAn SET TrangThai = @status WHERE MaMonAn = @foodId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {(int)status, foodId });
        }

        public DataTable GetFoods()
        {
            string query = "SELECT * FROM MONAN WHERE TrangThai = 1";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        public DataTable GetFood(Enum @enum, string getValue)
        {
            if (Config.IsValidEnum<Food>(@enum.ToString()))
            {
                string query = "SELECT * FROM MonAn WHERE " + @enum.GetEnumDescription() + " Like '%' + @getValue + '%' AND TrangThai = 1";
                return SqlHelper.ExecuteReader(query, new object[] { getValue });
            }
            return null;
        }
        // lấy nguyên liệu theo món ăn
        public DataTable GetFoodIngredient(string foodID) {
            string query = "Select nl.MaNguyenLieu,TenNguyenLieu,nm.SoLuong,DonViTinh from MonAn as ma join NguyenLieuMonAn as nm on ma.MaMonAn=nm.MaMonAn join NguyenLieu as nl on nm.MaNguyenLieu=nl.MaNguyenLieu where ma.MaMonAn = @foodID";
            return SqlHelper.ExecuteReader(query, new object[] { foodID });
        }
        public DataTable GetNewestFood(FoodType prefix)
        {
            int count = GetFoodCount(prefix);
            if (count == -1)
                return null;
            string foodId = prefix.GetEnumDescription() + new string('0', 4 - count.ToString().Length) + count.ToString();
            string query = "SELECT * FROM MonAn WHERE MaMonAn = @foodId";
            return SqlHelper.ExecuteReader(query, new object[] { foodId });
        }

        public string GetFoodIdByName (string foodName)
        {
            string query = "SELECT MaMonAn FROM MonAn WHERE TenMonAn = @FoodName";
            DataTable dt = SqlHelper.ExecuteReader(query, new object[] { foodName });
            if(dt.Rows.Count > 0)
            {
                return dt.Rows[0]["MaMonAn"].ToString();
            }
            return null;
        }
    }
}
