using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class InputDetail : UserControl
    {
        public InputDetail()
        {
            InitializeComponent();
        }

        private void InputDetail_Load(object sender, EventArgs e)
        {
            AddSuppliers();
        }

        private void AddSuppliers()
        {
            foreach (SupplierDTO supplier in new SupplierBLL().GetSuppliers())
            {
                cmbSupplierName.Items.Add(supplier.SupplierName);
            }
        }

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackgroundImage = Properties.Resources.bgResetInputHover;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackgroundImage = Properties.Resources.bgResetInput;
        }

        private void btnConfirm_MouseEnter(object sender, EventArgs e)
        {
            btnConfirm.BackgroundImage = Properties.Resources.btnConfirmInputHover;
        }

        private void btnConfirm_MouseLeave(object sender, EventArgs e)
        {
            btnConfirm.BackgroundImage = Properties.Resources.btnConfirmInput;
        }
    }
}
