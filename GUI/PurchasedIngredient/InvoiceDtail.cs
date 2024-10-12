using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class InvoiceDtail : UserControl
    {
        public InvoiceDtail(PurchaseInvoiceDTO invoice, List<PurchaseInvoiceDetailDTO> invoiceDetail, DataGridView data)
        {
            InitializeComponent();
            lblCreateionTime.Text = invoice.DateOfPurchase.ToString("HH:mm:ss dd/MM/yyyy");
            EmployeeDTO employee = new EmployeeBLL().GetEmployee(invoice.EmployeeId);
            lblEmployeeInformation.Text = employee.Name + " - " + employee.EmployeeId;
            SupplierDTO supplier = new SupplierBLL().GetSupplierById(invoice.SupplierId);
            lblSupplierNameValue.Text = supplier.SupplierName;
            lblSupplierAddressValue.Text = supplier.SupplierAddress;
            dgvList.DataSource = data.DataSource;
            ActiveControl = lblAction;
        }

        public void SetTotal()
        {
            decimal total = 0;
            foreach(DataGridViewRow row in dgvList.Rows)
            {
                try
                {
                    total += int.Parse(row.Cells[2].Value.ToString()) * decimal.Parse(row.Cells[3].Value.ToString());
                }
                catch (FormatException) { }
            }
            lblTotalValue.Text = total.ToString("0.00") + " VND";
        }
    }
}
