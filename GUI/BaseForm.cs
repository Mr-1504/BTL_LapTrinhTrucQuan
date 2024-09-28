using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Utilities;

namespace GUI
{
    public partial class BaseForm : Form
    {

        public BaseForm()
        {
            InitializeComponent();

            //int res = new Class1().IsExist("QL0001");
            //MessageBox.Show(res.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////if (res == 1)
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
            RoundPictureBox(pictureBox2, 20);
            foreach(Control control in this.Controls)
                control.Click += Control_Click;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeButtonCircular(button1);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, MainPanel.Width - 1, MainPanel.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            MainPanel.Region = new Region(path);

            //Vẽ viền với Pen
            Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            Brush fillBrush = new SolidBrush(Color.Silver); // Màu nền trắng
            e.Graphics.FillPath(fillBrush, path);
        }

        private void RoundPictureBox(PictureBox picBox, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = cornerRadius * 2;
            Rectangle rect = new Rectangle(0, 0, picBox.Width, picBox.Height);

            // Các cung tròn ở các góc
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Góc trên-trái
            path.AddArc(rect.X + rect.Width - diameter, rect.Y, diameter, diameter, 270, 90); // Góc trên-phải
            path.AddArc(rect.X + rect.Width - diameter, rect.Y + rect.Height - diameter, diameter, diameter, 0, 90); // Góc dưới-phải
            path.AddArc(rect.X, rect.Y + rect.Height - diameter, diameter, diameter, 90, 90); // Góc dưới-trái

            // Đóng vùng path (tạo hình chữ nhật bo góc)
            path.CloseFigure();

            // Gán vùng này làm vùng hiển thị của PictureBox
            picBox.Region = new Region(path);
        }

        private void MakeButtonCircular(Button btn)
        {
            // Tạo một GraphicsPath với hình tròn
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height);

            // Đặt vùng hiển thị (Region) của button thành hình tròn
            btn.Region = new Region(path);
        }

        private void slidePanel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 8;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, slidePanel1.Width - 1, slidePanel1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            slidePanel1.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.Blue); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);
        }
        private void slidePanel2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 8;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, slidePanel2.Width - 1, slidePanel2.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            slidePanel2.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.Blue); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);
        }
        private void slidePanel3_Paint(object sender, PaintEventArgs e)
        {
            int radius = 8;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, slidePanel3.Width - 1, slidePanel3.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            slidePanel3.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.Blue); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);
        }
        
        // Bời vì không cho ảnh và button mà tạo riêng thành 2 component nên khi mà hover ví dụ như vào panel Home thì khi di chuột đến picHome và
        // btnHome thì sẽ không thể đổi màu được nên buộc phải add sự kiện cho cả 3 component để cho nhanh thì dùng chung 1 phương thức như bên dưới
        // ae thêm nhưng cái khác thì dùng tương tự như t còn không thì có thể cho t xin 1 cách khác oke hơn để cả nhóm lm theo
        private void Component_MouseEnter(object sender, EventArgs e)
        {
            if (sender == Home || sender == picHome || sender == btnHome)
            {
                picHome.Image = Properties.Resources.home1;
                btnHome.ForeColor = Color.Blue;
            }
            else if (sender == Account || sender == picAccount || sender == btnAccount)
            {
                picAccount.Image = Properties.Resources.Account1;
                btnAccount.ForeColor = Color.Blue;
            }
            
        }
        private void Component_MouseLeave(object sender, EventArgs e)
        {
            if (sender == Home || sender == picHome || sender == btnHome)
            {
                picHome.Image = Properties.Resources.Home;
                btnHome.ForeColor = Color.Black;
            }
            else if (sender == Account || sender == picAccount || sender == btnAccount)
            {
                picAccount.Image = Properties.Resources.Account;
                btnAccount.ForeColor = Color.Black;
            }
            
        }

        

        private void Component_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender == Home || sender == picHome || sender == btnHome)
            {
                slidePanel1.Visible = true;
                slidePanel2.Visible = false;
                slidePanel3.Visible = false;    
            }
            else if(sender == Account || sender == picAccount || sender == btnAccount)
            {
                slidePanel1.Visible = false;
                slidePanel2.Visible = true;
                slidePanel3.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if(ActiveControl is TextBox)
            {
                this.ActiveControl = null;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Text = "tìm";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void SearchBar_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, SearchBar.Width - 1, SearchBar.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            SearchBar.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);
        }
    }   
}
