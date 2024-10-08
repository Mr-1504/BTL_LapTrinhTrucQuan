using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucFood : UserControl
    {
        public ucFood()
        {
            InitializeComponent();
        }
        public  string _idFood
        {
            get => lblFoodID.Text;
            set => lblFoodID.Text = value;
        }
        public int _FPrice
        {
            get => int.Parse(lblPriceValue.Text);
            set => lblPriceValue.Text = value.ToString();
        }
        public string _FName
        {
            get => lblNameFood.Text;
            set => lblNameFood.Text = value;
        }
        private int _count = 0;
        private Image FImage
        {
            get { return picFood.Image; }
            set { picFood.Image = value; }
        }

        //public ucFood(int idFood, string fName, string fPrice, Image foodImage = null)
        //{
        //    InitializeComponent();
        //    _idFood = idFood;      // Gán id cho món ăn
        //    _FName = fName;        // Gán tên món ăn
        //    _FPrice = fPrice;      // Gán giá món ăn
        //    if (foodImage != null)
        //    {
        //        FImage = foodImage;  // Gán hình ảnh nếu có
        //    }

        //    // Hiển thị tên và giá của món ăn lên giao diện
           
        //}
        public event EventHandler<FoodUpdatedEventArgs> FoodUpdated;

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(_count > 0)
            {
                _count--;
            }else
            {
                this._count = 0;
            }
            lblCountFood.Text = _count.ToString();
            // OnFoodUpdated();
            FoodUpdated(this, new FoodUpdatedEventArgs(_idFood, _FName, _FPrice, _count));
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _count++;
            lblCountFood.Text = _count.ToString();
            //OnFoodUpdated();
            FoodUpdated(this, new FoodUpdatedEventArgs(_idFood, _FName, _FPrice, _count));
        }
        protected virtual void OnFoodUpdated()
        {
            if (FoodUpdated != null)
            {
                decimal price = _FPrice;
                decimal totalPrice = price * _count;
                FoodUpdated(this,new FoodUpdatedEventArgs(_idFood,_FName,(int)price,_count));
            }
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

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            Brush fillBrush = new SolidBrush(Color.White); // Màu nền trắng
            e.Graphics.FillPath(fillBrush, path);
        }
    }
}
