namespace DTO
{
    public class FoodDTO
    {
        private string foodId;
        private string foodName;
        private string foodMaking;
        private int foodUnitPrice;
        public int FoodUnitPrice { get => foodUnitPrice; set => foodUnitPrice = value; }
        public string FoodId { get => foodId; set => foodId = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string FoodMaking { get => foodMaking; set => foodMaking = value; }
    }
}
