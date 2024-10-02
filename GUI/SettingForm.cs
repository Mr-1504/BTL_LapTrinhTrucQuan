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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            // Tạo instance của form con SettingFormEditProfile
            SettingFormEditProfile editProfileForm = new SettingFormEditProfile();

            // Gọi hàm LoadChildForm để nhúng form con vào panel
            LoadChildForm(editProfileForm);

        }

        private void slidePanel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 8;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, slidePanel1.Width - 1, slidePanel1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            slidePanel1.Region = new Region(path);
        }

        private void pnallsettring_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 15;
            Panel panel = sender as Panel;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90); // Bo góc trên trái
                path.AddArc(new Rectangle(panel.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90); // Bo góc trên phải
                path.AddArc(new Rectangle(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius), 0, 90); // Bo góc dưới phải
                path.AddArc(new Rectangle(0, panel.Height - borderRadius, borderRadius, borderRadius), 90, 90); // Bo góc dưới trái
                path.CloseFigure();

                // Thiết lập vùng cho panel để tạo bo góc
                panel.Region = new Region(path);

            }
        }



        private void pnoption1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void slidePanel2_Paint(object sender, PaintEventArgs e)
        {
            int radius = 8;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, slidePanel1.Width - 1, slidePanel1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            slidePanel2.Region = new Region(path);
        }

        private void slidePanel3_Paint(object sender, PaintEventArgs e)
        {
            int radius = 8;

            // Tạo GraphicsPath để vẽ hình chữ nhật bo góc
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, slidePanel1.Width - 1, slidePanel1.Height - 1);

            // Thêm hình chữ nhật bo góc vào GraphicsPath
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            slidePanel3.Region = new Region(path);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            slidePanel2.Visible = true;
            slidePanel1.Visible = false;
            slidePanel3.Visible = false;
            // Tạo instance của form con SettingFormSecurity
            SettingFormOption formOption = new SettingFormOption();

            // Gọi hàm LoadChildForm để nhúng form con vào panel
            LoadChildForm(formOption);
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            slidePanel1.Visible = true;
            slidePanel2.Visible = false;
            slidePanel3.Visible = false;
            // Tạo instance của form con SettingFormSecurity
            SettingFormEditProfile editProfileForm = new SettingFormEditProfile();

            // Gọi hàm LoadChildForm để nhúng form con vào panel
            LoadChildForm(editProfileForm);
        }
        private void btnSecurity_Click(object sender, EventArgs e)
        {
            slidePanel1.Visible = false;
            slidePanel2.Visible = false;
            slidePanel3.Visible = true;
            // Tạo instance của form con SettingFormSecurity
            SettingFormSecurity securityForm = new SettingFormSecurity();

            // Gọi hàm LoadChildForm để nhúng form con vào panel
            LoadChildForm(securityForm);
        }
        private void LoadChildForm(Form childForm)
        {
            // Xóa form con hiện tại trong panel (nếu có)
            if (this.pnItems.Controls.Count > 0)
                this.pnItems.Controls.RemoveAt(0);

            // Cài đặt form con: không là cửa sổ độc lập
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            // Thêm form con vào panel của form chính
            this.pnItems.Controls.Add(childForm);
            this.pnItems.Tag = childForm;

            // Hiển thị form con
            childForm.Show();
        }
        private void lbname_Click(object sender, EventArgs e)
        {

        }

        private void picAvatar_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
