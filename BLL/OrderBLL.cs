using DAL;
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
    }
}
