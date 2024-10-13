using BLL;
using DTO;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class PurchasedList : Form
    {
        string _id;
        BaseForm _baseForm;
        List<PurchaseInvoiceDTO> _invoices;
        List<EmployeeDTO> _employees;
        List<SupplierDTO> _suppliers;
        DataTable _data;
        DetailInvoice _detail;
        public PurchasedList(string id, BaseForm @base)
        {
            InitializeComponent();
            _id = id;
            _baseForm = @base;
            _employees = new List<EmployeeDTO>();
            _suppliers = new List<SupplierDTO>();
            _data = new DataTable();
            _data.Columns.Add("Id");
            _data.Columns.Add("Employee");
            _data.Columns.Add("Supplier");
            _data.Columns.Add("Time");
            _data.Columns.Add("Total");

            LoadData();
            dgvList.DataSource = _data;

            _detail = new DetailInvoice(this);
            _detail.Location = new System.Drawing.Point(0, 0);
            Controls.Add(_detail);
            _detail.SendToBack();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            DetailPurchaseedIngredient detail = new DetailPurchaseedIngredient(_id, _baseForm, this, Add);
            _baseForm.AddIntoPanel(detail);
            detail.Location = new System.Drawing.Point(0, 0);
            SendToBack();
        }
        private void Add(PurchaseInvoiceDTO invoice)
        {
            _invoices.Add(invoice);

            EmployeeDTO employee = new EmployeeBLL().GetEmployee(invoice.EmployeeId);
            _employees.Add(employee);

            SupplierDTO supplier = new SupplierBLL().GetSupplierById(invoice.SupplierId);
            _suppliers.Add(supplier);

            _data.Rows.Add(invoice.PurchaseInvoiceId, invoice.EmployeeId, invoice.SupplierId, invoice.DateOfPurchase.ToString("HH:mm:ss dd:MM:yyyy"), invoice.Total);
        }
        private void LoadData()
        {
            _invoices = new PurchaseInvoiceBLL().GetInvoices();
            foreach(PurchaseInvoiceDTO invoice in _invoices)
            {
                EmployeeDTO employee = new EmployeeBLL().GetEmployee(invoice.EmployeeId);
                _employees.Add(employee);

                SupplierDTO supplier = new SupplierBLL().GetSupplierById(invoice.SupplierId);
                _suppliers.Add(supplier);

                _data.Rows.Add(invoice.PurchaseInvoiceId, invoice.EmployeeId, invoice.SupplierId, invoice.DateOfPurchase.ToString("HH:mm:ss dd:MM:yyyy"), invoice.Total);
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvList.Columns["colDetail"].Index && e.RowIndex >= 0)
            {
                _detail.SetInformation(_employees[e.RowIndex], _suppliers[e.RowIndex], _invoices[e.RowIndex]);
                _detail.BringToFront();
            }
        }
    }
}
