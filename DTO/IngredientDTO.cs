using Utilities;

namespace DTO
{
    public class IngredientDTO
    {
        private string _ingredientId;
        private string _ingredientName;
        private string _ingredientUses;
        private string _ingredientRequirement;
        private string _ingredientContraindication;
        private int _ingredientQuantity;
        private Unit _ingredientUnit;
        private Status _ingredientStatus;

        public IngredientDTO(string ingredientName, Unit unit, string ingredientUses, string ingredientRequirement,
                string ingredientContraindication, int ingredientQuantity, Status status)
        {
            IngredientName = ingredientName;
            IngredientUses = ingredientUses;
            IngredientRequirement = ingredientRequirement;
            IngredientContraindication = ingredientContraindication;
            IngredientQuantity = ingredientQuantity;
            IngredientUnit = unit;
            IngredientStatus = status;
        }

        public IngredientDTO(string ingredientId, string ingredientName, Unit unit, string ingredientUses, 
            string ingredientRequirement, string ingredientContraindication, int ingredientQuantity, Status status)
            : this(ingredientName, unit, ingredientUses, ingredientRequirement, ingredientContraindication, ingredientQuantity, status)
        {
            IngredientId = ingredientId;
        }

        public string IngredientId { get => _ingredientId; set => _ingredientId = value; }
        public string IngredientName { get => _ingredientName; set => _ingredientName = value; }
        public string IngredientUses { get => _ingredientUses; set => _ingredientUses = value; }
        public string IngredientRequirement { get => _ingredientRequirement; set => _ingredientRequirement = value; }
        public string IngredientContraindication { get => _ingredientContraindication; set => _ingredientContraindication = value; }
        public int IngredientQuantity { get => _ingredientQuantity; set => _ingredientQuantity = value; }
        public Unit IngredientUnit { get => _ingredientUnit; set => _ingredientUnit = value; }
        public Status IngredientStatus { get => _ingredientStatus; set => _ingredientStatus = value; }
    }
}
