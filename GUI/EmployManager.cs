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
        string role = null;
        bool isSearch = false;
        public EmployManager(string eRole)
        {
            InitializeComponent();
            dataEmployerMNG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataEmployerMNG.ReadOnly = true;  
            dataEmployerMNG.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dataEmployerMNG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataEmployerMNG.EnableHeadersVisualStyles = false;
            dataEmployerMNG.ColumnHeadersHeight = 50;
            dataEmployerMNG.ColumnHeadersBorderStyle = (DataGridViewHeaderBorderStyle)DataGridViewCellBorderStyle.None;
            dataEmployerMNG.AllowUserToResizeColumns = false;
            dataEmployerMNG.AutoGenerateColumns = false;
            dataEmployerMNG.AllowUserToResizeRows = false;
            dataEmployerMNG.Columns["EmployeeID"].DataPropertyName = "MaNhanVien";
            dataEmployerMNG.Columns["EmployeeName"].DataPropertyName = "TenNhanVien";
            dataEmployerMNG.Columns["NumberPhone"].DataPropertyName = "DienThoai";
            dataEmployerMNG.Columns["Address"].DataPropertyName = "DiaChi";
            role = eRole; 
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
            SetPlaceholder(textSearch, "Nhập tên nhân viên tìm kiếm...");
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
            EmployManager2 employManager2 = new EmployManager2(this,role);

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
            LoadEmployeeData();
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
                
                ShowComponent(false);
                foreach (Control control in Controls)
                {
                    if(control is EmployManager2)
                    {
                        control.BringToFront();
                        return;
                    }
                }
                EmployManager2 employManager2 = new EmployManager2(employeeID, this,role);
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

            if (isSearch && !string.IsNullOrEmpty(textSearch.Text))
            {
                employeeTable = employ.GetEmployees(Employee.Name, textSearch.Text);
            }
            else
            {
                employeeTable = employ.GetEmployees();
            }

            if (employeeTable != null && employeeTable.Rows.Count > 0)
            {
                AddPermissionColumn(employeeTable);
                dataEmployerMNG.DataSource = employeeTable;
            }
            else
            {
                dataEmployerMNG.DataSource = null;
            }
        }

        private void AddPermissionColumn(DataTable data)
        {
            if (!data.Columns.Contains("quyen"))
            {
                data.Columns.Add("quyen");
            }

            foreach (DataRow row in data.Rows)
            {
                string employeeID = row["MaNhanVien"].ToString();
                string permission = employeeID.Substring(0, 2);
                row["quyen"] = permission == "QL" ? "Quản lý" : (permission == "LT" ? "Lễ Tân" : "Kho Hàng");
            }
        }




        private void LoadEmployeeData1()
        {
            
            DataTable data = employ.GetEmployees();

            DataColumn dataColumn = new DataColumn("quyen");
            data.Columns.Add(dataColumn);


            foreach (DataRow row in data.Rows)
            {
                string employeeID = row["MaNhanVien"].ToString();
                string permission = employeeID.Substring(0, 2);
                row["quyen"] = permission == "QL" ? "Quản lý" : (permission == "LT" ? "Lễ Tân" : "Kho Hàng");
            }
            dataEmployerMNG.DataSource = data;

        }
        private void LoadEmployeeData1(string textSearch)
        {

            DataTable data = employ.GetEmployees(Employee.Name,textSearch);

            DataColumn dataColumn = new DataColumn("quyen");
            data.Columns.Add(dataColumn);


            foreach (DataRow row in data.Rows)
            {
                string employeeID = row["MaNhanVien"].ToString();
                string permission = employeeID.Substring(0, 2);
                row["quyen"] = permission == "QL" ? "Quản lý" : (permission == "LT" ? "Lễ Tân" : "Kho Hàng");
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
        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = Properties.Resources.btn;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackgroundImage = Properties.Resources.hover;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
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
                if (role == "QL")
                {
                    if (employeeID.Substring(0, 2) == "QL")
                    {
                        MessageBox.Show("Bạn không thể xóa quản lý!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    int result = employ.DeletaEmployee(employeeID, EmployeeStatus.NoLongerWorking);
                    if (result == 0)
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployeeData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSearch.Text.ToString()))
            {
                isSearch = false;
                LoadEmployeeData1();
            }
            else
            {
                isSearch = true;
                LoadEmployeeData1(textSearch.Text.ToString());
            }
        }
        private void TextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(textSearch.Text.ToString()))
                {
                    isSearch = false;
                    LoadEmployeeData1();
                }
                else
                {
                    isSearch = true;
                    LoadEmployeeData1(textSearch.Text.ToString());
                }
                e.SuppressKeyPress = true;
            }
        }
        private void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportEmployee reportEmployee = new ReportEmployee(this,"Vinh",DateTime.Now);
            ShowComponent(false);
            reportEmployee.TopLevel = false;
            pnlEmployMNG.Controls.Add(reportEmployee);
            reportEmployee.Show();
            reportEmployee.FormClosed += new FormClosedEventHandler(Report_FormClosed);
        }
        private void Report_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void btnRp_MouseLeave(object sender, EventArgs e)
        {
            btnReport.BackgroundImage = Properties.Resources.btn;
            btnReport.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnRp_MouseEnter(object sender, EventArgs e)
        {
            btnReport.BackgroundImage = Properties.Resources.hover;
            btnReport.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
