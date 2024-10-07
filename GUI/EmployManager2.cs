using BLL;
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
using DTO;
using System.Xml.Linq;
namespace GUI
{
    public partial class EmployManager2 : Form
    {
        EmployManager employ;
        bool edit;
        EmployManager2BLL employManager2BLL = new EmployManager2BLL();
        public EmployManager2(EmployManager form)
        {
            InitializeComponent();
            employID.AutoSize = false;
            employID.Height = 30;
            numberPhone.AutoSize = false;
            numberPhone.Height = 30;
            gender.AutoSize = false;
            gender.Height = 30;
            address.AutoSize = false;
            address.Height = 30;
            hometown.AutoSize = false;
            hometown.Height = 30;
            
            edit = false;
            employ = form;
        }
        public EmployManager2(string employID1,EmployManager form)
        {
            InitializeComponent();
            employID.AutoSize = false;
            employID.Height = 30;
            numberPhone.AutoSize = false;
            numberPhone.Height = 30;
            gender.AutoSize = false;
            gender.Height = 30;
            address.AutoSize = false;
            address.Height = 30;
            hometown.AutoSize = false;
            hometown.Height = 30;
            gender.Items.Clear();
            gender.Items.Add("Nam");
            gender.Items.Add("Nữ");
            employ = form;
            edit = true;
            DataTable editTable  = new DataTable();
            editTable = employManager2BLL.EditEmployeeManager(employID1, Employee.EmployeeId);
            employID.Text = editTable.Rows[0]["MaNhanVien"].ToString();
            numberPhone.Text = editTable.Rows[0]["DienThoai"].ToString();
            gender.SelectedItem = editTable.Rows[0]["GioiTinh"].ToString();
            address.Text = editTable.Rows[0]["DiaChi"].ToString();
            hometown.Text = editTable.Rows[0]["QueQuan"].ToString();
            dateTimeBirthDay.Value = Convert.ToDateTime(editTable.Rows[0]["NamSinh"]);
            name.Text = editTable.Rows[0]["TenNhanVien"].ToString();
        }
        private void Button_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employ.Update();
            employ.ShowComponent(true);
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 50;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            panel1.Region = new Region(path);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (edit == true)
            {
                
                string s = gender.SelectedItem.ToString();
                Console.WriteLine(s);
                if (s==Gender.Female.GetEnumDescription() || s==Gender.Male.GetEnumDescription() )
                {
                    EmployeeDTO employeeDTO = new EmployeeDTO
                    (
                        employID.Text,  // Sử dụng giá trị từ TextBox
                        name.Text,
                        s == Gender.Male.GetEnumDescription() ? Gender.Male : Gender.Female,  // Gán giá trị enum đã chuyển đổi
                        dateTimeBirthDay.Value,
                        hometown.Text,
                        address.Text,
                        numberPhone.Text
                    );

                    int result = employManager2BLL.UpdateEmployee(employeeDTO);

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        employ.ShowComponent(true);  // Hiển thị lại form chính
                        this.Close();  // Đóng form hiện tại
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Giới tính không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }

        }
        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Properties.Resources.btn;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        }
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackgroundImage = Properties.Resources.hover;
            btnSave.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
