namespace GUI
{
    partial class Warehouse_ListAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse_ListAll));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.pnOrdering = new System.Windows.Forms.Panel();
            this.odr_btnSortUpDown = new System.Windows.Forms.Button();
            this.odr_cbbChooseTable = new System.Windows.Forms.ComboBox();
            this.pnLocalSearchBar = new System.Windows.Forms.Panel();
            this.lsb_lbHint = new System.Windows.Forms.Label();
            this.lsb_txbSearchbox = new System.Windows.Forms.TextBox();
            this.pnTabDishCal = new System.Windows.Forms.Panel();
            this.pnTabListAll = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.lab7070Cube = new System.Windows.Forms.Panel();
            this.lbControlTitle = new System.Windows.Forms.Label();
            this.pnBackground.SuspendLayout();
            this.pnOrdering.SuspendLayout();
            this.pnLocalSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnBackground.Controls.Add(this.pnOrdering);
            this.pnBackground.Controls.Add(this.pnLocalSearchBar);
            this.pnBackground.Controls.Add(this.pnTabDishCal);
            this.pnBackground.Controls.Add(this.pnTabListAll);
            this.pnBackground.Controls.Add(this.dgvTable);
            this.pnBackground.Controls.Add(this.lab7070Cube);
            this.pnBackground.Controls.Add(this.lbControlTitle);
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1370, 815);
            this.pnBackground.TabIndex = 0;
            // 
            // pnOrdering
            // 
            this.pnOrdering.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnOrdering.BackgroundImage")));
            this.pnOrdering.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnOrdering.Controls.Add(this.odr_btnSortUpDown);
            this.pnOrdering.Controls.Add(this.odr_cbbChooseTable);
            this.pnOrdering.Location = new System.Drawing.Point(950, 14);
            this.pnOrdering.Name = "pnOrdering";
            this.pnOrdering.Size = new System.Drawing.Size(400, 42);
            this.pnOrdering.TabIndex = 6;
            // 
            // odr_btnSortUpDown
            // 
            this.odr_btnSortUpDown.BackgroundImage = global::GUI.Properties.Resources.sortSmaller;
            this.odr_btnSortUpDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.odr_btnSortUpDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.odr_btnSortUpDown.FlatAppearance.BorderSize = 0;
            this.odr_btnSortUpDown.Location = new System.Drawing.Point(363, 6);
            this.odr_btnSortUpDown.Name = "odr_btnSortUpDown";
            this.odr_btnSortUpDown.Size = new System.Drawing.Size(30, 30);
            this.odr_btnSortUpDown.TabIndex = 1;
            this.odr_btnSortUpDown.Tag = "nowSortBigger";
            this.odr_btnSortUpDown.UseVisualStyleBackColor = true;
            this.odr_btnSortUpDown.Click += new System.EventHandler(this.odr_btnSortUpDown_Click);
            // 
            // odr_cbbChooseTable
            // 
            this.odr_cbbChooseTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odr_cbbChooseTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odr_cbbChooseTable.FormattingEnabled = true;
            this.odr_cbbChooseTable.Location = new System.Drawing.Point(45, 7);
            this.odr_cbbChooseTable.Name = "odr_cbbChooseTable";
            this.odr_cbbChooseTable.Size = new System.Drawing.Size(310, 29);
            this.odr_cbbChooseTable.TabIndex = 0;
            this.odr_cbbChooseTable.Text = "Chọn bảng";
            // 
            // pnLocalSearchBar
            // 
            this.pnLocalSearchBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLocalSearchBar.BackgroundImage")));
            this.pnLocalSearchBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLocalSearchBar.Controls.Add(this.lsb_lbHint);
            this.pnLocalSearchBar.Controls.Add(this.lsb_txbSearchbox);
            this.pnLocalSearchBar.Location = new System.Drawing.Point(27, 14);
            this.pnLocalSearchBar.Name = "pnLocalSearchBar";
            this.pnLocalSearchBar.Size = new System.Drawing.Size(400, 42);
            this.pnLocalSearchBar.TabIndex = 5;
            this.pnLocalSearchBar.Click += new System.EventHandler(this.pnLocalSearchBar_Click);
            // 
            // lsb_lbHint
            // 
            this.lsb_lbHint.AutoSize = true;
            this.lsb_lbHint.BackColor = System.Drawing.Color.Transparent;
            this.lsb_lbHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_lbHint.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lsb_lbHint.Location = new System.Drawing.Point(45, 11);
            this.lsb_lbHint.Name = "lsb_lbHint";
            this.lsb_lbHint.Size = new System.Drawing.Size(91, 21);
            this.lsb_lbHint.TabIndex = 7;
            this.lsb_lbHint.Text = "placeholder";
            this.lsb_lbHint.Click += new System.EventHandler(this.lsb_lbHint_Click);
            // 
            // lsb_txbSearchbox
            // 
            this.lsb_txbSearchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsb_txbSearchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsb_txbSearchbox.Location = new System.Drawing.Point(45, 11);
            this.lsb_txbSearchbox.Name = "lsb_txbSearchbox";
            this.lsb_txbSearchbox.Size = new System.Drawing.Size(340, 22);
            this.lsb_txbSearchbox.TabIndex = 0;
            this.lsb_txbSearchbox.Enter += new System.EventHandler(this.lsb_txbSearchbox_Enter);
            this.lsb_txbSearchbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsb_txbSearchbox_KeyDown);
            this.lsb_txbSearchbox.Leave += new System.EventHandler(this.lsb_txbSearchbox_Leave);
            // 
            // pnTabDishCal
            // 
            this.pnTabDishCal.BackColor = System.Drawing.Color.Transparent;
            this.pnTabDishCal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTabDishCal.BackgroundImage")));
            this.pnTabDishCal.Location = new System.Drawing.Point(81, 767);
            this.pnTabDishCal.Name = "pnTabDishCal";
            this.pnTabDishCal.Size = new System.Drawing.Size(48, 48);
            this.pnTabDishCal.TabIndex = 4;
            this.pnTabDishCal.Click += new System.EventHandler(this.pnTabDishCal_Click);
            // 
            // pnTabListAll
            // 
            this.pnTabListAll.BackColor = System.Drawing.Color.Transparent;
            this.pnTabListAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnTabListAll.BackgroundImage")));
            this.pnTabListAll.Location = new System.Drawing.Point(27, 767);
            this.pnTabListAll.Name = "pnTabListAll";
            this.pnTabListAll.Size = new System.Drawing.Size(48, 48);
            this.pnTabListAll.TabIndex = 3;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.ColumnHeadersHeight = 48;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.Location = new System.Drawing.Point(0, 70);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowTemplate.Height = 48;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTable.Size = new System.Drawing.Size(1370, 675);
            this.dgvTable.TabIndex = 2;
            this.dgvTable.SelectionChanged += new System.EventHandler(this.dgvTable_SelectionChanged);
            // 
            // lab7070Cube
            // 
            this.lab7070Cube.BackColor = System.Drawing.Color.Fuchsia;
            this.lab7070Cube.Location = new System.Drawing.Point(1194, 745);
            this.lab7070Cube.Name = "lab7070Cube";
            this.lab7070Cube.Size = new System.Drawing.Size(70, 70);
            this.lab7070Cube.TabIndex = 1;
            this.lab7070Cube.Visible = false;
            // 
            // lbControlTitle
            // 
            this.lbControlTitle.AutoSize = true;
            this.lbControlTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbControlTitle.Location = new System.Drawing.Point(549, 767);
            this.lbControlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbControlTitle.Name = "lbControlTitle";
            this.lbControlTitle.Size = new System.Drawing.Size(273, 32);
            this.lbControlTitle.TabIndex = 0;
            this.lbControlTitle.Text = "Danh sách nguyên liệu";
            this.lbControlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Warehouse_ListAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Warehouse_ListAll";
            this.Text = "Warehouse_ListAll";
            this.Load += new System.EventHandler(this.Warehouse_ListAll_Load);
            this.pnBackground.ResumeLayout(false);
            this.pnBackground.PerformLayout();
            this.pnOrdering.ResumeLayout(false);
            this.pnLocalSearchBar.ResumeLayout(false);
            this.pnLocalSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Label lbControlTitle;
        private System.Windows.Forms.Panel lab7070Cube;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel pnTabListAll;
        private System.Windows.Forms.Panel pnTabDishCal;
        private System.Windows.Forms.Panel pnLocalSearchBar;
        private System.Windows.Forms.TextBox lsb_txbSearchbox;
        private System.Windows.Forms.Panel pnOrdering;
        private System.Windows.Forms.ComboBox odr_cbbChooseTable;
        private System.Windows.Forms.Button odr_btnSortUpDown;
        private System.Windows.Forms.Label lsb_lbHint;
    }
}