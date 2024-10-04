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
            this.pnNewPass = new System.Windows.Forms.Panel();
            this.picSeen2 = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.pnCrPass = new System.Windows.Forms.Panel();
            this.picSeen1 = new System.Windows.Forms.PictureBox();
            this.txtCrPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbCrPass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnEditPassword.SuspendLayout();
            this.grbEditPassword.SuspendLayout();
            this.pnNewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen2)).BeginInit();
            this.pnCrPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeen1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEditPassword
            // 
            this.pnEditPassword.Controls.Add(this.grbEditPassword);
            this.pnEditPassword.Location = new System.Drawing.Point(11, 84);
            this.pnEditPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnEditPassword.Name = "pnEditPassword";
            this.pnEditPassword.Size = new System.Drawing.Size(1246, 543);
            this.pnEditPassword.TabIndex = 6;
            // 
            // grbEditPassword
            // 
            this.grbEditPassword.Controls.Add(this.btnSave);
            this.grbEditPassword.Controls.Add(this.pnNewPass);
            this.grbEditPassword.Controls.Add(this.pnCrPass);
            this.grbEditPassword.Controls.Add(this.lbNewPass);
            this.grbEditPassword.Controls.Add(this.lbCrPass);
            this.grbEditPassword.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditPassword.Location = new System.Drawing.Point(16, 28);
            this.grbEditPassword.Name = "grbEditPassword";
            this.grbEditPassword.Size = new System.Drawing.Size(1213, 499);
            this.grbEditPassword.TabIndex = 0;
            this.grbEditPassword.TabStop = false;
            this.grbEditPassword.Text = "Đổi mật khẩu";
            // 
            // pnNewPass
            // 
            this.pnNewPass.BackColor = System.Drawing.Color.Transparent;
            this.pnNewPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnNewPass.BackgroundImage")));
            this.pnNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnNewPass.Controls.Add(this.picSeen2);
            this.pnNewPass.Controls.Add(this.txtNewPass);
            this.pnNewPass.Location = new System.Drawing.Point(118, 271);
            this.pnNewPass.Name = "pnNewPass";
            this.pnNewPass.Size = new System.Drawing.Size(338, 50);
            this.pnNewPass.TabIndex = 21;
            // 
            // picSeen2
            // 
            this.picSeen2.BackColor = System.Drawing.Color.Transparent;
            this.picSeen2.BackgroundImage = global::GUI.Properties.Resources.Seen;
            this.picSeen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSeen2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSeen2.Location = new System.Drawing.Point(291, 9);
            this.picSeen2.Name = "picSeen2";
            this.picSeen2.Size = new System.Drawing.Size(34, 28);
            this.picSeen2.TabIndex = 18;
            this.picSeen2.TabStop = false;
            this.picSeen2.Click += new System.EventHandler(this.picSeen2_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.White;
            this.txtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.Location = new System.Drawing.Point(22, 14);
            this.txtNewPass.MaxLength = 20;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(298, 22);
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.TabStop = false;
            // 
            // pnCrPass
            // 
            this.pnCrPass.BackColor = System.Drawing.Color.Transparent;
            this.pnCrPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCrPass.BackgroundImage")));
            this.pnCrPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnCrPass.Controls.Add(this.picSeen1);
            this.pnCrPass.Controls.Add(this.txtCrPass);
            this.pnCrPass.Location = new System.Drawing.Point(118, 154);
            this.pnCrPass.Name = "pnCrPass";
            this.pnCrPass.Size = new System.Drawing.Size(338, 50);
            this.pnCrPass.TabIndex = 20;
            // 
            // picSeen1
            // 
            this.picSeen1.BackColor = System.Drawing.Color.Transparent;
            this.picSeen1.BackgroundImage = global::GUI.Properties.Resources.Seen;
            this.picSeen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSeen1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSeen1.Location = new System.Drawing.Point(291, 9);
            this.picSeen1.Name = "picSeen1";
            this.picSeen1.Size = new System.Drawing.Size(34, 31);
            this.picSeen1.TabIndex = 19;
            this.picSeen1.TabStop = false;
            this.picSeen1.Click += new System.EventHandler(this.picSeen1_Click);
            // 
            // txtCrPass
            // 
            this.txtCrPass.BackColor = System.Drawing.Color.White;
            this.txtCrPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrPass.Location = new System.Drawing.Point(22, 13);
            this.txtCrPass.MaxLength = 20;
            this.txtCrPass.Name = "txtCrPass";
            this.txtCrPass.Size = new System.Drawing.Size(298, 22);
            this.txtCrPass.TabIndex = 6;
            this.txtCrPass.TabStop = false;
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.Location = new System.Drawing.Point(113, 241);
            this.lbNewPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(147, 27);
            this.lbNewPass.TabIndex = 16;
            this.lbNewPass.Text = "Mật khẩu mới";
            this.lbNewPass.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCrPass
            // 
            this.lbCrPass.AutoSize = true;
            this.lbCrPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrPass.Location = new System.Drawing.Point(113, 122);
            this.lbCrPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCrPass.Name = "lbCrPass";
            this.lbCrPass.Size = new System.Drawing.Size(181, 27);
            this.lbCrPass.TabIndex = 14;
            this.lbCrPass.Text = "Mật khẩu hiện tại";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(1026, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 50);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // SettingFormSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 652);
            this.Controls.Add(this.pnEditPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingFormSecurity";
            this.Text = "SettingFormOption";
            this.pnEditPassword.ResumeLayout(false);
            this.grbEditPassword.ResumeLayout(false);
            this.grbEditPassword.PerformLayout();
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
        private System.Windows.Forms.Button btnSave;
    }
}