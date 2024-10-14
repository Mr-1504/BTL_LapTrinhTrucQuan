namespace GUI
{
    partial class frmOrderDetail
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
            this.pnlOrderDetail = new System.Windows.Forms.Panel();
            this.txtIdTable = new System.Windows.Forms.TextBox();
            this.lblSoBan = new System.Windows.Forms.Label();
            this.pnlNganCach = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblTimeOrder = new System.Windows.Forms.Label();
            this.lblIdOrder = new System.Windows.Forms.Label();
            this.btnSaveOrderDetail = new System.Windows.Forms.Button();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListFood = new System.Windows.Forms.DataGridView();
            this.cmbStatusOrder = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblThoiDiemTaoHD = new System.Windows.Forms.Label();
            this.lblHoaDonBan = new System.Windows.Forms.Label();
            this.lblChiTietHoaDon = new System.Windows.Forms.Label();
            this.btnBackToOrder = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlOrderDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrderDetail
            // 
            this.pnlOrderDetail.Controls.Add(this.txtIdTable);
            this.pnlOrderDetail.Controls.Add(this.lblSoBan);
            this.pnlOrderDetail.Controls.Add(this.pnlNganCach);
            this.pnlOrderDetail.Controls.Add(this.lblTotalPrice);
            this.pnlOrderDetail.Controls.Add(this.lblTongtien);
            this.pnlOrderDetail.Controls.Add(this.lblTimeOrder);
            this.pnlOrderDetail.Controls.Add(this.lblIdOrder);
            this.pnlOrderDetail.Controls.Add(this.btnSaveOrderDetail);
            this.pnlOrderDetail.Controls.Add(this.btnThemMonAn);
            this.pnlOrderDetail.Controls.Add(this.label1);
            this.pnlOrderDetail.Controls.Add(this.dgvListFood);
            this.pnlOrderDetail.Controls.Add(this.cmbStatusOrder);
            this.pnlOrderDetail.Controls.Add(this.lblTrangThai);
            this.pnlOrderDetail.Controls.Add(this.lblMaHoaDon);
            this.pnlOrderDetail.Controls.Add(this.lblThoiDiemTaoHD);
            this.pnlOrderDetail.Controls.Add(this.lblHoaDonBan);
            this.pnlOrderDetail.Location = new System.Drawing.Point(23, 87);
            this.pnlOrderDetail.Name = "pnlOrderDetail";
            this.pnlOrderDetail.Size = new System.Drawing.Size(1312, 706);
            this.pnlOrderDetail.TabIndex = 0;
            // 
            // txtIdTable
            // 
            this.txtIdTable.Location = new System.Drawing.Point(292, 236);
            this.txtIdTable.Name = "txtIdTable";
            this.txtIdTable.Size = new System.Drawing.Size(229, 20);
            this.txtIdTable.TabIndex = 15;
            // 
            // lblSoBan
            // 
            this.lblSoBan.AutoSize = true;
            this.lblSoBan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoBan.Location = new System.Drawing.Point(83, 238);
            this.lblSoBan.Name = "lblSoBan";
            this.lblSoBan.Size = new System.Drawing.Size(52, 16);
            this.lblSoBan.TabIndex = 14;
            this.lblSoBan.Text = "Bàn số:";
            // 
            // pnlNganCach
            // 
            this.pnlNganCach.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlNganCach.Location = new System.Drawing.Point(58, 287);
            this.pnlNganCach.Name = "pnlNganCach";
            this.pnlNganCach.Size = new System.Drawing.Size(464, 5);
            this.pnlNganCach.TabIndex = 13;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalPrice.Location = new System.Drawing.Point(293, 317);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(41, 16);
            this.lblTotalPrice.TabIndex = 12;
            this.lblTotalPrice.Text = "label2";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongtien.Location = new System.Drawing.Point(83, 314);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(64, 16);
            this.lblTongtien.TabIndex = 11;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // lblTimeOrder
            // 
            this.lblTimeOrder.AutoSize = true;
            this.lblTimeOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOrder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTimeOrder.Location = new System.Drawing.Point(287, 141);
            this.lblTimeOrder.Name = "lblTimeOrder";
            this.lblTimeOrder.Size = new System.Drawing.Size(41, 16);
            this.lblTimeOrder.TabIndex = 10;
            this.lblTimeOrder.Text = "label2";
            // 
            // lblIdOrder
            // 
            this.lblIdOrder.AutoSize = true;
            this.lblIdOrder.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOrder.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblIdOrder.Location = new System.Drawing.Point(287, 99);
            this.lblIdOrder.Name = "lblIdOrder";
            this.lblIdOrder.Size = new System.Drawing.Size(41, 16);
            this.lblIdOrder.TabIndex = 9;
            this.lblIdOrder.Text = "label2";
            // 
            // btnSaveOrderDetail
            // 
            this.btnSaveOrderDetail.FlatAppearance.BorderSize = 0;
            this.btnSaveOrderDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrderDetail.Image = global::GUI.Properties.Resources.btnSaveOrderDetail;
            this.btnSaveOrderDetail.Location = new System.Drawing.Point(156, 615);
            this.btnSaveOrderDetail.Name = "btnSaveOrderDetail";
            this.btnSaveOrderDetail.Size = new System.Drawing.Size(150, 60);
            this.btnSaveOrderDetail.TabIndex = 8;
            this.btnSaveOrderDetail.UseVisualStyleBackColor = true;
            this.btnSaveOrderDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSaveOrderDetail_Paint);
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.BackgroundImage = global::GUI.Properties.Resources.btnThem;
            this.btnThemMonAn.FlatAppearance.BorderSize = 0;
            this.btnThemMonAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMonAn.Location = new System.Drawing.Point(1165, 35);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(116, 41);
            this.btnThemMonAn.TabIndex = 7;
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            this.btnThemMonAn.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThemMonAn_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách món ăn";
            // 
            // dgvListFood
            // 
            this.dgvListFood.BackgroundColor = System.Drawing.Color.White;
            this.dgvListFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListFood.Location = new System.Drawing.Point(607, 82);
            this.dgvListFood.Name = "dgvListFood";
            this.dgvListFood.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvListFood.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListFood.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListFood.Size = new System.Drawing.Size(674, 584);
            this.dgvListFood.TabIndex = 5;
            // 
            // cmbStatusOrder
            // 
            this.cmbStatusOrder.FormattingEnabled = true;
            this.cmbStatusOrder.Location = new System.Drawing.Point(290, 188);
            this.cmbStatusOrder.Name = "cmbStatusOrder";
            this.cmbStatusOrder.Size = new System.Drawing.Size(232, 21);
            this.cmbStatusOrder.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Location = new System.Drawing.Point(83, 193);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(68, 16);
            this.lblTrangThai.TabIndex = 3;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(83, 99);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(81, 16);
            this.lblMaHoaDon.TabIndex = 2;
            this.lblMaHoaDon.Text = "Mã hóa đơn:";
            // 
            // lblThoiDiemTaoHD
            // 
            this.lblThoiDiemTaoHD.AutoSize = true;
            this.lblThoiDiemTaoHD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiDiemTaoHD.Location = new System.Drawing.Point(83, 138);
            this.lblThoiDiemTaoHD.Name = "lblThoiDiemTaoHD";
            this.lblThoiDiemTaoHD.Size = new System.Drawing.Size(143, 16);
            this.lblThoiDiemTaoHD.TabIndex = 1;
            this.lblThoiDiemTaoHD.Text = "Thời điểm tạo hóa đơn:";
            // 
            // lblHoaDonBan
            // 
            this.lblHoaDonBan.AutoSize = true;
            this.lblHoaDonBan.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDonBan.Location = new System.Drawing.Point(44, 49);
            this.lblHoaDonBan.Name = "lblHoaDonBan";
            this.lblHoaDonBan.Size = new System.Drawing.Size(129, 22);
            this.lblHoaDonBan.TabIndex = 0;
            this.lblHoaDonBan.Text = "Hóa đơn bán";
            // 
            // lblChiTietHoaDon
            // 
            this.lblChiTietHoaDon.AutoSize = true;
            this.lblChiTietHoaDon.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietHoaDon.Location = new System.Drawing.Point(104, 27);
            this.lblChiTietHoaDon.Name = "lblChiTietHoaDon";
            this.lblChiTietHoaDon.Size = new System.Drawing.Size(199, 29);
            this.lblChiTietHoaDon.TabIndex = 2;
            this.lblChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // btnBackToOrder
            // 
            this.btnBackToOrder.FlatAppearance.BorderSize = 0;
            this.btnBackToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOrder.Image = global::GUI.Properties.Resources.btnBackToOrders;
            this.btnBackToOrder.Location = new System.Drawing.Point(23, 27);
            this.btnBackToOrder.Name = "btnBackToOrder";
            this.btnBackToOrder.Size = new System.Drawing.Size(55, 35);
            this.btnBackToOrder.TabIndex = 1;
            this.btnBackToOrder.UseVisualStyleBackColor = true;
            this.btnBackToOrder.Click += new System.EventHandler(this.btnBackToOrder_Click);
            this.btnBackToOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBackToOrder_Paint);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.btnBackToOrder);
            this.pnlContent.Controls.Add(this.lblChiTietHoaDon);
            this.pnlContent.Controls.Add(this.pnlOrderDetail);
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1370, 815);
            this.pnlContent.TabIndex = 3;
            // 
            // frmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderDetail";
            this.Text = "frmOrderDetail";
            this.pnlOrderDetail.ResumeLayout(false);
            this.pnlOrderDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListFood)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrderDetail;
        private System.Windows.Forms.TextBox txtIdTable;
        private System.Windows.Forms.Label lblSoBan;
        private System.Windows.Forms.Panel pnlNganCach;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblTimeOrder;
        private System.Windows.Forms.Label lblIdOrder;
        private System.Windows.Forms.Button btnSaveOrderDetail;
        private System.Windows.Forms.Button btnThemMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListFood;
        private System.Windows.Forms.ComboBox cmbStatusOrder;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblThoiDiemTaoHD;
        private System.Windows.Forms.Label lblHoaDonBan;
        private System.Windows.Forms.Label lblChiTietHoaDon;
        private System.Windows.Forms.Button btnBackToOrder;
        private System.Windows.Forms.Panel pnlContent;
    }
}