using System;
using System.Drawing;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class BaseForm : Form
    {
        private string _itemName;
        private int _distance;
        private int _y;
        private Panel _pnl;
        private Panel _choosePnl;
        public BaseForm()
        {
            _y = 0;
            _distance = 0;
            _itemName = "Home";
            InitializeComponent();
            foreach (Control control in this.Controls)
                control.Click += Control_Click;

            foreach (Control control in pnlMenu.Controls)
            {
                control.MouseEnter += Menu_MouseEnter;
                control.Click += Menu_Click;
                foreach (Control control_ in control.Controls)
                    control_.Click += Menu_Click;
            }
            foreach (Control control in Controls)
            {
                foreach (Control control_ in pnlMenu.Controls)
                    if (control_ == control)
                    {
                        continue;
                    }
                control.MouseEnter += Menu_MouseLeave;
            }
            pnlMenu.MouseEnter += Menu_MouseLeave;
        }


        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            _pnl = GetParentsPanel(sender, e);
            if (_pnl != null)
            {
                foreach (Control control in _pnl.Controls)
                {
                    Control_Hover(control, true);

                }

                foreach (Control control in pnlMenu.Controls)
                {
                    if (control != _pnl && control != picChoose && control != picHover && control is Panel && control != _choosePnl)
                    {
                        Panel pnl = control as Panel;
                        foreach (Control control_ in pnl.Controls)
                        {
                            Control_Hover(control_, false);

                        }
                    }
                }
            }
            if (_itemName != _pnl.Name)
            {
                _itemName = _pnl.Name;
                _y = _pnl.Location.Y + 11;
                if (!picHover.Visible)
                    picHover.Location = new Point(0, _y);
                picHover.Visible = true;

                _distance = _y - picHover.Location.Y;
                tmrHover.Start();
            }
            picHover.Visible = true;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                this.ActiveControl = null;
            }
        }

        private void tmrHover_Tick(object sender, EventArgs e)
        {
            if (_distance > 0)
            {
                if (picHover.Location.Y < _y)
                {
                    picHover.Location = new Point(0, picHover.Location.Y + 7);
                }
                else
                {
                    tmrHover.Stop();
                    picHover.Location = new Point(0, _pnl.Location.Y + 11);

                }
            }
            else if (_distance < 0)
            {
                if (picHover.Location.Y > _y)
                    picHover.Location = new Point(0, picHover.Location.Y - 7);
                else
                {
                    tmrHover.Stop();
                    picHover.Location = new Point(0, _pnl.Location.Y + 11);

                }
            }
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            picHover.Visible = false;
            if (_pnl != null)
            {
                foreach (Control control in _pnl.Controls)
                {
                    if (_pnl != _choosePnl)
                        Control_Hover(control, false);
                }

            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            _choosePnl = GetParentsPanel(sender, e);
            picChoose.Location = new Point(0, _choosePnl.Location.Y + 11);
            picChoose.Visible = true;
            Control_Hover(_choosePnl, true);
            foreach (Control control in pnlMenu.Controls)
            {
                if (control != _pnl && control != picChoose && control != picHover && control is Panel && control != _choosePnl)
                {
                    Panel pnl = control as Panel;
                    foreach (Control control_ in pnl.Controls)
                    {
                        Control_Hover(control_, false);

                    }
                }
            }
        }

        private void Control_Hover(Control control, bool hover)
        {
            string color = hover ? "Blue" : "Gray";
            Color _color = hover ? ColorTranslator.FromHtml(Config.BLUE) : ColorTranslator.FromHtml(Config.GRAY);
            FontStyle fontStyle = hover ? FontStyle.Bold : FontStyle.Regular;

            if (control is PictureBox)
            {
                PictureBox pic = control as PictureBox;
                string name = pic.Name + color;
                var imgResource = Properties.Resources.ResourceManager.GetObject(name) as Image;

                if (imgResource != null)
                {
                    pic.Image = imgResource;
                }
            }

            if (control is Label)
            {
                Label lbl = control as Label;
                if (lbl != null)
                {
                    lbl.ForeColor = _color;
                    lbl.Font = new Font(lbl.Font, fontStyle);
                }
            }
        }

        private Panel GetParentsPanel(object sender, EventArgs e)
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
            return panel;
        }
    }
}
