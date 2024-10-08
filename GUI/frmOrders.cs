using BLL;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmOrders : Form
    {
        private int _currentPage = 1;
        private int _pageSize = 6;
        private int _totalPages = 1;
        private FoodBLL _foodBLL = new FoodBLL();

        public frmOrders()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            SetupDataGridView();

        }
        private void SetupDataGridView()
        {
            
            dgvOrders.Columns.Clear();

           

           
            DataGridViewTextBoxColumn foodNameColumn = new DataGridViewTextBoxColumn();
            foodNameColumn.HeaderText = "Tên món";
            foodNameColumn.Name = "FoodName";
            foodNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvOrders.Columns.Add(foodNameColumn);

            
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Số lượng";
            quantityColumn.Name = "Quantity";
            quantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            dgvOrders.Columns.Add(quantityColumn);

            
            DataGridViewTextBoxColumn totalPriceColumn = new DataGridViewTextBoxColumn();
            totalPriceColumn.HeaderText = "Thành tiền";
            totalPriceColumn.Name = "TotalPrice";
            totalPriceColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  
            dgvOrders.Columns.Add(totalPriceColumn);

            dgvOrders.RowTemplate.Height = 50;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvOrders.GridColor = Color.White;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.ColumnHeadersVisible = true;
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
            //CheckColumnWidths();
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

                _ucFood.FoodUpdated += UcFood_FoodUpdated;

                fpnlMenu.Controls.Add(_ucFood);
            }

            UpdatePagination();
           
        }
        private void UcFood_FoodUpdated(object sender,FoodUpdatedEventArgs e )
        {
            AddOrUpdateFoodToGrid(e.FoodName, e.Quantity, e.FoodPrice);
        }
        private void AddOrUpdateFoodToGrid(string foodName, int quantity, int price)
        {
            bool foodExits = false;

            foreach(DataGridViewRow row in dgvOrders.Rows)
            {
                if (row.Cells["FoodName"].Value != null && row.Cells["FoodName"].Value.ToString() == foodName)
                {
                    int currentQuantity = 0;
                    if (row.Cells["Quantity"].Value != null)
                    {
                        currentQuantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    }
                    if(quantity == 0)
                    {
                        dgvOrders.Rows.Remove(row);
                    }
                    else
                    {
                        row.Cells["Quantity"].Value = quantity;
                        row.Cells["TotalPrice"].Value = quantity * price;
                    }

                    foodExits = true;
                    break;


                    //row.Cells["Quantity"].Value =  quantity;
                    //row.Cells["TotalPrice"].Value = quantity * price;
                    //foodExits = true;
                    //break;
                }
            }
            if(!foodExits)
            {
                dgvOrders.Rows.Add(foodName, quantity, price);
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

        private void pnlHeaderTable_Paint(object sender, PaintEventArgs e)
        {
            //int radius = 20;

            //// Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            //GraphicsPath path = new GraphicsPath();
            //Rectangle rect = new Rectangle(0, 0, pnlHeaderTable.Width - 1, pnlHeaderTable.Height - 1);

            //// Thêm hình chữ nhật bo góc vào GraphicsPath
            //path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Bo góc trên bên trái
            //path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90); // Bo góc trên bên phải
            //path.AddLine(rect.X + rect.Width, rect.Y + radius, rect.X + rect.Width, rect.Y + rect.Height); // Vẽ đường thẳng từ trên xuống dưới bên phải
            ////path.AddLine(rect.X + rect.Width, rect.Y + rect.Height, rect.X, rect.Y + rect.Height); // Vẽ đường thẳng ngang ở dưới
            ////path.AddLine(rect.X, rect.Y + rect.Height, rect.X, rect.Y + radius); // Vẽ đường thẳng từ dưới lên trên bên trái
            //path.CloseFigure();
            //pnlHeaderTable.Region = new Region(path);
        }

        
    }
    public static class ControlExtensions
    {
        public static void DoubleBuffered(this Control control, bool setting)
        {
            System.Reflection.PropertyInfo propertyInfo = control.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            propertyInfo.SetValue(control, setting, null);
        }
    }
}
