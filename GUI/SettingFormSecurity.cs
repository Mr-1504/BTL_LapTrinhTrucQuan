using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SettingFormSecurity : Form
    {
        private bool _seen;
        private bool _seen1;
        private bool _seen2;
        private AccountDAL _account = new AccountDAL();
        private string _employeeId;
        private int _loginCout=0;
        public SettingFormSecurity(string employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _seen = false;
            _seen1 = false;
            _seen2 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picSeen1_Click(object sender, EventArgs e)
        {
            txtCrPass.UseSystemPasswordChar = !txtCrPass.UseSystemPasswordChar;

            if (_seen)
            {
                picSeen1.BackgroundImage = Properties.Resources.Seen;
            }
            else
            {
                picSeen1.BackgroundImage = Properties.Resources.UnSeen;
            }
            _seen = !_seen;

        }

        private void picSeen2_Click(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = !txtNewPass.UseSystemPasswordChar;
            if (_seen1)
            {
                picSeen2.BackgroundImage = Properties.Resources.Seen;
            }
            else
            {
                picSeen2.BackgroundImage = Properties.Resources.UnSeen;
            }
            _seen1 = !_seen1;
        }
        private void picSeen3_Click(object sender, EventArgs e)
        {
            txtConfirmPass.UseSystemPasswordChar = !txtConfirmPass.UseSystemPasswordChar;
            if (_seen2)
            {
                picSeen3.BackgroundImage = Properties.Resources.Seen;
            }
            else
            {
                picSeen3.BackgroundImage = Properties.Resources.UnSeen;
            }
            _seen2 = !_seen2;
        }
        private void lbNewPassbtn_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void SettingFormSecurity_Load(object sender, EventArgs e)
        {

        }

        private void btnbtnChangePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCrPass.Text;
            string newPassword = txtNewPass.Text;
            string confirmPassword = txtConfirmPass.Text;

            // Kiểm tra nếu các trường mật khẩu trống
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Điền đầy đủ thông tin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Kiểm tra mật khẩu hiện tại
            string storedPasswordHash = _account.GetPasswordHash(_employeeId);
            if ((storedPasswordHash != HashPassword(currentPassword)))
            {

                _loginCout++;
                if (_loginCout > 3)
                {
                    MessageBox.Show("Bạn đã nhập quá nhiều lần thử lại sau.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }
                MessageBox.Show("Mật khẩu hiện tại không chính xác.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            // Kiểm tra mật khẩu mới và xác nhận mật khẩu
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu mới không khớp.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật mật khẩu mới
            AccountDTO account = new AccountDTO(_employeeId, HashPassword(newPassword));
            int result = _account.UpdatePassword(account);

            if (result == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


    }
}
