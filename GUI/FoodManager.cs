using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FoodManager : Form
    {
        FoodManagerBLL foodManagerBLL = new FoodManagerBLL();
        private boxFoodManager selectedFoodBox = null;
        string selectedFoodId=null;
        FoodManager2 foodManager2 = null;
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
        public void AddFood(string id, string name,string price,string imageFileName)
        {
            string imagePath = $@"..\..\Resources\ImageFood\{imageFileName}.JPG"; 
            Image icon = null;
            
            try
            {
                
                icon = Image.FromFile(imagePath);

            }
            catch (Exception)
            {
                
                icon = Image.FromFile($@"..\..\Resources\ImageFood\default.jpg"); 
            }
            boxFoodManager foodBox = new boxFoodManager
            {
                IdFood = id,
                Title = name,
                Cost = price,
                Icon = icon
            };
            selectFood( foodBox );

            flowLayoutPanelFood.Controls.Add(foodBox);
        }
        private void selectFood(boxFoodManager foodBox)
        {
            foodBox.pnlFoodItem.BackColor = Color.WhiteSmoke;

            EventHandler clickHandler = (s, e) =>
            {
                if (selectedFoodBox != null && selectedFoodBox != foodBox)
                {
                    selectedFoodBox.pnlFoodItem.BackColor = Color.WhiteSmoke;
                }
                selectedFoodBox = foodBox;
                selectedFoodBox.pnlFoodItem.BackColor = Color.Gray;
                selectedFoodId = getIDFoodBox();
            };
            foodBox.pnlFoodItem.Click += clickHandler;
            foodBox.picFood.Click += clickHandler;
            foodBox.textNameFood.Click += clickHandler;
            foodBox.textPriceValue.Click += clickHandler;
            foodBox.lblName.Click += clickHandler;
        }
        public string getIDFoodBox()
        {
            return selectedFoodBox?.IdFood;
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

        private void FoodManager_Shown(object sender, EventArgs e)
        {
            DataTable data = foodManagerBLL.GetFoods();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i];
                string id = row["MaMonAn"].ToString();
                string name = row["TenMonAn"].ToString();
                string price = row["DonGia"].ToString();
                string imageFileName = row["MaMonAn"].ToString();
                AddFood(id, name, price, imageFileName);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FoodManager2 foodManager2 = new FoodManager2(this);

            ShowComponent(false);
            foodManager2.TopLevel = false;
            foodManager2.BringToFront();
            foodManager2.Focus(); 
            pnFoodMNG.Controls.Add(foodManager2);
            foodManager2.Show();
        }
        public void ShowComponent(bool show)
        {
            HideControls(Controls, show);
        }

        private void HideControls(Control.ControlCollection controls, bool show)
        {
            foreach (Control control in controls)
            {
                if (control != pnFoodMNG)
                {
                    control.Visible = show;
                }
                if (control.HasChildren)
                {
                    HideControls(control.Controls, show); 
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(selectedFoodBox == null)
            {
                MessageBox.Show("Vui long chọn lại", "Bạn chưa chọn món ăn cần sửa", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                FoodManager2 foodManager2 = new FoodManager2(this, selectedFoodId);
                ShowComponent(false);
                foodManager2.TopLevel = false;
                foodManager2.BringToFront();
                foodManager2.Focus();
                pnFoodMNG.Controls.Add(foodManager2);
                foodManager2.Show();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
