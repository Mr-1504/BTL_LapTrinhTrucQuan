using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Utilities;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(SqlHelper.GetConnectionString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int res = new Class1().IsExist("QL0001");
            if (res == 1)
            {
                MessageBox.Show("Thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (res == 0)
            {
                MessageBox.Show("k", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                MessageBox.Show("loi" + res.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
