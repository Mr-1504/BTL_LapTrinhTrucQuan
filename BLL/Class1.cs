using System.Data;
using DAL;
using Utilities;
namespace BLL
{
    public class Class1
    {
        public int IsExist(string userID)
        {
            return new IngredientDAL().UpdateIngredient(new DTO.IngredientDTO("THI0001", "Thịt voi", Unit.Kg, "Bổ dưỡng lắm", "Ăn chín nhé", "Ăn ít thôi", 20));
            //return new IngredientDAL().RemoveIngredient("THI0001");
        }
        public DataTable GetData() {
            return new IngredientDAL().GetIngredient(Ingredient.IngredientId, "THI0001");
        }
    }
}
