using System;
using System.Windows.Forms;
using static BLL.WarehouseBLL.EditData;
using Utilities;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Collections.Generic;

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
            bf_dgvTable.DataSource = BLL_GetTable(selectedTableName);
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
        private void bf_sb_txbSearchbox_TextChanged(object sender, EventArgs e)
        {
            BLL_SearchInTable(bf_sb_txbSearchbox.Text);
            bf_funcUpdate();
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

        //  > the event on BF that causes smt to EF section
        private void bf_dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ef_funcSelectingRow(bf_dgvTable.SelectedRows[0]);
        }
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
            ef_funcFieldTextReset();
            ef_funcVisualReset();
            switch (selectedTableName)
            {
                case "NguyenLieu": ef_funcActivateForm(ef_pnNguyenLieu); break;
                case "NhaCungCap": ef_funcActivateForm(ef_pnNhaCungCap); break;
                case "HoaDonNhap": ef_funcActivateForm(ef_pnHoaDonNhap); break;
                case "ChiTietHoaDonNhap": ef_funcActivateForm(ef_pnChiTietHoaDonNhap);  break;
                default: break;
            }
        }
        //  part to control panel's text/graphics
        private Panel ef_funcGetCurrentActiveForm()
        {
            switch (selectedTableName)
            {
                case "NguyenLieu": return ef_pnNguyenLieu;
                case "NhaCungCap": return ef_pnNhaCungCap;
                case "HoaDonNhap": return ef_pnHoaDonNhap;
                case "ChiTietHoaDonNhap": return ef_pnChiTietHoaDonNhap;
                default: return null;
            }
        }
        private void ef_evtFieldValueChange(object sender, EventArgs e) // when EF field have its value changed
        {
            ef_funcVisualizeFieldValueChange(sender);
            ef_funcInformantUpdate();
        }
            //  > text-driven start
        private void ef_funcSelectingRow(DataGridViewRow selectedRow)
        {
            switch (selectedTableName)
            {
                case "NguyenLieu":
                    ef_NL_lbMa.Text = selectedRow.Cells[0].Value.ToString();
                    ef_NL_txbTen.Text = selectedRow.Cells[1].Value.ToString();
                    ef_NL_txbDVT.Text = selectedRow.Cells[2].Value.ToString();
                    ef_NL_rtbCD.Text = selectedRow.Cells[3].Value.ToString();
                    ef_NL_rtbYC.Text = selectedRow.Cells[4].Value.ToString();
                    ef_NL_rtbCCD.Text = selectedRow.Cells[5].Value.ToString();
                    ef_NL_txbSL.Text = selectedRow.Cells[6].Value.ToString();
                    break;
                case "NhaCungCap":
                    ef_NCC_lbMa.Text = selectedRow.Cells[0].Value.ToString();
                    ef_NCC_txbTen.Text = selectedRow.Cells[1].Value.ToString();
                    ef_NCC_txbDC.Text = selectedRow.Cells[2].Value.ToString();
                    ef_NCC_txbDT.Text = selectedRow.Cells[3].Value.ToString();
                    if ((int)selectedRow.Cells[4].Value == 1) ef_NCC_rdbActive.Checked = true; else ef_NCC_rdbDeactive.Checked = true;
                    break;
                case "HoaDonNhap":
                    ef_HDN_lbMaHD.Text = selectedRow.Cells[0].Value.ToString();
                    ef_HDN_txbMaNV.Text = selectedRow.Cells[1].Value.ToString();
                    ef_HDN_txbMaNCC.Text = selectedRow.Cells[2].Value.ToString();
                    ef_HDN_dtpNgayNhap.Value = (DateTime)selectedRow.Cells[3].Value;
                    ef_HDN_lbInformantNV.Text = BLL_InformantCheck(ef_HDN_txbMaNV.Text, IFM_NHANVIEN);
                    ef_HDN_lbInformantNCC.Text = BLL_InformantCheck(ef_HDN_txbMaNCC.Text, IFM_NHACUNGCAP);
                    break;
                case "ChiTietHoaDonNhap":
                    ef_CTHDN_txbMaHDN.Text = selectedRow.Cells[0].Value.ToString();
                    ef_CTHDN_txbMaNL.Text = selectedRow.Cells[1].Value.ToString();
                    ef_CTHDN_txbSLN.Text = selectedRow.Cells[2].Value.ToString();
                    ef_CTHDN_txbDG.Text = selectedRow.Cells[3].Value.ToString();
                    ef_CTHDN_lbInformantNL.Text = BLL_InformantCheck(ef_CTHDN_txbMaNL.Text, IFM_NGUYENLIEU);
                    ef_CTHDN_lbInformantDV.Text = BLL_InformantCheck(ef_CTHDN_txbMaNL.Text, IFM_DONVI);
                    ef_CTHDN_lbInformantNN.Text = BLL_InformantCheck(ef_CTHDN_txbMaHDN.Text, IFM_NGAYNHAP);
                    break;
            }
            ef_funcVisualReset();
        }
            // informant section (tf so dumb, optimize code if needed)
        private void ef_funcInformantUpdate() // update informant value on panel
        {
            switch (selectedTableName)
            {
                case "HoaDonNhap": 
                    ef_HDN_lbInformantNV.Text = BLL_InformantCheck(ef_HDN_txbMaNV.Text, IFM_NHANVIEN);
                    ef_HDN_lbInformantNCC.Text = BLL_InformantCheck(ef_HDN_txbMaNCC.Text, IFM_NHACUNGCAP); 
                    break;
                case "ChiTietHoaDonNhap": 
                    ef_CTHDN_lbInformantNL.Text = BLL_InformantCheck(ef_CTHDN_txbMaNL.Text, IFM_NGUYENLIEU);
                    ef_CTHDN_lbInformantDV.Text = BLL_InformantCheck(ef_CTHDN_txbMaNL.Text, IFM_DONVI);
                    ef_CTHDN_lbInformantNN.Text = BLL_InformantCheck(ef_CTHDN_txbMaHDN.Text, IFM_NGAYNHAP);
                    break;
            }
        }
            //  > visual-driven start
        private void ef_funcVisualizeFieldValueChange(object changedField)
        {
            Panel parentPn = ((Control)changedField).Parent as Panel;
            if (parentPn.BackgroundImage.Height == 80)
                parentPn.BackgroundImage = Properties.Resources.field_multi_valuechanged_420x80;
            else
                parentPn.BackgroundImage = Properties.Resources.field_single_valuechanged_420x40;
        }
        private void ef_funcVisualReset()
        {
            foreach (Control ctr in ef_funcGetCurrentActiveForm().Controls)
            {
                if (ctr is Panel && ctr.Tag == null)
                {
                    if (ctr.BackgroundImage.Height < 80)
                        ctr.BackgroundImage = Properties.Resources.field_single_editable_420x40;
                    else
                        ctr.BackgroundImage = Properties.Resources.field_multi_editable_420x80;
                }
            }
        }
        //  > button pushed section
        private void ef_funcFieldTextReset()
        {
            switch (selectedTableName)
            {
                case "NguyenLieu":
                    ef_NL_lbMa.Text = string.Empty;
                    ef_NL_txbTen.Text = string.Empty;
                    ef_NL_txbDVT.Text = string.Empty;
                    ef_NL_rtbCD.Text = string.Empty;
                    ef_NL_rtbYC.Text = string.Empty;
                    ef_NL_rtbCCD.Text = string.Empty;
                    ef_NL_txbSL.Text = string.Empty;
                    break;
                case "NhaCungCap":
                    ef_NCC_lbMa.Text = string.Empty;
                    ef_NCC_txbTen.Text = string.Empty;
                    ef_NCC_txbDC.Text = string.Empty;
                    ef_NCC_txbDT.Text = string.Empty;
                    ef_NCC_rdbActive.Checked = false;
                    ef_NCC_rdbDeactive.Checked = false;
                    break;
                case "HoaDonNhap":
                    ef_HDN_lbMaHD.Text = string.Empty;
                    ef_HDN_txbMaNV.Text = string.Empty;
                    ef_HDN_txbMaNCC.Text = string.Empty;
                    ef_HDN_dtpNgayNhap.Value = DateTime.Parse("1-1-1900");
                    ef_HDN_lbInformantNV.Text = string.Empty;
                    ef_HDN_lbInformantNCC.Text = string.Empty;
                    break;
                case "ChiTietHoaDonNhap":
                    ef_CTHDN_txbMaHDN.Text = string.Empty;
                    ef_CTHDN_txbMaNL.Text = string.Empty;
                    ef_CTHDN_txbSLN.Text = string.Empty;
                    ef_CTHDN_txbDG.Text = string.Empty;
                    ef_CTHDN_lbInformantDV.Text = string.Empty;
                    ef_CTHDN_lbInformantNL.Text = string.Empty;
                    ef_CTHDN_lbInformantNN.Text = string.Empty;
                    break;
            }
        }
        private void ef_btnReset_Click(object sender, EventArgs e)
        {
            ef_funcFieldTextReset();
            ef_funcVisualReset();
        }

        //  ^ end


        //  ^ end
    }
}
