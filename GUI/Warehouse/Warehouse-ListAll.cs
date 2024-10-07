﻿using static BLL.WarehouseBLL.ListAll;
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
            lsb_Update();
            odb_Update();
        }

        //  >> table operation section start
        private string selectedColumnName = string.Empty;
        private void dgvTable_PreparingForDisplay()
        {
            dgvTable_ShowData();
            foreach (DataGridViewColumn it in dgvTable.Columns)
            {
                it.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvTable.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvTable.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            lsb_HintDisplay();
        }
        private void dgvTable_ShowData()
        {
            dgvTable.DataSource = BLL_GetTable();
        }
        private void dgvTable_SearchInColumn(string colName, string keyword)
        {
            dgvTable.DataSource = BLL_SearchKeywordInColumn(colName, keyword);
        }
        private void dgvTable_MouseClick(object sender, MouseEventArgs e)
        {
            selectedColumnName = dgvTable.SelectedCells.Count > 0 ? dgvTable.Columns[dgvTable.SelectedCells[0].ColumnIndex].Name : string.Empty;
            lsb_Update();
            odb_Update();
        }
        //  ^^ table operation section end

        //  >> column ordering's section start
        private void odb_Update()
        {
            odb_HintDisplay();
            odb_btnSortUpDown.Enabled = !string.IsNullOrEmpty(selectedColumnName);
        }
        private void odb_HintDisplay()
        {
            orb_lbHint.Text = "Sắp xếp " + selectedColumnName;
        }
        private void odb_btnSortUpDown_Click(object sender, EventArgs e)
        {
            if (odb_btnSortUpDown.Tag.ToString() == "doDecend")
            {
                BLL_OrderByColumn(selectedColumnName, false);
                odb_btnSortUpDown.BackgroundImage = GUI.Properties.Resources.sortBigger;
                odb_btnSortUpDown.Tag = "doAscend";
            }
            else if (odb_btnSortUpDown.Tag.ToString() == "doAscend")
            {
                BLL_OrderByColumn(selectedColumnName, true);
                odb_btnSortUpDown.BackgroundImage = GUI.Properties.Resources.sortSmaller;
                odb_btnSortUpDown.Tag = "doDecend";
            }
            dgvTable_ShowData();
        }
        //  ^^ column ordering's section end

        //  >> column search's section start
        private void lsb_Update()
        {
            lsb_HintDisplay();
        }
        private void lsb_HintDisplay()
        {
            lsb_lbHint.Visible = string.IsNullOrEmpty(lsb_txbSearchbox.Text);
            lsb_lbHint.Text = "Tìm kiếm " + selectedColumnName;
        }
        private void lsb_func_EnterKeyword()
        {
            lsb_lbHint.Visible = false;
            lsb_txbSearchbox.Focus();
        }
        private void lsb_txbSearchbox_TextChanged(object sender, EventArgs e)
        {
            BLL_SearchKeywordInColumn(selectedColumnName, lsb_txbSearchbox.Text);
            dgvTable_ShowData();
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
            lsb_func_EnterKeyword();
        }
        private void lsb_txbSearchbox_Leave(object sender, EventArgs e)
        {
            lsb_HintDisplay();
        }
        //  ^^ column search's section end

            //  todo: thêm lệnh mở ServingPrecal
        private void pnTabDishCal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Warehouse_ServingPrecal");
        }
    }
}
