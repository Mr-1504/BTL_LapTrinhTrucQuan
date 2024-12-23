﻿using DTO;
using System;
using System.Data;
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

        public int IsExistIngerdientId(string ingredientId)
        {
            string query = "SELECT COUNT(*) FROM NguyenLieu WHERE MaNguyenLieu = @ingredientId";
            return SqlHelper.ExecuteScalar(query, new object[] { ingredientId });
        }
        public int IsExistIngerdientName(string ingredientName)
        {
            string query = "SELECT COUNT(*) FROM NguyenLieu WHERE TenNguyenLieu = @ingredientName";
            return SqlHelper.ExecuteScalar(query, new object[] { ingredientName });
        }
        public int AddNewIngredient(string prefix, IngredientDTO ingredient)
        {
            int count = GetIngredientCount(prefix) + 1;
            if (count == 0)
                return -1;

            string ingredientId = prefix + new string('0', 4 - count.ToString().Length) + count.ToString();
            string query = "INSERT INTO NguyenLieu(MaNguyenLieu, TenNguyenLieu, DonViTinh, CongDung, YeuCau, ChongChiDinh, Soluong) VALUES " +
                "( @ingredientId , @ingredientnName , @ingredientUnit , @ingredientUses , @ingredientRequirement , @ingredientContraindication , @ingredientQuantity )";
            return SqlHelper.ExecuteNonQuery(query, new object[] { ingredientId, ingredient.IngredientName,
                ingredient.IngredientUnit.GetEnumDescription(), ingredient.IngredientUses, ingredient.IngredientRequirement,
                ingredient.IngredientContraindication, ingredient.IngredientQuantity });
        }

        public int UpdateIngredient(IngredientDTO ingredient)
        {
            string query = "UPDATE NguyenLieu SET TenNguyenLieu = @ingredientName , DonViTinh = @ingredientUnit , CongDung = @ingredientUses" +
                " , YeuCau = @ingredientRequirement , ChongChiDinh = @ingredientContraindication ," +
                " Soluong = @ingredientQuantity WHERE MaNguyenLieu = @ingredientId";

            return SqlHelper.ExecuteNonQuery(query, new object[] {ingredient.IngredientName, ingredient.IngredientUnit.GetEnumDescription(),
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

        public DataTable GetIngredients(Ingredient @enum, string getValue)
        {
            string query = "SELECT * FROM NguyenLieu WHERE " + @enum.GetEnumDescription() + " LIKE @getValue + '%'";
            return SqlHelper.ExecuteReader(query, new object[] { getValue });
        }

        public int UpdateIngredientQuantity(string ingredientId, decimal quantity)
        {
            string query = "UPDATE NguyenLieu SET Soluong = @quantity WHERE MaNguyenLieu = @ingredientId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { quantity, ingredientId });
        }

        public decimal GetIngredientQuantity(string ingredientId)
        {
            string query = "SELECT Soluong FROM NguyenLieu WHERE MaNguyenLieu = @ingredientId";

            decimal result =SqlHelper.ExecuteScalarDecimal(query, new object[] { ingredientId });

            if(result == -1)
            {
                return 0.0m;
            }
            return result;

            throw new InvalidCastException("Result is not a valid numeric type.");
        }
    }
}
