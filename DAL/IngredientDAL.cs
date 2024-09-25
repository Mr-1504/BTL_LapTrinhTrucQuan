using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace DAL
{
    public class IngredientDAL
    {
        private int GetIngredientCount(string prefix)
        {
            string query = "SELECT COUNT(*) FROM NguyenLieu WHERE MaNguyenLieu LIKE @Prefix + '%'";
            return SqlHelper.ExecuteScalar(query, new object[] { prefix });
        }

        public int IsExistIngerdient(string ingredientId)
        {
            string query = "SELECT COUNT(*) FROM NguyenLieu WHERE MaNguyenLieu = @ingredientId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {ingredientId});
        }
        public int AddNewIngredient(string prefix, IngredientDTO ingredient)
        {
            string ingredientCount = (GetIngredientCount(prefix) + 1).ToString();
            ingredientCount = new string('0', 4 - ingredientCount.Length) + ingredientCount;

            string ingredientId = prefix + ingredientCount;
            string query = "INSERT INTO NguyenLieu(MaNguyenLieu, TenNguyenLieu, DonViTinh, CongDung, YeuCau, ChongChiDinh, Soluong) VALUES " +
                "( @ingredientId , @ingredientnName , @ingredientUnit , @ingredientUses , @ingredientRequirement , @ingredientContraindication , @ingredientQuantity )";
            return SqlHelper.ExecuteNonQuery(query, new object[] { ingredientId, ingredient.IngredientName,
                ingredient.IngredientUnit.ToString(), ingredient.IngredientUses, ingredient.IngredientRequirement,
                ingredient.IngredientContraindication, ingredient.IngredientQuantity });
        }

        public int UpdateIngredient(IngredientDTO ingredient)
        {
            string query = "UPDATE NguyenLieu SET TenNguyenLieu = @name , DonViTinh = @unit , CongDung = @uses , " +
                "YeuCau = @repuirement , ChongChiDinh = @contraindication , Soluong = @quantity WHERE MaNguyenLieu = @id";

            return SqlHelper.ExecuteNonQuery(query, new object[] {ingredient.IngredientName, ingredient.IngredientUnit.ToString(),
                ingredient.IngredientUses, ingredient.IngredientRequirement, ingredient.IngredientContraindication,
                ingredient.IngredientQuantity, ingredient.IngredientId});
        }

        public int RemoveIngredient(string ingredientId)
        {
            string query = "DELETE FROM NguyenLieu WHERE MaNguyenLieu = @id";
            return SqlHelper.ExecuteNonQuery(query, new object[] { ingredientId });
        }

        public DataTable GetIngredients()
        {
            string query = "SELECT * FROM NguyenLieu";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        public DataTable GetIngredient(Enum @enum, string getValue)
        {
            if (Config.IsValidEnum<Ingredient>(@enum.ToString()))
            {
                string query = "SELECT * FROM NguyenLieu WHERE " + @enum.GetEnumDescription() + " = @getValue";
                return SqlHelper.ExecuteReader(query, new object[] { getValue });
            }
            return null;
        }
    }
}
