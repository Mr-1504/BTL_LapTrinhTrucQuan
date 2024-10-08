using static BLL.WarehouseBLL.ServingPrecal;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace GUI.Warehouse
{
    public partial class Warehouse_ServingPrecal : Form
    {
        public Warehouse_ServingPrecal()
        {
            InitializeComponent();
        }

        //  todo: thêm lệnh mở ListAll
        private void pnTabListAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To Warehouse_ListAll");
        }

        private void Warehouse_ServingPrecal_Load(object sender, EventArgs e)
        {
            ml_dgvMenu_DoDisplayConfig();
            ml_dgvMenu_ShowData();
            pc_dgvPrecal_DoDisplayConfig();
        }

        //  >> MenuList section start
        private void ml_dgvMenu_DoDisplayConfig()
        {
            ml_dgvMenu_ShowData();
            foreach (DataGridViewColumn it in ml_dgvMenu.Columns)
            {
                it.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            ml_dgvMenu.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ml_dgvMenu.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
        private void ml_dgvMenu_ShowData()
        {
            ml_dgvMenu.DataSource = BLL_GetMenu();
        }
            //  searchbar section
        private void ml_scb_EnterKeyword()
        {
            ml_scb_lbHint.Visible = false;
            ml_scb_txbSearchbox.Focus();
        }
        private void ml_scb_txbSearchbox_Leave(object sender, EventArgs e)
        {
            ml_scb_lbHint.Visible = string.IsNullOrEmpty(ml_scb_txbSearchbox.Text);
        }

        private void ml_Searchbar_Click(object sender, EventArgs e)
        {
            ml_scb_EnterKeyword();
        }
        private void ml_scb_lbHint_Click(object sender, EventArgs e)
        {
            ml_scb_EnterKeyword();
        }
        private void ml_scb_txbSearchbox_Enter(object sender, EventArgs e)
        {
            ml_scb_EnterKeyword();
        }

        private void ml_scb_txbSearchbox_TextChanged(object sender, EventArgs e)
        {
            BLL_SearchFromMenu(ml_scb_txbSearchbox.Text);
            ml_dgvMenu_ShowData();
        }
        //  ^^ end

        //  >> Menu-Precal interaction section start
        private HashSet<string> selectedDishID = new HashSet<string>();

        private void ml_dgvMenu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedDishID.Add(ml_dgvMenu.CurrentRow.Cells[0].Value.ToString()))
            {
                pc_dgvPrecal.Rows.Add(selectedDishID.Last(), ml_dgvMenu.CurrentRow.Cells[1].Value);
            }
        }


        //  ^^ end

        //  >> Precal section start
        private void pc_dgvPrecal_DoDisplayConfig()
        {
            foreach (DataGridViewColumn it in pc_dgvPrecal.Columns)
            {
                it.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            pc_dgvPrecal.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            pc_dgvPrecal.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
        private void pc_dgvPrecal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDishID.Remove(pc_dgvPrecal.SelectedRows[0].Cells[0].Value.ToString());
            pc_dgvPrecal.Rows.Remove(pc_dgvPrecal.SelectedRows[0]);
        }
        //  ^^ end
    }
}
