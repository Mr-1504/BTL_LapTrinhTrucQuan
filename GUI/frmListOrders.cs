using BLL;
using DAL;
using DTO;
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
    public partial class frmListOrders : Form
    {
        private OrderBLL _orderBLL = new OrderBLL();
        private bool _isSearching = false;
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
            TimePaymentColumn.DefaultCellStyle.Format = "dd/MM/yyyy";
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
            printButtonColumn.Width = 50;
            printButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListOrders.Columns.Add(printButtonColumn);

            dgvListOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);

            dgvListOrders.RowTemplate.Height = 50;
            dgvListOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvListOrders.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListOrders.GridColor = Color.White;
            dgvListOrders.RowHeadersVisible =  false;
            dgvListOrders.ColumnHeadersVisible = true;
            dgvListOrders.ReadOnly = true;
        }

        public void LoadOrderData(string search="")
        {
            DataTable orderTabel;

            if (string.IsNullOrEmpty(search) || search == "Đơn hàng cần tìm ?")
            {
                orderTabel =  _orderBLL.GetOrders(search);
            }
            else
            {
                orderTabel = _orderBLL.GetOrders(search);
            }
           
            dgvListOrders.DataSource = orderTabel;

            dgvListOrders.Columns["IdTable"].DataPropertyName = "SoBan";
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
                
                ucInvoiceDetail invoiceDetail = new ucInvoiceDetail(orderId);
                AddUc(invoiceDetail);
                invoiceDetail.BringToFront();

            }
        }

        private void dgvListOrders_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dgvListOrders.Columns["PrintInvoice"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                // Tạo hình chữ nhật cho nút với kích thước nhỏ hơn
                Rectangle buttonRect = new Rectangle(e.CellBounds.X + 5, e.CellBounds.Y + 5, e.CellBounds.Width - 10, e.CellBounds.Height - 10); // Kích thước nhỏ hơn

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

        private void pnlSearchBarOrder_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnlSearchBarOrder.Width - 1, pnlSearchBarOrder.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnlSearchBarOrder.Region = new Region(path);
        }

        private void txtSearchBarOrder_MouseEnter(object sender, EventArgs e)
        {
            txtSearchBarOrder.Text = txtSearchBarOrder.Text == "Đơn hàng cần tìm ?" ? "" : txtSearchBarOrder.Text;
        }

        private void txtSearchBarOrder_MouseLeave(object sender, EventArgs e)
        {
            txtSearchBarOrder.Text = txtSearchBarOrder.Text.Length == 0 ? "Đơn hàng cần tìm ?" : txtSearchBarOrder.Text;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if(keyData == Keys.Enter)
            {
                string searchValue = txtSearchBarOrder.Text.Trim();
                if (searchValue == "" || searchValue == "Đơn hàng cần tìm ?")
                {
                    LoadOrderData();
                    _isSearching = false;
                }
                else
                {
                    LoadOrderData(searchValue);
                    txtSearchBarOrder.Text = "";
                    _isSearching=true;
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            OrderDTO newOrder = new OrderDTO(DateTime.Now, 0, Order.unpaid);
            

            //OrderDTO newOrder = new OrderDTO();
            OrderBLL _orderBLL = new OrderBLL();

            bool isSuccess = _orderBLL.AddNewOrder(newOrder);
            
            if(isSuccess)
            {
                string orderID = _orderBLL.GetLastIDOrder();

                OrderDetailDTO orderDetailDTO = new OrderDetailDTO
                {
                    OrderId = orderID,
                };

                frmOrderDetail _frmOrderDetail = new frmOrderDetail(this,orderID, newOrder.OrderDate, newOrder.OrderStatus, newOrder.TotalMoney, newOrder.TableNumber);
                Add(_frmOrderDetail);
                _frmOrderDetail.BringToFront();
            }
            else
            {
                MessageBox.Show("Thêm đơn hàng thất bại. Vui lòng thử lại");
            }
        }
        public void Add(Form frm)
        {
            frm.TopLevel = false;
            Controls.Add(frm);
            frm.Location = new Point(0, 0);
            frm.Show();
            frm.SendToBack();
        }
        public void AddUc(UserControl userControl)
        {
            
            Controls.Add(userControl);
            int xPos = (Screen.PrimaryScreen.WorkingArea.Width - userControl.Width) / 2 - 100;
            int yPos = (Screen.PrimaryScreen.WorkingArea.Height - userControl.Height) / 2;

            userControl.Location = new Point(xPos, yPos);
            userControl.Show();
            userControl.SendToBack();

        }

        private void dgvListOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string orderID = dgvListOrders.Rows[e.RowIndex].Cells["IDOrder"].Value.ToString();
                DateTime orderDate = Convert.ToDateTime(dgvListOrders.Rows[e.RowIndex].Cells["TimePayment"].Value);
                string status = dgvListOrders.Rows[e.RowIndex].Cells["StatusPayment"].Value.ToString();
                Order orderStaus = Config.GetEnumValueFromDescription<Order>(status);
                int totalPrice = Convert.ToInt32(dgvListOrders.Rows[e.RowIndex].Cells["TotalPrice"].Value);
                int tableNumber = Convert.ToInt32(dgvListOrders.Rows[e.RowIndex].Cells["IdTable"].Value);

                frmOrderDetail orderDetail = new frmOrderDetail(this, orderID, orderDate, orderStaus, totalPrice, tableNumber);

                Add(orderDetail);
                orderDetail.BringToFront();


            }
        }
    }
}
