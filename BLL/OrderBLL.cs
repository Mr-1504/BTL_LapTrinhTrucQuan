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
    public  class OrderBLL
    {
        private OrderDAL _orderDAL = new OrderDAL();
        
        public DataTable GetOrders()
        {
            return _orderDAL.GetOrders();
        }

        public DataTable GetOrders(string search="")
        {
            DataTable orders = string.IsNullOrEmpty(search) ? new OrderDAL().GetOrders() : new OrderDAL().GetOrder(search);
            return orders;
        }

        public bool AddNewOrder(OrderDTO order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            int result = _orderDAL.AddnewOrder(order);
            return result > 0;
        }

        public string GetLastIDOrder()
        {
            return _orderDAL.GetLastInsertOrderID();
        }

        public int UpdateOrder(OrderDTO order)
        {
            return _orderDAL.UpdateOrder(order); 
        }

        
    }
}
