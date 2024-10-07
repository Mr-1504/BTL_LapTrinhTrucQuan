using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MessageForm : Form
    {
        public MessageForm(string message, string title)
        {
            InitializeComponent();
            lblTitle.Text = title;
            lblMessage.Text = message;
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
