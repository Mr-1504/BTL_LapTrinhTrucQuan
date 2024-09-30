using Utilities;

namespace DTO
{
    public class SupplierDTO
    {
        private string _supplierId;
        private string _supplierName;
        private string _supplierAddress;
        private string _supplierNumberPhone;
        private Status _status;

        public SupplierDTO(string supplierName, string supplierAddress, string supplierNumberPhone, Status status)
        {
            SupplierName = supplierName;
            SupplierAddress = supplierAddress;
            SupplierNumberPhone = supplierNumberPhone;
            Status = status;
        }

        public SupplierDTO(string supplierId, string supplierName, string supplierAddress,
            string supplierNumberPhone, Status status) : this(supplierName, supplierAddress, supplierNumberPhone, status)
        {
            SupplierId = supplierId;
        }

        public string SupplierId { get => _supplierId; set => _supplierId = value; }
        public string SupplierName { get => _supplierName; set => _supplierName = value; }
        public string SupplierAddress { get => _supplierAddress; set => _supplierAddress = value; }
        public string SupplierNumberPhone { get => _supplierNumberPhone; set => _supplierNumberPhone = value; }
        public Status Status { get => _status; set => _status = value; }
    }
}
