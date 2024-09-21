namespace DTO
{
    public class FoodDTO
    {
        private string foodId;
        private string foodName;
        private string foodMaking;
        private int foodUnitPrice;

        public FoodDTO(string foodName, string foodMaking, int foodUnitPrice)
        {
            FoodName = foodName;
            FoodMaking = foodMaking;
            FoodUnitPrice = foodUnitPrice;
        }

        public FoodDTO(string foodId = "", string foodName = "", string foodMaking = "", int foodUnitPrice = 0) 
            : this(foodName, foodMaking, foodUnitPrice)
        {
            FoodId = foodId;
        }

        public int FoodUnitPrice { get => foodUnitPrice; set => foodUnitPrice = value; }
        public string FoodId { get => foodId; set => foodId = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string FoodMaking { get => foodMaking; set => foodMaking = value; }

        
    }
}
