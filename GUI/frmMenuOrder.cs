using BLL;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMenuOrder : Form
    {
        private int _currentPage = 1;
        private int _pageSize = 6;
        private int _totalPages = 1;
        private FoodBLL _foodBLL = new FoodBLL();
        private frmOrderDetail _orderDetail;
        private DataTable _selectedFoodItems;
        private List<FoodUpdatedEventArgs> _selectedFoodList;

        public frmMenuOrder(frmOrderDetail orderDetail)
        {
            InitializeComponent();

            SetupDataGridView();
            _selectedFoodItems = new DataTable();
            _selectedFoodItems.Columns.Add("FoodName");
            _selectedFoodItems.Columns.Add("Quantity");
            _selectedFoodItems.Columns.Add("TotalPrice");
            _selectedFoodList = new List<FoodUpdatedEventArgs>();
            _orderDetail = orderDetail;
            dgvOrders.DataSource = _selectedFoodItems;

        }
        private void SetupDataGridView()
        {
            
            dgvOrders.Columns.Clear();

            DataGridViewTextBoxColumn foodNameColumn = new DataGridViewTextBoxColumn();
            foodNameColumn.HeaderText = "Tên món";
            foodNameColumn.Name = "FoodName";
            foodNameColumn.DataPropertyName = "FoodName";
            foodNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrders.Columns.Add(foodNameColumn);

            
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Số lượng";
            quantityColumn.Name = "Quantity";
            quantityColumn.DataPropertyName = "Quantity";
            quantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            dgvOrders.Columns.Add(quantityColumn);

            
            DataGridViewTextBoxColumn totalPriceColumn = new DataGridViewTextBoxColumn();
            totalPriceColumn.HeaderText = "Thành tiền";
            totalPriceColumn.Name = "TotalPrice";
            totalPriceColumn.DataPropertyName = "TotalPrice";
            totalPriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  
            dgvOrders.Columns.Add(totalPriceColumn);

            dgvOrders.RowTemplate.Height = 50;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvOrders.GridColor = Color.White;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.ColumnHeadersVisible = true;
            dgvOrders.DataSource = _selectedFoodItems;
            dgvOrders.ReadOnly = true;  
        }

        private void CheckColumnWidths()
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataGridViewColumn column in dgvOrders.Columns)
            {
                sb.AppendLine($"Tên cột: {column.HeaderText}, Chiều rộng: {column.Width}");
            }
            MessageBox.Show(sb.ToString(), "Thông tin kích thước cột");
        }

        private void btnOrder_Paint(object sender, PaintEventArgs e)
        {
            int radius = 12;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, btnOrder.Width - 1, btnOrder.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            btnOrder.Region = new Region(path);
    

        }

        private void frmOrders_Load(object sender, EventArgs e)
        {

            CalculateTotalPage();
            fpnlMenu.SuspendLayout();
            LoadFoods(_currentPage);
            fpnlMenu.ResumeLayout();
            UpdateButtonColors(_currentPage);
        }

        private int CalculateTotalPage()
        {
            int totalFoods = _foodBLL.GetListFoods().Count;
            _totalPages = (totalFoods + _pageSize - 1) / _pageSize;
            return _totalPages;
        }

        private void LoadFoods(int page)
        {
            
            fpnlMenu.Controls.Clear();

            var foodsToShow = _foodBLL.GetListFoods().Skip((page - 1) * _pageSize).Take(_pageSize).ToList();

            foreach (var food in foodsToShow)
            {
                ucFood _ucFood = new ucFood();
                _ucFood._idFood = food.FoodId;
                _ucFood._FName = food.FoodName;
                _ucFood._FPrice = food.FoodUnitPrice;
                _ucFood.Margin = new Padding(10);
                _ucFood.FImage = AddImageFood(food.FoodId);
                _ucFood.FoodUpdated += UcFood_FoodUpdated;

                fpnlMenu.Controls.Add(_ucFood);
            }

            UpdatePagination();
           
        }
        public Image AddImageFood(string imageFileName)
        {
            string imagePath = $@"Resources\ImageFood\{imageFileName}.JPG";
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
                using (FileStream fs = new FileStream($@"Resources\ImageFood\default.jpg", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    icon = Image.FromStream(fs);
                }
            }
            icon = Resize(icon, 152, 107);
            return icon;
            
        }
        private Image Resize(Image imgToResize, int width, int height)
        {
            return new Bitmap(imgToResize, new Size(width, height));
        }
        private void UcFood_FoodUpdated(object sender,FoodUpdatedEventArgs e )
        {
            AddOrUpdateFoodToGrid(e);
        }
        private void AddOrUpdateFoodToGrid(FoodUpdatedEventArgs e)
        {
            bool foodExits = false;

            int i = 0;
            foreach(DataRow row in _selectedFoodItems.Rows)
            {
                if (row["FoodName"] != null && row["FoodName"].ToString() == e.FoodName)
                {
                    int currentQuantity = 0;
                    if (row["Quantity"] != null)
                    {
                        currentQuantity = int.Parse(row["Quantity"].ToString());
                    }
                    if(e.Quantity == 0)
                    {
                        _selectedFoodList.RemoveAt(i);
                        _selectedFoodItems.Rows.Remove(row);
                    }
                    else
                    {
                        row["Quantity"] = e.Quantity;
                        row["TotalPrice"] = e.Quantity * e.FoodPrice;
                        _selectedFoodList[i].Quantity = e.Quantity;
                        _selectedFoodList[i].FoodPrice = e.FoodPrice;
                    }

                    foodExits = true;
                    break;

                }
            }
            if(!foodExits)
            {
                _selectedFoodItems.Rows.Add(e.FoodName, e.Quantity, e.FoodPrice);
                _selectedFoodList.Add(e);
            }
        }
        private void UpdatePagination()
        {
            btnPrevious.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(_currentPage > 1)
            {
                _currentPage--;
                LoadFoods(_currentPage);
                UpdatePageButtons(CalculateTotalPage(), _currentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(_currentPage < _totalPages)
            {
                _currentPage++;
                LoadFoods(_currentPage);
                UpdatePageButtons(CalculateTotalPage(), _currentPage);
            }
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

        private void HandleEventClickButton(Button button)
        {
            int selectedPage = int.Parse(button.Text);
            if(selectedPage != _currentPage)
            {
                _currentPage = selectedPage;
                LoadFoods(_currentPage);
                UpdatePageButtons(CalculateTotalPage(), _currentPage);
            }
        }

        private void PageButton_Click(object sender, MouseEventArgs e)
        {
            if (sender == btnPage_st || sender == btnPage_nd || sender == btnPage_rd || sender == btnPage_th)
            {
                HandleEventClickButton((Button)sender);
            }
        }

        private void btnPage_Paint(object sender, PaintEventArgs e)
        {
            if (sender == btnPage_st || sender == btnPage_nd || sender == btnPage_rd || sender == btnPage_th)
            {
                 int radius = 12;

                 // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
                GraphicsPath path = new GraphicsPath();
                Rectangle rect = new Rectangle(0, 0, btnOrder.Width - 1, btnOrder.Height - 1);

                // Thêm hình chữ nhật bo góc vào GraphicsPath
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();
                btnOrder.Region = new Region(path);
            }
        }
        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text == "Món ăn cần tìm ?" ? "" : txtSearch.Text;
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text.Length == 0 ? "Món ăn cần tìm ?" : txtSearch.Text;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim().ToLower();
                SearchFood(searchTerm);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SearchFood(string searchTerm)
        {
            var allFood = _foodBLL.GetListFoods();
            var filteredFoods = allFood.Where(food => food.FoodName.ToLower().Contains(searchTerm)).ToList();
            if(filteredFoods.Count > 0)
            {
                _currentPage = 1;
                _totalPages = (filteredFoods.Count + _pageSize) / _pageSize;
                LoadFilteredFoods(filteredFoods, _currentPage);
                UpdatePagination();
            }
            else
            {
                new MessageForm("Không tìm thấy món ăn nào!", "Thông báo", 1);
            }
        }

        private void LoadFilteredFoods(List<FoodDTO> filteredFoods, int page)
        {
            fpnlMenu.Controls.Clear();

            var foodsToShow = filteredFoods.Skip((page - 1) * _pageSize).Take(_pageSize).ToList();

            foreach (var food in foodsToShow)
            {
                ucFood _ucFood = new ucFood();
                _ucFood._idFood = food.FoodId;
                _ucFood._FName = food.FoodName;
                _ucFood._FPrice = food.FoodUnitPrice;
                _ucFood.Margin = new Padding(10);

                _ucFood.FoodUpdated += UcFood_FoodUpdated;

                fpnlMenu.Controls.Add(_ucFood);
            }

            UpdatePagination();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //MessageForm messageForm = new MessageForm("Bạn đã đặt món xong rồi đúng không?", "Xác nhận", 1);

            //if(messageForm.ShowDialog() == DialogResult.Yes)
            //{
            //    SendToBack();
            //    _orderDetail.SetData(_selectedFoodList);
            //    _orderDetail.BringToFront();
            //}

            SendToBack();
            _orderDetail.SetData(_selectedFoodList);
            _orderDetail.BringToFront();

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

        private void lblOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
