using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using BLL;
using Utilities;

namespace GUI
{
    public partial class BaseForm : Form
    {
        private string _itemName;
        private string _mark;
        private int _interval;
        private int _distance;
        private int _y;
        public BaseForm()
        {
            _y = 0;
            _distance = 0;
            _itemName = "Home";
            _interval = 16;
            InitializeComponent();
            foreach(Control control in this.Controls)
                control.Click += Control_Click;
            
            foreach (Control control in pnlMenu.Controls)
                control.MouseEnter += Menu_Enter;
            foreach (Control control in this.Controls)
            {
                foreach (Control control_ in pnlMenu.Controls)
                    if(control_ == control)
                    {
                        continue;
                    }
                control.MouseEnter += Menu_MouseLeave;
            }
            pnlMenu.MouseEnter += Menu_MouseLeave;
        }

        private void Menu_Enter(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            if (sender is Panel)
            {
                panel = sender as Panel;
            }else if (sender is Label)
            {
                Label label = sender as Label;
                panel = label.Parent as Panel;
            }else if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                panel = pictureBox.Parent as Panel;
            }
            if(_itemName != panel.Name)
            {
                _itemName = panel.Name;
                _y = panel.Location.Y + 11;
                if(!picHover.Visible)
                    picHover.Location = new Point(0, _y);
                picHover.Visible= true;

                _distance = _y - picHover.Location.Y;
                tmrHover.Start();
            }
            picHover.Visible = true;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if(ActiveControl is TextBox)
            {
                this.ActiveControl = null;
            }
        }

        private void tmrHover_Tick(object sender, EventArgs e)
        {
            if(_distance > 0)
            {
                if (picHover.Location.Y < _y){
                    picHover.Location = new Point(0, picHover.Location.Y + 7);
                    Console.WriteLine(picHover.Location.Y.ToString() + " h");

                }
                else
                    tmrHover.Stop();
            }
            else if (_distance < 0)
            {
                if (picHover.Location.Y > _y)
                    picHover.Location = new Point(0, picHover.Location.Y - 7);
                else
                    tmrHover.Stop();
            }
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = new Panel();
            if (sender is Panel)
            {
                panel = sender as Panel;
            }
            else if (sender is Label)
            {
                Label label = sender as Label;
                panel = label.Parent as Panel;
            }
            else if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                panel = pictureBox.Parent as Panel;
            }
            picHover.Location = new Point(picHover.Location.X, panel.Location.Y + e.Y + 11);
            Console.WriteLine("...");
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            picHover.Visible = false;
        }
    }   
}
