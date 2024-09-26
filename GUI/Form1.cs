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

            int res = new Class1().IsExist("QL0001");
            MessageBox.Show(res.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //if (res == 1)
            //{
            //    MessageBox.Show("Thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (res == 0)
            //{
            //    MessageBox.Show("k", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}else
            //{
            //    MessageBox.Show("loi" + res.ToString(), "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Class1().GetData();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
