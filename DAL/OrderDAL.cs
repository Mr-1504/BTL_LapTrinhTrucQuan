using DTO;
using System;
using System.Data;
using Utilities;

namespace DAL
{
    public class OrderDAL
    {
        private int GetOrderCount(string day, string month, string year)
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE MaHoaDonNhap LIKE 'HDB" + day + month + year + "%'";
            return SqlHelper.ExecuteScalar(query, new object[] {});
        }

        public int IsExistOrderId(string orderId)
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE MaDon = @OrderId";
            return SqlHelper.ExecuteScalar(query, new object[] { orderId });
        }

        public int AddnewOrder(OrderDTO order)
        {
            string year = DateTime.Now.Year.ToString().Substring(2);
            string month = new string('0', 2 - DateTime.Now.Month.ToString().Length) + DateTime.Now.Month.ToString();
            string day = new string('0', 2 - DateTime.Now.Day.ToString().Length) + DateTime.Now.Day.ToString();
            string orderId = (GetOrderCount(day, month, year) + 1).ToString();
            orderId = "HDB" + day + month + year + new string('0', 3 -  orderId.Length) + orderId;

            string query = "INSERT INTO DonHang (MaDon, NgayTao, TongTien, TrangThai ) " +
                "VALUES ( @orderId , @orderDate , @totalMoney , @orderStatus )";
            
            return SqlHelper.ExecuteNonQuery(query, new object[] 
                { orderId, order.OrderDate, order.TotalMoney, order.OrderStatus.GetEnumDescription() });
        }

        public int UpdateOrder(OrderDTO order) 
        {
            string query = "UPDATE DonHang SET NgayTao = @orderDate , TongTien = @totalMoney " +
                ", TrangThai = @orderStatus WHERE MaDon = @orderId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {order.OrderDate, order.TotalMoney,
                order.OrderStatus.GetEnumDescription(), order.OrderId });
        }

        public int RemoveOrder(string orderId) 
        {
            string query = "DELETE FROM DonHang WHERE MaDon = @orderId";
            return SqlHelper.ExecuteNonQuery(query, new object[] { orderId });
        }

        public DataTable GetOrders()
        {
            string query = "SELECT * FROM DonHang";
            return SqlHelper.ExecuteReader(query, new object[] { });
        }

        public DataTable GetOrder(string orderId)
        {
            string query = "SELECT * FROM DonHang WHERE MaDon LIKE @orderId + '%'";
            return SqlHelper.ExecuteReader(query, new object[] { orderId});
        }
    }
}
