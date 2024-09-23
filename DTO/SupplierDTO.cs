namespace DTO
{
    public class SupplierDTO
    {
        private string _supplierId;
        private string _supplierName;
        private string _supplierAddress;
        private string _supplierNumberPhone;

        public SupplierDTO(string supplierName = "", string supplierAddress = "", string supplierNumberPhone = "")
        {
            SupplierName = supplierName;
            SupplierAddress = supplierAddress;
            SupplierNumberPhone = supplierNumberPhone;
        }

        public SupplierDTO(string supplierId = "", string supplierName = "", string supplierAddress = "", 
            string supplierNumberPhone = "") : this (supplierName, supplierAddress, supplierNumberPhone)
        {
            SupplierId = supplierId;
        }

        public string SupplierId { get => _supplierId; set => _supplierId = value; }
        public string SupplierName { get => _supplierName; set => _supplierName = value; }
        public string SupplierAddress { get => _supplierAddress; set => _supplierAddress = value; }
        public string SupplierNumberPhone { get => _supplierNumberPhone; set => _supplierNumberPhone = value; }
    }
}
