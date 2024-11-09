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

namespace GUI
{
    public partial class ReportManager : Form
    {
        public ReportManager()
        {
            InitializeComponent();
        }

        private void ReportManager_Load(object sender, EventArgs e)
        {
            QuanLyNguyenLieuMonAnDataSet quanLyNguyenLieuMonAnDataSet = new QuanLyNguyenLieuMonAnDataSet();
            DonHangTableAdapter donHangTableAdapter = new DonHangTableAdapter();
            donHangTableAdapter.Fill(quanLyNguyenLieuMonAnDataSet.DonHang);
            ChiTietHoaDonNhapTableAdapter chiTietHoaDonNhapTableAdapter = new ChiTietHoaDonNhapTableAdapter();
            chiTietHoaDonNhapTableAdapter.Fill(quanLyNguyenLieuMonAnDataSet.ChiTietHoaDonNhap);
            HoaDonNhapTableAdapter hoaDonNhapTableAdapter = new HoaDonNhapTableAdapter();
            hoaDonNhapTableAdapter.Fill(quanLyNguyenLieuMonAnDataSet.HoaDonNhap);
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportManager.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDonHang", quanLyNguyenLieuMonAnDataSet.Tables["DonHang"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetChiTietHoaDonNhap", quanLyNguyenLieuMonAnDataSet.Tables["ChiTietHoaDonNhap"]));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetHoaDonNhap", quanLyNguyenLieuMonAnDataSet.Tables["HoaDonNhap"]));
            this.reportViewer1.RefreshReport();
        }
    }
}
