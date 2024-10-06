using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.PurchasedIngredient
{
    public partial class InputDetail : UserControl
    {
        List<IngredientDTO> _ingredients;
        public InputDetail()
        {
            InitializeComponent();
        }

        private void InputDetail_Load(object sender, EventArgs e)
        {
            AddSuppliers();
            AddIngredients();
        }

        private void AddSuppliers(string search = "")
        {
            foreach (SupplierDTO supplier in new SupplierBLL().GetSuppliers(search))
            {
                cmbSupplierName.Items.Add(supplier.SupplierName);
            }

        }

        private void AddIngredients(string search = "")
        {
            _ingredients = new IngredientBLL().GetIngredients();
            foreach (IngredientDTO ingredient in _ingredients)
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
            int index = cmbIngredientName.SelectedIndex;
            if (index >= 0)
                txtUnit.Text = _ingredients[index].IngredientUnit.ToString();
        }

        private void txtPriceUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                txtQuantity.Focus();
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

        private void cmbSupplierName_Leave(object sender, EventArgs e)
        {
            if (cmbSupplierName.Text == "")
            {
                AddSuppliers();
            }
            cmbSupplierName.DroppedDown = false;
        }

        private void cmbSupplierName_TextUpdate(object sender, EventArgs e)
        {
            string s = cmbSupplierName.Text;
            int cursorPosition = cmbSupplierName.SelectionStart;

            cmbSupplierName.SelectedIndexChanged -= cmbSupplierName_SelectedIndexChanged;

            cmbSupplierName.Items.Clear();
            AddSuppliers(s); 

            cmbSupplierName.SelectedIndex = -1;
            cmbSupplierName.DroppedDown = true;

            cmbSupplierName.Text = s;
            cmbSupplierName.SelectionStart = cursorPosition;
            cmbSupplierName.SelectionLength = 0;


            cmbSupplierName.SelectedIndexChanged += cmbSupplierName_SelectedIndexChanged;

        }

        private void cmbIngredientName_TextUpdate(object sender, EventArgs e)
        {
            string s = cmbIngredientName.Text;
            int cursorPosition = cmbIngredientName.SelectionStart;

            cmbIngredientName.SelectedIndexChanged -= cmbIngredientName_SelectedIndexChanged;

            cmbIngredientName.Items.Clear();
            AddIngredients(s);

            cmbIngredientName.SelectedIndex = -1;
            cmbIngredientName.DroppedDown = true;

            cmbIngredientName.Text = s;
            cmbIngredientName.SelectionStart = cursorPosition;
            cmbSupplierName.SelectionLength = 0;

            cmbIngredientName.SelectedIndexChanged += cmbIngredientName_SelectedIndexChanged;
        }
    }
}
