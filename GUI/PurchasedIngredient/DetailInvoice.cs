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
            decimal total = 0;
            foreach (DataRow row in data.Rows)
            {
                total += Convert.ToDecimal(row[3]) * Convert.ToDecimal(row[2]);
            }
            lblTotalValue.Text = total.ToString("#,##0", new System.Globalization.CultureInfo("vi-VN"))
                + " VND" + "( " + PurchaseInvoiceBLL.ReadNumberToWords(total).ToUpper() + ")";
        }
    }   
}
