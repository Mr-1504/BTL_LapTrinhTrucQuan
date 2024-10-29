using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RecipeBLL
    {
        private RecipeDAL _recipeDAL = new RecipeDAL();

        public DataTable GetRecipeByFood(string foodId)
        {
            return _recipeDAL.GetRecipeByFood(foodId);
        }   
    }
}
