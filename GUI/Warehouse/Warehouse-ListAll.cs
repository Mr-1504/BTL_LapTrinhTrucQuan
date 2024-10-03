using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class Warehouse_ListAll : Form
    {
        public Warehouse_ListAll()
        {
            InitializeComponent();
        }

        private void Warehouse_ListAll_Load(object sender, EventArgs e)
        {
            dgvTable_PreparingForDisplay();
        }

        private void dgvTable_PreparingForDisplay()
        {
            dgvTable_ShowDefault();
            //dgvTable.DataSource = SqlHelper.ExecuteReader("select MaNguyenLieu N'Mã nguyên liệu', TenNguyenLieu N'Tên nguyên liệu', DonViTinh N'Đơn vị tính', Soluong N'Số lượng' from NguyenLieu", new object[] { });
            foreach (DataGridViewColumn it in dgvTable.Columns)
            {
                it.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            //dgvTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvTable.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvTable_ShowDefault()
        {
            dgvTable.DataSource = SqlHelper.ExecuteReader("select MaNguyenLieu, TenNguyenLieu, DonViTinh, Soluong from NguyenLieu", new object[] { });
        }

        private void dgvTable_SearchInColumn(string colName, string keyword)
        {
            dgvTable.DataSource = SqlHelper.ExecuteReader($"select MaNguyenLieu, TenNguyenLieu, DonViTinh, Soluong from NguyenLieu where {colName} like N'%{keyword}%'", new object[] { });
        }

        private void odr_btnSortUpDown_Click(object sender, EventArgs e)
        {
            if (odr_btnSortUpDown.Tag.ToString() == "nowSortBigger")
            {
                odr_btnSortUpDown.BackgroundImage = GUI.Properties.Resources.sortBigger;
                odr_btnSortUpDown.Tag = "nowSortSmaller";
            }
            else if (odr_btnSortUpDown.Tag.ToString() == "nowSortSmaller")
            {
                odr_btnSortUpDown.BackgroundImage = GUI.Properties.Resources.sortSmaller;
                odr_btnSortUpDown.Tag = "nowSortBigger";
            }
        }

        private DataGridViewCell selectedCell = null;

        private void lsb_func_Searching()
        {
            if (!string.IsNullOrEmpty(lsb_txbSearchbox.Text))
            {
                string colName = dgvTable.Columns[selectedCell.ColumnIndex].Name;
                string keyword = lsb_txbSearchbox.Text;
                dgvTable_SearchInColumn(colName, keyword);
            }
            else
            {
                dgvTable_ShowDefault();
            }
        }

        private void lsb_func_EnterKeyword()
        {
            lsb_lbHint.Text = string.Empty;
            lsb_txbSearchbox.Focus();
        }

        private void lsb_func_Reset()
        {
            lsb_txbSearchbox.Text = string.Empty;
        }

        private void pnLocalSearchBar_Click(object sender, EventArgs e)
        {
            lsb_func_EnterKeyword();
        }

        private void lsb_lbHint_Click(object sender, EventArgs e)
        {
            lsb_func_EnterKeyword();
        }

        private void lsb_txbSearchbox_Enter(object sender, EventArgs e)
        {
            lsb_lbHint.Text = string.Empty;
        }

        private void lsb_txbSearchbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lsb_txbSearchbox.Text)) lsb_lbHint_DisplayCurrentActiveColumn();
            else lsb_func_Searching();
        }

        private void lsb_txbSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) lsb_func_Searching();
        }

        private void lsb_lbHint_DisplayCurrentActiveColumn()
        {
            lsb_lbHint.Visible = string.IsNullOrEmpty(lsb_txbSearchbox.Text);
            lsb_lbHint.Text = "Tìm kiếm " + dgvTable.Columns[selectedCell.ColumnIndex].Name;
        }

        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            selectedCell = dgvTable.CurrentCell;
            if (selectedCell != null) lsb_lbHint_DisplayCurrentActiveColumn();
        }
    }
}
