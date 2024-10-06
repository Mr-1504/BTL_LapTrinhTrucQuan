using static BLL.WarehouseBLL.ListAll;
using System;
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

        //  >> table operation section start
        private void dgvTable_PreparingForDisplay()
        {
            dgvTable_ShowData();
            foreach (DataGridViewColumn it in dgvTable.Columns)
            {
                it.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
        private void dgvTable_ShowData()
        {
            dgvTable.DataSource = BLL_GetTable();
        }
        private void dgvTable_SearchInColumn(string colName, string keyword)
        {
            dgvTable.DataSource = BLL_SearchKeywordInColumn(colName, keyword);
        }
        private void dgvTable_SelectionChanged(object sender, EventArgs e)
        {
            selectedCell = dgvTable.CurrentCell;
            if (selectedCell != null) lsb_lbHint_DisplayCurrentActiveColumn();
        }
        //  ^^ table operation section end

        //  >> column ordering's section start
        private void odr_btnSortUpDown_Click(object sender, EventArgs e)
        {
            if (odr_btnSortUpDown.Tag.ToString() == "doDecend")
            {
                odr_btnSortUpDown.BackgroundImage = GUI.Properties.Resources.sortBigger;
                odr_btnSortUpDown.Tag = "doAscend";
            }
            else if (odr_btnSortUpDown.Tag.ToString() == "doAscend")
            {
                odr_btnSortUpDown.BackgroundImage = GUI.Properties.Resources.sortSmaller;
                odr_btnSortUpDown.Tag = "doDecend";
            }
        }
        //  ^^ column ordering's section end

        //  >> column search's section start
        private DataGridViewCell selectedCell = null;
            //  chưa có BLL để tìm kiếm (không cấp bách)
        private void lsb_func_EnterKeyword()
        {
            lsb_lbHint.Text = string.Empty;
            lsb_txbSearchbox.Focus();
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
        }
        private void lsb_txbSearchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ;
        }
        private void lsb_lbHint_DisplayCurrentActiveColumn()
        {
            lsb_lbHint.Visible = string.IsNullOrEmpty(lsb_txbSearchbox.Text);
            lsb_lbHint.Text = "Tìm kiếm " + dgvTable.Columns[selectedCell.ColumnIndex].Name;
        }
        //  ^^ column search's section end

            //  todo: thêm lệnh mở ServingPrecal
        private void pnTabDishCal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Warehouse_ServingPrecal");
        }
    }
}
