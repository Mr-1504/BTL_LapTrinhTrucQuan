namespace GUI.Warehouse
{
    partial class Warehouse_ServingPrecal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse_ServingPrecal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnTabDishCal = new System.Windows.Forms.Panel();
            this.pnTabListAll = new System.Windows.Forms.Panel();
            this.lbControlTitle = new System.Windows.Forms.Label();
            this.pnMenuListing = new System.Windows.Forms.Panel();
            this.ml_Searchbar = new System.Windows.Forms.Panel();
            this.ml_scb_lbHint = new System.Windows.Forms.Label();
            this.ml_scb_txbSearchbox = new System.Windows.Forms.TextBox();
            this.ml_lbUsageHint = new System.Windows.Forms.Label();
            this.ml_dgvMenu = new System.Windows.Forms.DataGridView();
            this.pnPrecal = new System.Windows.Forms.Panel();
            this.pc_lbUsageHint = new System.Windows.Forms.Label();
            this.pc_dgvPrecal = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenLieuThieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_lbTitle = new System.Windows.Forms.Label();
            this.pnMenuListing.SuspendLayout();
            this.ml_Searchbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ml_dgvMenu)).BeginInit();
            this.pnPrecal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_dgvPrecal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Location = new System.Drawing.Point(230, 745);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 70);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // pnTabDishCal
            // 
            this.pnTabDishCal.BackColor = System.Drawing.Color.Transparent;
            this.pnTabDishCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTabDishCal.BackgroundImage")));
            this.pnTabDishCal.Location = new System.Drawing.Point(81, 767);
            this.pnTabDishCal.Name = "pnTabDishCal";
            this.pnTabDishCal.Size = new System.Drawing.Size(48, 48);
            this.pnTabDishCal.TabIndex = 6;
            // 
            // pnTabListAll
            // 
            this.pnTabListAll.BackColor = System.Drawing.Color.Transparent;
            this.pnTabListAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTabListAll.BackgroundImage")));
            this.pnTabListAll.Location = new System.Drawing.Point(27, 767);
            this.pnTabListAll.Name = "pnTabListAll";
            this.pnTabListAll.Size = new System.Drawing.Size(48, 48);
            this.pnTabListAll.TabIndex = 5;
            this.pnTabListAll.Click += new System.EventHandler(this.pnTabListAll_Click);
            // 
            // lbControlTitle
            // 
            this.lbControlTitle.AutoSize = true;
            this.lbControlTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbControlTitle.Location = new System.Drawing.Point(586, 767);
            this.lbControlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbControlTitle.Name = "lbControlTitle";
            this.lbControlTitle.Size = new System.Drawing.Size(198, 32);
            this.lbControlTitle.TabIndex = 1;
            this.lbControlTitle.Text = "Dự tính phục vụ";
            this.lbControlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMenuListing
            // 
            this.pnMenuListing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMenuListing.BackgroundImage")));
            this.pnMenuListing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMenuListing.Controls.Add(this.ml_Searchbar);
            this.pnMenuListing.Controls.Add(this.ml_lbUsageHint);
            this.pnMenuListing.Controls.Add(this.ml_dgvMenu);
            this.pnMenuListing.Location = new System.Drawing.Point(27, 30);
            this.pnMenuListing.Name = "pnMenuListing";
            this.pnMenuListing.Size = new System.Drawing.Size(480, 715);
            this.pnMenuListing.TabIndex = 7;
            // 
            // ml_Searchbar
            // 
            this.ml_Searchbar.BackColor = System.Drawing.Color.Transparent;
            this.ml_Searchbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ml_Searchbar.BackgroundImage")));
            this.ml_Searchbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ml_Searchbar.Controls.Add(this.ml_scb_lbHint);
            this.ml_Searchbar.Controls.Add(this.ml_scb_txbSearchbox);
            this.ml_Searchbar.Location = new System.Drawing.Point(30, 20);
            this.ml_Searchbar.Name = "ml_Searchbar";
            this.ml_Searchbar.Size = new System.Drawing.Size(421, 42);
            this.ml_Searchbar.TabIndex = 10;
            this.ml_Searchbar.Click += new System.EventHandler(this.ml_Searchbar_Click);
            // 
            // ml_scb_lbHint
            // 
            this.ml_scb_lbHint.AutoSize = true;
            this.ml_scb_lbHint.BackColor = System.Drawing.Color.Transparent;
            this.ml_scb_lbHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ml_scb_lbHint.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ml_scb_lbHint.Location = new System.Drawing.Point(45, 11);
            this.ml_scb_lbHint.Name = "ml_scb_lbHint";
            this.ml_scb_lbHint.Size = new System.Drawing.Size(74, 21);
            this.ml_scb_lbHint.TabIndex = 7;
            this.ml_scb_lbHint.Text = "Tìm kiếm";
            this.ml_scb_lbHint.Click += new System.EventHandler(this.ml_scb_lbHint_Click);
            // 
            // ml_scb_txbSearchbox
            // 
            this.ml_scb_txbSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ml_scb_txbSearchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ml_scb_txbSearchbox.Location = new System.Drawing.Point(45, 11);
            this.ml_scb_txbSearchbox.Name = "ml_scb_txbSearchbox";
            this.ml_scb_txbSearchbox.Size = new System.Drawing.Size(361, 22);
            this.ml_scb_txbSearchbox.TabIndex = 0;
            this.ml_scb_txbSearchbox.TextChanged += new System.EventHandler(this.ml_scb_txbSearchbox_TextChanged);
            this.ml_scb_txbSearchbox.Enter += new System.EventHandler(this.ml_scb_txbSearchbox_Enter);
            this.ml_scb_txbSearchbox.Leave += new System.EventHandler(this.ml_scb_txbSearchbox_Leave);
            // 
            // ml_lbUsageHint
            // 
            this.ml_lbUsageHint.AutoSize = true;
            this.ml_lbUsageHint.BackColor = System.Drawing.Color.Transparent;
            this.ml_lbUsageHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ml_lbUsageHint.Location = new System.Drawing.Point(27, 679);
            this.ml_lbUsageHint.Name = "ml_lbUsageHint";
            this.ml_lbUsageHint.Size = new System.Drawing.Size(246, 13);
            this.ml_lbUsageHint.TabIndex = 9;
            this.ml_lbUsageHint.Text = "ⓘ Nhấp đôi chuột để thêm món vào bảng tính";
            // 
            // ml_dgvMenu
            // 
            this.ml_dgvMenu.AllowUserToAddRows = false;
            this.ml_dgvMenu.AllowUserToDeleteRows = false;
            this.ml_dgvMenu.AllowUserToResizeColumns = false;
            this.ml_dgvMenu.AllowUserToResizeRows = false;
            this.ml_dgvMenu.BackgroundColor = System.Drawing.Color.White;
            this.ml_dgvMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ml_dgvMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ml_dgvMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ml_dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ml_dgvMenu.ColumnHeadersHeight = 38;
            this.ml_dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ml_dgvMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.ml_dgvMenu.Location = new System.Drawing.Point(30, 81);
            this.ml_dgvMenu.MultiSelect = false;
            this.ml_dgvMenu.Name = "ml_dgvMenu";
            this.ml_dgvMenu.ReadOnly = true;
            this.ml_dgvMenu.RowHeadersVisible = false;
            this.ml_dgvMenu.RowTemplate.Height = 32;
            this.ml_dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ml_dgvMenu.Size = new System.Drawing.Size(421, 579);
            this.ml_dgvMenu.TabIndex = 8;
            this.ml_dgvMenu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ml_dgvMenu_CellDoubleClick);
            // 
            // pnPrecal
            // 
            this.pnPrecal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnPrecal.BackgroundImage")));
            this.pnPrecal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnPrecal.Controls.Add(this.pc_lbUsageHint);
            this.pnPrecal.Controls.Add(this.pc_dgvPrecal);
            this.pnPrecal.Controls.Add(this.pc_lbTitle);
            this.pnPrecal.Location = new System.Drawing.Point(520, 30);
            this.pnPrecal.Name = "pnPrecal";
            this.pnPrecal.Size = new System.Drawing.Size(820, 715);
            this.pnPrecal.TabIndex = 8;
            // 
            // pc_lbUsageHint
            // 
            this.pc_lbUsageHint.AutoSize = true;
            this.pc_lbUsageHint.BackColor = System.Drawing.Color.Transparent;
            this.pc_lbUsageHint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_lbUsageHint.Location = new System.Drawing.Point(23, 679);
            this.pc_lbUsageHint.Name = "pc_lbUsageHint";
            this.pc_lbUsageHint.Size = new System.Drawing.Size(243, 13);
            this.pc_lbUsageHint.TabIndex = 10;
            this.pc_lbUsageHint.Text = "ⓘ Nhấp đôi chuột để xoá món khỏi bảng tính";
            // 
            // pc_dgvPrecal
            // 
            this.pc_dgvPrecal.AllowUserToAddRows = false;
            this.pc_dgvPrecal.AllowUserToDeleteRows = false;
            this.pc_dgvPrecal.AllowUserToResizeColumns = false;
            this.pc_dgvPrecal.AllowUserToResizeRows = false;
            this.pc_dgvPrecal.BackgroundColor = System.Drawing.Color.White;
            this.pc_dgvPrecal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pc_dgvPrecal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pc_dgvPrecal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(228)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pc_dgvPrecal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pc_dgvPrecal.ColumnHeadersHeight = 38;
            this.pc_dgvPrecal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pc_dgvPrecal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.SoPhan,
            this.NguyenLieuThieu});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pc_dgvPrecal.DefaultCellStyle = dataGridViewCellStyle4;
            this.pc_dgvPrecal.Location = new System.Drawing.Point(26, 81);
            this.pc_dgvPrecal.MultiSelect = false;
            this.pc_dgvPrecal.Name = "pc_dgvPrecal";
            this.pc_dgvPrecal.ReadOnly = true;
            this.pc_dgvPrecal.RowHeadersVisible = false;
            this.pc_dgvPrecal.RowTemplate.Height = 32;
            this.pc_dgvPrecal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pc_dgvPrecal.Size = new System.Drawing.Size(770, 579);
            this.pc_dgvPrecal.TabIndex = 10;
            this.pc_dgvPrecal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pc_dgvPrecal_CellDoubleClick);
            // 
            // MaMonAn
            // 
            this.MaMonAn.HeaderText = "Mã món ăn";
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.ReadOnly = true;
            this.MaMonAn.Width = 193;
            // 
            // TenMonAn
            // 
            this.TenMonAn.HeaderText = "Tên món";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.ReadOnly = true;
            this.TenMonAn.Width = 192;
            // 
            // SoPhan
            // 
            this.SoPhan.HeaderText = "Số phần";
            this.SoPhan.Name = "SoPhan";
            this.SoPhan.ReadOnly = true;
            this.SoPhan.Width = 193;
            // 
            // NguyenLieuThieu
            // 
            this.NguyenLieuThieu.HeaderText = "Nguyên liệu thiếu";
            this.NguyenLieuThieu.Name = "NguyenLieuThieu";
            this.NguyenLieuThieu.ReadOnly = true;
            this.NguyenLieuThieu.Width = 192;
            // 
            // pc_lbTitle
            // 
            this.pc_lbTitle.AutoSize = true;
            this.pc_lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pc_lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_lbTitle.Location = new System.Drawing.Point(20, 25);
            this.pc_lbTitle.Name = "pc_lbTitle";
            this.pc_lbTitle.Size = new System.Drawing.Size(156, 32);
            this.pc_lbTitle.TabIndex = 10;
            this.pc_lbTitle.Text = "Bảng dự tính";
            // 
            // Warehouse_ServingPrecal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnPrecal);
            this.Controls.Add(this.pnMenuListing);
            this.Controls.Add(this.lbControlTitle);
            this.Controls.Add(this.pnTabDishCal);
            this.Controls.Add(this.pnTabListAll);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Warehouse_ServingPrecal";
            this.Text = "Warehouse_ServingPrecal";
            this.Load += new System.EventHandler(this.Warehouse_ServingPrecal_Load);
            this.pnMenuListing.ResumeLayout(false);
            this.pnMenuListing.PerformLayout();
            this.ml_Searchbar.ResumeLayout(false);
            this.ml_Searchbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ml_dgvMenu)).EndInit();
            this.pnPrecal.ResumeLayout(false);
            this.pnPrecal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_dgvPrecal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnTabDishCal;
        private System.Windows.Forms.Panel pnTabListAll;
        private System.Windows.Forms.Label lbControlTitle;
        private System.Windows.Forms.Panel pnMenuListing;
        private System.Windows.Forms.DataGridView ml_dgvMenu;
        private System.Windows.Forms.Label ml_lbUsageHint;
        private System.Windows.Forms.Panel pnPrecal;
        private System.Windows.Forms.Label pc_lbUsageHint;
        private System.Windows.Forms.DataGridView pc_dgvPrecal;
        private System.Windows.Forms.Label pc_lbTitle;
        private System.Windows.Forms.Panel ml_Searchbar;
        private System.Windows.Forms.Label ml_scb_lbHint;
        private System.Windows.Forms.TextBox ml_scb_txbSearchbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenLieuThieu;
    }
}