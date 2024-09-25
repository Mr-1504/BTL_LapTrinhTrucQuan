using Utilities;
using DTO;
using System.Data;

namespace DAL
{
    public class OrderDetailDAL
    {
        public int IsExitOrder(string orderId)
        {
            string query = "SELECT COUNT(*) FROM ChiTietDonHang WHERE MaDon = @OrderId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { orderId });
        }

        public int AddNewOrderDetail(OrderDetailDTO orderDetail)
        {
            string query = "INSERT INTO ChiTietDonHang(MaDon, MaMonAn, SoLuong) VALUES ( @orderId , @foodId , @quantity )";
            return SqlHelper.ExecuteNonQuery(query, new object[] 
                {orderDetail.OrderId, orderDetail.FoodId, orderDetail.Quantity});
        } 

        public int UpdateOrder(OrderDetailDTO orderDetail)
        {
            string query = "UPDATE ChiTietDonHang SET SoLuong = @quantity WHERE MaDon = @orderId AND MaMonAn = @foodId";
            return SqlHelper.ExecuteNonQuery(query, new object[] 
                { orderDetail.Quantity, orderDetail.OrderId, orderDetail.FoodId });
        }

        public DataTable GetOrderDetail()
        {
            string query = "SELECT * FROM ChiTietDonHang";
            return SqlHelper.ExecuteReader(query, null);
        }

    }
}
