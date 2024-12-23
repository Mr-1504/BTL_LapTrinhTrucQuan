﻿using System;
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
        private bool isSearch = false;
        public FoodManager()
        {
            InitializeComponent();
            btnPrevious.Enabled = false;
            textSearch.AutoSize = false;
            CustomizeFlowLayoutPanel();
        }
        private void CustomizeFlowLayoutPanel()
        {
            flowLayoutPanelFood.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelFood.Padding = new Padding(20);
            flowLayoutPanelFood.WrapContents = true;
        }

        private void FoodManager_Load(object sender, EventArgs e)
        {
            SetPlaceholder(textSearch, "Nhập tên món ăn tìm kiếm...");
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
            icon = Resize(icon, 178, 149);
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
        private Image Resize(Image imgToResize, int width, int height)
        {
            return new Bitmap(imgToResize, new Size(width, height));
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
            if (isSearch)
            {
                LoadFoodItems(textSearch.Text);
            }
            else
            {
                LoadFoodItems();
            }
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
        private void LoadFoodItems(string getValue)
        {
            DataTable data = foodManagerBLL.GetFoods(Food.FoodName, getValue);
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

        }
        

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
                if (isSearch)
                {
                    LoadFoodItems(textSearch.Text);
                }
                else
                {
                    LoadFoodItems();
                }
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
            ShowComponent(false);
            foodManager2.TopLevel = false;
            foodManager2.BringToFront();
            foodManager2.Focus(); 
            pnFoodMNG.Controls.Add(foodManager2);
            foodManager2.Show();
            foodManager2.FormClosed += FoodManager2_FormClosed;
        }
        public void ShowComponent(bool show)
        {
            HideControls(Controls, show);
            UpdatePagination();
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
                foodManager2.FormClosed += FoodManager2_FormClosed;
            }
            
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                if (isSearch)
                {
                    LoadFoodItems(textSearch.Text);
                }
                else
                {
                    LoadFoodItems();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                if (isSearch)
                {
                    LoadFoodItems(textSearch.Text);
                }
                else
                {
                    LoadFoodItems();
                }
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
            ShowComponent(true);
            if (isSearch)
            {
                LoadFoodItems(textSearch.Text);
            }
            else
            {
                LoadFoodItems();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = textSearch.Text.ToString();
            if (string.IsNullOrWhiteSpace(search))
            {
                isSearch = false;
                LoadFoodItems();
            }
            else
            {
                isSearch = true;
                LoadFoodItems(search);
            }
        }

        private void TextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = textSearch.Text.ToString();
                if (string.IsNullOrWhiteSpace(search))
                {
                    isSearch = false;
                    LoadFoodItems();
                }
                else
                {
                    isSearch = true;
                    LoadFoodItems(search);
                }
                e.SuppressKeyPress = true;
            }
        }
        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        
    }
}
