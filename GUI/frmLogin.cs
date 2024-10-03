using BLL;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private bool isNameUp;
        private bool isPasswordUp;
        private bool seen;
        private Image image;
        private AccountBLL acc = new AccountBLL();
        private string id;
        public frmLogin()
        {
            id = "";
            seen = false;
            isNameUp = false;
            isPasswordUp = false;
            InitializeComponent();
            lblName.Cursor = Cursors.IBeam;
            lblPassword.Cursor = Cursors.IBeam;
            foreach (Control control in Controls)
                control.Click += Control_Click;
            Click += Control_Click;
            image = Properties.Resources.load;
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
                    tmrNameMove.Stop();
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
                tmrNameMove.Stop();
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
                    tmrPassMove.Stop();
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
                tmrPassMove.Stop();
                isPasswordUp = false;
                lblPassword.Cursor = Cursors.Default;
            }
        }
        private void lblName_Click(object sender, EventArgs e)
        {
            if (!isNameUp)
            {
                txtUsername.Focus();
            }
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (!isNameUp)
            {
                lblName.AutoSize = true;
                lblName.Text = "Mã nhân viên";
                lblName.ForeColor = Color.Black;
                tmrNameMove.Start();
            }
        }
        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.ForeColor = Color.Black;
                tmrNameMove.Start();
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
                tmrPassMove.Start();
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (!isPasswordUp)
            {
                lblPassword.AutoSize = true;
                lblPassword.Text = "Mật khẩu";
                lblPassword.ForeColor = Color.Black;
                tmrPassMove.Start();
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
                tmrPassMove.Start();
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
                btnSeen.BackgroundImage = Properties.Resources.Seen;
            }
            else
            {
                btnSeen.BackgroundImage = Properties.Resources.UnSeen;
            }
            seen = !seen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string res = acc.Login(txtUsername.Text, txtPassword.Text);
            string[] result = res.Split(',');
            if (result[0] == "W")
            {
                lblName.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                MessageBox.Show(result[1], "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result[0] == "E")
            {
                lblName.ForeColor = Color.Red;
                lblName.Text = result[1];
            }
            else if (result[0] == "P")
            {
                lblName.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Red;
                lblPassword.Text = result[1];
            }
            else
            {
                lblName.ForeColor = Color.Black;
                lblPassword.ForeColor = Color.Black;
                id = txtUsername.Text;
                txtUsername.Text = "";
                txtPassword.Text = "";
                foreach (Control control in Controls)
                    control.Visible = false;
                picLoad.Visible = true;
                tmrLoad.Start();
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                ActiveControl = null;
            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.BBlueButton;
            btnLogin.ForeColor = ColorTranslator.FromHtml("#083c78");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.BlueButton;
            btnLogin.ForeColor = ColorTranslator.FromHtml("#1961b2");
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            picLoad.Visible = false;
            Hide();
            BaseForm baseForm = new BaseForm(id);
            baseForm.Show();
            tmrLoad.Stop();

            baseForm.FormClosed += (s, args) => Application.Exit();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Login();
            }
        }
    }
}
