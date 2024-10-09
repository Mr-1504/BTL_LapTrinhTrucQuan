namespace GUI
{
    partial class frmListOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListOrders = new System.Windows.Forms.DataGridView();
            this.btnThemDonHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListOrders
            // 
            this.dgvListOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvListOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListOrders.Location = new System.Drawing.Point(36, 199);
            this.dgvListOrders.Name = "dgvListOrders";
            this.dgvListOrders.Size = new System.Drawing.Size(1274, 456);
            this.dgvListOrders.TabIndex = 0;
            this.dgvListOrders.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListOrders_CellPainting);
            // 
            // btnThemDonHang
            // 
            this.btnThemDonHang.BackgroundImage = global::GUI.Properties.Resources.btnThem;
            this.btnThemDonHang.FlatAppearance.BorderSize = 0;
            this.btnThemDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDonHang.Location = new System.Drawing.Point(1145, 137);
            this.btnThemDonHang.Name = "btnThemDonHang";
            this.btnThemDonHang.Size = new System.Drawing.Size(116, 41);
            this.btnThemDonHang.TabIndex = 1;
            this.btnThemDonHang.UseVisualStyleBackColor = true;
            this.btnThemDonHang.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThemDonHang_Paint);
            // 
            // frmListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.btnThemDonHang);
            this.Controls.Add(this.dgvListOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListOrders";
            this.Text = "frmListOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListOrders;
        private System.Windows.Forms.Button btnThemDonHang;
    }
}