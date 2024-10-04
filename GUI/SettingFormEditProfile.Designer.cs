namespace GUI
{
    partial class SettingFormEditProfile
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
            this.pnEditProfile = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtDateofBirth = new System.Windows.Forms.TextBox();
            this.lbDateofBirth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.pnEditProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEditProfile
            // 
            this.pnEditProfile.Controls.Add(this.btnSave);
            this.pnEditProfile.Controls.Add(this.picAvatar);
            this.pnEditProfile.Controls.Add(this.txtGender);
            this.pnEditProfile.Controls.Add(this.lbGender);
            this.pnEditProfile.Controls.Add(this.txtPhone);
            this.pnEditProfile.Controls.Add(this.lbPhone);
            this.pnEditProfile.Controls.Add(this.txtUserName);
            this.pnEditProfile.Controls.Add(this.lbUserName);
            this.pnEditProfile.Controls.Add(this.txtAddress);
            this.pnEditProfile.Controls.Add(this.lbAddress);
            this.pnEditProfile.Controls.Add(this.txtCountry);
            this.pnEditProfile.Controls.Add(this.lbCountry);
            this.pnEditProfile.Controls.Add(this.txtDateofBirth);
            this.pnEditProfile.Controls.Add(this.lbDateofBirth);
            this.pnEditProfile.Controls.Add(this.txtName);
            this.pnEditProfile.Controls.Add(this.lbname);
            this.pnEditProfile.Location = new System.Drawing.Point(3, 11);
            this.pnEditProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pnEditProfile.Name = "pnEditProfile";
            this.pnEditProfile.Size = new System.Drawing.Size(1266, 630);
            this.pnEditProfile.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(1061, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 50);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::GUI.Properties.Resources.logo;
            this.picAvatar.Location = new System.Drawing.Point(62, 28);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(165, 215);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 14;
            this.picAvatar.TabStop = false;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtGender.Location = new System.Drawing.Point(737, 316);
            this.txtGender.Margin = new System.Windows.Forms.Padding(2);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(260, 32);
            this.txtGender.TabIndex = 13;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lbGender.Location = new System.Drawing.Point(741, 290);
            this.lbGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(91, 23);
            this.lbGender.TabIndex = 12;
            this.lbGender.Text = "Giới Tính";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtPhone.Location = new System.Drawing.Point(737, 211);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 32);
            this.txtPhone.TabIndex = 11;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lbPhone.Location = new System.Drawing.Point(741, 185);
            this.lbPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(120, 23);
            this.lbPhone.TabIndex = 10;
            this.lbPhone.Text = "Số điện thoại";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtUserName.Location = new System.Drawing.Point(737, 114);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 32);
            this.txtUserName.TabIndex = 9;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lbUserName.Location = new System.Drawing.Point(741, 88);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(134, 23);
            this.lbUserName.TabIndex = 8;
            this.lbUserName.Text = "Tên Đăng nhập";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtAddress.Location = new System.Drawing.Point(390, 431);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(260, 32);
            this.txtAddress.TabIndex = 7;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lbAddress.Location = new System.Drawing.Point(394, 405);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(136, 23);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Địa chỉ hiện tại";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtCountry.Location = new System.Drawing.Point(390, 316);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(2);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(260, 32);
            this.txtCountry.TabIndex = 5;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lbCountry.Location = new System.Drawing.Point(394, 290);
            this.lbCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(90, 23);
            this.lbCountry.TabIndex = 4;
            this.lbCountry.Text = "Quê quán";
            // 
            // txtDateofBirth
            // 
            this.txtDateofBirth.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtDateofBirth.Location = new System.Drawing.Point(390, 211);
            this.txtDateofBirth.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateofBirth.Name = "txtDateofBirth";
            this.txtDateofBirth.Size = new System.Drawing.Size(260, 32);
            this.txtDateofBirth.TabIndex = 3;
            // 
            // lbDateofBirth
            // 
            this.lbDateofBirth.AutoSize = true;
            this.lbDateofBirth.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.lbDateofBirth.Location = new System.Drawing.Point(394, 185);
            this.lbDateofBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateofBirth.Name = "lbDateofBirth";
            this.lbDateofBirth.Size = new System.Drawing.Size(92, 23);
            this.lbDateofBirth.TabIndex = 2;
            this.lbDateofBirth.Text = "Ngày sinh";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.txtName.Location = new System.Drawing.Point(390, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 32);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(394, 88);
            this.lbname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(90, 23);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Họ và tên";
            // 
            // SettingFormEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 652);
            this.Controls.Add(this.pnEditProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingFormEditProfile";
            this.Text = "SettingFormEditProfile";
            this.Load += new System.EventHandler(this.SettingFormEditProfile_Load);
            this.pnEditProfile.ResumeLayout(false);
            this.pnEditProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEditProfile;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtDateofBirth;
        private System.Windows.Forms.Label lbDateofBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btnSave;
    }
}