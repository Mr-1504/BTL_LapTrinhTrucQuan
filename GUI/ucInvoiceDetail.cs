using BLL;
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

namespace GUI
{
    public partial class ucInvoiceDetail : UserControl
    {
        private OrderDetailBLL _orderDetailBLL = new OrderDetailBLL();
        private OrderBLL _orderBLL = new OrderBLL();
        private string _orderID;
        public ucInvoiceDetail(string orderID)
        {
            InitializeComponent();
            _orderID = orderID;
            LoadInvoiceData(orderID);
        }

        public void LoadInvoiceData(string orderId)
        {
            DataTable order = _orderDetailBLL.GetOrderDetailWithFood(orderId);
            DataTable dt = _orderBLL.GetOrderById(orderId);

            if(dt.Rows.Count > 0)
            {
                lblIdOrder.Text = dt.Rows[0]["MaDon"].ToString();
                lblIdTable.Text = dt.Rows[0]["SoBan"].ToString();
                lblDate.Text = dt.Rows[0]["NgayTao"].ToString();
            }
            
            int total = 0;
            foreach (DataRow row in order.Rows)
            {
                total += Convert.ToInt32(row["ThanhTien"]);
            }

            dgvOrderDetail.DataSource = order;

            dgvOrderDetail.Columns["MaMonAn"].DataPropertyName = "MaMonAn";
            dgvOrderDetail.Columns["TenMonAn"].DataPropertyName = "TenMonAn";
            dgvOrderDetail.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dgvOrderDetail.Columns["DonGia"].DataPropertyName = "DonGia";
            dgvOrderDetail.Columns["ThanhTien"].DataPropertyName = "ThanhTien";

            DataRow totalRow = order.NewRow();
            totalRow["TenMonAn"] = "Tổng";
            totalRow["ThanhTien"] = total;

            totalRow["MaMonAn"] = DBNull.Value;
            totalRow["SoLuong"] = DBNull.Value;
            totalRow["DonGia"] = DBNull.Value;

            order.Rows.Add(totalRow);
            dgvOrderDetail.DataSource = order;

            
        }

        private void dgvOrderDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex == dgvOrderDetail.Rows.Count - 1)
            {
                e.CellStyle.Font = new Font(dgvOrderDetail.Font, FontStyle.Bold);
                //e.CellStyle.BackColor = Color.Blue ;
                e.CellStyle.ForeColor = Color.Blue ;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void btnExit_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btnExit.Width - 1, btnExit.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btnExit.Region = new Region(path);
        }
    }
}
