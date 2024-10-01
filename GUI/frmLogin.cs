using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private bool isNameUp;
        private bool isPasswordUp;
        private bool seen;
        //private ListBookForm listBookForm;
        public frmLogin()
        {
            seen = false;
            isNameUp = false;
            isPasswordUp = false;
            InitializeComponent();
            lblName.Cursor = Cursors.IBeam;
            lblPassword.Cursor = Cursors.IBeam;
        }
        

        private void timerNameMove_Tick(object sender, EventArgs e)
        {
            if (!isNameUp)
                if (lblName.Location.Y > -4)
                {
                    lblName.Location = new Point(lblName.Location.X, lblName.Location.Y - 2);
                }
                else
                {
                    timerNameMove.Stop();
                    isNameUp = true;
                    lblName.Cursor = Cursors.Default;
                }
            else
                if (lblName.Location.Y < 18)
            {
                lblName.Location = new Point(lblName.Location.X, lblName.Location.Y + 2);
            }
            else
            {
                lblName.AutoSize = false;
                lblName.Size = new Size(234, 15);
                timerNameMove.Stop();
                isNameUp = false;
                lblName.Cursor = Cursors.IBeam;
            }

        }
        private void timerPassMove_Tick(object sender, EventArgs e)
        {
            if (!isPasswordUp)
                if (lblPassword.Location.Y > -4)
                {
                    lblPassword.Location = new Point(lblPassword.Location.X, lblPassword.Location.Y - 2);
                }
                else
                {
                    timerPassMove.Stop();
                    isPasswordUp = true;
                    lblPassword.Cursor = Cursors.Default;
                }
            else
                if (lblPassword.Location.Y < 18)
            {
                lblPassword.Location = new Point(lblPassword.Location.X, lblPassword.Location.Y + 2);
            }
            else
            {
                lblPassword.AutoSize = false;
                lblPassword.Size = new Size(234, 15);
                timerPassMove.Stop();
                isPasswordUp = false;
                lblPassword.Cursor = Cursors.Default;
            }
        }
        private void lblName_Click(object sender, EventArgs e)
        {
            if (!isNameUp)
            {
                lblName.AutoSize = true;
                lblName.Text = "Mã nhân viên";
                lblName.ForeColor = Color.Black;
                txtUsername.Focus();
                timerNameMove.Start();
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                timerNameMove.Start();
                lblName.Text = "Mã nhân viên";
                lblName.ForeColor = Color.Black;
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            if (!isPasswordUp)
            {
                txtPassword.Focus();
                lblPassword.AutoSize = true;
                lblPassword.Text = "Mật khẩu";
                lblPassword.ForeColor = Color.Black;
                timerPassMove.Start();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = true;
                timerPassMove.Start();
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!seen)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            if (txtPassword.Text == "")
            {
                btnSeen.Visible = false;
            }
            else
            {
                btnSeen.Visible = true;
            }
        }

        private void BtnSeen_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            if (seen)
            {
                Image image = Image.FromFile("..\\Resources\\Seen.png");
                btnSeen.BackgroundImage = image;
            }
            else
            {
                Image image = Image.FromFile("..\\Resources\\UnSeen.png");
                btnSeen.BackgroundImage = image;
            }
            seen = !seen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
            {
                lblName.Text = "Nhập đủ thông tin";
                lblName.ForeColor = Color.Red;
                return;
            }
            if (this.txtPassword.Text == "")
            {
                lblPassword.Text = "Nhập đủ thông tin";
                lblPassword.ForeColor = Color.Red;
                return;
            }
           // Login();
        }
        //private void Login()
        //{
        //    try
        //    {
        //        SqlHelper sqlHelper = new SqlHelper();
        //        List<string> informationLogin = sqlHelper.GetLogin(this.txtUsername.Text);
        //        if (informationLogin == null || informationLogin.Count < 2)
        //        {
        //            lblName.AutoSize = true;
        //            lblName.Text = "Tên người dùng không đúng";
        //            lblName.ForeColor = Color.Red;
        //            lblName.AutoSize = false;
        //            return;
        //        }
        //        if (this.IsPasswordValid(this.txtPassword.Text, informationLogin[1]))
        //        {
        //            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.txtPassword.Text = "";
        //            this.txtUsername.Text = "";
        //            timerNameMove.Start();
        //            timerPassMove.Start();
        //            this.seen = false;
        //            this.txtPassword.UseSystemPasswordChar = false;
        //            return;
        //        }
        //        else
        //        {
        //            lblPassword.AutoSize = true;
        //            lblPassword.Text = "Mật khẩu không đúng";
        //            lblPassword.ForeColor = Color.Red;
        //            lblPassword.AutoSize = false;
        //            return;
        //        }
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void picTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
