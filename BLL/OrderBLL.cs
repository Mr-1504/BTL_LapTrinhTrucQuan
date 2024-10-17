using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

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

        public DataTable GetOrderById(string orderID)
        {
            return _orderDAL.GetOrder(orderID);
        }

        public bool ValidateOrder(string orderId, string tableNumber, string totalPrice, string status, out string errorMessage)
        {
            DataTable dt = _orderDAL.GetOrder(orderId);
            if(dt.Rows.Count == 0)
            {
                errorMessage = "Không tìm thấy đơn hàng!";
                return false;
            }

            DataRow row =  dt.Rows[0];

            //if (row["SoBan"].ToString() != tableNumber)
            //{
            //    errorMessage = "Số bàn đã thay đổi!";
            //    return false;
            //}

            if (row["TrangThai"].ToString() != status)
            {
                errorMessage = "Trạng thái thanh toán đã thay đổi!";
                return false;
            }

            //if (Convert.ToInt32(row["TongTien"]) != Convert.ToInt32(totalPrice))
            //{
            //    errorMessage = "Tổng tiền đã thay đổi!";
            //    return false;
            //}
            errorMessage = string.Empty;
            return true;
        }

        public void UpdateOrder(string orderId, int totalPrice, DateTime datetime, int tableNumber, Utilities.Order status)
        {
            OrderDTO order = new OrderDTO(orderId, datetime, totalPrice, tableNumber, status);
            _orderDAL.UpdateOrder(order);
        }

        public bool IsOrderPaid(string orderId)
        {
            return _orderDAL.IsOrderPaid(orderId);
        }

        

        
    }
}
