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
using Utilities;

namespace GUI
{
    public partial class frmOrderDetail : Form
    {
        private string _orderID;
        private DateTime _orderDate;
        private Order _orderStatus;
        private int _totalPrice;
        private int _tableNumer;
        private frmListOrders _frmListOrders;
        private DataTable _data;

        frmMenuOrder _menuOrder;

        public DataTable Data { get => _data; set => _data = value; }

        public frmOrderDetail(frmListOrders listOrders, string orderID, DateTime orderDate, Order orderStatus, int totalPrice, int tableNumber)
        {
            InitializeComponent();
            _frmListOrders = listOrders;
            _orderID = orderID;
            _orderDate = orderDate;
            _orderStatus = orderStatus;
            _totalPrice = totalPrice;
            _tableNumer = tableNumber;
            _menuOrder = new frmMenuOrder(this);
            _frmListOrders.Add(_menuOrder);
            Data = new DataTable();
            Data.Columns.Add("FoodName");
            Data.Columns.Add("Quantity");
            Data.Columns.Add("TotalPrice");


            lblIdOrder.Text = orderID;
            lblTimeOrder.Text = orderDate.ToString();
            lblTotalPrice.Text = totalPrice.ToString();
            txtIdTable.Text = tableNumber.ToString();

            IntitializeOrderStatus();
            SetUpDataGridView();
            LoadOrderDetails(orderID);
        }
        public void SetData(List<FoodUpdatedEventArgs> data)
        {
            foreach (FoodUpdatedEventArgs e in data)
            {
                _data.Rows.Add(e.FoodName, e.Quantity, e.FoodPrice * e.Quantity);
            }
            dgvListFood.Columns["FoodName"].DataPropertyName = "FoodName";
            dgvListFood.Columns["Quantity"].DataPropertyName = "Quantity";
            dgvListFood.Columns["TotalPrice"].DataPropertyName = "TotalPrice";
            dgvListFood.DataSource = _data;
        }

        private void SetUpDataGridView()
        {
            dgvListFood.Columns.Clear();


            dgvListFood.AutoGenerateColumns = false;
            dgvListFood.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn FoodNameColumn = new DataGridViewTextBoxColumn();
            FoodNameColumn.HeaderText = "Tên món ăn";
            FoodNameColumn.Name = "FoodName";
            FoodNameColumn.DataPropertyName = "FoodName";
            FoodNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListFood.Columns.Add(FoodNameColumn);


            DataGridViewTextBoxColumn QuantityColumn = new DataGridViewTextBoxColumn();
            QuantityColumn.HeaderText = "Số lượng";
            QuantityColumn.Name = "Quantity";
            QuantityColumn.DataPropertyName = "Quantity";
            QuantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListFood.Columns.Add(QuantityColumn);


            DataGridViewTextBoxColumn PriceColumn = new DataGridViewTextBoxColumn();
            PriceColumn.HeaderText = "Thành tiền";
            PriceColumn.Name = "TotalPrice";
            PriceColumn.DataPropertyName = "TotalPrice";
            PriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListFood.Columns.Add(PriceColumn);

            

            dgvListFood.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            dgvListFood.RowTemplate.Height = 50;
            dgvListFood.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListFood.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListFood.GridColor = Color.White;
            dgvListFood.RowHeadersVisible = false;
            dgvListFood.ColumnHeadersVisible = true;
            dgvListFood.ReadOnly = true;
        }

        private void LoadOrderDetails(string orderID)
        {
            OrderDetailBLL _orderDetailBLL = new OrderDetailBLL();
            DataTable dt = _orderDetailBLL.GetOrderDetailsByOrderId(orderID);

            dgvListFood.DataSource = dt;

            dgvListFood.Columns["FoodName"].DataPropertyName = "TenMonAn";
            dgvListFood.Columns["Quantity"].DataPropertyName = "SoLuong";
            dgvListFood.Columns["TotalPrice"].DataPropertyName = "ThanhTien";
        }

        private void IntitializeOrderStatus()
        {
            cmbStatusOrder.Items.Add(Order.paid.GetEnumDescription());
            cmbStatusOrder.Items.Add(Order.unpaid.GetEnumDescription());

            cmbStatusOrder.SelectedItem = _orderStatus.GetEnumDescription();
        }

        private void btnBackToOrder_Paint(object sender, PaintEventArgs e)
        {
            int radius = 12;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btnBackToOrder.Width - 1, btnBackToOrder.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btnBackToOrder.Region = new Region(path);
        }

        private void btnThemMonAn_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btnThemMonAn.Width - 1, btnThemMonAn.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btnThemMonAn.Region = new Region(path);
        }

        private void btnSaveOrderDetail_Paint(object sender, PaintEventArgs e)
        {
            int radius = 60;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btnSaveOrderDetail.Width - 1, btnSaveOrderDetail.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btnSaveOrderDetail.Region = new Region(path);
        }

        private void btnBackToOrder_Click(object sender, EventArgs e)
        {
            SendToBack();
            _frmListOrders.BringToFront();
            _frmListOrders.LoadOrderData();
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            if(_orderStatus == Order.paid)
            {
                new MessageForm("Đơn hàng đã dược thanh toán. Vui lòng không đặt thêm món!", "Thông báo", 1);
                return;
            }
            _menuOrder.BringToFront();
        }
    }
}
