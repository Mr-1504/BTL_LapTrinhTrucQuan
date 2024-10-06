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
using BLL;


namespace GUI
{
    public partial class EmployManager : Form
    {
        EmployManagerBLL employ = new EmployManagerBLL();

        public EmployManager()
        {
            InitializeComponent();
            dataEmployerMNG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataEmployerMNG.ReadOnly = true;  // Không cho phép chỉnh sửa
            //Chinh hang tieu de
            dataEmployerMNG.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataEmployerMNG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataEmployerMNG.EnableHeadersVisualStyles = false;
            dataEmployerMNG.ColumnHeadersHeight = 50;
            dataEmployerMNG.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)DataGridViewCellBorderStyle.None;
            // Khóa không cho phép kéo dãn cột
            dataEmployerMNG.AllowUserToResizeColumns = false;
            dataEmployerMNG.AutoGenerateColumns = false;


            // Khóa không cho phép kéo dãn hàng
            dataEmployerMNG.AllowUserToResizeRows = false;

            
            // Gán DataPropertyName để ánh xạ với tên cột trong cơ sở dữ liệu
            dataEmployerMNG.Columns["EmployeeID"].DataPropertyName = "MaNhanVien";
            dataEmployerMNG.Columns["EmployeeName"].DataPropertyName = "TenNhanVien";
            dataEmployerMNG.Columns["NumberPhone"].DataPropertyName = "DienThoai";
            dataEmployerMNG.Columns["Address"].DataPropertyName = "DiaChi";
            dataEmployerMNG.DataSource = employ.GetEmployees();
            pnlEmployMNG.Focus();
        }

        private void dataGridView1_ColumnHeaderCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
             
        }


        private void EmployManager_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, dataEmployerMNG.Width - 1, dataEmployerMNG.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel1.Region = new Region(path);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployManager2 employManager2 = new EmployManager2(this);

            ShowComponent(false);
            employManager2.TopLevel = false;
            pnlEmployMNG.Controls.Add(employManager2);
            employManager2.Show();
        }

        public void ShowComponent(bool show)
        {
            foreach (Control control in Controls)
            {
                if (control != pnlEmployMNG)
                    control.Visible = show;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataEmployerMNG.SelectedRows.Count > 0)  // Kiểm tra xem có hàng nào được chọn không
            {
                // Lấy chỉ số hàng được chọn
                DataGridViewRow selectedRow = dataEmployerMNG.SelectedRows[0];

                // Lấy dữ liệu từ các cột tương ứng
                string employeeID = selectedRow.Cells["EmployeeID"].Value.ToString();
                

                // Truyền dữ liệu sang form EmployManager2
                EmployManager2 employManager2 = new EmployManager2(employeeID, this);
                ShowComponent(false);
                employManager2.TopLevel = false;
                pnlEmployMNG.Controls.Add(employManager2);
                employManager2.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        
    }
}
