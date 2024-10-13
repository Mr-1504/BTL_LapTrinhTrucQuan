namespace GUI
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tmrNameMove = new System.Windows.Forms.Timer(this.components);
            this.tmrPassMove = new System.Windows.Forms.Timer(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSeen = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.pnlPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrNameMove
            // 
            this.tmrNameMove.Interval = 15;
            this.tmrNameMove.Tick += new System.EventHandler(this.timerNameMove_Tick);
            // 
            // tmrPassMove
            // 
            this.tmrPassMove.Interval = 15;
            this.tmrPassMove.Tick += new System.EventHandler(this.timerPassMove_Tick);
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 2000;
            this.tmrLoad.Tick += new System.EventHandler(this.tmrLoad_Tick);
            // 
            // picLoad
            // 
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLoad.Image = global::GUI.Properties.Resources.load1;
            this.picLoad.Location = new System.Drawing.Point(188, 194);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(80, 80);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 18;
            this.picLoad.TabStop = false;
            this.picLoad.Visible = false;
            // 
            // picTitle
            // 
            this.picTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTitle.BackgroundImage")));
            this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picTitle.Location = new System.Drawing.Point(190, 47);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(77, 65);
            this.picTitle.TabIndex = 17;
            this.picTitle.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUser.BackgroundImage")));
            this.pnlUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUser.Controls.Add(this.pnlLine1);
            this.pnlUser.Controls.Add(this.picUser);
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Controls.Add(this.txtUsername);
            this.pnlUser.Location = new System.Drawing.Point(59, 219);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(338, 50);
            this.pnlUser.TabIndex = 12;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.Black;
            this.pnlLine1.Location = new System.Drawing.Point(50, 9);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(2, 30);
            this.pnlLine1.TabIndex = 8;
            // 
            // picUser
            // 
            this.picUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUser.BackgroundImage")));
            this.picUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picUser.Location = new System.Drawing.Point(15, 6);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(24, 34);
            this.picUser.TabIndex = 7;
            this.picUser.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblName.Location = new System.Drawing.Point(67, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 15);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Mã nhân viên";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtUsername.Location = new System.Drawing.Point(70, 18);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 14);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            this.txtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPass.BackgroundImage")));
            this.pnlPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPass.Controls.Add(this.lblPassword);
            this.pnlPass.Controls.Add(this.btnSeen);
            this.pnlPass.Controls.Add(this.panel2);
            this.pnlPass.Controls.Add(this.picPassword);
            this.pnlPass.Controls.Add(this.txtPassword);
            this.pnlPass.Location = new System.Drawing.Point(59, 285);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(338, 50);
            this.pnlPass.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.White;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(67, 18);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(234, 15);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Mật khẩu";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // btnSeen
            // 
            this.btnSeen.BackColor = System.Drawing.Color.Transparent;
            this.btnSeen.BackgroundImage = global::GUI.Properties.Resources.Seen;
            this.btnSeen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSeen.Location = new System.Drawing.Point(307, 15);
            this.btnSeen.Name = "btnSeen";
            this.btnSeen.Size = new System.Drawing.Size(20, 20);
            this.btnSeen.TabIndex = 9;
            this.btnSeen.TabStop = false;
            this.btnSeen.Visible = false;
            this.btnSeen.Click += new System.EventHandler(this.BtnSeen_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(50, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 30);
            this.panel2.TabIndex = 8;
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.Transparent;
            this.picPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPassword.Image = global::GUI.Properties.Resources.password;
            this.picPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picPassword.Location = new System.Drawing.Point(15, 6);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(24, 34);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 7;
            this.picPassword.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPassword.Location = new System.Drawing.Point(70, 18);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 14);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLogo.Location = new System.Drawing.Point(120, 137);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(202, 59);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::GUI.Properties.Resources.BlueButton;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(97)))), ((int)(((byte)(178)))));
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(59, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(338, 51);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 469);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox btnSeen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer tmrNameMove;
        private System.Windows.Forms.Timer tmrPassMove;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.Timer tmrLoad;
    }
}