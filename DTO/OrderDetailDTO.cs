namespace DTO
{
    public class OrderDetailDTO
    {
        private string _orderId;
        private string _foodId;
        private int _quantity;

        public OrderDetailDTO(string orderId = "", string foodId = "", int quantity = 0)
        {
            OrderId = orderId;
            FoodId = foodId;
            Quantity = quantity;
        }

        public string OrderId { get => _orderId; set => _orderId = value; }
        public string FoodId { get => _foodId; set => _foodId = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
