using System.Data;
using DAL;
using Utilities;
namespace BLL
{
    public class Class1
    {
        public int IsExist(string userID)
        {
            return new OrderDAL().AddnewOrder(new DTO.OrderDTO(new System.DateTime(2014, 10, 3), 1000, Order.paid));
          // return new OrderDAL().RemoveOrder("0002");
        }

        public DataTable GetData() {
            return new OrderDAL().GetOrder("0001");
        }
    }
}
