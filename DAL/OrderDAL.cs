using DTO;
using System;
using System.Data;
using System.Windows.Forms;
using Utilities;

namespace DAL
{
    public class OrderDAL
    {
        private int GetOrderCount(string day, string month, string year)
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE MaDon LIKE 'HDB" + day + month + year + "%'";
            return SqlHelper.ExecuteScalar(query, new object[] {});
        }

        public int IsExistOrderId(string orderId)
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE MaDon = @OrderId";
            return SqlHelper.ExecuteScalar(query, new object[] { orderId });
        }

        //public int AddnewOrder(OrderDTO order)
        //{

        //    string year = DateTime.Now.Year.ToString().Substring(2);
        //    string month = new string('0', 2 - DateTime.Now.Month.ToString().Length) + DateTime.Now.Month.ToString();
        //    string day = new string('0', 2 - DateTime.Now.Day.ToString().Length) + DateTime.Now.Day.ToString();
        //    if(GetOrderCount(day, month, year) == -1)
        //    {
        //        return -1;
        //    }
        //    string orderId = (GetOrderCount(day, month, year) + 1).ToString();
        //    orderId = "HDB" + day + month + year + new string('0', 3 -  orderId.Length) + orderId;
        //    string query = "INSERT INTO DonHang (MaDon, NgayTao, TongTien, TrangThai, SoBan ) " +
        //        "VALUES ( @orderId , @orderDate , @totalMoney , @orderStatus, @tableNumber )";

        //    return SqlHelper.ExecuteNonQuery(query, new object[] 
        //        { orderId, order.OrderDate, order.TotalMoney, order.OrderStatus.GetEnumDescription(), order.TableNumber });
        //}

        //public int UpdateOrder(OrderDTO order) 
        //{
        //    string query = "UPDATE DonHang SET NgayTao = @orderDate , TongTien = @totalMoney " +
        //        ", TrangThai = @orderStatus, SoBan = @tableNumber WHERE MaDon = @orderId";
        //    return SqlHelper.ExecuteNonQuery(query, new object[] {order.OrderDate, order.TotalMoney,
        //        order.OrderStatus.GetEnumDescription(),order.TableNumber, order.OrderId });
        //}
        public int AddnewOrder(OrderDTO order)
        {
            string year = DateTime.Now.Year.ToString().Substring(2);
            string month = new string('0', 2 - DateTime.Now.Month.ToString().Length) + DateTime.Now.Month.ToString();
            string day = new string('0', 2 - DateTime.Now.Day.ToString().Length) + DateTime.Now.Day.ToString();
            string orderId = (GetOrderCount(day, month, year) + 1).ToString();
            orderId = "HDB" + day + month + year + new string('0', 3 - orderId.Length) + orderId;

            string query = "INSERT INTO DonHang (MaDon, NgayTao, TongTien, TrangThai, SoBan ) " +
                "VALUES ( @orderId , @orderDate , @totalMoney , @orderStatus , @tableNumber )";

            return SqlHelper.ExecuteNonQuery(query, new object[]
                { orderId, order.OrderDate, order.TotalMoney, order.OrderStatus.GetEnumDescription(), order.TableNumber });
        }

        public int UpdateOrder(OrderDTO order)
        {
            string query = "UPDATE DonHang SET NgayTao = @orderDate , TongTien = @totalMoney " +
                ", TrangThai = @orderStatus , SoBan = @tableNumber WHERE MaDon = @orderId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {order.OrderDate, order.TotalMoney,
        order.OrderStatus.GetEnumDescription(), order.TableNumber, order.OrderId });
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

        public string GetLastInsertOrderID()
        {
            string year = DateTime.Now.Year.ToString().Substring(2);
            string month = new string('0', 2 - DateTime.Now.Month.ToString().Length) + DateTime.Now.Month.ToString();
            string day = new string('0', 2 - DateTime.Now.Day.ToString().Length) + DateTime.Now.Day.ToString();
            string orderId = GetOrderCount(day, month, year).ToString();
            orderId = "HDB" + day + month + year + new string('0', 3 - orderId.Length) + orderId;
            return orderId;
        }

        public bool IsOrderPaid(string orderId)
        {
            string query = "SELECT TrangThai FROM DonHang WHERE MaDon = @orderId";
            DataTable dt = SqlHelper.ExecuteReader(query, new object[] {orderId});
            if (dt.Rows.Count > 0)
            {
                var status = dt.Rows[0].ToString();
                return status == "Đã thanh toán";
            }
            return false;
        }

        public int UpdateOrderTotalPrice(string orderId, int totalPrice)
        {
            string query = "UPDATE DonHang set TongTien = @TotalPrice Where MaDon = @orderId";
            return SqlHelper.ExecuteNonQuery(query, new object[] {orderId, totalPrice});
        }

        
    }
}
