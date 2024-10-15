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
using Utilities;

namespace GUI
{
    public partial class FoodManager : Form
    {
        FoodManagerBLL foodManagerBLL = new FoodManagerBLL();
        private boxFoodManager selectedFoodBox = null;
        string selectedFoodId=null;
        FoodManager2 foodManager2 = null;
        private int currentPage = 1;
        private int itemsPerPage = 6;
        private int totalPages = 1;
        
        public FoodManager()
        {
            InitializeComponent();
            btnPrevious.Enabled = false;
            CustomizeFlowLayoutPanel();
        }
        private void CustomizeFlowLayoutPanel()
        {
            flowLayoutPanelFood.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelFood.Padding = new Padding(20);
            flowLayoutPanelFood.WrapContents = true;
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
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    icon = Image.FromStream(fs);
                }
            }
            catch (Exception)
            {
                using (FileStream fs = new FileStream($@"..\..\Resources\ImageFood\default.jpg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    icon = Image.FromStream(fs);
                }
            }

            boxFoodManager foodBox = new boxFoodManager
            {
                IdFood = id,
                Title = name,
                Cost = price,
                Icon = icon
            };
            selectFood(foodBox);
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
            LoadFoodItems();
            CustomizeFlowLayoutPanel();

        }
        private void LoadFoodItems()
        {
            DataTable data = foodManagerBLL.GetFoods();
            int totalItems = data.Rows.Count;

            totalPages = (totalItems + itemsPerPage - 1) / itemsPerPage;
            flowLayoutPanelFood.Controls.Clear();
            int startItem = (currentPage - 1) * itemsPerPage;
            int endItem = Math.Min(startItem + itemsPerPage, totalItems);

            for (int i = startItem; i < endItem; i++)
            {
                DataRow row = data.Rows[i];
                if (row["TrangThai"].ToString() == "1")
                {
                    string id = row["MaMonAn"].ToString();
                    string name = row["TenMonAn"].ToString();
                    string price = row["DonGia"].ToString();
                    string imageFileName = row["MaMonAn"].ToString();
                    AddFood(id, name, price, imageFileName);
                }
            }

            UpdatePagination();
        }
        
        private void UpdatePagination()
        {
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            UpdatePageButtons(totalPages, currentPage); 
        }
        private void UpdatePageButtons(int totalPages, int currentPage)
        {
            //Button[] pageButtons = { btnPage_st, btnPage_nd, btnPage_rd, btnPage_th };
            //int buttonsToShow = Math.Min(totalPages, 4); 
            //int startPage, endPage;

            //if (totalPages <= 4)
            //{
            //    startPage = 1;
            //    endPage = totalPages;
            //}
            //else
            //{
            //    if (currentPage <= 2)
            //    {
            //        startPage = 1;
            //        endPage = 4;
            //    }
            //    else if (currentPage >= totalPages - 1)
            //    {
            //        startPage = totalPages - 3;
            //        endPage = totalPages;
            //    }
            //    else
            //    {
            //        startPage = currentPage - 1;
            //        endPage = currentPage + 2;
            //    }
            //}

            //for (int i = 0; i < buttonsToShow; i++)
            //{
            //    pageButtons[i].Text = (startPage + i).ToString();
            //    pageButtons[i].Visible = true;
            //}

            //for (int i = buttonsToShow; i < pageButtons.Length; i++)
            //{
            //    pageButtons[i].Visible = false;
            //}
            //UpdateButtonColors(currentPage);
            Button[] pageButtons = { btnPage_st, btnPage_nd, btnPage_rd, btnPage_th };
            int buttonsToShow = Math.Min(totalPages, 4);
            int startPage, endPage;

            if (totalPages <= 4)
            {
                startPage = 1;
                endPage = totalPages;
            }
            else
            {
                startPage = Math.Max(1, currentPage - 1);
                endPage = Math.Min(startPage + 3, totalPages);
                if (endPage - startPage < 3)
                {
                    startPage = Math.Max(1, endPage - 3);
                }
            }

            for (int i = 0; i < buttonsToShow; i++)
            {
                pageButtons[i].Text = (startPage + i).ToString();
                pageButtons[i].Visible = true;
            }

            for (int i = buttonsToShow; i < pageButtons.Length; i++)
            {
                pageButtons[i].Visible = false;
            }

            UpdateButtonColors(currentPage);
            //btnPage_st.Click += PageButton_Click;
            //btnPage_nd.Click += PageButton_Click;
            //btnPage_rd.Click += PageButton_Click;
            //btnPage_th.Click += PageButton_Click;
        }
        
        //private void PageButton_Click(object sender, EventArgs e)
        //{
        //    Button clickedButton = sender as Button;
        //    if (clickedButton != null && int.TryParse(clickedButton.Text, out int selectedPage))
        //    {
        //        if (selectedPage != currentPage)
        //        {
        //            currentPage = selectedPage; 
        //            LoadFoodItems();            
        //            UpdatePageButtons(totalPages, currentPage);  
        //        }
        //    }
        //}

        private void UpdateButtonColors(int currentPage)
        {
            Button[] pageButtons = { btnPage_st, btnPage_nd, btnPage_rd, btnPage_th };
            foreach (var button in pageButtons)
            {
                if (int.TryParse(button.Text, out int pageNumber))
                {
                    if (pageNumber == currentPage)
                    {
                        button.BackColor = Color.Blue;
                        button.ForeColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = SystemColors.Control;
                        button.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void HandleEventClickButton(Button button)
        {
            int selectedPage = int.Parse(button.Text);
            if (selectedPage != currentPage)
            {
                currentPage = selectedPage;
                LoadFoodItems();
                UpdatePageButtons(totalPages, currentPage);
            }
        }

        private void PageButton_Click(object sender, MouseEventArgs e)
        {
            if (sender == btnPage_st || sender == btnPage_nd || sender == btnPage_rd || sender == btnPage_th)
            {
                HandleEventClickButton((Button)sender);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FoodManager2 foodManager2 = new FoodManager2(this);
            foodManager2.FormClosed += FoodManager2_FormClosed;
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
                foodManager2.FormClosed += FoodManager2_FormClosed;
                ShowComponent(false);
                foodManager2.TopLevel = false;
                foodManager2.BringToFront();
                foodManager2.Focus();
                pnFoodMNG.Controls.Add(foodManager2);
                foodManager2.Show();
            }
            
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadFoodItems();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadFoodItems();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int resul = foodManagerBLL.ChangeFoodStatus(selectedFoodId, Utilities.Status.NoUse);
            if (resul > 0)
            {
                MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFoodItems();
            }
            else
            {
                MessageBox.Show("Xóa món ăn thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FoodManager2_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadFoodItems();
            ShowComponent(true);
        }
    }
}
