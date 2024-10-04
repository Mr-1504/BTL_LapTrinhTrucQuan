namespace GUI.PurchasedIngredient
{
    partial class InputDetail
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
            this.pnlList = new System.Windows.Forms.Panel();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPriceUnit = new System.Windows.Forms.Label();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.Transparent;
            this.pnlList.BackgroundImage = global::GUI.Properties.Resources.bgImport;
            this.pnlList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlList.Location = new System.Drawing.Point(692, 7);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(649, 611);
            this.pnlList.TabIndex = 6;
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlInformation.BackgroundImage = global::GUI.Properties.Resources.bgImport;
            this.pnlInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlInformation.Controls.Add(this.btnConfirm);
            this.pnlInformation.Controls.Add(this.btnReset);
            this.pnlInformation.Controls.Add(this.lblQuantity);
            this.pnlInformation.Controls.Add(this.lblUnit);
            this.pnlInformation.Controls.Add(this.lblPriceUnit);
            this.pnlInformation.Controls.Add(this.lblIngredientName);
            this.pnlInformation.Controls.Add(this.comboBox1);
            this.pnlInformation.Controls.Add(this.lblIngredient);
            this.pnlInformation.Controls.Add(this.cmbSupplierName);
            this.pnlInformation.Controls.Add(this.lblSupplierName);
            this.pnlInformation.Controls.Add(this.lblSupplier);
            this.pnlInformation.Location = new System.Drawing.Point(27, 7);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(649, 611);
            this.pnlInformation.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::GUI.Properties.Resources.bgResetInput;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(61, 529);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 50);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Đặt lại";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(67, 375);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 18);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(355, 259);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(54, 18);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "Đơn vị";
            // 
            // lblPriceUnit
            // 
            this.lblPriceUnit.AutoSize = true;
            this.lblPriceUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceUnit.Location = new System.Drawing.Point(67, 259);
            this.lblPriceUnit.Name = "lblPriceUnit";
            this.lblPriceUnit.Size = new System.Drawing.Size(103, 18);
            this.lblPriceUnit.TabIndex = 6;
            this.lblPriceUnit.Text = "Đơn giá nhập";
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientName.Location = new System.Drawing.Point(67, 170);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(115, 18);
            this.lblIngredientName.TabIndex = 5;
            this.lblIngredientName.Text = "Tên nguyên liệu";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(70, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(499, 32);
            this.comboBox1.TabIndex = 4;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.Location = new System.Drawing.Point(57, 134);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(228, 24);
            this.lblIngredient.TabIndex = 3;
            this.lblIngredient.Text = "Nguyên liệu nhập vào";
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.ItemHeight = 24;
            this.cmbSupplierName.Location = new System.Drawing.Point(169, 82);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(240, 32);
            this.cmbSupplierName.TabIndex = 2;
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(67, 87);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(81, 18);
            this.lblSupplierName.TabIndex = 1;
            this.lblSupplierName.Text = "Tên đơn vị";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(57, 41);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(177, 24);
            this.lblSupplier.TabIndex = 0;
            this.lblSupplier.Text = "Đơn vị cung cấp";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackgroundImage = global::GUI.Properties.Resources.btnConfirmInput;
            this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(458, 529);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(111, 50);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Đồng ý";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.MouseEnter += new System.EventHandler(this.btnConfirm_MouseEnter);
            this.btnConfirm.MouseLeave += new System.EventHandler(this.btnConfirm_MouseLeave);
            // 
            // InputDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlInformation);
            this.Name = "InputDetail";
            this.Size = new System.Drawing.Size(1369, 625);
            this.Load += new System.EventHandler(this.InputDetail_Load);
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblPriceUnit;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnConfirm;
    }
}
