using System;

namespace DTO
{
    public class PurchaseInvoiceDTO
    {
        private string _purchaseInvoiceId;
        private string _employeeId;
        private string _supplierId;
        private DateTime _dateOfPurchase;
        private decimal _total;

        public PurchaseInvoiceDTO(string employeeId, string supplierId, DateTime dateOfPurchase, decimal total)
        {
            EmployeeId = employeeId;
            SupplierId = supplierId;
            DateOfPurchase = dateOfPurchase;
            Total = total;
        }

        public PurchaseInvoiceDTO(string purchaseInvoiceId, string employeeId, string supplierId, DateTime dateOfPurchase, decimal total)
        {
            PurchaseInvoiceId = purchaseInvoiceId;
            EmployeeId = employeeId;
            SupplierId = supplierId;
            DateOfPurchase = dateOfPurchase;
            Total = total;
        }

        public string PurchaseInvoiceId { get => _purchaseInvoiceId; set => _purchaseInvoiceId = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string SupplierId { get => _supplierId; set => _supplierId = value; }
        public DateTime DateOfPurchase { get => _dateOfPurchase; set => _dateOfPurchase = value; }
        public decimal Total { get => _total; set => _total = value; }
    }
}