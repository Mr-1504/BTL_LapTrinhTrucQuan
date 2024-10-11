using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BLL
{
    public class FoodManagerBLL2
    {
        FoodDAL foodDAL = new FoodDAL();
        IngredientDAL ingredientDAL = new IngredientDAL();
        public DataTable EditGetFood(Food @enum,string foodID)
        {
            FoodDAL foodDAL = new FoodDAL();
            return foodDAL.GetFood(@enum,foodID);
        }
        public DataTable getIngredientForFood(string foodID)
        {
            return foodDAL.GetFoodIngredient(foodID);
        }
        public DataTable getIngredient()
        {
            return ingredientDAL.GetIngredients();
        }
    }
}
