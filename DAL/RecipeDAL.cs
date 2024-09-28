using DTO;
using System.Data;
using Utilities;
namespace DAL
{
    public class RecipeDAL
    {
        public int AddNewRecipe(RecipeDTO recipe)
        {
            string query = "INSERT INTO NguyenLieuMonAn (MaMonAn, MaNguyenLieu, SoLuong) VALUES ( @foodId , @ingredientId , @quantity )";
            return SqlHelper.ExecuteNonQuery(query, new object[] { recipe.FoodId, recipe.IngredientId, recipe.Quantity });
        }

        public int UpdateRecipe(RecipeDTO recipe)
        {
            string query = "UPDATE NguyenLieuMonAn SET SoLuong = @quantity WHERE MaMonAn = @foodId AND MaNguyenLieu = @ingredientId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {recipe.Quantity, recipe.FoodId, recipe.IngredientId});
        }

        public int RemoveRecipe(RecipeDTO recipe) 
        {
            string query = "DELETE NguyenLieuMonAn WHERE MaMonAn = @foodId AND MaNguyenLieu = @ingredientId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {recipe.FoodId, recipe.IngredientId});
        }

        public DataTable GetRecipes()
        {
            string query = "SELECT * FROM NguyenLieuMonAn";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        public DataTable GetRecipe(string foodId = "", string ingredientId = "")
        {
            string query = "SELECT * FROM NguyenLieuMonAn";
            object[] objects = new object[2];
            if (foodId != "" || ingredientId != "")
                query += " WHERE ";
            if (foodId != ""){
                query += Recipe.FoodId.GetEnumDescription() + " LIKE @foodId + '%'";
                objects[0] = foodId;
            }
            if (ingredientId != "" && foodId != "")
            {
                query += " AND " + Recipe.Ingredient.GetEnumDescription() + " LIKE @ingredient + '%'";
                objects[1] = ingredientId;
            } else if(ingredientId != "")
            {
                query += Recipe.Ingredient.GetEnumDescription() + " LIKE @ingredient + '%'";
                objects[0] = ingredientId;
            }
            return SqlHelper.ExecuteReader(query, objects);
        }

    }
}
