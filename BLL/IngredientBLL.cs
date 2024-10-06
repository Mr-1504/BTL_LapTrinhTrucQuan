using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;
using Utilities;

namespace BLL
{
    public class IngredientBLL
    {
        public List<IngredientDTO> GetIngredients(string search = "")
        {
            List<IngredientDTO> ingredients= new List<IngredientDTO>();
            DataTable data = search == "" ? new IngredientDAL().GetIngredients() : new IngredientDAL().GetIngredients(Ingredient.IngredientName, search);
            foreach (DataRow row in data.Rows)
            {
                if (row != null)
                {
                    int quantity;
                    try
                    {
                        quantity = int.Parse(row[6].ToString());
                    }
                    catch
                    {
                        quantity = 0;
                    }
                    ingredients.Add(new IngredientDTO(row[0].ToString(), row[1].ToString(),
                        Config.GetEnumValueFromName<Unit>(row[2].ToString()), row[3].ToString(), 
                        row[4].ToString(), row[5].ToString(), quantity, Status.Use));
                }
            }
            return ingredients;
        }
    }
}
