using DTO;
using System;
using System.Data;
using Utilities;

namespace DAL
{
    public class FoodDAL
    {
        private int GetFoodCount(string prefix)
        {
            string query = "SELECT COUNT(*) FROM MonAn WHERE MaMonAn LIKE @Prefix + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix });
        }

        public int AddNewFood(string prefix, FoodDTO food)
        {
            string foodCount = (GetFoodCount(prefix) + 1).ToString();
            foodCount = new string('0', 4 -  foodCount.Length) + foodCount;

            string foodId = prefix + foodCount;
            string query = "INSERT INTO MonAn (MaMonAn, TenMonAn, CachLam, DonGia) VALUES ( @foodId , @foodName , @foodMakeing , @foodUnitPrice )";


            return SqlHelper.ExecuteNonQuery(query, new object[] { foodId, food.FoodName, food.FoodMaking, food.FoodUnitPrice });
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
            return SqlHelper.ExecuteNonQuery(query, new object[] {food.FoodName, food.FoodMaking, food.FoodUnitPrice, food.FoodId});
        }

        public int RemoveFood(string foodId) 
        {
            string query = "DELETE FROM MonAn WHERE MaMonAn = @foodId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {foodId});
        }

        public DataTable GetFoods() 
        {
            string query = "SELECT * FROM MONAN";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        public DataTable GetFood(Enum @enum, string getValue)
        {
            if (Config.IsValidEnum<Food>(@enum.ToString()))
            {
                string query = "SELECT * FROM MonAn WHERE " + @enum.GetEnumDescription() + " = @getValue";
                return SqlHelper.ExecuteReader(query, new object[] { getValue });
            }
            return null;
        }
    }
}
