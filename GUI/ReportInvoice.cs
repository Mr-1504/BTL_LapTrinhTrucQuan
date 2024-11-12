using GUI.QuanLyNguyenLieuMonAnDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace GUI
{
    public partial class ReportInvoice : Form
    {
        private string _orderID;
        private string _orderDate;
        private string _numberTable;
        private frmListOrders _frmListOrders;
        public ReportInvoice(string orderID, string orderDate, string numberTable)
        {
            InitializeComponent();
            _orderID = orderID;
            _orderDate = orderDate;
            _numberTable = numberTable;
        }

        private void ReportInvoice_Load(object sender, EventArgs e)
        {
            QuanLyNguyenLieuMonAnDataSet quanLyNguyenLieuMonAnDataSet = new QuanLyNguyenLieuMonAnDataSet();
            ChiTietDonHangMonAnTableAdapter chiTietDonHangMonAnTableAdapter = new ChiTietDonHangMonAnTableAdapter();
            chiTietDonHangMonAnTableAdapter.Fill(quanLyNguyenLieuMonAnDataSet.ChiTietDonHangMonAn, _orderID);
            List<ReportParameter> reportParameters = new List<ReportParameter>
            {
                new ReportParameter("ReportParameterMaDonHang",_orderID, true),
                new ReportParameter("ReportParameterNgayTao", _orderDate, true),
                new ReportParameter("ReportParameterSoBan", _numberTable, true),
            };
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportInvoice.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetChiTietDonHangMonAn", quanLyNguyenLieuMonAnDataSet.Tables["ChiTietDonHangMonAn"]));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
        }

        private void btnBackToOrder_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
