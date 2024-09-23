using System.Data;
using DAL;
using Utilities;
namespace BLL
{
    public class Class1
    {
        public int IsExist(string userID)
        {
           // return new SupplierDAL().UpdateSupplier(new DTO.SupplierDTO("0002", "Vinaphone", "Nghe an", "0983387388"));
           return new OrderDetailDAL().UpdateOrder(new DTO.OrderDetailDTO("0001", "XAO0001", 4));
        }

        public DataTable GetData() {
            return new OrderDetailDAL().GetOrderDetail();
        }
    }
}
