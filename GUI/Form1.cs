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
using BLL;
using Utilities;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int res = new Class1().IsExist("QL0001");
            //MessageBox.Show(res.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //if (res == 1)
            //{
            //    MessageBox.Show("Thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (res == 0)
            //{
            //    MessageBox.Show("k", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}else
            //{
            //    MessageBox.Show("loi" + res.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Class1().GetData();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 0, 270);
            path.CloseFigure();

            // Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            Brush fillBrush = new SolidBrush(Color.White); // Màu nền trắng
            e.Graphics.FillPath(fillBrush, path);
        }
    }
}
