using System;
using Utilities;

namespace DTO
{
    public class OrderDTO
    {
        private string _orderId;
        private DateTime _orderDate;
        private int _totalMoney;
        private Order _orderStatus;

        public OrderDTO(DateTime orderDate = default(DateTime), int totalMoney = 0, Order orderStatus = Order.unpaid)
        {
            OrderDate = orderDate;
            TotalMoney = totalMoney;
            OrderStatus = orderStatus;
        }

        public OrderDTO(string orderId = "", DateTime orderDate = default(DateTime), int totalMoney = 0, Order orderStatus = Order.unpaid)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            TotalMoney = totalMoney;
            OrderStatus = orderStatus;
        }

        public string OrderId { get => _orderId; set => _orderId = value; } 
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        public int TotalMoney { get => _totalMoney; set => _totalMoney = value; }
        public Order OrderStatus { get => _orderStatus; set => _orderStatus = value; }
    }
}
