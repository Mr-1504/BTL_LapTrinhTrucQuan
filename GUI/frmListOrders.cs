using BLL;
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

namespace GUI
{
    public partial class frmListOrders : Form
    {
        private OrderBLL _orderBLL = new OrderBLL();
        public frmListOrders()
        {
            InitializeComponent();
            SetUpTable();
            LoadOrderData();
        }

        private void SetUpTable()
        {
            dgvListOrders.Columns.Clear();


            dgvListOrders.AutoGenerateColumns = false;
            dgvListOrders.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn IdTableColumn = new DataGridViewTextBoxColumn();
            IdTableColumn.HeaderText = "Số bàn";
            IdTableColumn.Name = "IdTable";
            IdTableColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOrders.Columns.Add(IdTableColumn);


            DataGridViewTextBoxColumn IDOrderColumn = new DataGridViewTextBoxColumn();
            IDOrderColumn.HeaderText = "Mã đơn hàng";
            IDOrderColumn.Name = "IDOrder";
            IDOrderColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOrders.Columns.Add(IDOrderColumn);


            DataGridViewTextBoxColumn StatusPaymentColumn = new DataGridViewTextBoxColumn();
            StatusPaymentColumn.HeaderText = "Tình trạng TT";
            StatusPaymentColumn.Name = "StatusPayment";
            StatusPaymentColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOrders.Columns.Add(StatusPaymentColumn);

            DataGridViewTextBoxColumn TimePaymentColumn = new DataGridViewTextBoxColumn();
            TimePaymentColumn.HeaderText = "Thời gian";
            TimePaymentColumn.Name = "TimePayment";
            TimePaymentColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOrders.Columns.Add(TimePaymentColumn);


            DataGridViewTextBoxColumn TotalPriceColumn = new DataGridViewTextBoxColumn();
            TotalPriceColumn.HeaderText = "Thành tiền";
            TotalPriceColumn.Name = "TotalPrice";
            TotalPriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOrders.Columns.Add(TotalPriceColumn);


            DataGridViewButtonColumn printButtonColumn = new DataGridViewButtonColumn();
            printButtonColumn.HeaderText = "Xuất hóa đơn";
            printButtonColumn.Name = "PrintInvoice";
            printButtonColumn.Text = "In";
            //printButtonColumn.FlatStyle = FlatStyle.Flat;
            printButtonColumn.UseColumnTextForButtonValue = true;
            printButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOrders.Columns.Add(printButtonColumn);


            dgvListOrders.RowTemplate.Height = 50;
            dgvListOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListOrders.GridColor = Color.White;
            dgvListOrders.RowHeadersVisible = false;
            dgvListOrders.ColumnHeadersVisible = true;
            dgvListOrders.ReadOnly = true;
        }

        private void LoadOrderData()
        {
            DataTable orderTabel = _orderBLL.GetOrders();

           

            dgvListOrders.DataSource = orderTabel;

            dgvListOrders.Columns["IDOrder"].DataPropertyName = "MaDon";
            dgvListOrders.Columns["StatusPayment"].DataPropertyName = "TrangThai";
            dgvListOrders.Columns["TimePayment"].DataPropertyName = "NgayTao";
            dgvListOrders.Columns["TotalPrice"].DataPropertyName = "TongTien";
        }

        private void dgvListOrders_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, dgvListOrders.Width - 1, dgvListOrders.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            dgvListOrders.Region = new Region(path);
        }

        private void dgvListOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListOrders.Columns["PrintInvoice"].Index && e.RowIndex >= 0)
            {
                string orderId = dgvListOrders.Rows[e.RowIndex].Cells["IDOrder"].Value.ToString();
                MessageBox.Show("Xuất hóa đơn cho đơn hàng: " + orderId);

            }
        }

        private void dgvListOrders_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvListOrders.Columns["PrintInvoice"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                // Tạo hình chữ nhật cho nút
                Rectangle buttonRect = e.CellBounds;

                // Vẽ nội dung chữ "In" với màu xanh
                TextRenderer.DrawText(e.Graphics, "In", e.CellStyle.Font,
                    buttonRect, Color.Blue, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Đánh dấu đã vẽ xong để tránh vẽ thêm
                e.Handled = true;
            }
        }

        private void btnThemDonHang_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btnThemDonHang.Width - 1, btnThemDonHang.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btnThemDonHang.Region = new Region(path);
        }
    }
}
