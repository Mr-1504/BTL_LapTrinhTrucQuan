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
        RecipeDAL recipeDAL = new RecipeDAL();
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
        public DataTable GetIngredients(Ingredient @enum, string getValue)
        {
            return ingredientDAL.GetIngredients(@enum,getValue);
        }
        public int UpdateRecipe(RecipeDTO recipe)
        {
            return recipeDAL.UpdateRecipe(recipe);
        }
        public int AddNewRecipe(RecipeDTO recipe)
        {
            return recipeDAL.AddNewRecipe(recipe);
        }
        public int UpdateFood(FoodDTO food)
        {
            return foodDAL.UpdateFood(food);
        }
        public int AddNewFood(FoodType prefix, FoodDTO food)
        {
            return foodDAL.AddNewFood(prefix, food);
        }
        public int RemoveIngredient(string ingredientId)
        {
            return ingredientDAL.RemoveIngredient(ingredientId);
        }
        public int RemoveRecipe(RecipeDTO recipe) { 
            return recipeDAL.RemoveRecipe(recipe);
        }
    }
}
