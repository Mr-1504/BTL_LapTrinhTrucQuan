using Utilities;

namespace DTO
{
    public class FoodDTO
    {
        private string _foodId;
        private string _foodName;
        private string _foodMaking;
        private int _foodUnitPrice;
        private Status _status;

        public FoodDTO(string foodName, string foodMaking, int foodUnitPrice, Status status)
        {
            FoodName = foodName;
            FoodMaking = foodMaking;
            FoodUnitPrice = foodUnitPrice;
            Status = status;
        }

        public FoodDTO(string foodId, string foodName, string foodMaking, int foodUnitPrice, Status status) 
            : this(foodName, foodMaking, foodUnitPrice, status)
        {
            FoodId = foodId;
        }

        public int FoodUnitPrice { get => _foodUnitPrice; set => _foodUnitPrice = value; }
        public string FoodId { get => _foodId; set => _foodId = value; }
        public string FoodName { get => _foodName; set => _foodName = value; }
        public string FoodMaking { get => _foodMaking; set => _foodMaking = value; }
        public Status Status { get => _status; set => _status = value; }
        
    }
}
