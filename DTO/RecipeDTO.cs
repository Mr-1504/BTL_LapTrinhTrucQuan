namespace DTO
{
    public class RecipeDTO
    {
        private string _foodId;
        private string _ingredientId;
        private decimal _quantity;

        public RecipeDTO(string foodId, string ingredientId, decimal quantity)
        {
            FoodId = foodId;
            IngredientId = ingredientId;
            Quantity = quantity;
        }

        public string FoodId { get => _foodId; set => _foodId = value; }
        public string IngredientId { get => _ingredientId; set => _ingredientId = value; }
        public decimal Quantity { get => _quantity; set => _quantity = value; }
    }
}
