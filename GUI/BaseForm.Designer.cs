using System.Drawing;
using Utilities;

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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlWarehouse = new System.Windows.Forms.Panel();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.pnlFood = new System.Windows.Forms.Panel();
            this.lblFood = new System.Windows.Forms.Label();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lblHome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tmrHover = new System.Windows.Forms.Timer(this.components);
            this.pnlImport = new System.Windows.Forms.Panel();
            this.lblImport = new System.Windows.Forms.Label();
            this.picImport = new System.Windows.Forms.PictureBox();
            this.picWarehouse = new System.Windows.Forms.PictureBox();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.picChoose = new System.Windows.Forms.PictureBox();
            this.picHover = new System.Windows.Forms.PictureBox();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlWarehouse.SuspendLayout();
            this.pnlFood.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnAvatar);
            this.pnlHeader.Controls.Add(this.btnNotification);
            this.pnlHeader.Controls.Add(this.pnlSearch);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1600, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlImport);
            this.pnlMenu.Controls.Add(this.pnlWarehouse);
            this.pnlMenu.Controls.Add(this.pnlFood);
            this.pnlMenu.Controls.Add(this.picChoose);
            this.pnlMenu.Controls.Add(this.picHover);
            this.pnlMenu.Controls.Add(this.pnlEmployee);
            this.pnlMenu.Controls.Add(this.pnlHome);
            this.pnlMenu.Location = new System.Drawing.Point(0, 86);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(231, 814);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlWarehouse
            // 
            this.pnlWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.pnlWarehouse.Controls.Add(this.lblWarehouse);
            this.pnlWarehouse.Controls.Add(this.picWarehouse);
            this.pnlWarehouse.Location = new System.Drawing.Point(5, 211);
            this.pnlWarehouse.Name = "pnlWarehouse";
            this.pnlWarehouse.Size = new System.Drawing.Size(226, 72);
            this.pnlWarehouse.TabIndex = 4;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblWarehouse.Location = new System.Drawing.Point(71, 27);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(105, 18);
            this.lblWarehouse.TabIndex = 2;
            this.lblWarehouse.Text = "Trạng thái kho";
            // 
            // pnlFood
            // 
            this.pnlFood.BackColor = System.Drawing.Color.Transparent;
            this.pnlFood.Controls.Add(this.lblFood);
            this.pnlFood.Controls.Add(this.picFood);
            this.pnlFood.Location = new System.Drawing.Point(5, 139);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(226, 72);
            this.pnlFood.TabIndex = 4;
            // 
            // lblFood
            // 
            this.lblFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblFood.Location = new System.Drawing.Point(71, 27);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(86, 19);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "Món ăn";
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmployee.Controls.Add(this.lblEmployee);
            this.pnlEmployee.Controls.Add(this.picEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(5, 67);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(226, 72);
            this.pnlEmployee.TabIndex = 3;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblEmployee.Location = new System.Drawing.Point(71, 27);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(76, 18);
            this.lblEmployee.TabIndex = 2;
            this.lblEmployee.Text = "Nhân viên";
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Transparent;
            this.pnlHome.Controls.Add(this.lblHome);
            this.pnlHome.Controls.Add(this.picHome);
            this.pnlHome.Location = new System.Drawing.Point(5, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(226, 72);
            this.pnlHome.TabIndex = 0;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblHome.Location = new System.Drawing.Point(70, 27);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(75, 18);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "Trang chủ";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlContent.Controls.Add(this.pictureBox2);
            this.pnlContent.Location = new System.Drawing.Point(231, 86);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1369, 814);
            this.pnlContent.TabIndex = 3;
            // 
            // tmrHover
            // 
            this.tmrHover.Interval = 1;
            this.tmrHover.Tick += new System.EventHandler(this.tmrHover_Tick);
            // 
            // pnlImport
            // 
            this.pnlImport.BackColor = System.Drawing.Color.Transparent;
            this.pnlImport.Controls.Add(this.lblImport);
            this.pnlImport.Controls.Add(this.picImport);
            this.pnlImport.Location = new System.Drawing.Point(5, 283);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(226, 72);
            this.pnlImport.TabIndex = 5;
            // 
            // lblImport
            // 
            this.lblImport.AutoSize = true;
            this.lblImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblImport.Location = new System.Drawing.Point(71, 27);
            this.lblImport.Name = "lblImport";
            this.lblImport.Size = new System.Drawing.Size(83, 18);
            this.lblImport.TabIndex = 2;
            this.lblImport.Text = "Nhập hàng";
            // 
            // picImport
            // 
            this.picImport.Image = global::GUI.Properties.Resources.picImportGray;
            this.picImport.Location = new System.Drawing.Point(30, 26);
            this.picImport.Name = "picImport";
            this.picImport.Size = new System.Drawing.Size(20, 20);
            this.picImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImport.TabIndex = 1;
            this.picImport.TabStop = false;
            // 
            // picWarehouse
            // 
            this.picWarehouse.Image = global::GUI.Properties.Resources.picWarehouseGray;
            this.picWarehouse.Location = new System.Drawing.Point(30, 26);
            this.picWarehouse.Name = "picWarehouse";
            this.picWarehouse.Size = new System.Drawing.Size(20, 20);
            this.picWarehouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWarehouse.TabIndex = 1;
            this.picWarehouse.TabStop = false;
            // 
            // picFood
            // 
            this.picFood.Image = global::GUI.Properties.Resources.picFoodGray;
            this.picFood.Location = new System.Drawing.Point(30, 26);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(20, 20);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 1;
            this.picFood.TabStop = false;
            // 
            // picChoose
            // 
            this.picChoose.Image = global::GUI.Properties.Resources.lblButton;
            this.picChoose.Location = new System.Drawing.Point(0, 11);
            this.picChoose.Name = "picChoose";
            this.picChoose.Size = new System.Drawing.Size(5, 50);
            this.picChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picChoose.TabIndex = 0;
            this.picChoose.TabStop = false;
            this.picChoose.Visible = false;
            // 
            // picHover
            // 
            this.picHover.Image = global::GUI.Properties.Resources.lblHover;
            this.picHover.Location = new System.Drawing.Point(0, 11);
            this.picHover.Name = "picHover";
            this.picHover.Size = new System.Drawing.Size(5, 50);
            this.picHover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHover.TabIndex = 0;
            this.picHover.TabStop = false;
            // 
            // picEmployee
            // 
            this.picEmployee.Image = global::GUI.Properties.Resources.picEmployeeGray;
            this.picEmployee.Location = new System.Drawing.Point(30, 26);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(20, 20);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmployee.TabIndex = 1;
            this.picEmployee.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::GUI.Properties.Resources.picHomeGray;
            this.picHome.Location = new System.Drawing.Point(30, 26);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(20, 20);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundImage = global::GUI.Properties.Resources.btnSetting1;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Location = new System.Drawing.Point(1385, 26);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(40, 40);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnAvatar
            // 
            this.btnAvatar.BackgroundImage = global::GUI.Properties.Resources.hihi1;
            this.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvatar.FlatAppearance.BorderSize = 0;
            this.btnAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvatar.Location = new System.Drawing.Point(1525, 21);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(45, 45);
            this.btnAvatar.TabIndex = 4;
            this.btnAvatar.UseVisualStyleBackColor = true;
            // 
            // btnNotification
            // 
            this.btnNotification.BackgroundImage = global::GUI.Properties.Resources.btnNotification;
            this.btnNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNotification.FlatAppearance.BorderSize = 0;
            this.btnNotification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNotification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotification.Location = new System.Drawing.Point(1445, 24);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(40, 40);
            this.btnNotification.TabIndex = 2;
            this.btnNotification.UseVisualStyleBackColor = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackgroundImage = global::GUI.Properties.Resources.SearchPanel;
            this.pnlSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSearch.Location = new System.Drawing.Point(395, 24);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(974, 40);
            this.pnlSearch.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::GUI.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(23, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(158, 52);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(111, 93);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // BaseForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlWarehouse.ResumeLayout(false);
            this.pnlWarehouse.PerformLayout();
            this.pnlFood.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.PictureBox picChoose;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.PictureBox picHover;
        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Panel pnlWarehouse;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.PictureBox picWarehouse;
        private System.Windows.Forms.Timer tmrHover;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.Label lblImport;
        private System.Windows.Forms.PictureBox picImport;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

