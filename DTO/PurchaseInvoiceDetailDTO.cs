namespace DTO
{
    
    public class PurchaseInvoiceDetailDTO
    {
        private string _purchaseInvoiceId;
        private string _ingredientId;
        private int _quantity;
        private int _unitPrice;

        public PurchaseInvoiceDetailDTO(string ingredientId, int quantity, int unitPrice)
        {
            _ingredientId = ingredientId;
            _quantity = quantity;
            _unitPrice = unitPrice;
        }

        public PurchaseInvoiceDetailDTO(string purchaseInvoiceId, string ingredientId, int quantity, int unitPrice)
        {
            PurchaseInvoiceId = purchaseInvoiceId;
            IngredientId = ingredientId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string PurchaseInvoiceId { get => _purchaseInvoiceId; set => _purchaseInvoiceId = value; }
        public string IngredientId { get => _ingredientId; set => _ingredientId = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public int UnitPrice { get => _unitPrice; set => _unitPrice = value; }
    }
}
