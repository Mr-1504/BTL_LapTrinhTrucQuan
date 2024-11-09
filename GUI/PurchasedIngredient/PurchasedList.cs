using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Utilities;

namespace GUI.PurchasedIngredient
{
    public partial class PurchasedList : Form
    {
        string _id;
        Timer _debounceTimer;
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
            ActiveControl = lblHistory;
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
        private void LoadData(string invoiceId = "", string employeeId = "", string supplierId = "")
        {
            _data.Clear();
            _employees = new List<EmployeeDTO>();
            _suppliers = new List<SupplierDTO>();
            _invoices = new PurchaseInvoiceBLL().GetInvoices(invoiceId, employeeId, supplierId);
            foreach (PurchaseInvoiceDTO invoice in _invoices)
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
            else if (e.ColumnIndex == dgvList.Columns["Id"].Index && e.RowIndex >= 0)
            {
                txtSearchType.Text = SearchTypeForInvoice.InvoiceId.GetEnumDescription();
            }else if (e.ColumnIndex == dgvList.Columns["colEmployee"].Index && e.RowIndex >= 0)
            {
                txtSearchType.Text = SearchTypeForInvoice.EmployeeId.GetEnumDescription();
            } else if (e.ColumnIndex == dgvList.Columns["colSupplier"].Index && e.RowIndex >= 0)
            {
                txtSearchType.Text = SearchTypeForInvoice.SupplierId.GetEnumDescription();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text == "Tìm kiếm" ? "" : txtSearch.Text;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text.Length == 0 ? "Tìm kiếm" : txtSearch.Text;
            if (txtSearch.Text == "Tìm kiếm")
            {
                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_debounceTimer != null)
            {
                _debounceTimer.Stop();
            }
            else
            {
                _debounceTimer = new Timer();
                _debounceTimer.Interval = 300;
                _debounceTimer.Tick += (s, args) =>
                {
                    _debounceTimer.Stop();
                    Search();
                };
            }
            _debounceTimer.Start();
        }
        private void Search()
        {
            var searchValue = txtSearchType.Text;
            if (txtSearch.Text == "Tìm kiếm")
            {
                LoadData();
            }
            else if (Config.GetEnumValueFromDescription<SearchTypeForInvoice>(searchValue) ==
                SearchTypeForInvoice.InvoiceId)
            {
                LoadData(invoiceId: txtSearch.Text);
            }
            else if (Config.GetEnumValueFromDescription<SearchTypeForInvoice>(searchValue) ==
                SearchTypeForInvoice.EmployeeId)
            {
                LoadData(employeeId: txtSearch.Text);
            }
            else if (Config.GetEnumValueFromDescription<SearchTypeForInvoice>(searchValue) ==
                SearchTypeForInvoice.SupplierId)
            {
                LoadData(supplierId: txtSearch.Text);
            }
        }
    }
}
