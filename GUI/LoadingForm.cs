using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {

        }

        private void pnProcessBar_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 17;
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



        private void LoadingForm_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 30; // Bán kính bo góc
            Form form = sender as Form;

            // Tạo GraphicsPath để bo góc
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, borderRadius, borderRadius), 180, 90); // Bo góc trên trái
            path.AddArc(new Rectangle(form.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90); // Bo góc trên phải
            path.AddArc(new Rectangle(form.Width - borderRadius, form.Height - borderRadius, borderRadius, borderRadius), 0, 90); // Bo góc dưới phải
            path.AddArc(new Rectangle(0, form.Height - borderRadius, borderRadius, borderRadius), 90, 90); // Bo góc dưới trái
            path.CloseFigure();

            // Thiết lập vùng bo tròn cho form
            this.Region = new Region(path);
        }

        private void logoBEA_Click(object sender, EventArgs e)
        {

        }

        private void pnHeader_Paint(object sender, PaintEventArgs e)
        {
            int borderRadius = 10;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnProcessBar2.Width += 2;
            lbProcessPercent.Text = ((pnProcessBar2.Width * 100) / pnProcessBar.Width).ToString() + "%";
            if (pnProcessBar2.Width >= pnProcessBar.Width)
            {
                timer1.Stop();
                BaseForm baseForm = new BaseForm();
                Hide();
                baseForm.Show();
            }
        }

        private void labelLoading_Click(object sender, EventArgs e)
        {

        }

        private void lbProcessPercent_Click(object sender, EventArgs e)
        {

        }
    }
}
