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
            numberPhone.AutoSize = false;
            gender.AutoSize = false;
            address.AutoSize = false;
            hometown.AutoSize = false;
            birthday.AutoSize = false;
            edit = false;
            employ = form;
        }
        public EmployManager2(string employID1,EmployManager form)
        {
            InitializeComponent();
            employID.AutoSize = false;
            numberPhone.AutoSize = false;
            gender.AutoSize = false;
            address.AutoSize = false;
            hometown.AutoSize = false;
            birthday.AutoSize = false;
            employ = form;
            edit = true;
            DataTable editTable  = new DataTable();
            editTable = employManager2BLL.EditEmployeeManager(employID1, Employee.EmployeeId);
            employID.Text = editTable.Rows[0]["MaNhanVien"].ToString();
            numberPhone.Text = editTable.Rows[0]["DienThoai"].ToString();
            gender.Text = editTable.Rows[0]["GioiTinh"].ToString();
            address.Text = editTable.Rows[0]["DiaChi"].ToString();
            hometown.Text = editTable.Rows[0]["QueQuan"].ToString();
            birthday.Text = editTable.Rows[0]["NamSinh"].ToString();
        }
        private void Button_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            if (edit = true) { 
                
            }
        }
    }
}
