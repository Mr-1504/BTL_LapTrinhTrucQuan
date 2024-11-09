using System;
using System.Drawing;
using System.Globalization;
using System.Media;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class SettingFormOption : Form
    {
        private ResourceManager resManager;
        private CultureInfo cultureInfo;
        private Action[] _action;
        public SettingFormOption(Action[] action)
        {
            InitializeComponent();
            InitializeLanguage();
            _action = action;
            btnLogout.MouseEnter += BtnLogout_MouseEnter;
            btnLogout.MouseLeave += BtnLogout_MouseLeave;
        }

        private void InitializeLanguage()
        {
            resManager = new ResourceManager("GUI.Resources.Strings", typeof(SettingFormOption).Assembly);
            cultureInfo = CultureInfo.CurrentCulture;
            ApplyLanguage();
        }

        private void ApplyLanguage()
        {
            //this.Text = resManager.GetString("FormTitle", cultureInfo);
            //toggleButton1.Text = resManager.GetString("ToggleButton1", cultureInfo);
            //toggleButton.Text = resManager.GetString("ToggleButton", cultureInfo);
            // Cập nhật các chuỗi văn bản khác tương tự
        }

        private void ChangeLanguage(string langCode)
        {
            cultureInfo = new CultureInfo(langCode);
            ApplyLanguage();
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = languageComboBox.SelectedItem.ToString();
            if (selectedLanguage == "English")
            {
                ChangeLanguage("en");
            }
            else if (selectedLanguage == "Vietnamese")
            {
                ChangeLanguage("vi");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton1.Checked)
            {
                //toggleButton1.Text = resManager.GetString("ToggleButton1On", cultureInfo);
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Comming soon...");
                toggleButton1.Text = "On";
            }
            else
            {
                //toggleButton1.Text = resManager.GetString("ToggleButton1Off", cultureInfo);
                MessageBox.Show("Comming soon...");
                toggleButton1.Text = "Off";
            }
        }

        private void ToggleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleButton.Checked)
            {
                //toggleButton.Text = resManager.GetString("ToggleButtonOn", cultureInfo);
                MessageBox.Show("Comming soon...");
                toggleButton.Text = "On";
            }
            else
            {
                //toggleButton.Text = resManager.GetString("ToggleButtonOff", cultureInfo);
                MessageBox.Show("Comming soon...");
                toggleButton.Text = "Off";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void grbEditPassword_Enter(object sender, EventArgs e)
        {

        }

        private void lbOp3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ BeA@dev.com", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pnLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _action[2]();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            loginForm.FormClosed += (s, args) => Application.Exit();
            _action[1]();
        }

        private void btnLogout_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = Properties.Resources.image2;
        }

        private void BtnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackgroundImage = Properties.Resources.image;
        }
    }
}

