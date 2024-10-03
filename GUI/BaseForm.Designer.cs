namespace GUI
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.slidePanel3 = new System.Windows.Forms.Panel();
            this.Account = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.picAccount = new System.Windows.Forms.PictureBox();
            this.slidePanel2 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.slidePanel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.SearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.Account);
            this.panel3.Controls.Add(this.Home);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 861);
            this.panel3.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.slidePanel3);
            this.panel7.Location = new System.Drawing.Point(0, 273);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 94);
            this.panel7.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(67, 22);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Home Page";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GUI.Properties.Resources.iconHome;
            this.pictureBox5.Location = new System.Drawing.Point(31, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // slidePanel3
            // 
            this.slidePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.slidePanel3.Location = new System.Drawing.Point(0, 22);
            this.slidePanel3.Margin = new System.Windows.Forms.Padding(0);
            this.slidePanel3.Name = "slidePanel3";
            this.slidePanel3.Size = new System.Drawing.Size(10, 56);
            this.slidePanel3.TabIndex = 1;
            this.slidePanel3.Visible = false;
            this.slidePanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.slidePanel3_Paint);
            // 
            // Account
            // 
            this.Account.Controls.Add(this.btnAccount);
            this.Account.Controls.Add(this.picAccount);
            this.Account.Controls.Add(this.slidePanel2);
            this.Account.Location = new System.Drawing.Point(0, 179);
            this.Account.Margin = new System.Windows.Forms.Padding(0);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(231, 94);
            this.Account.TabIndex = 4;
            this.Account.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseClick);
            this.Account.MouseEnter += new System.EventHandler(this.Component_MouseEnter);
            this.Account.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // btnAccount
            // 
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(67, 22);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(161, 56);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseClick);
            this.btnAccount.MouseEnter += new System.EventHandler(this.Component_MouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // picAccount
            // 
            this.picAccount.Image = global::GUI.Properties.Resources.Account;
            this.picAccount.Location = new System.Drawing.Point(31, 32);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(30, 30);
            this.picAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccount.TabIndex = 2;
            this.picAccount.TabStop = false;
            this.picAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseClick);
            this.picAccount.MouseEnter += new System.EventHandler(this.Component_MouseEnter);
            this.picAccount.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // slidePanel2
            // 
            this.slidePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.slidePanel2.Location = new System.Drawing.Point(0, 22);
            this.slidePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.slidePanel2.Name = "slidePanel2";
            this.slidePanel2.Size = new System.Drawing.Size(10, 56);
            this.slidePanel2.TabIndex = 1;
            this.slidePanel2.Visible = false;
            this.slidePanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.slidePanel2_Paint);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.btnHome);
            this.Home.Controls.Add(this.picHome);
            this.Home.Controls.Add(this.slidePanel1);
            this.Home.Location = new System.Drawing.Point(0, 85);
            this.Home.Margin = new System.Windows.Forms.Padding(0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(231, 94);
            this.Home.TabIndex = 0;
            this.Home.Paint += new System.Windows.Forms.PaintEventHandler(this.Home_Paint);
            this.Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseClick);
            this.Home.MouseEnter += new System.EventHandler(this.Component_MouseEnter);
            this.Home.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(67, 22);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(161, 56);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home Page";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseClick);
            this.btnHome.MouseEnter += new System.EventHandler(this.Component_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // picHome
            // 
            this.picHome.Image = global::GUI.Properties.Resources.Home;
            this.picHome.Location = new System.Drawing.Point(31, 32);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(30, 30);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 2;
            this.picHome.TabStop = false;
            this.picHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Component_MouseClick);
            this.picHome.MouseEnter += new System.EventHandler(this.Component_MouseEnter);
            this.picHome.MouseLeave += new System.EventHandler(this.Component_MouseLeave);
            // 
            // slidePanel1
            // 
            this.slidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(95)))), ((int)(((byte)(255)))));
            this.slidePanel1.Location = new System.Drawing.Point(0, 22);
            this.slidePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.slidePanel1.Name = "slidePanel1";
            this.slidePanel1.Size = new System.Drawing.Size(10, 56);
            this.slidePanel1.TabIndex = 1;
            this.slidePanel1.Visible = false;
            this.slidePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.slidePanel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.SearchBar);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(231, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1353, 85);
            this.panel6.TabIndex = 1;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.LightGray;
            this.SearchBar.Controls.Add(this.txtSearch);
            this.SearchBar.Location = new System.Drawing.Point(237, 35);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(797, 24);
            this.SearchBar.TabIndex = 4;
            this.SearchBar.Paint += new System.Windows.Forms.PaintEventHandler(this.SearchBar_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LightGray;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(790, 22);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "tìm";
            this.txtSearch.Click += new System.EventHandler(this.textBox1_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSearch.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Image = global::GUI.Properties.Resources.btnSetting;
            this.button1.Location = new System.Drawing.Point(1135, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 43);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.hihi;
            this.pictureBox2.Location = new System.Drawing.Point(1269, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overview";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Silver;
            this.MainPanel.Location = new System.Drawing.Point(238, 91);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1337, 770);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // BaseForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Account.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.SearchBar.ResumeLayout(false);
            this.SearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
    
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel slidePanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel slidePanel3;
        private System.Windows.Forms.Panel Account;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.PictureBox picAccount;
        private System.Windows.Forms.Panel slidePanel2;
        private System.Windows.Forms.FlowLayoutPanel SearchBar;
    }
}

