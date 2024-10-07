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
            this.pnlEditInformation = new System.Windows.Forms.Panel();
            this.lblEditInformation = new System.Windows.Forms.Label();
            this.pnlOrderList = new System.Windows.Forms.Panel();
            this.lblOrderList = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.lblImport = new System.Windows.Forms.Label();
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
            this.picEditInformation = new System.Windows.Forms.PictureBox();
            this.picOrderList = new System.Windows.Forms.PictureBox();
            this.picOrder = new System.Windows.Forms.PictureBox();
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlEditInformation.SuspendLayout();
            this.pnlOrderList.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlImport.SuspendLayout();
            this.pnlWarehouse.SuspendLayout();
            this.pnlFood.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.pnlMenu.Controls.Add(this.pnlEditInformation);
            this.pnlMenu.Controls.Add(this.pnlOrderList);
            this.pnlMenu.Controls.Add(this.pnlOrder);
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
            // pnlEditInformation
            // 
            this.pnlEditInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlEditInformation.Controls.Add(this.lblEditInformation);
            this.pnlEditInformation.Controls.Add(this.picEditInformation);
            this.pnlEditInformation.Location = new System.Drawing.Point(5, 504);
            this.pnlEditInformation.Name = "pnlEditInformation";
            this.pnlEditInformation.Size = new System.Drawing.Size(226, 72);
            this.pnlEditInformation.TabIndex = 8;
            this.pnlEditInformation.Visible = false;
            // 
            // lblEditInformation
            // 
            this.lblEditInformation.AutoSize = true;
            this.lblEditInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblEditInformation.Location = new System.Drawing.Point(71, 27);
            this.lblEditInformation.Name = "lblEditInformation";
            this.lblEditInformation.Size = new System.Drawing.Size(101, 18);
            this.lblEditInformation.TabIndex = 2;
            this.lblEditInformation.Text = "Sửa thông tin";
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrderList.Controls.Add(this.lblOrderList);
            this.pnlOrderList.Controls.Add(this.picOrderList);
            this.pnlOrderList.Location = new System.Drawing.Point(5, 432);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Size = new System.Drawing.Size(226, 72);
            this.pnlOrderList.TabIndex = 7;
            this.pnlOrderList.Visible = false;
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblOrderList.Location = new System.Drawing.Point(71, 27);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(99, 18);
            this.lblOrderList.TabIndex = 2;
            this.lblOrderList.Text = "Hóa đơn bán";
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrder.Controls.Add(this.lblOrder);
            this.pnlOrder.Controls.Add(this.picOrder);
            this.pnlOrder.Location = new System.Drawing.Point(5, 360);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(226, 72);
            this.pnlOrder.TabIndex = 6;
            this.pnlOrder.Visible = false;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblOrder.Location = new System.Drawing.Point(71, 27);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(67, 18);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Đặt món";
            // 
            // pnlImport
            // 
            this.pnlImport.BackColor = System.Drawing.Color.Transparent;
            this.pnlImport.Controls.Add(this.lblImport);
            this.pnlImport.Controls.Add(this.picImport);
            this.pnlImport.Location = new System.Drawing.Point(5, 288);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(226, 72);
            this.pnlImport.TabIndex = 5;
            this.pnlImport.Visible = false;
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
            // pnlWarehouse
            // 
            this.pnlWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.pnlWarehouse.Controls.Add(this.lblWarehouse);
            this.pnlWarehouse.Controls.Add(this.picWarehouse);
            this.pnlWarehouse.Location = new System.Drawing.Point(5, 216);
            this.pnlWarehouse.Name = "pnlWarehouse";
            this.pnlWarehouse.Size = new System.Drawing.Size(226, 72);
            this.pnlWarehouse.TabIndex = 4;
            this.pnlWarehouse.Visible = false;
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
            this.pnlFood.Location = new System.Drawing.Point(5, 144);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(226, 72);
            this.pnlFood.TabIndex = 4;
            this.pnlFood.Visible = false;
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
            this.pnlEmployee.Location = new System.Drawing.Point(5, 72);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(226, 72);
            this.pnlEmployee.TabIndex = 3;
            this.pnlEmployee.Visible = false;
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
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.lblHome.Location = new System.Drawing.Point(70, 27);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(75, 18);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "Trang chủ";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
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
            // picEditInformation
            // 
            this.picEditInformation.Image = global::GUI.Properties.Resources.picEditInformationGray;
            this.picEditInformation.Location = new System.Drawing.Point(30, 26);
            this.picEditInformation.Name = "picEditInformation";
            this.picEditInformation.Size = new System.Drawing.Size(20, 20);
            this.picEditInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditInformation.TabIndex = 1;
            this.picEditInformation.TabStop = false;
            // 
            // picOrderList
            // 
            this.picOrderList.Image = global::GUI.Properties.Resources.picOrderListGray;
            this.picOrderList.Location = new System.Drawing.Point(30, 26);
            this.picOrderList.Name = "picOrderList";
            this.picOrderList.Size = new System.Drawing.Size(20, 20);
            this.picOrderList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrderList.TabIndex = 1;
            this.picOrderList.TabStop = false;
            // 
            // picOrder
            // 
            this.picOrder.Image = global::GUI.Properties.Resources.picOrderGray;
            this.picOrder.Location = new System.Drawing.Point(30, 26);
            this.picOrder.Name = "picOrder";
            this.picOrder.Size = new System.Drawing.Size(20, 20);
            this.picOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrder.TabIndex = 1;
            this.picOrder.TabStop = false;
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
            this.picHome.Image = global::GUI.Properties.Resources.picHomeBlue;
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
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
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
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Location = new System.Drawing.Point(395, 24);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(974, 40);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(163)))), ((int)(((byte)(203)))));
            this.txtSearch.Location = new System.Drawing.Point(55, 13);
            this.txtSearch.MaxLength = 72;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(879, 15);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Tìm kiếm";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // picSearch
            // 
            this.picSearch.Image = global::GUI.Properties.Resources.Search;
            this.picSearch.Location = new System.Drawing.Point(29, 13);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(16, 16);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 0;
            this.picSearch.TabStop = false;
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
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlEditInformation);
            this.pnlMenu.Controls.Add(this.pnlOrderList);
            this.pnlMenu.Controls.Add(this.pnlOrder);
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
            // pnlEditInformation
            // 
            this.pnlEditInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlEditInformation.Controls.Add(this.lblEditInformation);
            this.pnlEditInformation.Controls.Add(this.picEditInformation);
            this.pnlEditInformation.Location = new System.Drawing.Point(5, 504);
            this.pnlEditInformation.Name = "pnlEditInformation";
            this.pnlEditInformation.Size = new System.Drawing.Size(226, 72);
            this.pnlEditInformation.TabIndex = 8;
            this.pnlEditInformation.Visible = false;
            // 
            // lblEditInformation
            // 
            this.lblEditInformation.AutoSize = true;
            this.lblEditInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblEditInformation.Location = new System.Drawing.Point(71, 27);
            this.lblEditInformation.Name = "lblEditInformation";
            this.lblEditInformation.Size = new System.Drawing.Size(101, 18);
            this.lblEditInformation.TabIndex = 2;
            this.lblEditInformation.Text = "Sửa thông tin";
            // 
            // picEditInformation
            // 
            this.picEditInformation.Image = global::GUI.Properties.Resources.picEditInformationGray;
            this.picEditInformation.Location = new System.Drawing.Point(30, 26);
            this.picEditInformation.Name = "picEditInformation";
            this.picEditInformation.Size = new System.Drawing.Size(20, 20);
            this.picEditInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEditInformation.TabIndex = 1;
            this.picEditInformation.TabStop = false;
            // 
            // pnlOrderList
            // 
            this.pnlOrderList.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrderList.Controls.Add(this.lblOrderList);
            this.pnlOrderList.Controls.Add(this.picOrderList);
            this.pnlOrderList.Location = new System.Drawing.Point(5, 432);
            this.pnlOrderList.Name = "pnlOrderList";
            this.pnlOrderList.Size = new System.Drawing.Size(226, 72);
            this.pnlOrderList.TabIndex = 7;
            this.pnlOrderList.Visible = false;
            // 
            // lblOrderList
            // 
            this.lblOrderList.AutoSize = true;
            this.lblOrderList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblOrderList.Location = new System.Drawing.Point(71, 27);
            this.lblOrderList.Name = "lblOrderList";
            this.lblOrderList.Size = new System.Drawing.Size(99, 18);
            this.lblOrderList.TabIndex = 2;
            this.lblOrderList.Text = "Hóa đơn bán";
            // 
            // picOrderList
            // 
            this.picOrderList.Image = global::GUI.Properties.Resources.picOrderListGray;
            this.picOrderList.Location = new System.Drawing.Point(30, 26);
            this.picOrderList.Name = "picOrderList";
            this.picOrderList.Size = new System.Drawing.Size(20, 20);
            this.picOrderList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrderList.TabIndex = 1;
            this.picOrderList.TabStop = false;
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrder.Controls.Add(this.lblOrder);
            this.pnlOrder.Controls.Add(this.picOrder);
            this.pnlOrder.Location = new System.Drawing.Point(5, 360);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(226, 72);
            this.pnlOrder.TabIndex = 6;
            this.pnlOrder.Visible = false;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.lblOrder.Location = new System.Drawing.Point(71, 27);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(67, 18);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Đặt món";
            // 
            // picOrder
            // 
            this.picOrder.Image = global::GUI.Properties.Resources.picOrderGray;
            this.picOrder.Location = new System.Drawing.Point(30, 26);
            this.picOrder.Name = "picOrder";
            this.picOrder.Size = new System.Drawing.Size(20, 20);
            this.picOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrder.TabIndex = 1;
            this.picOrder.TabStop = false;
            // 
            // pnlImport
            // 
            this.pnlImport.BackColor = System.Drawing.Color.Transparent;
            this.pnlImport.Controls.Add(this.lblImport);
            this.pnlImport.Controls.Add(this.picImport);
            this.pnlImport.Location = new System.Drawing.Point(5, 288);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(226, 72);
            this.pnlImport.TabIndex = 5;
            this.pnlImport.Visible = false;
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
            // pnlWarehouse
            // 
            this.pnlWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.pnlWarehouse.Controls.Add(this.lblWarehouse);
            this.pnlWarehouse.Controls.Add(this.picWarehouse);
            this.pnlWarehouse.Location = new System.Drawing.Point(5, 216);
            this.pnlWarehouse.Name = "pnlWarehouse";
            this.pnlWarehouse.Size = new System.Drawing.Size(226, 72);
            this.pnlWarehouse.TabIndex = 4;
            this.pnlWarehouse.Visible = false;
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
            // pnlFood
            // 
            this.pnlFood.BackColor = System.Drawing.Color.Transparent;
            this.pnlFood.Controls.Add(this.lblFood);
            this.pnlFood.Controls.Add(this.picFood);
            this.pnlFood.Location = new System.Drawing.Point(5, 144);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(226, 72);
            this.pnlFood.TabIndex = 4;
            this.pnlFood.Visible = false;
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
            // pnlEmployee
            // 
            this.pnlEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmployee.Controls.Add(this.lblEmployee);
            this.pnlEmployee.Controls.Add(this.picEmployee);
            this.pnlEmployee.Location = new System.Drawing.Point(5, 72);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(226, 72);
            this.pnlEmployee.TabIndex = 3;
            this.pnlEmployee.Visible = false;
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
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(96)))), ((int)(((byte)(255)))));
            this.lblHome.Location = new System.Drawing.Point(70, 27);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(75, 18);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "Trang chủ";
            // 
            // picHome
            // 
            this.picHome.Image = global::GUI.Properties.Resources.picHomeBlue;
            this.picHome.Location = new System.Drawing.Point(30, 26);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(20, 20);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
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
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
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
            this.pnlEditInformation.ResumeLayout(false);
            this.pnlEditInformation.PerformLayout();
            this.pnlOrderList.ResumeLayout(false);
            this.pnlOrderList.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            this.pnlWarehouse.ResumeLayout(false);
            this.pnlWarehouse.PerformLayout();
            this.pnlFood.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
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
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.PictureBox picOrder;
        private System.Windows.Forms.Panel pnlOrderList;
        private System.Windows.Forms.Label lblOrderList;
        private System.Windows.Forms.PictureBox picOrderList;
        private System.Windows.Forms.Panel pnlEditInformation;
        private System.Windows.Forms.Label lblEditInformation;
        private System.Windows.Forms.PictureBox picEditInformation;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

