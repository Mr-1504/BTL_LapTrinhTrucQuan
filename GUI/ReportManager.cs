using GUI.QuanLyNguyenLieuMonAnDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private string name,action;
        private DateTime time;
        HomeManager homeManager = new HomeManager();

        public ReportManager()
        {
            InitializeComponent();
        }
        public ReportManager(HomeManager homeManager,string name,DateTime time,string action)
        {
            InitializeComponent();
            this.name = name;
            this.time = time;
            this.action = action;
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
            if (action == "Tuần")
            {
                action = "WEEK";
            }
            else if (action == "Tháng")
            {
                action = "MONTH";
            }
            else if (action == "Năm")
            {
                action = "YEAR";
            }
            var filteredRows = quanLyNguyenLieuMonAnDataSet.DonHang.AsEnumerable()
                    .Where(row => row.Field<string>("TrangThai") == "Đã thanh toán" && row.Field<DateTime>("NgayTao").DatePart(action) == DateTime.Now.DatePart(action));

            DataTable filteredTable = quanLyNguyenLieuMonAnDataSet.DonHang.Clone();
            filteredTable.Columns["NgayTao"].DataType = typeof(string);

            foreach (DataRow row in filteredRows)
            {
                DataRow newRow = filteredTable.NewRow();
                newRow["MaDon"] = row["MaDon"];
                newRow["NgayTao"] = Convert.ToDateTime(row["NgayTao"]).ToString("dd/MM/yyyy");
                newRow["TongTien"] = row["TongTien"];
                newRow["SoBan"] = row["SoBan"];
                newRow["TrangThai"] = row["TrangThai"];
                filteredTable.Rows.Add(newRow);
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportManager.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDonHang", filteredTable));
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
    public static class DateTimeExtensions
    {
        public static int DatePart(this DateTime dateTime, string part)
        {
            switch (part)
            {
                case "WEEK":
                    return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
                case "MONTH":
                    return dateTime.Month;
                case "YEAR":
                    return dateTime.Year;
                default:
                    throw new ArgumentException("Invalid date part", nameof(part));
            }
        }
    }
}
