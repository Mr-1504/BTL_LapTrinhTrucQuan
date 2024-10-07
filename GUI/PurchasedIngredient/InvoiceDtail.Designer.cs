namespace GUI.PurchasedIngredient
{
    partial class InvoiceDtail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierAddressValue = new System.Windows.Forms.Label();
            this.lblSupplierNameValue = new System.Windows.Forms.Label();
            this.lblCreateionTime = new System.Windows.Forms.Label();
            this.lblEmployeeInformation = new System.Windows.Forms.Label();
            this.lblBuyerNameValue = new System.Windows.Forms.Label();
            this.lblBuyerAddressValue = new System.Windows.Forms.Label();
            this.lblBuyerAddress = new System.Windows.Forms.Label();
            this.lblBuyerName = new System.Windows.Forms.Label();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(51, 8);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(210, 24);
            this.lblInvoice.TabIndex = 0;
            this.lblInvoice.Text = "Hóa đơn nhập hàng";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pnlTop.Location = new System.Drawing.Point(55, 129);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1258, 1);
            this.pnlTop.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pnlBottom.Location = new System.Drawing.Point(55, 299);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1258, 1);
            this.pnlBottom.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pnlLeft.Location = new System.Drawing.Point(451, 129);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(1, 170);
            this.pnlLeft.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.pnlRight.Location = new System.Drawing.Point(869, 129);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(1, 170);
            this.pnlRight.TabIndex = 4;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(52, 55);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(171, 18);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Thời điểm tạo hóa đơn:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(52, 92);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(147, 18);
            this.lblEmployee.TabIndex = 6;
            this.lblEmployee.Text = "Nhân viên phụ trách:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(77, 158);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(115, 19);
            this.lblSupplier.TabIndex = 7;
            this.lblSupplier.Text = "Bên cung cấp";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(106, 192);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(85, 18);
            this.lblSupplierName.TabIndex = 8;
            this.lblSupplierName.Text = "Tên đơn vị:";
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(106, 239);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(61, 18);
            this.lblSupplierAddress.TabIndex = 9;
            this.lblSupplierAddress.Text = "Địa chỉ:";
            // 
            // lblSupplierAddressValue
            // 
            this.lblSupplierAddressValue.AutoSize = true;
            this.lblSupplierAddressValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddressValue.Location = new System.Drawing.Point(173, 239);
            this.lblSupplierAddressValue.Name = "lblSupplierAddressValue";
            this.lblSupplierAddressValue.Size = new System.Drawing.Size(34, 18);
            this.lblSupplierAddressValue.TabIndex = 10;
            this.lblSupplierAddressValue.Text = "N/A";
            // 
            // lblSupplierNameValue
            // 
            this.lblSupplierNameValue.AutoSize = true;
            this.lblSupplierNameValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierNameValue.Location = new System.Drawing.Point(197, 192);
            this.lblSupplierNameValue.Name = "lblSupplierNameValue";
            this.lblSupplierNameValue.Size = new System.Drawing.Size(34, 18);
            this.lblSupplierNameValue.TabIndex = 11;
            this.lblSupplierNameValue.Text = "N/A";
            // 
            // lblCreateionTime
            // 
            this.lblCreateionTime.AutoSize = true;
            this.lblCreateionTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateionTime.Location = new System.Drawing.Point(229, 55);
            this.lblCreateionTime.Name = "lblCreateionTime";
            this.lblCreateionTime.Size = new System.Drawing.Size(34, 18);
            this.lblCreateionTime.TabIndex = 12;
            this.lblCreateionTime.Text = "N/A";
            // 
            // lblEmployeeInformation
            // 
            this.lblEmployeeInformation.AutoSize = true;
            this.lblEmployeeInformation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeInformation.Location = new System.Drawing.Point(205, 92);
            this.lblEmployeeInformation.Name = "lblEmployeeInformation";
            this.lblEmployeeInformation.Size = new System.Drawing.Size(34, 18);
            this.lblEmployeeInformation.TabIndex = 13;
            this.lblEmployeeInformation.Text = "N/A";
            // 
            // lblBuyerNameValue
            // 
            this.lblBuyerNameValue.AutoSize = true;
            this.lblBuyerNameValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerNameValue.Location = new System.Drawing.Point(1020, 192);
            this.lblBuyerNameValue.Name = "lblBuyerNameValue";
            this.lblBuyerNameValue.Size = new System.Drawing.Size(34, 18);
            this.lblBuyerNameValue.TabIndex = 18;
            this.lblBuyerNameValue.Text = "N/A";
            // 
            // lblBuyerAddressValue
            // 
            this.lblBuyerAddressValue.AutoSize = true;
            this.lblBuyerAddressValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerAddressValue.Location = new System.Drawing.Point(996, 239);
            this.lblBuyerAddressValue.Name = "lblBuyerAddressValue";
            this.lblBuyerAddressValue.Size = new System.Drawing.Size(34, 18);
            this.lblBuyerAddressValue.TabIndex = 17;
            this.lblBuyerAddressValue.Text = "N/A";
            // 
            // lblBuyerAddress
            // 
            this.lblBuyerAddress.AutoSize = true;
            this.lblBuyerAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerAddress.Location = new System.Drawing.Point(929, 239);
            this.lblBuyerAddress.Name = "lblBuyerAddress";
            this.lblBuyerAddress.Size = new System.Drawing.Size(61, 18);
            this.lblBuyerAddress.TabIndex = 16;
            this.lblBuyerAddress.Text = "Địa chỉ:";
            // 
            // lblBuyerName
            // 
            this.lblBuyerName.AutoSize = true;
            this.lblBuyerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerName.Location = new System.Drawing.Point(929, 192);
            this.lblBuyerName.Name = "lblBuyerName";
            this.lblBuyerName.Size = new System.Drawing.Size(85, 18);
            this.lblBuyerName.TabIndex = 15;
            this.lblBuyerName.Text = "Tên đơn vị:";
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyer.Location = new System.Drawing.Point(900, 158);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(83, 19);
            this.lblBuyer.TabIndex = 14;
            this.lblBuyer.Text = "Bên nhận";
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(78, 321);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(288, 18);
            this.lblAction.TabIndex = 19;
            this.lblAction.Text = "Thực hiện nhập hàng với chi tiết như sau";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(78, 562);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(152, 18);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Tổng trị giá hóa đơn:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.Red;
            this.lblTotalValue.Location = new System.Drawing.Point(236, 562);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(32, 18);
            this.lblTotalValue.TabIndex = 21;
            this.lblTotalValue.Text = "N/A";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUnit,
            this.colPriceUnit,
            this.colQuantity});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.dataGridView1.Location = new System.Drawing.Point(87, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // colName
            // 
            this.colName.Frozen = true;
            this.colName.HeaderText = "Tên nguyên liệu";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 416;
            // 
            // colUnit
            // 
            this.colUnit.Frozen = true;
            this.colUnit.HeaderText = "Đơn vị";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 206;
            // 
            // colPriceUnit
            // 
            this.colPriceUnit.Frozen = true;
            this.colPriceUnit.HeaderText = "Đơn giá nhập";
            this.colPriceUnit.Name = "colPriceUnit";
            this.colPriceUnit.ReadOnly = true;
            this.colPriceUnit.Width = 320;
            // 
            // colQuantity
            // 
            this.colQuantity.Frozen = true;
            this.colQuantity.HeaderText = "Số lượng nhập";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 312;
            // 
            // InvoiceDtail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblBuyerNameValue);
            this.Controls.Add(this.lblBuyerAddressValue);
            this.Controls.Add(this.lblBuyerAddress);
            this.Controls.Add(this.lblBuyerName);
            this.Controls.Add(this.lblBuyer);
            this.Controls.Add(this.lblEmployeeInformation);
            this.Controls.Add(this.lblCreateionTime);
            this.Controls.Add(this.lblSupplierNameValue);
            this.Controls.Add(this.lblSupplierAddressValue);
            this.Controls.Add(this.lblSupplierAddress);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblInvoice);
            this.DoubleBuffered = true;
            this.Name = "InvoiceDtail";
            this.Size = new System.Drawing.Size(1369, 625);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierAddressValue;
        private System.Windows.Forms.Label lblSupplierNameValue;
        private System.Windows.Forms.Label lblCreateionTime;
        private System.Windows.Forms.Label lblEmployeeInformation;
        private System.Windows.Forms.Label lblBuyerNameValue;
        private System.Windows.Forms.Label lblBuyerAddressValue;
        private System.Windows.Forms.Label lblBuyerAddress;
        private System.Windows.Forms.Label lblBuyerName;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    }
}
