using System;

namespace DTO
{
    public class PurchaseInvoiceDTO
    {
        private string _purchaseInvoiceId;
        private string _employeeId;
        private string _supplierId;
        private DateTime _dateOfPurchase;

        public PurchaseInvoiceDTO(string employeeId, string supplierId, DateTime dateOfPurchase)
        {
            EmployeeId = employeeId;
            SupplierId = supplierId;
            DateOfPurchase = dateOfPurchase;
        }

        public PurchaseInvoiceDTO(string purchaseInvoiceId, string employeeId, string supplierId, DateTime dateOfPurchase)
        {
            PurchaseInvoiceId = purchaseInvoiceId;
            EmployeeId = employeeId;
            SupplierId = supplierId;
            DateOfPurchase = dateOfPurchase;
        }

        public string PurchaseInvoiceId { get => _purchaseInvoiceId; set => _purchaseInvoiceId = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string SupplierId { get => _supplierId; set => _supplierId = value; }
        public DateTime DateOfPurchase { get => _dateOfPurchase; set => _dateOfPurchase = value; }
    }
}