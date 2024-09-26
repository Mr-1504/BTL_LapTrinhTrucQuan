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
            return new PurchaseInvoiceDetailDAL().UpdatePurchaseInvoiceDetail(new PurchaseInvoiceDetailDTO("0000000003", "THI0001", 17, 20));
         //   return new RecipeDAL().GetRecipe(Recipe.FoodId, "XAO0001");
        }

        public DataTable GetData() {
            return new PurchaseInvoiceDetailDAL().GetPurchaseInvoiceDetail(purchaseInvoiceId: "0000000003", ingredientId: "RAU0001");
            //return new RecipeDAL().GetRecipes();
        }
    }
}
