using System;
using Utilities;

namespace DTO
{
    //public class OrderDTO
    //{
    //    private string _orderId;
    //    private DateTime _orderDate;
    //    private int _totalMoney;
    //    private Order _orderStatus;
    //    private int _tableNumber;

    //    public OrderDTO()
    //    {
    //        OrderId = "";
    //        OrderDate = DateTime.Now;
    //        TotalMoney = 0;
    //        OrderStatus = Order.unpaid;
    //        TableNumber = 0;
    //    }
    //    public OrderDTO(DateTime orderDate = default(DateTime), int totalMoney = 0, Order orderStatus = Order.unpaid, int tableNumber = 0)
    //    {
    //        OrderDate = orderDate;
    //        TotalMoney = totalMoney;
    //        OrderStatus = orderStatus;
    //        TableNumber = tableNumber;
    //    }

    //    public OrderDTO(string orderId = "", DateTime orderDate = default(DateTime), int totalMoney = 0, Order orderStatus = Order.unpaid, int tableNumber = 0)
    //    {
    //        OrderId = orderId;
    //        OrderDate = orderDate;
    //        TotalMoney = totalMoney;
    //        OrderStatus = orderStatus;
    //        TableNumber = tableNumber;
    //    }

    //    public string OrderId { get => _orderId; set => _orderId = value; } 
    //    public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
    //    public int TotalMoney { get => _totalMoney; set => _totalMoney = value; }
    //    public Order OrderStatus { get => _orderStatus; set => _orderStatus = value; }
    //    public int TableNumber { get => _tableNumber; set => _tableNumber = value; }  
    //}
    public class OrderDTO
    {
        private string _orderId;
        private DateTime _orderDate;
        private int _totalMoney;
        private int _tableNumber;
        private Order _orderStatus;


        public OrderDTO(DateTime orderDate, int totalMoney, Order orderStatus)
        {
            OrderDate = orderDate;
            TotalMoney = totalMoney;
            OrderStatus = orderStatus;
            TableNumber = 0;
        }

        public OrderDTO(string orderId, DateTime orderDate, int totalMoney, Order orderStatus)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            TotalMoney = totalMoney;
            OrderStatus = orderStatus;
            TableNumber = 0;
        }

        public OrderDTO(string orderId, DateTime orderDate, int totalMoney, int tableNumber, Order orderStatus)
        {
            _orderId = orderId;
            _orderDate = orderDate;
            _totalMoney = totalMoney;
            TableNumber = tableNumber;
            _orderStatus = orderStatus;
        }

        public string OrderId { get => _orderId; set => _orderId = value; }
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        public int TotalMoney { get => _totalMoney; set => _totalMoney = value; }
        public Order OrderStatus { get => _orderStatus; set => _orderStatus = value; }
        public int TableNumber { get => _tableNumber; set => _tableNumber = value; }
    }
}
