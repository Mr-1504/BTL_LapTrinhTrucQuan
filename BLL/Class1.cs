using System.Data;
using DAL;
using Utilities;
namespace BLL
{
    public class Class1
    {
        public int IsExist(string userID)
        {
            //return new SupplierDAL().UpdateSupplier(new DTO.SupplierDTO("0002", "Vinaphone", "Nghe an", "0983387388"));
            return new PurchaseInvoiceDAL().UpdatePurchaseInvoice(new DTO.PurchaseInvoiceDTO("0001", "QL0002", "0001", new System.DateTime(2024, 10, 5)));
        }

        public DataTable GetData() {
            return new PurchaseInvoiceDAL().GetPurchaseInvoice(purchaseInvoiceId:  "0001", supplierId: "0001", employeeId: "QL0002");
        }
    }
}
