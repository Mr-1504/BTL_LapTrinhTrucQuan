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
    public partial class FoodManager : Form
    {
        public FoodManager()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel1.Region = new Region(path);
        }
        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.btn;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.hover;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.enter;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackgroundImage = Properties.Resources.btn;
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackgroundImage = Properties.Resources.hover;
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = Properties.Resources.btn;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = Properties.Resources.hover;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
