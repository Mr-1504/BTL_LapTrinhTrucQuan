using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Utilities;
namespace GUI
{
    public partial class SettingFormEditProfile : Form
    {
        private EmployeeDAL _employeeDAL = new EmployeeDAL();
        private string _employeeId ;
        private DataTable _dt = new DataTable();
        public SettingFormEditProfile(string employeeId)
        {
            _employeeId = employeeId;
            _dt = _employeeDAL.GetEmployee(Employee.EmployeeId, _employeeId);
            InitializeComponent();
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
                }

                
            }
            else
            {
                MessageBox.Show("No data found for the specified employee.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    MessageBox.Show("Invalid gender value. Please enter 'Nam', 'Nữ', or 'Khác'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Invalid date format. Please use dd/MM/yyyy.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Quê quán không được bỏ trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number cannot be empty.");
                return false;
            }
            if ((txtPhone.Text).Length <8)
            {
                MessageBox.Show("Phone number có hơn 8 kí tự.");
                return false;
            }
            return true;
        }

    }
}
