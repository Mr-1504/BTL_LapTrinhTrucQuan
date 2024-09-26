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
            return new EmployeeDAL().AddNewEmployee("QL", new EmployeeDTO("Trương Văn Minh", Gender.Male, new System.DateTime(2004, 5, 10), "Nghệ An", "79 Cầu Giấy", "0373294997", EmployeeStatus.CurrentlyWorking));
         //   return new RecipeDAL().GetRecipe(Recipe.FoodId, "XAO0001");
        }

        public DataTable GetData() {
            return new EmployeeDAL().GetEmployees();
            //return new RecipeDAL().GetRecipes();
        }
    }
}
