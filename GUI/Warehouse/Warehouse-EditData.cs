using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace GUI.Warehouse
{
    public partial class Warehouse_EditData : Form
    {
        public Warehouse_EditData()
        {
            InitializeComponent();
            MakeDefaultDisplayProperties();
        }

        //  > local global section
        private string selectedTableName = string.Empty;

        private void Update()
        {
            bf_funcUpdate();
            ef_funcUpdate();
        }
        private void MakeDefaultDisplayProperties()
        {
            ef_pnNguyenLieu.Visible = false;
            ef_pnNguyenLieu.Enabled = false;
            ef_pnNhaCungCap.Visible = false;
            ef_pnNhaCungCap.Enabled = false;
            ef_pnHoaDonNhap.Visible = false;
            ef_pnHoaDonNhap.Enabled = false;
            ef_pnChiTietHoaDonNhap.Visible = false;
            ef_pnChiTietHoaDonNhap.Enabled = false;
        }
        //  ^ end

        //  > browseField section
        private void bf_funcUpdate()
        {
            bf_dgvTable.DataSource = SqlHelper.ExecuteReader($"select * from {selectedTableName}", new object[] {});
        }
        private void bf_st_cbbTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTableName = bf_st_cbbTableList.SelectedItem.ToString();
            Update();
        }
            //  > searchbar section
        private void bf_pnSearchbar_funcEnterKeyword()
        {
            bf_sb_lbHint.Visible = false;
            bf_sb_txbSearchbox.Focus();
        }
        private void bf_pnSearchbar_Click(object sender, EventArgs e)
        {
            bf_pnSearchbar_funcEnterKeyword();
        }
        private void bf_sb_lbHint_Click(object sender, EventArgs e)
        {
            bf_pnSearchbar_funcEnterKeyword();
        }
        private void bf_sb_txbSearchbox_Enter(object sender, EventArgs e)
        {
            bf_pnSearchbar_funcEnterKeyword();
        }
        private void bf_sb_txbSearchbox_Leave(object sender, EventArgs e)
        {
            bf_sb_lbHint.Visible = string.IsNullOrEmpty(bf_sb_txbSearchbox.Text);
        }
        //  ^ end
        //  ^ end

        //  > editField section
        private void ef_funcActivateForm(Panel pn)
        {
            pn.Enabled = true;
            pn.Visible = true;
        }
        private void ef_funcUpdate()
        {
            MakeDefaultDisplayProperties();
            switch (selectedTableName)
            {
                case "NguyenLieu": ef_funcActivateForm(ef_pnNguyenLieu); break;
                case "NhaCungCap": ef_funcActivateForm(ef_pnNhaCungCap); break;
                case "HoaDonNhap": ef_funcActivateForm(ef_pnHoaDonNhap); break;
                case "ChiTietHoaDonNhap": ef_funcActivateForm(ef_pnChiTietHoaDonNhap);  break;
                default: break;
            }
        }
        //  ^ end
    }
}
