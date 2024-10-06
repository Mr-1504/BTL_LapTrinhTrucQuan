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
            this.ml_lbUsageHint = new System.Windows.Forms.Label();
            this.ml_dgvMenu = new System.Windows.Forms.DataGridView();
            this.ml_lbTitle = new System.Windows.Forms.Label();
            this.pnPrecal = new System.Windows.Forms.Panel();
            this.pc_lbUsageHint = new System.Windows.Forms.Label();
            this.pc_dgvPrecal = new System.Windows.Forms.DataGridView();
            this.pc_lbTitle = new System.Windows.Forms.Label();
            this.pnMenuListing.SuspendLayout();
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
            this.pnMenuListing.Controls.Add(this.ml_lbUsageHint);
            this.pnMenuListing.Controls.Add(this.ml_dgvMenu);
            this.pnMenuListing.Controls.Add(this.ml_lbTitle);
            this.pnMenuListing.Location = new System.Drawing.Point(27, 30);
            this.pnMenuListing.Name = "pnMenuListing";
            this.pnMenuListing.Size = new System.Drawing.Size(480, 715);
            this.pnMenuListing.TabIndex = 7;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ml_dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ml_dgvMenu.ColumnHeadersHeight = 32;
            this.ml_dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ml_dgvMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.ml_dgvMenu.Location = new System.Drawing.Point(5, 70);
            this.ml_dgvMenu.MultiSelect = false;
            this.ml_dgvMenu.Name = "ml_dgvMenu";
            this.ml_dgvMenu.ReadOnly = true;
            this.ml_dgvMenu.RowTemplate.Height = 32;
            this.ml_dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ml_dgvMenu.Size = new System.Drawing.Size(470, 590);
            this.ml_dgvMenu.TabIndex = 8;
            // 
            // ml_lbTitle
            // 
            this.ml_lbTitle.AutoSize = true;
            this.ml_lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.ml_lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ml_lbTitle.Location = new System.Drawing.Point(20, 20);
            this.ml_lbTitle.Name = "ml_lbTitle";
            this.ml_lbTitle.Size = new System.Drawing.Size(217, 32);
            this.ml_lbTitle.TabIndex = 0;
            this.ml_lbTitle.Text = "Danh sách món ăn";
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
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pc_dgvPrecal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pc_dgvPrecal.ColumnHeadersHeight = 32;
            this.pc_dgvPrecal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pc_dgvPrecal.DefaultCellStyle = dataGridViewCellStyle4;
            this.pc_dgvPrecal.Location = new System.Drawing.Point(5, 70);
            this.pc_dgvPrecal.MultiSelect = false;
            this.pc_dgvPrecal.Name = "pc_dgvPrecal";
            this.pc_dgvPrecal.ReadOnly = true;
            this.pc_dgvPrecal.RowTemplate.Height = 32;
            this.pc_dgvPrecal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.pc_dgvPrecal.Size = new System.Drawing.Size(810, 590);
            this.pc_dgvPrecal.TabIndex = 10;
            // 
            // pc_lbTitle
            // 
            this.pc_lbTitle.AutoSize = true;
            this.pc_lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.pc_lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_lbTitle.Location = new System.Drawing.Point(20, 20);
            this.pc_lbTitle.Name = "pc_lbTitle";
            this.pc_lbTitle.Size = new System.Drawing.Size(156, 32);
            this.pc_lbTitle.TabIndex = 10;
            this.pc_lbTitle.Text = "Bảng dự tính";
            // 
            // Warehouse_ServingPrecal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnPrecal);
            this.Controls.Add(this.pnMenuListing);
            this.Controls.Add(this.lbControlTitle);
            this.Controls.Add(this.pnTabDishCal);
            this.Controls.Add(this.pnTabListAll);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Warehouse_ServingPrecal";
            this.Text = "Warehouse_ServingPrecal";
            this.pnMenuListing.ResumeLayout(false);
            this.pnMenuListing.PerformLayout();
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
        private System.Windows.Forms.Label ml_lbTitle;
        private System.Windows.Forms.DataGridView ml_dgvMenu;
        private System.Windows.Forms.Label ml_lbUsageHint;
        private System.Windows.Forms.Panel pnPrecal;
        private System.Windows.Forms.Label pc_lbUsageHint;
        private System.Windows.Forms.DataGridView pc_dgvPrecal;
        private System.Windows.Forms.Label pc_lbTitle;
    }
}