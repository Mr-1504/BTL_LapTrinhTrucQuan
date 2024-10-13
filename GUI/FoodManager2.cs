using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Utilities;

namespace GUI
{
    public partial class FoodManager2 : Form
    {
        FoodManager foodManager;
        bool edit;
        string idFood=null;
        FoodManagerBLL2 foodBLL = new FoodManagerBLL2();
        public FoodManager2(FoodManager form)
        {
            InitializeComponent();
            edit = false;
            dataIngredientMNG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataIngredientMNG.ReadOnly = true;
            dataIngredientMNG.EnableHeadersVisualStyles = false;
            dataIngredientMNG.ColumnHeadersHeight = 50;
            dataIngredientMNG.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)DataGridViewCellBorderStyle.None;
            dataIngredientMNG.AllowUserToResizeColumns = false;
            dataIngredientMNG.AutoGenerateColumns = false;
            dataIngredientMNG.AllowUserToResizeRows = false;
            foodManager = form;
            ingredient();
            dataIngredientMNG.SelectionChanged += DataIngredientMNG_SelectionChanged;
        }
        public FoodManager2(FoodManager form,string foodID)
        {
            InitializeComponent();
            edit=false;
            dataIngredientMNG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataIngredientMNG.ReadOnly = true;
            dataIngredientMNG.EnableHeadersVisualStyles = false;
            dataIngredientMNG.ColumnHeadersHeight = 50;
            dataIngredientMNG.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)DataGridViewCellBorderStyle.None;
            dataIngredientMNG.AllowUserToResizeColumns = false;
            dataIngredientMNG.AutoGenerateColumns = false;
            dataIngredientMNG.AllowUserToResizeRows = false;
            foodManager = form;
            idFood = foodID;
            DataTable foodTable = new DataTable();
            foodTable = foodBLL.EditGetFood(Food.FoodId, foodID);
            FoodID.Text = idFood;
            nameFood.Text = foodTable.Rows[0]["TenMonAn"].ToString();
            Price.Text = foodTable.Rows[0]["DonGia"].ToString();
            DataTable ingredientTable = new DataTable();
            ingredientTable = foodBLL.getIngredientForFood(foodID);
            dataIngredientMNG.Columns["ingredientID"].DataPropertyName = "MaNguyenLieu";
            dataIngredientMNG.Columns["nameIngredient"].DataPropertyName = "TenNguyenLieu";
            dataIngredientMNG.Columns["number"].DataPropertyName = "SoLuong";
            dataIngredientMNG.Columns["unit"].DataPropertyName = "DonViTinh";
            dataIngredientMNG.DataSource = ingredientTable;
            LoadFoodImage( foodID );
            ingredient();
            dataIngredientMNG.SelectionChanged += DataIngredientMNG_SelectionChanged;
        }

        private void DataIngredientMNG_SelectionChanged(object sender, EventArgs e)
        {
            selectIngredient();
        }

        private void ingredient()
        {
            cbIngredient.Items.Clear();
            cbUnit.Items.Clear();
            DataTable ingredient = new DataTable();
            ingredient = foodBLL.getIngredient();
            for (int i = 0; i < ingredient.Rows.Count; i++)
            {
                cbIngredient.Items.Add(ingredient.Rows[i]["TenNguyenLieu"]);
            }
            Unit [] unit  = (Unit[] )Enum.GetValues(typeof(Unit)); 
            foreach(var name in unit)
            {
                cbUnit.Items.Add(name.GetEnumDescription());
            }

        }
        private void selectIngredient()
        {
            if (dataIngredientMNG.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataIngredientMNG.SelectedRows[0];
                cbIngredient.Text = selectedRow.Cells["nameIngredient"].Value.ToString();
                textNumber.Text = selectedRow.Cells["number"].Value.ToString();
                cbUnit.Text = selectedRow.Cells["unit"].Value.ToString();
                
            }
        }
        private void dataEmployerMNG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataEmployerMNG_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, dataIngredientMNG.Width - 1, dataIngredientMNG.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            dataIngredientMNG.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodManager.Update();
            foodManager.ShowComponent(true);
            this.SendToBack();
            foodManager.BringToFront();
        }

        private void pnFood_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnFood.Width - 1, pnFood.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnFood.Region = new Region(path);
        }

        private void pnIngredient_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, pnIngredient.Width - 1, pnIngredient.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            pnIngredient.Region = new Region(path);
        }
        private void LoadFoodImage(string foodID)
        {
            string resourcePath = $@"..\..\Resources\ImageFood\";
            string imagePath = Path.Combine(resourcePath, $"{foodID}.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (File.Exists(imagePath))
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
            }
            else
            {
                
                string defaultImagePath = Path.Combine(resourcePath, "default.jpg");
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                using (FileStream fs = new FileStream(defaultImagePath, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
            }

        }

        private void btnChaneIm_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string selectedImagePath = openFileDialog.FileName;
                    string resourcePath = $@"..\..\Resources\ImageFood\";
                    string destinationPath = Path.Combine(resourcePath, $"{idFood}.jpg");

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }
                    if (edit == false)
                    {
                        //selectedPath = selectedImagePath;
                    }

                    File.Copy(selectedImagePath, destinationPath, true);

                    LoadFoodImage(idFood);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit == true)
            {

                //string s = gender.SelectedItem.ToString();

                //if (s == Gender.Female.GetEnumDescription() || s == Gender.Male.GetEnumDescription())
                //{
                //    EmployeeDTO employeeDTO = new EmployeeDTO
                //    (
                //    employID.Text,  // Sử dụng giá trị từ TextBox
                //        name.Text,
                //        s == Gender.Male.GetEnumDescription() ? Gender.Male : Gender.Female,  // Gán giá trị enum đã chuyển đổi
                //        dateTimeBirthDay.Value,
                //        hometown.Text,
                //        address.Text,
                //        numberPhone.Text
                //    );

                //    int result = employManager2BLL.UpdateEmployee(employeeDTO);

                //    if (result > 0)
                //    {
                //        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        employ.ShowComponent(true);  // Hiển thị lại form chính
                //        this.Close();  // Đóng form hiện tại
                //    }
                //    else
                //    {
                //        MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Giới tính không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            else
            {

                //EmployeeStatus status = EmployeeStatus.CurrentlyWorking;
                //string s = gender.SelectedItem.ToString();

                //if (s == Gender.Female.GetEnumDescription() || s == Gender.Male.GetEnumDescription())
                //{
                //    EmployeeDTO employeeDTO = new EmployeeDTO
                //    (
                //        name.Text,
                //        s == Gender.Male.GetEnumDescription() ? Gender.Male : Gender.Female,
                //        dateTimeBirthDay.Value,
                //        hometown.Text,
                //        address.Text,
                //        numberPhone.Text,
                //        status
                //    );
                //    EmployeeType employeeType = new EmployeeType();
                //    if (cbboxChucVu.SelectedItem != null)
                //    {
                //        string selectedRole = cbboxChucVu.SelectedItem.ToString();
                //        switch (selectedRole)
                //        {
                //            case "Quản Lý":
                //                employeeType = EmployeeType.Manager;
                //                break;
                //            case "Lễ Tân":
                //                employeeType = EmployeeType.Receptionist;
                //                break;
                //            case "Kho Hàng":
                //                employeeType = EmployeeType.Warehouse;
                //                break;
                //        }

                //        int result = employManager2BLL.AddEmployee(employeeType, employeeDTO);


                //        if (result > 0)
                //        {
                //            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            employ.ShowComponent(true);
                //            EmployeeDTO employee = new EmployManager2BLL().GetNewestEmployee(employeeType);

                //            string resourcePath = $@"..\..\Resources\AvatarImage\";
                //            string destinationPath = Path.Combine(resourcePath, $"{employee.EmployeeId}.jpg");

                //            if (string.IsNullOrEmpty(selectedPath))
                //            {
                //                string defaultImagePath = Path.Combine(resourcePath, "default.jpg");
                //                File.Copy(defaultImagePath, destinationPath, true);
                //            }
                //            else
                //            {
                //                File.Copy(selectedPath, destinationPath, true);
                //            }
                //            employeeID = "AA0000000";
                //            destinationPath = Path.Combine(resourcePath, $"{employeeID}.jpg");
                //            File.Delete(destinationPath);
                //            LoadEmployeeImage(employeeID);
                //            this.Close();
                //        }
                //        else if (result == 0)
                //        {
                //            MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //        }
                //        else
                //        {
                //            MessageBox.Show("csdl", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //        }
                //    }
                //    else
                //    {
                //        MessageBox.Show("Vui lòng chọn chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Giới tính không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
    }
}
