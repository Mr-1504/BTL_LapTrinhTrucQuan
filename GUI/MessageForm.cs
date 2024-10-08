using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MessageForm : Form
    {
        public MessageForm(string message, string title, int type)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblMessage.Text = message;
            if (type == 1)
            {
                btnNo.Visible = false;
                btnYes.Location = new System.Drawing.Point(183, btnYes.Location.Y);
            }
            ShowDialog();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Yes;
        }
    }
}
