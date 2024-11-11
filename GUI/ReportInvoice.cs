using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ReportInvoice : Form
    {
        private string _orderID;
        public ReportInvoice(string orderID)
        {
            InitializeComponent();
            _orderID = orderID;
        }

        private void ReportInvoice_Load(object sender, EventArgs e)
        {
            var tableAdapter = new QuanLyNguyenLieuMonAnDataSetTableAdapters.ChitietHoaDonBanTableAdapter();
            var dataTable = new QuanLyNguyenLieuMonAnDataSet.ChitietHoaDonBanDataTable();
            tableAdapter.Fill(dataTable, _orderID);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetChiTietDonHangMonAn", (DataTable)dataTable));

            this.reportViewer1.RefreshReport();
        }
    }
}
