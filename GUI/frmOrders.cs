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
        private List<Label> foodNameLabels = new List<Label>();
        private List<Label> quantityLabels = new List<Label>();
        private List<Label> priceLabels = new List<Label>();
        public frmOrders()
        {
            InitializeComponent();

           

           
        }     


        private void UcFood_FoodUpdated(object sender, FoodUpdatedEventArgs e)
        {
            UpdateOrderPanels(e.FoodName, e.Quantity, e.FoodPrice);
        }

        private void UpdateOrderPanels(string foodName, int quantity, string totalPrice)
        {

            // Tìm kiếm món ăn trong danh sách theo tên
            int index = -1;
            for (int i = 0; i < foodNameLabels.Count; i++)
            {
                if (foodNameLabels[i].Text == foodName)  // Kiểm tra xem món ăn đã có trong danh sách hay chưa
                {
                    index = i;
                    break;
                }
            }

            if (index == -1) // Món ăn chưa có trong danh sách, thêm mới
            {
                if (quantity > 0)
                {
                    // Tạo Label cho tên món ăn
                    Label lblFoodName = new Label();
                    lblFoodName.Text = foodName;
                    lblFoodName.AutoSize = true;
                    pnlFoodName.Controls.Add(lblFoodName);
                    foodNameLabels.Add(lblFoodName); // Lưu Label vào danh sách để quản lý

                    // Tạo Label cho số lượng
                    Label lblQuantity = new Label();
                    lblQuantity.Text = quantity.ToString();
                    lblQuantity.AutoSize = true;
                    pnlQuantity.Controls.Add(lblQuantity);
                    quantityLabels.Add(lblQuantity); // Lưu Label vào danh sách để quản lý

                    // Tạo Label cho thành tiền
                    Label lblPrice = new Label();
                    lblPrice.Text = totalPrice;
                    lblPrice.AutoSize = true;
                    pnlPrice.Controls.Add(lblPrice);
                    priceLabels.Add(lblPrice); // Lưu Label vào danh sách để quản lý
                }
            }
            else // Món ăn đã tồn tại, chỉ cần cập nhật số lượng và thành tiền
            {
                if (quantity > 0)
                {
                    // Cập nhật số lượng
                    quantityLabels[index].Text = quantity.ToString();

                    // Cập nhật thành tiền
                    priceLabels[index].Text = totalPrice;
                }
                else
                {
                    // Nếu số lượng là 0, xóa dòng tương ứng

                    // Xóa Label của tên món ăn
                    pnlFoodName.Controls.Remove(foodNameLabels[index]);
                    foodNameLabels.RemoveAt(index);

                    // Xóa Label của số lượng
                    pnlQuantity.Controls.Remove(quantityLabels[index]);
                    quantityLabels.RemoveAt(index);

                    // Xóa Label của thành tiền
                    pnlPrice.Controls.Remove(priceLabels[index]);
                    priceLabels.RemoveAt(index);
                }
            }

            // Cập nhật tên món ăn
            //Label lblFoodName = new Label();
            //lblFoodName.Text = foodName;
            //pnlFoodName.Controls.Add(lblFoodName);

            //// Cập nhật số lượng
            //Label lblQuantity = new Label();
            //lblQuantity.Text = quantity.ToString();
            //pnlQuantity.Controls.Add(lblQuantity);

            //// Cập nhật thành tiền (đã được tính sẵn trong ucFood)
            //Label lblPrice = new Label();
            //lblPrice.Text = totalPrice; // Giá trị đã được tính toán và truyền qua sự kiện
            //pnlPrice.Controls.Add(lblPrice);
            // Sắp xếp lại các label sau khi xóa (nếu cần)
            ReArrangeLabels();
        }

        private void ReArrangeLabels()
        {
            int xPosition = pnlTenMon.Location.X + 50;
            int yPosition = pnlTenMon.Location.Y + 60;
            foreach (var lbl in foodNameLabels)
            {
                lbl.Location = new Point(xPosition, yPosition);
                yPosition += lbl.Height + 5; // Cách nhau 5 pixel
            }
            xPosition = pnlSoLuong.Location.X + 70;
            yPosition = pnlSoLuong.Location.Y + 60;
            foreach (var lbl in quantityLabels)
            {
                lbl.Location = new Point(xPosition, yPosition);
                yPosition += lbl.Height + 5;
            }
            xPosition = pnlThanhTien.Location.X + 90;
            yPosition = pnlThanhTien.Location.Y + 60;
            foreach (var lbl in priceLabels)
            {
                lbl.Location = new Point(xPosition, yPosition);
                yPosition += lbl.Height + 5;
            }
        }



        private void pnlOrder_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnlOrder.Width - 1, pnlOrder.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnlOrder.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Red, 2);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            Brush fillBrush = new SolidBrush(Color.White); // Màu nền trắng
            e.Graphics.FillPath(fillBrush, path);
        }

        private void pnlFoodName_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnlQuantity.Width - 1, pnlQuantity.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnlQuantity.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Gray, 1);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.White); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);


        }

        private void pnlQuantity_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnlQuantity.Width - 1, pnlQuantity.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnlQuantity.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Gray, 1);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.White); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);
        }

        private void pnlPrice_Paint(object sender, PaintEventArgs e)
        {
            int radius = 40;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnlQuantity.Width - 1, pnlQuantity.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnlQuantity.Region = new Region(path);

            //Vẽ viền với Pen
            //Pen borderPen = new Pen(Color.Gray, 1);  // Màu đỏ, độ dày 2px
            //e.Graphics.DrawPath(borderPen, path);

            // Đổ màu cho Panel (tuỳ chọn)
            //Brush fillBrush = new SolidBrush(Color.White); // Màu nền trắng
            //e.Graphics.FillPath(fillBrush, path);
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
                _ucFood._FPrice = $"${food.FoodUnitPrice}";
                _ucFood.Margin = new Padding(10);

                fpnlMenu.Controls.Add(_ucFood);
            }

            UpdatePagination();
            fpnlMenu.ResumeLayout();
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

   
    }
}
