using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SettingFormSecurity : Form
    {
        private bool seen;
        private bool seen1;
        public SettingFormSecurity()
        {
            InitializeComponent();
            seen = false;
            seen1 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picSeen1_Click(object sender, EventArgs e)
        {
            txtCrPass.UseSystemPasswordChar = !txtCrPass.UseSystemPasswordChar;

            if (seen)
            {
                picSeen1.BackgroundImage = Properties.Resources.Seen;
            }
            else
            {
                picSeen1.BackgroundImage = Properties.Resources.UnSeen;
            }
            seen = !seen;

        }

        private void picSeen2_Click(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = !txtNewPass.UseSystemPasswordChar;
            if (seen1)
            {
                picSeen2.BackgroundImage = Properties.Resources.Seen;
            }
            else
            {
                picSeen2.BackgroundImage = Properties.Resources.UnSeen;
            }
            seen1 = !seen1;
        }

        private void lbNewPassbtn_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txtCrPass.Focus();
        }
    }
}
