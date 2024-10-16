using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderDetailBLL
    {
        private OrderDetailDAL _orderDetailDAL = new OrderDetailDAL();
        private FoodBLL _foodBLL = new FoodBLL();
        public DataTable GetOrderDetailsByOrderId(string orderID)
        {
            return _orderDetailDAL.GetOrderDetailByOrderID(orderID);
        }

        public bool IsExitOrderDetail(string orderId)
        {
            return _orderDetailDAL.IsExitOrder(orderId) > 0;
        }

        public void AddNewOrderDetails(OrderDetailDTO orderDetail)
        {
            _orderDetailDAL.AddNewOrderDetail(orderDetail);
        }

        public void UpdateOrderDetails(OrderDetailDTO orderDetail)
        {
            _orderDetailDAL.UpdateOrder(orderDetail);
        }

        public DataTable GetOrderDetails()
        {
            return _orderDetailDAL.GetOrderDetail();
        }

        public bool ValidateOrderDetails(string orderId, DataTable current, out string errorMessage)
        {
            DataTable dt = _orderDetailDAL.GetOrderDetailByOrderID(orderId);

            if (dt.Rows.Count == 0)
            {
                errorMessage = "Đơn hàng chưa có món ăn. Các món sẽ được thêm mới!";
                return true;
            }
            if(dt.Rows.Count != current.Rows.Count)
            {
                errorMessage = "Số lượng món đã thay đổi";
                return false;
            }
            for(int i = 0; i < current.Rows.Count; i++)
            {
                DataRow currentRow = current.Rows[i];
                DataRow dtRow = dt.Rows[i];

                if (currentRow["TenMonAn"].ToString() != dtRow["TenMonAn"].ToString() )
                {
                    errorMessage = $"Đã thêm món ăn mới ở dòng {i + 1}!";
                    return true;
                }
                if (Convert.ToInt32(currentRow["SoLuong"]) != Convert.ToInt32(dtRow["SoLuong"]))
                {
                    errorMessage = $"Số lượng món ăn ở dòng {i + 1} đã thay đổi!";
                    return true;
                }
            }
            errorMessage = "Không có thay đổi nào";
            return false;
        }

        public void CreateOrderDetail(string orderId, DataTable dt)
        {
            
            foreach(DataRow row in dt.Rows)
            {
                string foodName = row["TenMonAn"].ToString();
                string foodId = _foodBLL.GetFoodIdByName(foodName);
                var orderDetail = new OrderDetailDTO
                {
                    OrderId = orderId,
                    FoodId = foodId,
                    Quantity = Convert.ToInt32(row["SoLuong"])
                };
                AddNewOrderDetails(orderDetail);
            }
        }

        public void UpdateOrderDetails(string orderId, DataTable dt)
        {
            DataTable current = _orderDetailDAL.GetOrderDetailByOrderID(orderId);

            foreach(DataRow row in dt.Rows)
            {
                string foodName = row["TenMonAn"].ToString();
                int newQuantity = Convert.ToInt32(row["SoLuong"]);
                int newTotalPrice = Convert.ToInt32(row["ThanhTien"]);

                bool exists = false;
                foreach(DataRow currentRow in current.Rows)
                {
                    if (currentRow["TenMonAn"].ToString() == foodName)
                    {
                        int currentQuantity = Convert.ToInt32(currentRow["SoLuong"]);
                        int updatedQuantity = currentQuantity + newQuantity;
                        string foodId = _foodBLL.GetFoodIdByName(foodName);
                        _orderDetailDAL.UpdateOrder(new OrderDetailDTO(orderId, foodId, updatedQuantity));
                       
                        
                        exists = true;
                        break;
                    }
                }

                if(!exists)
                {
                    string foodId = _foodBLL.GetFoodIdByName(foodName);
                    AddNewOrderDetails(new OrderDetailDTO(orderId, foodId, newQuantity));
                }
            }
        }

        public int CalculateTotalPrice(string orderId)
        {
            return _orderDetailDAL.CalculateTotalPrice(orderId);
        }
    }
}
