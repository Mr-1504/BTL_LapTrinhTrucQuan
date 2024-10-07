using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        //  >> MenuList section start
        //  ^^ MenuList section end

        //  >> Precal section start
        //  ^^ Precal section end
    }
}
