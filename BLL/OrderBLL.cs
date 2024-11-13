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
        private IngredientBLL _ingredientBLL = new IngredientBLL();

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
        public int DeDuctIngredients(string orderId, DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                string foodName = row["TenMonAn"].ToString();
                string foodId = new FoodBLL().GetFoodIdByName(foodName);
                int quantity = Convert.ToInt32(row["SoLuong"]);
                Console.WriteLine($"Food: {foodName}, Quantity: {quantity}");

                DataTable current = new OrderDetailBLL().GetOrderDetailsByOrderId(orderId);
                Console.WriteLine($"Order Details Count: {current.Rows.Count}");
                DataRow currentRow = current.AsEnumerable().FirstOrDefault(r => r.Field<string>("TenMonAn") == foodName);
                int currentQuantity = currentRow != null ? Convert.ToInt32(currentRow["SoLuong"]) : 0;
                Console.WriteLine($"Current Quantity: {currentQuantity}");
                int quantityToDeduct = quantity - currentQuantity;
                Console.WriteLine($"QuantityToDeduct: {quantityToDeduct}");
                Console.WriteLine($"Food: {foodName}, Quantity to Deduct: {quantityToDeduct}");
                if (quantityToDeduct > 0)
                {
                    try
                    {
                        _ingredientBLL.DeductIngredients(foodId, quantityToDeduct);
                        return 1;
                    }
                    catch (Exception ex)
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }
    }
}
