using System.Drawing;
using System.Windows.Forms;
using System;

namespace GUI
{
    partial class SettingFormOption
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
            this.pnEditPassword = new System.Windows.Forms.Panel();
            this.grbOptinon = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.toggleButton1 = new System.Windows.Forms.CheckBox();
            this.toggleButton = new System.Windows.Forms.CheckBox();
            this.lbOp3 = new System.Windows.Forms.Label();
            this.lbOp2 = new System.Windows.Forms.Label();
            this.lbOp1 = new System.Windows.Forms.Label();
            this.pnEditPassword.SuspendLayout();
            this.grbOptinon.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEditPassword
            // 
            this.pnEditPassword.Controls.Add(this.grbOptinon);
            this.pnEditPassword.Location = new System.Drawing.Point(11, 11);
            this.pnEditPassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnEditPassword.Name = "pnEditPassword";
            this.pnEditPassword.Size = new System.Drawing.Size(1246, 617);
            this.pnEditPassword.TabIndex = 17;
            // 
            // grbOptinon
            // 
            this.grbOptinon.Controls.Add(this.btnLogout);
            this.grbOptinon.Controls.Add(this.panel1);
            this.grbOptinon.Controls.Add(this.pnLine);
            this.grbOptinon.Controls.Add(this.label1);
            this.grbOptinon.Controls.Add(this.languageComboBox);
            this.grbOptinon.Controls.Add(this.toggleButton1);
            this.grbOptinon.Controls.Add(this.toggleButton);
            this.grbOptinon.Controls.Add(this.lbOp3);
            this.grbOptinon.Controls.Add(this.lbOp2);
            this.grbOptinon.Controls.Add(this.lbOp1);
            this.grbOptinon.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOptinon.Location = new System.Drawing.Point(16, 28);
            this.grbOptinon.Name = "grbOptinon";
            this.grbOptinon.Size = new System.Drawing.Size(1213, 574);
            this.grbOptinon.TabIndex = 0;
            this.grbOptinon.TabStop = false;
            this.grbOptinon.Text = "Tuỳ chọn";
            this.grbOptinon.Enter += new System.EventHandler(this.grbEditPassword_Enter);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::GUI.Properties.Resources.image;
            this.btnLogout.Location = new System.Drawing.Point(53, 517);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(197, 39);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(1, 498);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 2);
            this.panel1.TabIndex = 31;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnLine.Location = new System.Drawing.Point(346, 14);
            this.pnLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(2, 560);
            this.pnLine.TabIndex = 30;
            this.pnLine.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLine_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(493, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 29;
            this.label1.Text = "Thay đổi ngôn ngữ";
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Việt Nam"});
            this.languageComboBox.Location = new System.Drawing.Point(498, 138);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(187, 39);
            this.languageComboBox.TabIndex = 28;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleButton1.AutoSize = true;
            this.toggleButton1.Location = new System.Drawing.Point(209, 174);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(59, 41);
            this.toggleButton1.TabIndex = 27;
            this.toggleButton1.Text = "Off";
            this.toggleButton1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toggleButton
            // 
            this.toggleButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.toggleButton.AutoSize = true;
            this.toggleButton.Location = new System.Drawing.Point(209, 88);
            this.toggleButton.Name = "toggleButton";
            this.toggleButton.Size = new System.Drawing.Size(59, 41);
            this.toggleButton.TabIndex = 26;
            this.toggleButton.Text = "Off";
            this.toggleButton.CheckedChanged += new System.EventHandler(this.ToggleButton_CheckedChanged);
            // 
            // lbOp3
            // 
            this.lbOp3.AutoSize = true;
            this.lbOp3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOp3.Location = new System.Drawing.Point(24, 260);
            this.lbOp3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOp3.Name = "lbOp3";
            this.lbOp3.Size = new System.Drawing.Size(191, 27);
            this.lbOp3.TabIndex = 23;
            this.lbOp3.Text = "Hỗ trợ khách hàng";
            this.lbOp3.Click += new System.EventHandler(this.lbOp3_Click);
            // 
            // lbOp2
            // 
            this.lbOp2.AutoSize = true;
            this.lbOp2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOp2.Location = new System.Drawing.Point(24, 182);
            this.lbOp2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOp2.Name = "lbOp2";
            this.lbOp2.Size = new System.Drawing.Size(139, 27);
            this.lbOp2.TabIndex = 16;
            this.lbOp2.Text = "Tắt âm thanh";
            // 
            // lbOp1
            // 
            this.lbOp1.AutoSize = true;
            this.lbOp1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOp1.Location = new System.Drawing.Point(24, 96);
            this.lbOp1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOp1.Name = "lbOp1";
            this.lbOp1.Size = new System.Drawing.Size(154, 27);
            this.lbOp1.TabIndex = 14;
            this.lbOp1.Text = "Toàn màn hình";
            // 
            // SettingFormOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 652);
            this.Controls.Add(this.pnEditPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingFormOption";
            this.Text = "SettingFormOption";
            this.pnEditPassword.ResumeLayout(false);
            this.grbOptinon.ResumeLayout(false);
            this.grbOptinon.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Panel pnEditPassword;
        private System.Windows.Forms.GroupBox grbOptinon;
        private System.Windows.Forms.Label lbOp3;
        private System.Windows.Forms.Label lbOp2;
        private System.Windows.Forms.Label lbOp1;
        private System.Windows.Forms.CheckBox toggleButton;
        private CheckBox toggleButton1;
        private ComboBox languageComboBox;
        private Label label1;
        private Panel pnLine;
        private Panel btnLogout;
        private Panel panel1;
    }
}