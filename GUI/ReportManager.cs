using GUI.QuanLyNguyenLieuMonAnDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class ReportManager : Form
    {
        private string name;
        private DateTime time;
        HomeManager homeManager = new HomeManager();
        public ReportManager()
        {
            InitializeComponent();
        }
        public ReportManager(HomeManager homeManager,string name,DateTime time)
        {
            InitializeComponent();
            this.name = name;
            this.time = time;
            this.homeManager = homeManager;
        }

        private void ReportManager_Load(object sender, EventArgs e)
        {
            
            QuanLyNguyenLieuMonAnDataSet quanLyNguyenLieuMonAnDataSet = new QuanLyNguyenLieuMonAnDataSet();
            DonHangTableAdapter donHangTableAdapter = new DonHangTableAdapter();
            donHangTableAdapter.Fill(quanLyNguyenLieuMonAnDataSet.DonHang);
            List<ReportParameter> reportParameters = new List<ReportParameter>
            {
                new ReportParameter("ReportParameterName", name, true),
                new ReportParameter("ReportParameterTime", time.ToString(), true),
            };
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportManager.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDonHang", quanLyNguyenLieuMonAnDataSet.Tables["DonHang"]));
            reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             homeManager.ShowComponent(true);
             homeManager.BringToFront();
             Hide();
        }
        [DllImport("SomeLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int CreateFontPackage(IntPtr param1, int param2);
    }
}
