namespace GUI.PurchasedIngredient
{
    partial class DetailInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblList = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuyerNameValue = new System.Windows.Forms.Label();
            this.lblBuyerAddressValue = new System.Windows.Forms.Label();
            this.lblSupplierAddressValue = new System.Windows.Forms.Label();
            this.lblSupplierNameValue = new System.Windows.Forms.Label();
            this.lblEmployeeValue = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::GUI.Properties.Resources.btnBack;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(59, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(141, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(264, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Chi tiết hóa đơn nhập";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlContent.Controls.Add(this.lblTotalValue);
            this.pnlContent.Controls.Add(this.lblTotal);
            this.pnlContent.Controls.Add(this.lblList);
            this.pnlContent.Controls.Add(this.dgvList);
            this.pnlContent.Controls.Add(this.lblBuyerNameValue);
            this.pnlContent.Controls.Add(this.lblBuyerAddressValue);
            this.pnlContent.Controls.Add(this.lblSupplierAddressValue);
            this.pnlContent.Controls.Add(this.lblSupplierNameValue);
            this.pnlContent.Controls.Add(this.lblEmployeeValue);
            this.pnlContent.Controls.Add(this.lblTimeValue);
            this.pnlContent.Controls.Add(this.pnlLine2);
            this.pnlContent.Controls.Add(this.lblAddress);
            this.pnlContent.Controls.Add(this.lblName);
            this.pnlContent.Controls.Add(this.lblCustomer);
            this.pnlContent.Controls.Add(this.lblSupplierAddress);
            this.pnlContent.Controls.Add(this.pnlLine1);
            this.pnlContent.Controls.Add(this.lblSupplierName);
            this.pnlContent.Controls.Add(this.lblSupplier);
            this.pnlContent.Controls.Add(this.lblEmployee);
            this.pnlContent.Controls.Add(this.lblTime);
            this.pnlContent.Controls.Add(this.lblInvoice);
            this.pnlContent.Location = new System.Drawing.Point(28, 88);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1312, 695);
            this.pnlContent.TabIndex = 2;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(553, 21);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(232, 24);
            this.lblList.TabIndex = 22;
            this.lblList.Text = "Danh sách hàng nhập";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList.ColumnHeadersHeight = 40;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUnit,
            this.colPriceUnit,
            this.colQuantity});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.Enabled = false;
            this.dgvList.Location = new System.Drawing.Point(553, 61);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.RowTemplate.Height = 38;
            this.dgvList.RowTemplate.ReadOnly = true;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(725, 580);
            this.dgvList.TabIndex = 21;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Tên nguyên liệu";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 250;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "Đơn vị";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // colPriceUnit
            // 
            this.colPriceUnit.DataPropertyName = "PriceUnit";
            this.colPriceUnit.HeaderText = "Đơn giá";
            this.colPriceUnit.Name = "colPriceUnit";
            this.colPriceUnit.ReadOnly = true;
            this.colPriceUnit.Width = 175;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 175;
            // 
            // lblBuyerNameValue
            // 
            this.lblBuyerNameValue.AutoSize = true;
            this.lblBuyerNameValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerNameValue.Location = new System.Drawing.Point(144, 419);
            this.lblBuyerNameValue.Name = "lblBuyerNameValue";
            this.lblBuyerNameValue.Size = new System.Drawing.Size(149, 18);
            this.lblBuyerNameValue.TabIndex = 20;
            this.lblBuyerNameValue.Text = "Nhà hàng BeA Food";
            // 
            // lblBuyerAddressValue
            // 
            this.lblBuyerAddressValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerAddressValue.Location = new System.Drawing.Point(120, 468);
            this.lblBuyerAddressValue.Name = "lblBuyerAddressValue";
            this.lblBuyerAddressValue.Size = new System.Drawing.Size(296, 47);
            this.lblBuyerAddressValue.TabIndex = 19;
            this.lblBuyerAddressValue.Text = "One Apple Park Way, Cupertino, CA 95014, Hoa Kỳ";
            // 
            // lblSupplierAddressValue
            // 
            this.lblSupplierAddressValue.AutoSize = true;
            this.lblSupplierAddressValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddressValue.Location = new System.Drawing.Point(121, 280);
            this.lblSupplierAddressValue.Name = "lblSupplierAddressValue";
            this.lblSupplierAddressValue.Size = new System.Drawing.Size(34, 18);
            this.lblSupplierAddressValue.TabIndex = 16;
            this.lblSupplierAddressValue.Text = "N/A";
            // 
            // lblSupplierNameValue
            // 
            this.lblSupplierNameValue.AutoSize = true;
            this.lblSupplierNameValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierNameValue.Location = new System.Drawing.Point(145, 231);
            this.lblSupplierNameValue.Name = "lblSupplierNameValue";
            this.lblSupplierNameValue.Size = new System.Drawing.Size(34, 18);
            this.lblSupplierNameValue.TabIndex = 15;
            this.lblSupplierNameValue.Text = "N/A";
            // 
            // lblEmployeeValue
            // 
            this.lblEmployeeValue.AutoSize = true;
            this.lblEmployeeValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeValue.Location = new System.Drawing.Point(207, 97);
            this.lblEmployeeValue.Name = "lblEmployeeValue";
            this.lblEmployeeValue.Size = new System.Drawing.Size(34, 18);
            this.lblEmployeeValue.TabIndex = 14;
            this.lblEmployeeValue.Text = "N/A";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeValue.Location = new System.Drawing.Point(231, 61);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(34, 18);
            this.lblTimeValue.TabIndex = 13;
            this.lblTimeValue.Text = "N/A";
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.pnlLine2.Location = new System.Drawing.Point(31, 333);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(473, 1);
            this.pnlLine2.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(53, 468);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 18);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(53, 419);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 18);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Tên đơn vị:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(26, 379);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(164, 24);
            this.lblCustomer.TabIndex = 10;
            this.lblCustomer.Text = "Bên nhận hàng";
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(54, 280);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(61, 18);
            this.lblSupplierAddress.TabIndex = 9;
            this.lblSupplierAddress.Text = "Địa chỉ:";
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.pnlLine1.Location = new System.Drawing.Point(30, 142);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(473, 1);
            this.pnlLine1.TabIndex = 8;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(54, 231);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(85, 18);
            this.lblSupplierName.TabIndex = 7;
            this.lblSupplierName.Text = "Tên đơn vị:";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(27, 191);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(150, 24);
            this.lblSupplier.TabIndex = 6;
            this.lblSupplier.Text = "Bên cung cấp";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(54, 97);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(147, 18);
            this.lblEmployee.TabIndex = 5;
            this.lblEmployee.Text = "Nhân viên phụ trách:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(54, 61);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(171, 18);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Thời điểm tạo hóa đơn:";
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(26, 21);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(153, 24);
            this.lblInvoice.TabIndex = 3;
            this.lblInvoice.Text = "Hóa đơn nhập";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.Red;
            this.lblTotalValue.Location = new System.Drawing.Point(28, 600);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(509, 54);
            this.lblTotalValue.TabIndex = 24;
            this.lblTotalValue.Text = "N/A";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(28, 563);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(152, 18);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Tổng trị giá hóa đơn:";
            // 
            // DetailInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "DetailInvoice";
            this.Size = new System.Drawing.Size(1369, 814);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblSupplierNameValue;
        private System.Windows.Forms.Label lblEmployeeValue;
        private System.Windows.Forms.Label lblSupplierAddressValue;
        private System.Windows.Forms.Label lblBuyerNameValue;
        private System.Windows.Forms.Label lblBuyerAddressValue;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
    }
}
