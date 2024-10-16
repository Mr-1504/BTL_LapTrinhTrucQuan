using Utilities;
using DTO;
using System.Data;
using System;

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
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        public DataTable GetOrderDetailByOrderID(string orderId)
        {
            string query = "SELECT MonAn.TenMonAn, ChiTietDonHang.SoLuong, ChiTietDonHang.SoLuong * MonAn.DonGia as ThanhTien FROM ChiTietDonHang JOIN MonAn ON ChiTietDonHang.MaMonAn = MonAn.MaMonAn where ChiTietDonHang.MaDon = @OrderID";
            return SqlHelper.ExecuteReader(query, new object[] { orderId });
        }

        public int CalculateTotalPrice(string orderId)
        {
            int toltalPrice = 0;
            string query = "SELECT SUM(ChiTietDonHang.SoLuong * MonAn.DonGia) AS TongTien FROM ChiTietDonHang JOIN MonAn ON ChiTietDonHang.MaMonAn = MonAn.MaMonAn WHERE ChiTietDonHang.MaDon = @orderId ";
            DataTable dt = SqlHelper.ExecuteReader(query, new object[] { orderId });
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["TongTien"]);
            }
            return toltalPrice;
        }
    }
}
