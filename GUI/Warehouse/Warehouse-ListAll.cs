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
            dgvTable.DataSource = SqlHelper.ExecuteReader("select * from NguyenLieu", new object[] { });
            foreach (DataGridViewColumn it in dgvTable.Columns)
            {
                it.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void pnLocalSearchBar_Click(object sender, EventArgs e)
        {
            lsb_txbSearchbox.Focus();
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

        private void lsb_txbSearchbox_EnterFocus(object sender, EventArgs e)
        {
            if (lsb_txbSearchbox.Text.Equals("Tìm kiếm"))
            {
                lsb_txbSearchbox.Text = string.Empty;

            }
        }

        private void lsb_txbSearchbox_LeaveFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lsb_txbSearchbox.Text))
            {
                lsb_txbSearchbox.Text = "Tìm kiếm";
            }
        }
    }
}
