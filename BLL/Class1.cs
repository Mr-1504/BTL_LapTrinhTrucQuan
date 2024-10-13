using System;
using System.Data;
using DAL;
using DTO;
using Utilities;
namespace BLL
{
    public class Class1
    {
        public int IsExist(string userID)
        {
      
            return new SupplierDAL().AddNewSupplier(SupplierType.Seafood, new SupplierDTO("Fuji Fress", "Xã đàn, đống đa", "0909898978", Status.Use));
         //   return new RecipeDAL().GetRecipe(Recipe.FoodId, "XAO0001");
        }

        public DataTable GetData() {
            return new SupplierDAL().GetSuppliers();
            //return new RecipeDAL().GetRecipes();
        }
    }
}
