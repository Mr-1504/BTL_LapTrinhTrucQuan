using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Utilities;

namespace BLL
{
    public class IngredientBLL
    {
        private IngredientDAL _ingredientDAL = new IngredientDAL();
        private RecipeBLL _recipeBLL = new RecipeBLL();
        public List<IngredientDTO> GetIngredients(string search = "")
        {
            List<IngredientDTO> ingredients= new List<IngredientDTO>();
            DataTable data = search == "" ? new IngredientDAL().GetIngredients() : new IngredientDAL().GetIngredients(Ingredient.IngredientName, search);
            foreach (DataRow row in data.Rows)
            {
                if (row != null)
                {
                    decimal quantity;
                    try
                    {
                        quantity = decimal.Parse(row[6].ToString());
                    }
                    catch
                    {
                        quantity = 0;
                    }
                    ingredients.Add(new IngredientDTO(row[0].ToString(), row[1].ToString(),
                        Config.GetEnumValueFromDescription<Unit>(row[2].ToString()), row[3].ToString(), 
                        row[4].ToString(), row[5].ToString(), quantity, Status.Use));
                }
            }
            return ingredients;
        }

        public List<IngredientDTO> GetIngredient(Ingredient type, string value)
        {
            List<IngredientDTO> ingredients = new List<IngredientDTO>();
            DataTable data = new IngredientDAL().GetIngredients(type, value);
            foreach (DataRow row in data.Rows)
            {
                if (row != null)
                {
                    decimal quantity;
                    try
                    {
                        quantity = decimal.Parse(row[6].ToString());
                    }
                    catch
                    {
                        quantity = 0;
                    }
                    ingredients.Add(new IngredientDTO(row[0].ToString(), row[1].ToString(),
                        Config.GetEnumValueFromDescription<Unit>(row[2].ToString()), row[3].ToString(),
                        row[4].ToString(), row[5].ToString(), quantity, Status.Use));
                }
            }
            return ingredients;
        }

        public int IsExistIngredientName(string name)
        {
            return new IngredientDAL().IsExistIngerdientName(name);
        }

        public decimal GetIngredientQuantity(string ingredientId)
        {
            return new IngredientDAL().GetIngredientQuantity(ingredientId);
        }

        public bool UpdateIngredientQuantity(string ingredientId, decimal newQuantity)
        {
            return _ingredientDAL.UpdateIngredientQuantity(ingredientId, newQuantity) > 0;
        }

        public void DeductIngredients(string foodId, decimal quantityToDeduct)
        {
            DataTable recipeTable = _recipeBLL.GetRecipeByFood(foodId);
            foreach(DataRow row in recipeTable.Rows)
            {
                string ingredientId = row["MaNguyenLieu"].ToString();
                decimal ingredientQuantityPerUnit = decimal.Parse(row["SoLuong"].ToString());
                decimal quantityToDeductForIngredient = ingredientQuantityPerUnit * quantityToDeduct;
                Console.WriteLine($"QuantityToDeductForIngredient: {quantityToDeductForIngredient}");
                decimal currentQuantity = GetIngredientQuantity(ingredientId);
                Console.WriteLine($"currentQuantity : {currentQuantity}");
                if(currentQuantity >= quantityToDeductForIngredient)
                {
                    UpdateIngredientQuantity(ingredientId, currentQuantity - quantityToDeductForIngredient);
                }
                else
                {
                    throw new Exception($"Không đủ nguyên liệu cho {ingredientId}!");
                }
                
            }

        }

    }
}
