﻿using DTO;
using System.Data;
using Utilities;

namespace DAL
{
    public class OrderDAL
    {
        private int GetOrderCount()
        {
            string query = "SELECT COUNT(*) FROM DonHang";
            return SqlHelper.ExecuteScalar(query, null);
        }

        public int IsExistOrderId(string orderId)
        {
            string query = "SELECT COUNT(*) FROM DonHang WHERE MaDon = @OrderId";
            return SqlHelper.ExecuteScalar(query, new object[] { orderId });
        }

        public int AddnewOrder(OrderDTO order)
        {
            string orderId = (GetOrderCount() + 1).ToString();
            orderId = new string('0', 4 -  orderId.Length) + orderId;

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
            return SqlHelper.ExecuteReader(query, null);
        }

        public DataTable GetOrder(string orderId)
        {
            string query = "SELECT * FROM DonHang WHERE MaDon = @orderId";
            return SqlHelper.ExecuteReader(query, new object[] { orderId});
        }
    }
}
