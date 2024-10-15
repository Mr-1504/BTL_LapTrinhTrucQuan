using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDetailBLL
    {
        private OrderDetailDAL _orderDetailDAL = new OrderDetailDAL();

        public DataTable GetOrderDetailsByOrderId(string orderID)
        {
            return _orderDetailDAL.GetOrderDetailByOrderID(orderID);
        }

        public void CreateOrderDetails(string orderID, DataTable dt)
        {
            foreach(DataRow row in dt.Rows)
            {
                string foodName = row["FoodName"].ToString();

            }
        }
    }
}
