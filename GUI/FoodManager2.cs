using BLL;
using DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FoodManager2 : Form
    {
        FoodManager foodManager;
        bool editIngredient,edit;
        string idFood = null;
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
            maMon.Text = "Kiểu món ăn";
            FoodID.Hide();
            cbFoodType.Items.Add("Món khai vị");
            cbFoodType.Items.Add("Món chính");
            cbFoodType.Items.Add("Món tráng miệng");
            foodManager = form;
            ingredient();
            dataIngredientMNG.SelectionChanged += DataIngredientMNG_SelectionChanged;
        }
        public FoodManager2(FoodManager form, string foodID)
        {
            InitializeComponent();
            edit = true;
            dataIngredientMNG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataIngredientMNG.ReadOnly = true;
            dataIngredientMNG.EnableHeadersVisualStyles = false;
            dataIngredientMNG.ColumnHeadersHeight = 50;
            dataIngredientMNG.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)DataGridViewCellBorderStyle.None;
            dataIngredientMNG.AllowUserToResizeColumns = false;
            dataIngredientMNG.AutoGenerateColumns = false;
            dataIngredientMNG.AllowUserToResizeRows = false;
            maMon.Text = "Mã món ăn";
            cbFoodType.Hide();
            foodManager = form;
            idFood = foodID;
            DataTable foodTable = new DataTable();
            foodTable = foodBLL.EditGetFood(Food.FoodId, foodID);
            FoodID.Text = idFood;
            nameFood.Text = foodTable.Rows[0]["TenMonAn"].ToString();
            Price.Text = foodTable.Rows[0]["DonGia"].ToString();
            textMaking.Text = foodTable.Rows[0]["CachLam"].ToString(); 
            LoadDataGredient(foodID);
            LoadFoodImage(foodID);
            ingredient();
            dataIngredientMNG.SelectionChanged += DataIngredientMNG_SelectionChanged;
            cbIngredient.SelectedIndexChanged += cbIngredient_SelectedIndexChanged;
            
        }

        private void LoadDataGredient(string foodID)
        {
            DataTable ingredientTable = new DataTable();
            ingredientTable = foodBLL.getIngredientForFood(foodID);
            dataIngredientMNG.Columns["ingredientID"].DataPropertyName = "MaNguyenLieu";
            dataIngredientMNG.Columns["nameIngredient"].DataPropertyName = "TenNguyenLieu";
            dataIngredientMNG.Columns["number"].DataPropertyName = "SoLuong";
            dataIngredientMNG.Columns["unit"].DataPropertyName = "DonViTinh";
            dataIngredientMNG.DataSource = ingredientTable;
        }
        private void DataIngredientMNG_SelectionChanged(object sender, EventArgs e)
        {
            selectIngredient();
        }

        private void ingredient()
        {
            cbIngredient.Items.Clear();
            cbUnit.Clear();
            DataTable ingredient = new DataTable();
            ingredient = foodBLL.getIngredient();
            for (int i = 0; i < ingredient.Rows.Count; i++)
            {
                cbIngredient.Items.Add(ingredient.Rows[i]["TenNguyenLieu"]);
            }
            //Unit[] unit = (Unit[])Enum.GetValues(typeof(Unit));
            //foreach (var name in unit)
            //{
            //    cbUnit.Items.Add(name.GetEnumDescription());
            //}

        }
        private bool IngredientTable(string ingredientID){
            foreach (DataGridViewRow row in dataIngredientMNG.Rows)
            {
                if (row.Cells["ingredientID"].Value != null && row.Cells["ingredientID"].Value.ToString() == ingredientID)
                {
                    return true;
                }
            }
            return false;
        }
        private bool IngredientExistsInGrid(string ingredientName)
        {
            foreach (DataGridViewRow row in dataIngredientMNG.Rows)
            {
                if (row.Cells["nameIngredient"].Value != null && row.Cells["nameIngredient"].Value.ToString() == ingredientName)
                {
                    return true;
                }
            }
            return false;
        }
        private void selectIngredient()
        {
            if (dataIngredientMNG.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataIngredientMNG.SelectedRows[0];
                cbIngredient.Text = selectedRow.Cells["nameIngredient"].Value.ToString();
                textNumber.Text = selectedRow.Cells["number"].Value.ToString();
                cbUnit.Text = selectedRow.Cells["unit"].Value.ToString();
                btnSave.Text = "Lưu";
                editIngredient = true;
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
                using (FileStream stream = new FileStream(defaultImagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
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

                    if (!Directory.Exists(resourcePath))
                    {
                        Directory.CreateDirectory(resourcePath);
                    }
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }

                    try
                    {
                        File.Copy(selectedImagePath, destinationPath, true);

                        LoadFoodImage(idFood);
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show($"Error copying file: {ioEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editIngredient == true)
            {
                DataTable dataIngredientTable = new DataTable();
                dataIngredientTable = foodBLL.GetIngredients(Ingredient.IngredientName, cbIngredient.Text);
                string editID = dataIngredientTable.Rows[0][0].ToString();

                RecipeDTO recipeDTO = new RecipeDTO(
                    idFood,
                    editID,
                    decimal.Parse(textNumber.Text)
                );

                foodBLL.UpdateRecipe(recipeDTO);
                LoadDataGredient(idFood);  
            }
            else
            {
                DataTable dataIngredientTable = new DataTable();
                dataIngredientTable = foodBLL.GetIngredients(Ingredient.IngredientName, cbIngredient.Text);
                string editID = dataIngredientTable.Rows[0][0].ToString();

                RecipeDTO recipeDTO = new RecipeDTO(
                    idFood,
                    editID,
                    decimal.Parse(textNumber.Text)
                );

                foodBLL.AddNewRecipe(recipeDTO);
                LoadDataGredient(idFood);  
            }

            btnSave.Text = "Thêm";
            editIngredient = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (edit == true)
            {
                int numberValue;
                if (!int.TryParse(Price.Text, out numberValue))
                {
                    MessageBox.Show("Phải nhập số nguyên.", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FoodDTO foodDTO = new FoodDTO(
                    nameFood.Text,
                    textMaking.Text,
                    numberValue,
                    idFood,
                    Utilities.Status.Use
                );
                int result = foodBLL.UpdateFood( foodDTO );
                Console.WriteLine( result );
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    foodManager.Update();
                    foodManager.ShowComponent(true);
                    this.Close();
                    this.SendToBack();
                    foodManager.BringToFront();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                int numberValue;
                if (!int.TryParse(Price.Text, out numberValue))
                {
                    MessageBox.Show("Phải nhập số nguyên.", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                FoodDTO foodDTO = new FoodDTO(
                    nameFood.Text,
                    textMaking.Text,
                    numberValue,
                    Utilities.Status.Use
                );

                FoodType foodType = new FoodType();
                if (cbFoodType.SelectedItem != null)
                {
                    string selectedRole = cbFoodType.SelectedItem.ToString();
                    switch (selectedRole)
                    {
                        case "Món khai vị":
                            foodType = FoodType.Appetizer;
                            break;
                        case "Món chính":
                            foodType = FoodType.MainCourse;
                            break;
                        case "Món tráng miệng":
                            foodType = FoodType.Dessert;
                            break;
                    }

                    int result = foodBLL.AddNewFood(foodType, foodDTO);


                    if (result > 0)
                    {
                        MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        foodManager.ShowComponent(true);
                        

                       
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Thêm món thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("csdl", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        
        }

        private void FoodManager2_Load(object sender, EventArgs e)
        {
            cbIngredient_SelectedIndexChanged(null, null);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataIngredientMNG.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataIngredientMNG.SelectedRows[0];
                RecipeDTO recipeDTO = new RecipeDTO(
                    idFood,
                    selectedRow.Cells["ingredientID"].Value.ToString(),
                    decimal.Parse(selectedRow.Cells["number"].Value.ToString())
                );
                int resul = foodBLL.RemoveRecipe(recipeDTO);
                if (resul > 0)
                {
                    MessageBox.Show("Xóa nguyên liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGredient(idFood);
                }
                else
                {
                    MessageBox.Show("Xóa nguyên liệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbIngredient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IngredientExistsInGrid(cbIngredient.Text))
            {
                DataGridViewRow row = dataIngredientMNG.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["nameIngredient"].Value.ToString() == cbIngredient.Text);

                if (row != null)
                {
                    textNumber.Text = row.Cells["number"].Value.ToString();
                    cbUnit.Text = row.Cells["unit"].Value.ToString();
                }

                btnSave.Text = "Lưu";
                editIngredient = true;
            }
            else
            {
                textNumber.Text = string.Empty;
                DataTable ingredientUnit = new DataTable();
                ingredientUnit = foodBLL.GetIngredients(Ingredient.IngredientName, cbIngredient.Text);
                cbUnit.Text = ingredientUnit.Rows[0][2].ToString();
                btnSave.Text = "Thêm";
                editIngredient = false;
            }

        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSaveFood.BackgroundImage = Properties.Resources.btn;
            btnSaveFood.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSaveFood.BackgroundImage = Properties.Resources.hover;
            btnSaveFood.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteIngredient.BackgroundImage = Properties.Resources.btn;
            btnDeleteIngredient.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteIngredient.BackgroundImage = Properties.Resources.hover;
            btnDeleteIngredient.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnSaveIngredient_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Properties.Resources.btn;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnSaveIngredient_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Properties.Resources.hover;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
