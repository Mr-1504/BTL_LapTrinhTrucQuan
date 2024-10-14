using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class HomeManager : Form
    {
        HomeManagerBLL managerBLL = new HomeManagerBLL();
        
        public HomeManager()
        {
            InitializeComponent();
            textDoanhThuRight.AutoSize = false;
            textDT_DHRight.AutoSize = false;
            textSoDonHangRight.AutoSize = false;
            textSoLoaiNguyenLieu.AutoSize = false;
            textNguyenLieuTrongKhoLau.AutoSize = false;
            textSoNhaCungCap.AutoSize = false;
            textSoNhanVienKho.AutoSize = false;
            textSoTienNLMoiNhap.AutoSize = false;
            textTongChiKho.AutoSize = false;
            textDoanhThuNgay.Text = managerBLL.GetSaleToday().ToString();
            textDonHang.Text = managerBLL.GetOrderToday().ToString();
            textSoNhanVien.Text = managerBLL.GetEmployee().ToString();
            textNguyenLieuTrongKhoLau.Text = managerBLL.GetIngredientOld();
            textSoNhaCungCap.Text = managerBLL.GetSupplier().ToString();
            textSoNhanVienKho.Text = managerBLL.GetEmployeeWarehouse().ToString();
            textSoTienNLMoiNhap.Text = managerBLL.GetMoneyIngredient().ToString();
            textTongChiKho.Text = managerBLL.GetTotalWarehouse().ToString();
            textSoLoaiNguyenLieu.Text = managerBLL.GetIngredient().ToString();
            textSoBan.Text = managerBLL.GetTable().ToString();
            cbbHoatDong.Items.Clear();
            cbbHoatDong.Items.Add("Tuần");
            cbbHoatDong.Items.Add("Tháng");
            cbbHoatDong.Items.Add("Năm");
            cbbHoatDong.SelectedIndexChanged += cbbHoatDong_SelectedIndexChanged;


        }

        private void HomeManager_Load(object sender, EventArgs e)
        {
            LoadChartData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadChartData()
        {
            chartSale.Series.Clear();
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            List<int> doanhThuThang = managerBLL.GetMonthlySales();
            for (int i = 0; i < 12; i++)
            {
                series.Points.AddXY("Tháng " + (i + 1), doanhThuThang[i]);
            }
            chartSale.Series.Add(series);
            chartSale.ChartAreas[0].AxisX.Title = "";
            chartSale.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chartSale.ChartAreas[0].AxisX.Interval = 1; 
        }
        private void cbbHoatDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra giá trị được chọn trong ComboBox
            string selectedValue = cbbHoatDong.SelectedItem.ToString();

            if (selectedValue == "Tuần")
            {
                textDoanhThuRight.Text = managerBLL.GetTotalSalesCurrentWeek().ToString();
                textSoDonHangRight.Text = managerBLL.GetOrderCountCurrentWeek().ToString();
                if (managerBLL.GetTotalSalesCurrentWeek() == 0 || managerBLL.GetOrderCountCurrentWeek()==0)
                {
                    textDT_DHRight.Text = '0'.ToString();
                }
                else
                {
                    textDT_DHRight.Text = (managerBLL.GetTotalSalesCurrentWeek() / managerBLL.GetOrderCountCurrentWeek()).ToString();
                }
            }
            else if (selectedValue == "Tháng")
            {
                textDoanhThuRight.Text = managerBLL.GetTotalSalesCurrentMonth().ToString();
                textSoDonHangRight.Text = managerBLL.GetOrderCountCurrentMonth().ToString();
                if (managerBLL.GetTotalSalesCurrentMonth() == 0 || managerBLL.GetOrderCountCurrentMonth()==0)
                {
                    textDT_DHRight.Text = '0'.ToString();
                }
                else
                {
                    textDT_DHRight.Text = (managerBLL.GetTotalSalesCurrentMonth() / managerBLL.GetOrderCountCurrentMonth()).ToString();
                }
            }
            else if (selectedValue == "Năm")
            {
                textDoanhThuRight.Text = managerBLL.GetTotalSalesCurrentYear().ToString();
                textSoDonHangRight.Text = managerBLL.GetOrderCountCurrentYear().ToString();
                if (managerBLL.GetTotalSalesCurrentYear() == 0 || managerBLL.GetOrderCountCurrentYear() == 0)
                {
                    textDT_DHRight.Text = '0'.ToString();
                }
                else
                {
                    textDT_DHRight.Text = (managerBLL.GetTotalSalesCurrentYear() / managerBLL.GetOrderCountCurrentYear()).ToString();
                }
                
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, InPanelManager1.Width - 1, InPanelManager1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            InPanelManager1.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Gray, 1);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.Silver); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelRevenue.Width - 1, PanelRevenue.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelRevenue.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.GhostWhite, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            //// Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.Silver); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelChart.Width - 1, PanelChart.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelChart.Region = new Region(path);
        }

        private void PanelOrder_Paint(object sender, PaintEventArgs e)
        {

            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelOrder.Width - 1, PanelOrder.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelOrder.Region = new Region(path);
        }

        private void PanelTable_Paint(object sender, PaintEventArgs e)
        {

            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelTable.Width - 1, PanelTable.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelTable.Region = new Region(path);
        }

        private void PanelStaff_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelStaff.Width - 1, PanelStaff.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelStaff.Region = new Region(path);
        }

        private void PanelWarehouse_Paint(object sender, PaintEventArgs e)
        {

            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelWarehouse.Width - 1, PanelWarehouse.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelWarehouse.Region = new Region(path);
        }

        private void PanelIngredient_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelIngredient.Width - 1, PanelIngredient.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelIngredient.Region = new Region(path);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void PanelRight_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, PanelRight.Width - 1, PanelRight.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            PanelRight.Region = new Region(path);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
