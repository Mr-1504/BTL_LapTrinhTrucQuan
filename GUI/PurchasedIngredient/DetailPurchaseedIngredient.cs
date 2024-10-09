using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class DetailPurchaseedIngredient : Form
    {
        private InputDetail inputDetail;
        private InvoiceDtail invoice;
        private BaseForm form;
        public DetailPurchaseedIngredient(string employeeId, BaseForm baseForm)
        {
            InitializeComponent();
            inputDetail = new InputDetail(employeeId);


            inputDetail.Location = new Point(0, 90);

            SuspendLayout();
            Controls.Add(inputDetail);
            ResumeLayout();

            form = baseForm;    
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            picArrowRight.Focus();
            if (inputDetail.IsCorrect())
            {
                picStep1Status.Image = Properties.Resources.step1Complete;
                picStep2Status.Image = Properties.Resources.step2Wait;
                btnReturn.Visible = true;
                invoice = new InvoiceDtail(inputDetail.GetInvoice(), inputDetail.GetInvoiceDetail(), inputDetail.GetData());
                foreach(Control control in invoice.Controls)
                {
                    control.MouseEnter += form.Menu_MouseLeave;
                }
                invoice.Location = new Point(0, 90);
                Controls.Add(invoice);
                invoice.BringToFront();
            }
            else
            {
                new MessageForm("Vui lòng thêm thông tin", "Thông báo", 1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            picArrowRight.Focus();
            DialogResult = new MessageForm("Bạn chắc chắn hủy yêu cầu thao tác thêm đơn bán, hành động sẽ không thể hoàn tác?", "Xác nhận", 2).DialogResult;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            inputDetail.BringToFront();
            btnReturn.Visible = false;
            picStep1Status.Image = Properties.Resources.step1Wait;
            picStep2Status.Image = Properties.Resources.step2;
        }
    }
}
