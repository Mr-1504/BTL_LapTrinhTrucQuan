using BLL;
using DTO;
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
        private PurchasedList _purchasedList;
        private bool status;
        private Action<PurchaseInvoiceDTO> _action;
        public DetailPurchaseedIngredient(string employeeId, BaseForm baseForm, PurchasedList purchasedList, Action<PurchaseInvoiceDTO> action)
        {
            InitializeComponent();
            _action = action;
            inputDetail = new InputDetail(employeeId);
            inputDetail.Location = new Point(0, 90);

            SuspendLayout();
            Controls.Add(inputDetail);
            ResumeLayout();

            form = baseForm;
            _purchasedList = purchasedList;
            status = false;
        }
        private void Reset()
        {
            inputDetail.Reset();
            btnReturn_Click(btnReturn, new EventArgs());
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!status)
            {
                picArrowRight.Focus();
                if (inputDetail.IsCorrect())
                {
                    picStep1Status.Image = Properties.Resources.step1Complete;
                    picStep2Status.Image = Properties.Resources.step2Wait;
                    btnContinue.BackgroundImage = Properties.Resources.btnComplete;
                    btnReturn.Visible = true;
                    invoice = new InvoiceDtail(inputDetail.GetInvoice(), inputDetail.GetInvoiceDetail(), inputDetail.GetData());
                    foreach (Control control in invoice.Controls)
                    {
                        control.MouseEnter += form.Menu_MouseLeave;
                    }
                    invoice.Location = new Point(0, 90);
                    Controls.Add(invoice);
                    invoice.SetTotal();
                    invoice.BringToFront();
                    picWarnning.Visible = true ;
                    status = true;
                }
                else
                {
                    new MessageForm("Vui lòng thêm thông tin", "Thông báo", 1);
                }
            }
            else
            {
                DialogResult result = new MessageForm("Xác nhận thêm hóa đơn\nSẽ không thể hoàn tác!", "Thông báo", 2).DialogResult;
                if(result == DialogResult.Yes)
                {
                    int res = new PurchaseInvoiceBLL().AddNewPurchaseInvoice(inputDetail.GetInvoice(), inputDetail.GetInvoiceDetail());
                    if (res == 1)
                    {
                        new MessageForm("Thêm thành công", "Thông báo", 1);
                        PurchaseInvoiceDTO invoiceDTO = new PurchaseInvoiceBLL().GetNewestPurchaseInvoice();
                        _action(invoiceDTO);
                        Reset();
                        SendToBack();
                    }
                    else
                    {
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            picArrowRight.Focus();
            DialogResult result = new MessageForm("Bạn chắc chắn hủy yêu cầu thao tác thêm đơn bán, hành động sẽ không thể hoàn tác?", "Xác nhận", 2).DialogResult;
            if (result == DialogResult.Yes)
            {
                Reset();   
                _purchasedList.BringToFront();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            btnContinue.BackgroundImage = Properties.Resources.btnContinue;
            btnReturn.Visible = false;
            picStep1Status.Image = Properties.Resources.step1Wait;
            picStep2Status.Image = Properties.Resources.step2;
            status = false;
            picWarnning.Visible = false;
            inputDetail.BringToFront();
        }
    }
}
