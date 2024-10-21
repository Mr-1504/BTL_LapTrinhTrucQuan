namespace GUI
{
    partial class SettingFormSecurity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingFormSecurity));
            this.pnEditPassword = new System.Windows.Forms.Panel();
            this.grbEditPassword = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSeen3 = new System.Windows.Forms.PictureBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.btnbtnChangePassword = new System.Windows.Forms.Button();
            this.pnNewPass = new System.Windows.Forms.Panel();
            this.picSeen2 = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.pnCrPass = new System.Windows.Forms.Panel();
            this.picSeen1 = new System.Windows.Forms.PictureBox();
            this.txtCrPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbCrPass = new System.Windows.Forms.Label();
            this.pnEditPassword.SuspendLayout();
            this.grbEditPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen3)).BeginInit();
            this.pnNewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen2)).BeginInit();
            this.pnCrPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEditPassword
            // 
            this.pnEditPassword.Controls.Add(this.grbEditPassword);
            this.pnEditPassword.Location = new System.Drawing.Point(15, 103);
            this.pnEditPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnEditPassword.Name = "pnEditPassword";
            this.pnEditPassword.Size = new System.Drawing.Size(1661, 668);
            this.pnEditPassword.TabIndex = 6;
            // 
            // grbEditPassword
            // 
            this.grbEditPassword.Controls.Add(this.panel1);
            this.grbEditPassword.Controls.Add(this.lbConfirmPass);
            this.grbEditPassword.Controls.Add(this.btnbtnChangePassword);
            this.grbEditPassword.Controls.Add(this.pnNewPass);
            this.grbEditPassword.Controls.Add(this.pnCrPass);
            this.grbEditPassword.Controls.Add(this.lbNewPass);
            this.grbEditPassword.Controls.Add(this.lbCrPass);
            this.grbEditPassword.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditPassword.Location = new System.Drawing.Point(21, 34);
            this.grbEditPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEditPassword.Name = "grbEditPassword";
            this.grbEditPassword.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbEditPassword.Size = new System.Drawing.Size(1617, 614);
            this.grbEditPassword.TabIndex = 0;
            this.grbEditPassword.TabStop = false;
            this.grbEditPassword.Text = "Đổi mật khẩu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.picSeen3);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Location = new System.Drawing.Point(157, 475);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 62);
            this.panel1.TabIndex = 24;
            // 
            // picSeen3
            // 
            this.picSeen3.BackColor = System.Drawing.Color.Transparent;
            this.picSeen3.BackgroundImage = global::GUI.Properties.Resources.Seen;
            this.picSeen3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSeen3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSeen3.Location = new System.Drawing.Point(388, 16);
            this.picSeen3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSeen3.Name = "picSeen3";
            this.picSeen3.Size = new System.Drawing.Size(45, 34);
            this.picSeen3.TabIndex = 18;
            this.picSeen3.TabStop = false;
            this.picSeen3.Click += new System.EventHandler(this.picSeen3_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.White;
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(29, 18);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPass.MaxLength = 20;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(397, 31);
            this.txtConfirmPass.TabIndex = 6;
            this.txtConfirmPass.TabStop = false;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPass.Location = new System.Drawing.Point(151, 438);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(232, 34);
            this.lbConfirmPass.TabIndex = 23;
            this.lbConfirmPass.Text = "Nhập lại mật khẩu";
            // 
            // btnbtnChangePassword
            // 
            this.btnbtnChangePassword.BackColor = System.Drawing.Color.Blue;
            this.btnbtnChangePassword.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbtnChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnbtnChangePassword.Location = new System.Drawing.Point(1368, 533);
            this.btnbtnChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbtnChangePassword.Name = "btnbtnChangePassword";
            this.btnbtnChangePassword.Size = new System.Drawing.Size(224, 62);
            this.btnbtnChangePassword.TabIndex = 22;
            this.btnbtnChangePassword.Text = "Change";
            this.btnbtnChangePassword.UseVisualStyleBackColor = false;
            this.btnbtnChangePassword.Click += new System.EventHandler(this.btnbtnChangePassword_Click);
            // 
            // pnNewPass
            // 
            this.pnNewPass.BackColor = System.Drawing.Color.White;
            this.pnNewPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnNewPass.BackgroundImage")));
            this.pnNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnNewPass.Controls.Add(this.picSeen2);
            this.pnNewPass.Controls.Add(this.txtNewPass);
            this.pnNewPass.Location = new System.Drawing.Point(157, 334);
            this.pnNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnNewPass.Name = "pnNewPass";
            this.pnNewPass.Size = new System.Drawing.Size(451, 62);
            this.pnNewPass.TabIndex = 21;
            // 
            // picSeen2
            // 
            this.picSeen2.BackColor = System.Drawing.Color.Transparent;
            this.picSeen2.BackgroundImage = global::GUI.Properties.Resources.Seen;
            this.picSeen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSeen2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSeen2.Location = new System.Drawing.Point(388, 11);
            this.picSeen2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSeen2.Name = "picSeen2";
            this.picSeen2.Size = new System.Drawing.Size(45, 34);
            this.picSeen2.TabIndex = 18;
            this.picSeen2.TabStop = false;
            this.picSeen2.Click += new System.EventHandler(this.picSeen2_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.White;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(29, 17);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewPass.MaxLength = 20;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(397, 31);
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.TabStop = false;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // pnCrPass
            // 
            this.pnCrPass.BackColor = System.Drawing.Color.White;
            this.pnCrPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCrPass.BackgroundImage")));
            this.pnCrPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCrPass.Controls.Add(this.picSeen1);
            this.pnCrPass.Controls.Add(this.txtCrPass);
            this.pnCrPass.Location = new System.Drawing.Point(157, 190);
            this.pnCrPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnCrPass.Name = "pnCrPass";
            this.pnCrPass.Size = new System.Drawing.Size(451, 62);
            this.pnCrPass.TabIndex = 20;
            // 
            // picSeen1
            // 
            this.picSeen1.BackColor = System.Drawing.Color.Transparent;
            this.picSeen1.BackgroundImage = global::GUI.Properties.Resources.Seen;
            this.picSeen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSeen1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSeen1.Location = new System.Drawing.Point(388, 11);
            this.picSeen1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSeen1.Name = "picSeen1";
            this.picSeen1.Size = new System.Drawing.Size(45, 38);
            this.picSeen1.TabIndex = 19;
            this.picSeen1.TabStop = false;
            this.picSeen1.Click += new System.EventHandler(this.picSeen1_Click);
            // 
            // txtCrPass
            // 
            this.txtCrPass.BackColor = System.Drawing.Color.White;
            this.txtCrPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrPass.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrPass.Location = new System.Drawing.Point(29, 16);
            this.txtCrPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCrPass.MaxLength = 20;
            this.txtCrPass.Name = "txtCrPass";
            this.txtCrPass.Size = new System.Drawing.Size(397, 31);
            this.txtCrPass.TabIndex = 6;
            this.txtCrPass.TabStop = false;
            this.txtCrPass.UseSystemPasswordChar = true;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.Location = new System.Drawing.Point(151, 297);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(182, 34);
            this.lbNewPass.TabIndex = 16;
            this.lbNewPass.Text = "Mật khẩu mới";
            this.lbNewPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCrPass
            // 
            this.lbCrPass.AutoSize = true;
            this.lbCrPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrPass.Location = new System.Drawing.Point(151, 150);
            this.lbCrPass.Name = "lbCrPass";
            this.lbCrPass.Size = new System.Drawing.Size(222, 34);
            this.lbCrPass.TabIndex = 14;
            this.lbCrPass.Text = "Mật khẩu hiện tại";
            // 
            // SettingFormSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 802);
            this.Controls.Add(this.pnEditPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingFormSecurity";
            this.Text = "SettingFormOption";
            this.Load += new System.EventHandler(this.SettingFormSecurity_Load);
            this.pnEditPassword.ResumeLayout(false);
            this.grbEditPassword.ResumeLayout(false);
            this.grbEditPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen3)).EndInit();
            this.pnNewPass.ResumeLayout(false);
            this.pnNewPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen2)).EndInit();
            this.pnCrPass.ResumeLayout(false);
            this.pnCrPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEditPassword;
        private System.Windows.Forms.GroupBox grbEditPassword;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbCrPass;
        private System.Windows.Forms.PictureBox picSeen1;
        private System.Windows.Forms.PictureBox picSeen2;
        private System.Windows.Forms.Panel pnNewPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Panel pnCrPass;
        private System.Windows.Forms.TextBox txtCrPass;
        private System.Windows.Forms.Button btnbtnChangePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picSeen3;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lbConfirmPass;
    }
}