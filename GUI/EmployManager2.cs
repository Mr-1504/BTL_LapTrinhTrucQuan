using BLL;
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
using BLL;
using Utilities;
using DTO;
using System.Xml.Linq;
using DAL;
using System.IO;
namespace GUI
{
    public partial class EmployManager2 : Form
    {
        EmployManager employ;
        bool edit;
        EmployManager2BLL employManager2BLL = new EmployManager2BLL();
        string employeeID, selectedPath;
        public EmployManager2(EmployManager form,string erole)
        {
            InitializeComponent();
            
            employID.AutoSize = false;
            numberPhone.AutoSize = false;
            gender.AutoSize = false;
            address.AutoSize = false;
            hometown.AutoSize = false;
            edit = false;
            gender.Items.Clear();
            gender.Items.Add("Nam");
            gender.Items.Add("Nữ");
            ma_quyen.Text = "Chức vụ";
            if(erole == "QL")
            {
                cbboxChucVu.Items.Clear();
                cbboxChucVu.Items.Add("Kho Hàng");
                cbboxChucVu.Items.Add("Lễ Tân");
            }
            else if(erole == "AD")
            {
                cbboxChucVu.Items.Clear();
                cbboxChucVu.Items.Add("Quản Lý");
                cbboxChucVu.Items.Add("Lễ Tân");
                cbboxChucVu.Items.Add("Kho Hàng");
            }
            employID.Hide();
            employ = form;
            employeeID = "AA0000000";
            LoadEmployeeImage(employeeID);
        }
        public EmployManager2(string employID1,EmployManager form,string erole)
        {
            InitializeComponent();
            
            employID.AutoSize = false;
            numberPhone.AutoSize = false;
            gender.AutoSize = false;
            address.AutoSize = false;
            hometown.AutoSize = false;
            
            gender.Items.Clear();
            gender.Items.Add("Nam");
            gender.Items.Add("Nữ");
            ma_quyen.Text = "Mã Nhân Viên";
            cbboxChucVu.Hide();
            employ = form;
            edit = true;
            DataTable editTable  = new DataTable();
            editTable = employManager2BLL.EditEmployeeManager(employID1, Employee.EmployeeId);
            employID.Text = editTable.Rows[0]["MaNhanVien"].ToString();
            if(employID.Text.Substring(0, 2) == "QL")
            {
                if (erole == "QL")
                {

                    numberPhone.ReadOnly = true;
                    gender.DropDownStyle = ComboBoxStyle.DropDownList;
                    address.ReadOnly = true;
                    hometown.ReadOnly = true;
                    dateTimeBirthDay.Enabled = false;
                    name.ReadOnly = true;
                    btnSave.Enabled = false; 
                    btnChaneIm.Enabled = false;
                }
                else if (erole == "AD")
                {
                    numberPhone.ReadOnly = false;
                    gender.DropDownStyle = ComboBoxStyle.DropDown;
                    address.ReadOnly = false;
                    hometown.ReadOnly = false;
                    dateTimeBirthDay.Enabled = true;
                    name.ReadOnly = false;
                    btnSave.Enabled = true; 
                    btnChaneIm.Enabled = true;
                }
            }
            numberPhone.Text = editTable.Rows[0]["DienThoai"].ToString();
            gender.SelectedItem = editTable.Rows[0]["GioiTinh"].ToString();
            address.Text = editTable.Rows[0]["DiaChi"].ToString();
            hometown.Text = editTable.Rows[0]["QueQuan"].ToString();
            dateTimeBirthDay.Value = Convert.ToDateTime(editTable.Rows[0]["NamSinh"]);
            name.Text = editTable.Rows[0]["TenNhanVien"].ToString();
            employeeID = employID.Text;
            LoadEmployeeImage(employID1);

        }
        private void Button_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employ.ShowComponent(true);
            employ.BringToFront();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {

            string errorMessage;
            if (edit)
            {
                if (gender.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string selectedGender = gender.SelectedItem.ToString();
                EmployeeDTO employeeDTO = new EmployeeDTO(
                    employID.Text,
                    name.Text,
                    selectedGender == Gender.Male.GetEnumDescription() ? Gender.Male : Gender.Female,
                    dateTimeBirthDay.Value,
                    hometown.Text,
                    address.Text,
                    numberPhone.Text
                );

                // Validate and Update employee
                if (employManager2BLL.UpdateEmployee(employeeDTO, out errorMessage))
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    employ.ShowComponent(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                EmployeeStatus status = EmployeeStatus.CurrentlyWorking;
                if (gender.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string s = gender.SelectedItem.ToString();

                if (s == Gender.Female.GetEnumDescription() || s == Gender.Male.GetEnumDescription())
                {
                    EmployeeDTO employeeDTO = new EmployeeDTO
                    (
                        name.Text,
                        s == Gender.Male.GetEnumDescription() ? Gender.Male : Gender.Female,
                        dateTimeBirthDay.Value,
                        hometown.Text,
                        address.Text,
                        numberPhone.Text,
                        status
                    );
                    EmployeeType employeeType = new EmployeeType();
                    if (cbboxChucVu.SelectedItem != null)
                    {
                        string selectedRole = cbboxChucVu.SelectedItem.ToString();
                        switch (selectedRole)
                        {
                            case "Quản Lý":
                                employeeType = EmployeeType.Manager;
                                break;
                            case "Lễ Tân":
                                employeeType = EmployeeType.Receptionist;
                                break;
                            case "Kho Hàng":
                                employeeType = EmployeeType.Warehouse;
                                break;
                        }
                        if (employManager2BLL.AddEmployee(employeeType, employeeDTO, out errorMessage))
                        {
                            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            employ.ShowComponent(true);
                            EmployeeDTO employee = new EmployManager2BLL().GetNewestEmployee(employeeType);

                            string resourcePath = $@"Resources\AvatarImage\";
                            string destinationPath = Path.Combine(resourcePath, $"{employee.EmployeeId}.jpg");

                            if (string.IsNullOrEmpty(selectedPath))
                            {
                                string defaultImagePath = Path.Combine(resourcePath, "default.jpg");
                                File.Copy(defaultImagePath, destinationPath, true);
                            }
                            else
                            {
                                File.Copy(selectedPath, destinationPath, true);
                            }
                            employeeID = "AA0000000";
                            destinationPath = Path.Combine(resourcePath, $"{employeeID}.jpg");
                            File.Delete(destinationPath);
                            LoadEmployeeImage(employeeID);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn chức vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Giới tính không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Properties.Resources.btn;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Properties.Resources.hover;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void LoadEmployeeImage(string employeeID)
        {
            string resourcePath = $@"Resources\AvatarImage\";
            string imagePath = Path.Combine(resourcePath, $"{employeeID}.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // Kiểm tra nếu ảnh tồn tại
            if (File.Exists(imagePath))
            {
                // Giải phóng ảnh trước đó, nếu có
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                // Mở tệp ảnh để hiển thị
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    Image originalImage = Image.FromStream(fs);
                    pictureBox1.Image = Resize(originalImage, pictureBox1.Width, pictureBox1.Height);
                }
            }
            else
            {
                // Đường dẫn ảnh mặc định nếu không tìm thấy ảnh của nhân viên
                string defaultImagePath = Path.Combine(resourcePath, "default.jpg");

                // Giải phóng ảnh trước đó, nếu có
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                using (FileStream fs = new FileStream(defaultImagePath, FileMode.Open, FileAccess.Read))
                {
                    Image originalImage = Image.FromStream(fs);
                    pictureBox1.Image = Resize(originalImage, pictureBox1.Width, pictureBox1.Height);
                }
            }

        }
        private Image Resize(Image imgToResize, int width, int height)
        {
            return new Bitmap(imgToResize, new Size(width, height));
        }
        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string selectedImagePath = openFileDialog.FileName;
                    string resourcePath = $@"Resources\AvatarImage\";
                    string destinationPath = Path.Combine(resourcePath, $"{employeeID}.jpg");

                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                    }
                    if (edit == false)
                    {
                        selectedPath = selectedImagePath;
                    }
                    
                    File.Copy(selectedImagePath, destinationPath, true);

                    LoadEmployeeImage(employeeID);
                }
            }

        }

        private void dateTimeBirthDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
