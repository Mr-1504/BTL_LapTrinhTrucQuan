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
    public partial class boxFoodManager : UserControl
    {
        public bool isSelected = false;
        string idFood;
        internal ContentAlignment TextAlign;

        public boxFoodManager()
        {
            InitializeComponent();
        }
        
       
        private void lblFoodID_Click(object sender, EventArgs e)
        {

        }

        private void lblNameFood_Click(object sender, EventArgs e)
        {

        }

        private void pnlFoodItem_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnlFoodItem.Width - 1, pnlFoodItem.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnlFoodItem.Region = new Region(path);
        }
        public string IdFood {  get=> idFood; set=> idFood = value; }
        public string Title { get=> textNameFood.Text; set=> textNameFood.Text = value; }
        public string Cost { get => textPriceValue.Text;set=> textPriceValue.Text = value; }
        public Image Icon { get => picFood.Image; set => picFood.Image = value; }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
