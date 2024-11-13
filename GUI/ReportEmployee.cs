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
    public partial class ReportEmployee : Form
    {
        
        private string name,chucVu="",trangThai="";
        private DateTime time;
        private string eRole=null;
        EmployManager employManager = new EmployManager("AD");
        public ReportEmployee()
        {
            InitializeComponent();
        }

        public ReportEmployee(EmployManager employManager,string name, DateTime time)
        {
            InitializeComponent();
            cbbChucVu.Items.Clear();
            cbbChucVu.Items.Add("Lễ tân");
            cbbChucVu.Items.Add("Quản lý");
            cbbChucVu.Items.Add("Kho hàng");
            cbbTrangThai.Items.Clear();
            cbbTrangThai.Items.Add("Đang làm việc");
            cbbTrangThai.Items.Add("Đã nghỉ việc");
            this.name = name;
            this.time = time;
            this.employManager = employManager;
        }

        private void ReportEmployee_Load(object sender, EventArgs e)
        {
            LoadReportData(null, null);
            cbbChucVu.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            cbbTrangThai.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData(cbbChucVu.SelectedItem?.ToString(), cbbTrangThai.SelectedItem?.ToString());
        }

        private void LoadReportData(string selectedChucVu, string selectedTrangThai)
        {
            string chucVuFilter = "";
            if (selectedChucVu == "Quản lý")
            {
                chucVuFilter = "QL";
            }
            else if (selectedChucVu == "Kho hàng")
            {
                chucVuFilter = "KH";
            }
            else if (selectedChucVu == "Lễ tân")
            {
                chucVuFilter = "LT";
            }
            QuanLyNguyenLieuMonAnDataSet quanLyNguyenLieuMonAnDataSet = new QuanLyNguyenLieuMonAnDataSet();
            NhanVienTableAdapter nhanVienTableAdapter = new NhanVienTableAdapter();
            nhanVienTableAdapter.Fill(quanLyNguyenLieuMonAnDataSet.NhanVien);

            string filterExpression = "";
            if (!string.IsNullOrEmpty(chucVuFilter))
            {
                filterExpression += $"MaNhanVien LIKE '{chucVuFilter}%'";
            }
            if (!string.IsNullOrEmpty(selectedTrangThai))
            {
                if (!string.IsNullOrEmpty(filterExpression)) filterExpression += " AND ";
                filterExpression += $"TrangThai = '{selectedTrangThai}'";
            }
            DataRow[] filteredRows = string.IsNullOrEmpty(filterExpression)
                ? quanLyNguyenLieuMonAnDataSet.NhanVien.Select()
                : quanLyNguyenLieuMonAnDataSet.NhanVien.Select(filterExpression);
            DataTable filteredTable = quanLyNguyenLieuMonAnDataSet.NhanVien.Clone();
            foreach (DataRow row in filteredRows)
            {
                DataRow newRow = filteredTable.NewRow();
                newRow.ItemArray = row.ItemArray;
                filteredTable.Rows.Add(newRow);
            }
            reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.ReportEmployee.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetDanhSachNhanVien", filteredTable));
            List<ReportParameter> reportParameters = new List<ReportParameter>
            {
                new ReportParameter("ReportParameterName", name, true),
                new ReportParameter("ReportParameterTime", time.ToString(), true),
            };
            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employManager.ShowComponent(true);
            employManager.BringToFront();
            Hide();
        }
    }
}
