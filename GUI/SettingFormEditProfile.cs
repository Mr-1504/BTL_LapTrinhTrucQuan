using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using Utilities;
namespace GUI
{
    public partial class SettingFormEditProfile : Form
    {
        private EmployeeDAL _employeeDAL = new EmployeeDAL();
        private string _employeeId ;
        private DataTable _dt = new DataTable();
        //path ảnh
        string _imagePath;
        private Action[] _actions;
        public SettingFormEditProfile(string employeeId, Action[] actions)
        {
            _employeeId = employeeId;
            _dt = _employeeDAL.GetEmployee(Employee.EmployeeId, _employeeId);
            _imagePath = $@"Resources\AvatarImage\{_employeeId}.JPG";
            _actions = actions;
            InitializeComponent();
            picEditImage.MouseEnter += new EventHandler(Picture_MouseEnter);
            picEditImage.MouseLeave += new EventHandler(Picture_MouseLeave);
        }
        private void Picture_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                pic.Image = Properties.Resources.ResourceManager.GetObject("picEditInformationBlue") as Image;
            }
        }

        private void Picture_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null)
            {
                pic.Image = Properties.Resources.ResourceManager.GetObject("picEditInformationGray") as Image;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SettingFormEditProfile_Load(object sender, EventArgs e)
        {
            
            if (_dt.Rows.Count > 0)
            {
                txtName.Text = _dt.Rows[0]["TenNhanVien"].ToString();
                txtAddress.Text = _dt.Rows[0]["DiaChi"].ToString();
                txtPhone.Text = _dt.Rows[0]["DienThoai"].ToString();
                txtCountry.Text = _dt.Rows[0]["QueQuan"].ToString();
                txtGender.Text = _dt.Rows[0]["GioiTinh"].ToString();
                txtUserName.Text = _dt.Rows[0]["MaNhanVien"].ToString();
                txtUserName.Enabled = false;


                // Ép kiểu thành DateTime và định dạng lại
                DateTime dateOfBirth;
                if (DateTime.TryParse(_dt.Rows[0]["NamSinh"].ToString(), out dateOfBirth))
                {
                    txtDateofBirth.Text = dateOfBirth.ToString("dd/MM/yyyy");
                }
                else
                {
                    txtDateofBirth.Text = "Invalid Date";
                }// Set the Image property of picAvatar
                if (System.IO.File.Exists(_imagePath))
                {
                    picAvatar.Image = Image.FromFile(_imagePath);
                    
                }
                else
                {
                    MessageBox.Show("Lỗi không tìm thấy ảnh.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Không load được data.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Tạo dic để ánh xạ các chuỗi đầu vào thành giá trị enum Gender
                var genderMapping = new Dictionary<string, Gender>(StringComparer.OrdinalIgnoreCase)
                {
                    { "Nam", Gender.Male },
                    { "Nữ", Gender.Female },
                    { "Khác", Gender.Other }
                };

                Gender gender;
                if (!genderMapping.TryGetValue(txtGender.Text, out gender))
                {
                    MessageBox.Show("Lỗi giới tính. Nhập 'Nam', 'Nữ', or 'Khác'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                EmployeeDTO employee = new EmployeeDTO(_employeeId,
                    txtName.Text,
                    gender,
                    DateTime.ParseExact(txtDateofBirth.Text, "dd/MM/yyyy", null),
                    txtCountry.Text, 
                    txtAddress.Text,
                    txtPhone.Text,
                    EmployeeStatus.CurrentlyWorking);

                int result = _employeeDAL.UpdateEmployee(employee);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Tên không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống.");
                return false;
            }
            DateTime dateOfBirth;
            if (!DateTime.TryParseExact(txtDateofBirth.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateOfBirth))
            {
                MessageBox.Show("Lỗi định dạng. Sử dụng dd/MM/yyyy.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Quê quán không được bỏ trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.");
                return false;
            }
            if ((txtPhone.Text).Length <8)
            {
                MessageBox.Show("Số điện thoại có hơn 8 kí tự.");
                return false;
            }
            return true;
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void picEditImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //lấy đường đãn file
                    string selectedFilePath = openFileDialog.FileName;

                    //  đường dẫn mặc định
                    string targetPath = $@"Resources\AvatarImage\{_employeeId}.JPG";

                    try
                    {
                        if (picAvatar.Image != null)
                        {
                            picAvatar.Image.Dispose();
                            picAvatar.Image = null;
                            
                        }
                        _actions[0]();

                        // copy file vào project
                        System.IO.File.Copy(selectedFilePath, targetPath, true);

                        picAvatar.Image = Image.FromFile(targetPath);
                        _actions[1]();

                        MessageBox.Show("Thay đổi ảnh thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi cập nhật ảnh: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
