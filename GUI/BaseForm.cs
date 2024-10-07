using BLL;
using GUI.PurchasedIngredient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Utilities;

namespace GUI
{
    public partial class BaseForm : Form
    {
        private string _itemName;
        private string _id;
        private string _action;
        private int _distance;
        private int _change;
        private int _y;
        private Panel _pnl;
        private Panel _choosePnl;
        public BaseForm(string employeeId)
        {
            _id = employeeId;
            _y = 0;
            _distance = 0;
            _change = 0;
            _itemName = "Home";
            InitializeComponent();
            _action = pnlHome.Name.Substring(3);
            _choosePnl = pnlHome;
            foreach (Control control in Controls)
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
            LoadMenu(employeeId);

            ActiveControl = picLogo;
        }

        private void LoadMenu(string employeeId)
        {
            int y = 72;
            List<string> list = new RoleBLL().GetOption(employeeId);
            foreach (string item in list)
            {
                foreach (Control control in pnlMenu.Controls)
                {
                    if (control is Panel && control.Name == item)
                    {
                        control.Location = new Point(5, y);
                        control.Visible = true;
                        y += 72;
                    }
                }
            }
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
                if (Math.Abs(_distance) >= 72 * 4)
                    _change = 11;
                else
                    _change = 7;
                tmrHover.Start();
            }
            picHover.Visible = true;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                ActiveControl = null;
            }
        }

        private void tmrHover_Tick(object sender, EventArgs e)
        {
            if (_distance > 0)
            {
                if (picHover.Location.Y < _y)
                {
                    picHover.Location = new Point(0, picHover.Location.Y + _change);
                }
                else
                {
                    tmrHover.Stop();
                    picHover.Location = new Point(0, _pnl.Location.Y + 11);
                }
            }
            else if (_distance < 0)
            {
                if (picHover.Location.Y > _y){
                    picHover.Location = new Point(0, picHover.Location.Y - _change);
                }
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
            if (_action == _choosePnl.Name.Substring(3))
                return;
            else
                _action = _choosePnl.Name.Substring(3);
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

            switch (_action)
            {
                case "Home":
                    
                    break;
                case "Employee":
                    
                    break;
                case "Food":
                    
                    break;
                case "Warehouse":

                    break;
                case "Import":
                    DetailPurchaseedIngredient detail = new DetailPurchaseedIngredient(_id);
                    OpenComponent( detail );
                    break;
                case "Order":

                    break;
                case "OrderList":

                    break;
                case "EditInformation":

                    break;
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

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (_action == btnSetting.Name.Substring(3)){
                return;
            }
            else
                _action = btnSetting.Name.Substring(3);
            foreach(Control control in _choosePnl.Controls)
                Control_Hover(control, false);
            picChoose.Visible = false;
            SettingForm settingForm = new SettingForm(_id);
            OpenComponent(settingForm);
        }

        private void OpenComponent(Form form)
        {
            form.MouseEnter += Menu_MouseLeave;
            foreach (Control control in form.Controls){
                control.MouseEnter += Menu_MouseLeave;
            }
            form.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(form);
            form.Show();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text == "Tìm kiếm" ? "" : txtSearch.Text;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = txtSearch.Text.Length == 0 ? "Tìm kiếm" : txtSearch.Text;
        }
    }
}
