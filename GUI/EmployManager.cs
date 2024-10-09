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
using Utilities;


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
            
            LoadEmployeeData1();
            pnlEmployMNG.Focus();
            dataEmployerMNG.AllowUserToAddRows = false;
            dataEmployerMNG.ClearSelection();
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
            dataEmployerMNG.Region = new Region(path);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployManager2 employManager2 = new EmployManager2(this);

            ShowComponent(false);
            employManager2.TopLevel = false;
            pnlEmployMNG.Controls.Add(employManager2);
            employManager2.Show();
            employManager2.FormClosed += new FormClosedEventHandler(EmployManager2_FormClosed);
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
            if (dataEmployerMNG.SelectedRows.Count > 0) 
            {
                DataGridViewRow selectedRow = dataEmployerMNG.SelectedRows[0];

                if (selectedRow.Cells["EmployeeID"].Value == null || string.IsNullOrEmpty(selectedRow.Cells["EmployeeID"].Value.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn một hàng có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string employeeID = selectedRow.Cells["EmployeeID"].Value.ToString();
                
                EmployManager2 employManager2 = new EmployManager2(employeeID, this);
                ShowComponent(false);
                employManager2.TopLevel = false;
                pnlEmployMNG.Controls.Add(employManager2);
                employManager2.Show();
                employManager2.FormClosed += new FormClosedEventHandler(EmployManager2_FormClosed);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EmployManager2_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadEmployeeData();
        }

        // Phương thức load dữ liệu cho DataGridView
        private void LoadEmployeeData()
        {
            DataTable employeeTable;
            EmployManagerBLL employ1 = new EmployManagerBLL();
            employeeTable = employ1.GetEmployees();
            dataEmployerMNG.DataSource = employeeTable;
            LoadEmployeeData1();


        }
       
        

        private void LoadEmployeeData1()
        {
            // Đổ dữ liệu từ cơ sở dữ liệu vào DataGridView
            DataTable data = employ.GetEmployees();

            DataColumn dataColumn = new DataColumn("quyen");
            data.Columns.Add(dataColumn);


            for (int i = 0; i < data.Rows.Count; i++)
            {
                string employeeID = data.Rows[i]["MaNhanVien"].ToString();
                string permission = employeeID.Substring(0, 2);

                // Gán quyền dựa trên mã nhân viên
                if (permission == "QL")
                {
                    data.Rows[i]["quyen"] = "Quản lý";
                }
                else if (permission == "LT")
                {
                    data.Rows[i]["quyen"] = "Lễ Tân";
                }
                else
                {
                    data.Rows[i]["quyen"] = "Kho Hàng";
                }
            }
            dataEmployerMNG.DataSource = data;

        }

        private void dataEmployerMNG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.btn;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.hover;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            btnAdd.BackgroundImage = Properties.Resources.enter;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackgroundImage = Properties.Resources.btn;
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            btnEdit.BackgroundImage = Properties.Resources.hover;
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = Properties.Resources.btn;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackgroundImage = Properties.Resources.hover;
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataEmployerMNG.SelectedRows.Count > 0)
            {
                DataGridViewRow selectRows = dataEmployerMNG.SelectedRows[0];

                if (selectRows.Cells["EmployeeID"].Value == null || string.IsNullOrEmpty(selectRows.Cells["EmployeeID"].Value.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn một hàng có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                string employeeID = selectRows.Cells["EmployeeID"].Value.ToString();

                int result = employ.DeletaEmployee(employeeID, EmployeeStatus.NoLongerWorking);
                if(result == 0)
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployeeData();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
