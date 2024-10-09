using BLL;
using DAL;
using DTO;
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
            if(dgvList.DataSource != null)
            {
                MessageBox.Show("null");
            }
            else
            {
                MessageBox.Show(dgvList.Rows.Count.ToString() + " " + data.Rows.Count.ToString());
            }
            AddData(data);
        }
        private void AddData(DataGridView data)
        {
            //foreach (DataGridViewRow row in data.Rows)
            //{
            //    DataGridViewRow dataGridViewRow = row;
            //    dgvList.Rows.Add(dataGridViewRow);
            //}
        }
    }
}
