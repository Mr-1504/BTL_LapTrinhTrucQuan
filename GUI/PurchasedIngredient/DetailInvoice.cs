using BLL;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class DetailInvoice : UserControl
    {
        PurchasedList _purchasedList;
        public DetailInvoice(PurchasedList purchasedList)
        {
            InitializeComponent();
            _purchasedList = purchasedList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SendToBack();
            _purchasedList.BringToFront();
        }

        public void SetInformation(EmployeeDTO employee, SupplierDTO supplier, PurchaseInvoiceDTO invoice)
        {
            lblTimeValue.Text = invoice.DateOfPurchase.ToString("HH:mm:ss dd/MM/yyyy");
            lblEmployeeValue.Text = employee.Name + " - " + employee.EmployeeId;
            lblSupplierNameValue.Text = supplier.SupplierName;
            lblSupplierAddressValue.Text = supplier.SupplierAddress;

            DataTable data = new PurchaseInvoiceBLL().GetPurchaseInvoiceDetail(invoice.PurchaseInvoiceId);
            dgvList.DataSource = data;
        }
    }   
}
