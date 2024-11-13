using static BLL.WarehouseBLL.IngrInfo;
using System;
using System.Windows.Forms;
using System.Data;

namespace GUI.Warehouse
{
    public partial class Warehouse_IngredientDetails : Form
    {
        private Warehouse_ListAll _listAll;

        public Warehouse_IngredientDetails(Warehouse_ListAll listAll)
        {
            InitializeComponent();
            _listAll = listAll;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            _listAll.BringPanelToFront();
        }

        public void loadInformation(string maNL)
        {
            DataTable ingrInfo = BLL_GetIngrInfo(maNL);
            lbTen.Text = ingrInfo.Rows[0][1].ToString();
            lbDonVi.Text = ingrInfo.Rows[0][2].ToString();
            lbSoLuong.Text = ingrInfo.Rows[0][6].ToString();
            rtbCongDung.Text = ingrInfo.Rows[0][3].ToString();
            rtbYeuCau.Text = ingrInfo.Rows[0][4].ToString();
            rtbChongChiDinh.Text = ingrInfo.Rows[0][5].ToString();
        }
    }
}
