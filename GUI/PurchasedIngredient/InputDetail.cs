using BLL;
using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.PurchasedIngredient
{
    public partial class InputDetail : UserControl
    {
        bool _res;
        public InputDetail()
        {
            InitializeComponent();
            _res = true;
        }

        private void InputDetail_Load(object sender, EventArgs e)
        {
            AddSuppliers();
            AddIngredients();
        }

        private void AddSuppliers(string search = "")
        {
            _res = false;
            foreach (SupplierDTO supplier in new SupplierBLL().GetSuppliers(search))
            {
                cmbSupplierName.Items.Add(supplier.SupplierName);
                _res = true;
            }
        }

        private void AddIngredients()
        {

            foreach (IngredientDTO ingredient in new IngredientBLL().GetIngredients())
            {
                cmbIngredientName.Items.Add(ingredient.IngredientName);
            }
        }
        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIngredient.Focus();
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

        private void cmbIngredientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIngredient.Focus();
        }

        private void txtPriceUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbIngredientName.SelectedIndex = -1;
            cmbSupplierName.SelectedIndex = -1;
            txtPriceUnit.Text = "";
            txtUnit.Text = "";

        }

        private void dgvList_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(Properties.Resources.ListIngrdient, dgvList.ClientRectangle);
        }

        private void cmbSupplierName_TextChanged(object sender, EventArgs e)
        {
            cmbSupplierName.Items.Clear();
            if (cmbSupplierName.Text == "")
            {
                AddSuppliers();
                cmbSupplierName.DroppedDown = false;
            }
            else
            {
                string s = cmbSupplierName.Text;
                AddSuppliers(cmbSupplierName.Text);
                cmbSupplierName.DroppedDown = _res;
                cmbSupplierName.Text = s;
                cmbSupplierName.SelectionStart = cmbSupplierName.Text.Length;
            }
        }
    }
}
