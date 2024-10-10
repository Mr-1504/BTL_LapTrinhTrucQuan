using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI.PurchasedIngredient
{
    public partial class InputDetail : UserControl
    {
        private Timer debounceTimerSupplier;
        private Timer debounceTimerIngredient;
        private List<IngredientDTO> _ingredients;
        private List<SupplierDTO> _suppliers;
        private List<PurchaseInvoiceDetailDTO> _invoiceDetail;
        private SupplierDTO _supplier;
        private string _id;
        private DataTable _ingradientData;
        private DataTable _supplierData;
        private decimal _total;
        private bool _isEditting = false;
        public decimal Total { get => _total; }
        private int _selectedIndex;
        public InputDetail(string employeeId)
        {
            InitializeComponent();
            _invoiceDetail = new List<PurchaseInvoiceDetailDTO>();
            _supplier = null;
            _id = employeeId;
            _ingradientData = new DataTable();
            _ingradientData.Columns.Add("colName");
            _ingradientData.Columns.Add("colUnit");
            _ingradientData.Columns.Add("colPriceUnit");
            _ingradientData.Columns.Add("colQuantity");
            dgvList.DataSource = _ingradientData;
            _total = 0;
            _selectedIndex = -1;

            foreach (Control control in dgvList.Controls)
            {
                if (control is Button)
                {
                    control.Click += (s, e) => { ActiveControl = lblDataName; };
                }
            }
        }

        private async void InputDetail_Load(object sender, EventArgs e)
        {
            await Task.Run(() => LoadData());

        }

        private void AddSuppliers(string search = "")
        {
            _suppliers = new SupplierBLL().GetSuppliers(search);
            foreach (SupplierDTO supplier in _suppliers)
            {
                cmbSupplierName.Items.Add(supplier.SupplierName);
            }

        }
        private void LoadData()
        {
            if (cmbSupplierName.InvokeRequired)
            {
                cmbSupplierName.Invoke(new Action(() =>
                {
                    AddSuppliers();
                    AddIngredients();
                }));
            }
            else
            {
                AddSuppliers();
                AddIngredients();
            }
        }
        private void AddIngredients(string search = "")
        {
            _ingredients = new IngredientBLL().GetIngredients(search);
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
                txtUnit.Text = _ingredients[index].IngredientUnit.GetEnumDescription();
        }

        private void txtPriceUnit_KeyDown(object sender, KeyEventArgs e)
        {
            string s = txtPriceUnit.Text;
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
                btnConfirm_Click(sender, e);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbIngredientName.SelectedIndex = -1;
            AddIngredients();
            cmbIngredientName.Text = "";
            txtPriceUnit.Text = "";
            txtUnit.Text = "";
            txtQuantity.Text = "";
            lblError.Visible = false;
            if (_isEditting)
            {
                _isEditting = false;
                btnReset.Text = "Đặt lại";
            }
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
            if (debounceTimerSupplier != null)
            {
                debounceTimerSupplier.Stop();
            }
            else
            {
                debounceTimerSupplier = new Timer();
                debounceTimerSupplier.Interval = 300;
                debounceTimerSupplier.Tick += (s, args) =>
                {
                    debounceTimerSupplier.Stop();
                    UpdateSupplier();
                };
            }

            debounceTimerSupplier.Start();
        }

        private void cmbIngredientName_TextUpdate(object sender, EventArgs e)
        {
            if (debounceTimerIngredient != null)
            {
                debounceTimerIngredient.Stop();
            }
            else
            {
                debounceTimerIngredient = new Timer();
                debounceTimerIngredient.Interval = 300;
                debounceTimerIngredient.Tick += (s, args) =>
                {
                    debounceTimerIngredient.Stop();
                    UpdateIngredient();
                };
            }

            debounceTimerIngredient.Start();
        }

        private void UpdateSupplier()
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

        private void UpdateIngredient()
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

            if (cmbIngredientName.Text == "")
            {
                txtUnit.Text = "";
            }
            else if (cmbIngredientName.Items.Count > 0 && cmbIngredientName.Text == cmbIngredientName.Items[0].ToString())
            {
                txtUnit.Text = _ingredients[0].IngredientUnit.GetEnumDescription();
            }
        }

        private void cmbIngredientName_Leave(object sender, EventArgs e)
        {
            if (cmbIngredientName.Text == "")
            {
                AddIngredients();
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int priceUnit = 0;
            decimal quantity = 0;
            if (new SupplierBLL().IsExist(cmbSupplierName.Text) < 1)
            {
                lblError.Text = "Nhà cung cấp không hợp lệ";
                lblError.Visible = true;
                return;
            }
            else if (_supplier != null && _supplier.SupplierName != cmbSupplierName.Text)
            {
                lblError.Text = "Chỉ nhập từ 1 nhà cung cấp";
                lblError.Visible = true;
                return;
            }
            else
            {
                _supplier = new SupplierBLL().GetSupplierByName(cmbSupplierName.Text);
            }
            if (new IngredientBLL().IsExistIngredientName(cmbIngredientName.Text) < 1)
            {
                lblError.Text = "Nguyên liệu không hợp lệ" + cmbIngredientName.Text;
                lblError.Visible = true;
                return;
            }
            if (txtPriceUnit.Text == "")
            {
                lblError.Text = "Nhập đơn giá!";
                lblError.Visible = true;
                return;
            }
            else
            {
                try
                {
                    priceUnit = int.Parse(txtPriceUnit.Text);
                    if (priceUnit < 0)
                    {
                        lblError.Text = "Đơn giá không hợp lệ";
                        lblError.Visible = true;
                        return;
                    }
                }
                catch (FormatException)
                {
                    lblError.Text = "Đơn giá không đúng định dạng";
                    lblError.Visible = true;
                    return;
                }
            }
            if (txtQuantity.Text == "")
            {
                lblError.Text = "Nhập số lượng!";
                lblError.Visible = true;
                return;
            }
            else
            {
                try
                {
                    quantity = decimal.Parse(txtQuantity.Text);
                    if (quantity < 0)
                    {
                        lblError.Text = "Số lượng không hợp lệ";
                        lblError.Visible = true;
                        return;
                    }
                }
                catch (FormatException)
                {
                    lblError.Text = "Số lượng không đúng định dạng";
                    lblError.Visible = true;
                    return;
                }
            }
            AddData(priceUnit, quantity);
            btnReset_Click(sender, e);
        }
        private void AddData(int priceUnit, decimal quantity)
        {
            _total += priceUnit * quantity;
            List<IngredientDTO> res = new IngredientBLL().GetIngredient(Ingredient.IngredientName, cmbIngredientName.Text);
            txtUnit.Text = res[0].IngredientUnit.GetEnumDescription();
            lblError.Visible = false;
            if (_isEditting)
            {
                _ingradientData.Rows[_selectedIndex][0] = "  " + cmbIngredientName.Text;
                _ingradientData.Rows[_selectedIndex][1] = "  " + txtUnit.Text;
                _ingradientData.Rows[_selectedIndex][2] = "  " + priceUnit;
                _ingradientData.Rows[_selectedIndex][3] = "  " + quantity;
                _isEditting = false;
                return;
            }
            

            for (int i = 0; i < dgvList.Rows.Count; i++)
            {
                Console.WriteLine(dgvList.Rows[i].Cells[1].Value.ToString() + "  " + txtUnit.Text);
                if (dgvList.Rows[i].Cells[0].Value.ToString() == cmbIngredientName.Text)
                {
                    MessageBox.Show("ten");
                }
                if (dgvList.Rows[i].Cells[1].Value.ToString() == txtUnit.Text)
                {
                    MessageBox.Show("donvi");
                }
                if (dgvList.Rows[i].Cells[0].Value.ToString().Trim() == cmbIngredientName.Text.Trim()
                    && dgvList.Rows[i].Cells[1].Value.ToString().Trim() == txtUnit.Text.Trim()
                    && int.Parse(dgvList.Rows[i].Cells[2].Value.ToString()) == priceUnit)
                {
                    _ingradientData.Rows[i][3] = "  " + (int.Parse(dgvList.Rows[i].Cells[3].Value.ToString()) + quantity).ToString();
                    return;
                }
            }
            _ingradientData.Rows.Add("  " + cmbIngredientName.Text, "  " + txtUnit.Text, "  " + priceUnit, "  " + quantity);
            _invoiceDetail.Add(new PurchaseInvoiceDetailDTO(res[0].IngredientId, quantity, priceUnit));
        }

        public bool IsCorrect()
        {
            return _supplier != null && dgvList.Rows.Count > 0;
        }
        public PurchaseInvoiceDTO GetInvoice()
        {
            return new PurchaseInvoiceDTO(_id, _supplier.SupplierId, DateTime.Now);
        }
        public List<PurchaseInvoiceDetailDTO> GetInvoiceDetail()
        {
            return _invoiceDetail;
        }
        public DataGridView GetData()
        {
            return dgvList;
        }

        private void cmbIngredientName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
            }
        }

        private void txtPriceUnit_Enter(object sender, EventArgs e)
        {
            List<IngredientDTO> res = new IngredientBLL().GetIngredient(Ingredient.IngredientName, cmbIngredientName.Text);
            if (cmbIngredientName.Text != "" && res.Count > 0)
            {
                txtUnit.Text = res[0].IngredientUnit.GetEnumDescription();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (_selectedIndex > -1)
            {
                DataRow row = _ingradientData.Rows[_selectedIndex];
                cmbIngredientName.Text = row[0].ToString().Substring(2);
                txtUnit.Text = row[1].ToString().Substring(2);
                txtPriceUnit.Text = row[2].ToString().Substring(2);
                txtQuantity.Text = row[3].ToString().Substring(2);

                btnReset.Text = "Hủy";
                btnConfirm.Text = "OK";
                _isEditting = true;
            }
        }

        private void dgvList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvList.Rows.Count > 0)
                {
                    var hitTestInfo = dgvList.HitTest(e.X, e.Y);

                    if (hitTestInfo.RowIndex >= 0)
                    {
                        dgvList.ClearSelection();
                        dgvList.Rows[hitTestInfo.RowIndex].Selected = true;
                        _selectedIndex = hitTestInfo.RowIndex;
                    }
                    else
                    {
                        _selectedIndex = -1;
                    }
                }
                else
                {
                    dgvList.ContextMenuStrip = null;
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count == 0)
            {
                return;
            }
            DialogResult dialogResult = new MessageForm("Xác nhận xóa?", "Thông báo", 2).DialogResult;
            if (dialogResult == DialogResult.Yes)
            {
                _ingradientData.Rows.RemoveAt(_selectedIndex);
                _selectedIndex = -1;
            }
        }
    }
}
