using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EmployManager : Form
    {
        public EmployManager()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;  // Không cho phép chỉnh sửa
            //Chinh hang tieu de
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersHeight = 50;
            // Khóa không cho phép kéo dãn cột
            dataGridView1.AllowUserToResizeColumns = false;

            // Khóa không cho phép kéo dãn hàng
            dataGridView1.AllowUserToResizeRows = false;

        }

        private void dataGridView1_ColumnHeaderCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void EmployManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
