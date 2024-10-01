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
            this.pnBackground = new System.Windows.Forms.Panel();
            this.stbPrecalMenu = new System.Windows.Forms.Panel();
            this.stbListAll = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbControlTitle = new System.Windows.Forms.Label();
            this.pnBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBackground
            // 
            this.pnBackground.BackColor = System.Drawing.SystemColors.Control;
            this.pnBackground.Controls.Add(this.stbPrecalMenu);
            this.pnBackground.Controls.Add(this.stbListAll);
            this.pnBackground.Controls.Add(this.dgvTable);
            this.pnBackground.Controls.Add(this.panel1);
            this.pnBackground.Controls.Add(this.lbControlTitle);
            this.pnBackground.Location = new System.Drawing.Point(0, 0);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(1370, 815);
            this.pnBackground.TabIndex = 0;
            // 
            // stbPrecalMenu
            // 
            this.stbPrecalMenu.BackColor = System.Drawing.Color.Transparent;
            this.stbPrecalMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stbPrecalMenu.BackgroundImage")));
            this.stbPrecalMenu.Location = new System.Drawing.Point(81, 767);
            this.stbPrecalMenu.Name = "stbPrecalMenu";
            this.stbPrecalMenu.Size = new System.Drawing.Size(48, 48);
            this.stbPrecalMenu.TabIndex = 4;
            // 
            // stbListAll
            // 
            this.stbListAll.BackColor = System.Drawing.Color.Transparent;
            this.stbListAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stbListAll.BackgroundImage")));
            this.stbListAll.Location = new System.Drawing.Point(27, 767);
            this.stbListAll.Name = "stbListAll";
            this.stbListAll.Size = new System.Drawing.Size(48, 48);
            this.stbListAll.TabIndex = 3;
            // 
            // dgvTable
            // 
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(0, 70);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.Size = new System.Drawing.Size(1370, 675);
            this.dgvTable.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Location = new System.Drawing.Point(1194, 745);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 70);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.Label lbControlTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel stbListAll;
        private System.Windows.Forms.Panel stbPrecalMenu;
    }
}