using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.PurchasedIngredient
{
    public partial class DetailPurchaseedIngredient : Form
    {
        private InputDetail inputDetail;
        private InvoiceDtail invoice;
        public DetailPurchaseedIngredient(string employeeId)
        {
            InitializeComponent();
            inputDetail = new InputDetail(employeeId);

            inputDetail.Location = new Point(0, 90);
            Controls.Add(inputDetail);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (inputDetail.IsCorrect())
            {
                picStep1Status.Image = Properties.Resources.step1Complete;
                picStep2Status.Image = Properties.Resources.step2Wait;  
                invoice = new InvoiceDtail(inputDetail.GetInvoice(), inputDetail.GetInvoiceDetail());
                invoice.Location = new Point(0, 90);
                Controls.Remove(inputDetail);
                Controls.Add(invoice);
            }
        }
    }
}
