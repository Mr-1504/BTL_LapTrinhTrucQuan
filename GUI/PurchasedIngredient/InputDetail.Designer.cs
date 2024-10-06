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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlList = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblList = new System.Windows.Forms.Label();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlIngredient = new System.Windows.Forms.Panel();
            this.cmbIngredientName = new System.Windows.Forms.ComboBox();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.pnlUnit = new System.Windows.Forms.Panel();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.pnlPriceUnit = new System.Windows.Forms.Panel();
            this.txtPriceUnit = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblPriceUnit = new System.Windows.Forms.Label();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.pnlList.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlInformation.SuspendLayout();
            this.pnlIngredient.SuspendLayout();
            this.pnlSupplier.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlUnit.SuspendLayout();
            this.pnlPriceUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.Transparent;
            this.pnlList.BackgroundImage = global::GUI.Properties.Resources.bgImport;
            this.pnlList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlList.Controls.Add(this.panel2);
            this.pnlList.Controls.Add(this.lblList);
            this.pnlList.Location = new System.Drawing.Point(692, 7);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(649, 611);
            this.pnlList.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GUI.Properties.Resources.ListIngrdient;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.dgvList);
            this.panel2.Location = new System.Drawing.Point(40, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 487);
            this.panel2.TabIndex = 18;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeight = 45;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colUnit,
            this.colPriceUnit,
            this.colQuantity});
            this.dgvList.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.GridColor = System.Drawing.Color.White;
            this.dgvList.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 50;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(569, 487);
            this.dgvList.TabIndex = 19;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên nguyên liệu";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 187;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Đơn vị";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUnit.Width = 94;
            // 
            // colPriceUnit
            // 
            this.colPriceUnit.HeaderText = "Đơn giá";
            this.colPriceUnit.Name = "colPriceUnit";
            this.colPriceUnit.ReadOnly = true;
            this.colPriceUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colPriceUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colPriceUnit.Width = 145;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.colQuantity.Width = 143;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(36, 41);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(206, 24);
            this.lblList.TabIndex = 17;
            this.lblList.Text = "Danh sách đã nhập";
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.Transparent;
            this.pnlInformation.BackgroundImage = global::GUI.Properties.Resources.bgImport;
            this.pnlInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlInformation.Controls.Add(this.pnlIngredient);
            this.pnlInformation.Controls.Add(this.pnlSupplier);
            this.pnlInformation.Controls.Add(this.panel1);
            this.pnlInformation.Controls.Add(this.pnlUnit);
            this.pnlInformation.Controls.Add(this.pnlPriceUnit);
            this.pnlInformation.Controls.Add(this.btnConfirm);
            this.pnlInformation.Controls.Add(this.btnReset);
            this.pnlInformation.Controls.Add(this.lblQuantity);
            this.pnlInformation.Controls.Add(this.lblUnit);
            this.pnlInformation.Controls.Add(this.lblPriceUnit);
            this.pnlInformation.Controls.Add(this.lblIngredientName);
            this.pnlInformation.Controls.Add(this.lblIngredient);
            this.pnlInformation.Controls.Add(this.lblSupplierName);
            this.pnlInformation.Controls.Add(this.lblSupplier);
            this.pnlInformation.Location = new System.Drawing.Point(27, 7);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(649, 611);
            this.pnlInformation.TabIndex = 5;
            // 
            // pnlIngredient
            // 
            this.pnlIngredient.BackgroundImage = global::GUI.Properties.Resources.cmbIngredientImput;
            this.pnlIngredient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlIngredient.Controls.Add(this.cmbIngredientName);
            this.pnlIngredient.Location = new System.Drawing.Point(70, 221);
            this.pnlIngredient.Name = "pnlIngredient";
            this.pnlIngredient.Size = new System.Drawing.Size(528, 39);
            this.pnlIngredient.TabIndex = 16;
            // 
            // cmbIngredientName
            // 
            this.cmbIngredientName.DropDownHeight = 95;
            this.cmbIngredientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIngredientName.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIngredientName.FormattingEnabled = true;
            this.cmbIngredientName.IntegralHeight = false;
            this.cmbIngredientName.ItemHeight = 19;
            this.cmbIngredientName.Location = new System.Drawing.Point(11, 6);
            this.cmbIngredientName.Name = "cmbIngredientName";
            this.cmbIngredientName.Size = new System.Drawing.Size(505, 27);
            this.cmbIngredientName.TabIndex = 4;
            this.cmbIngredientName.SelectedIndexChanged += new System.EventHandler(this.cmbIngredientName_SelectedIndexChanged);
            this.cmbIngredientName.TextUpdate += new System.EventHandler(this.cmbIngredientName_TextUpdate);
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.BackgroundImage = global::GUI.Properties.Resources.cmbSupplierName;
            this.pnlSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSupplier.Controls.Add(this.cmbSupplierName);
            this.pnlSupplier.Location = new System.Drawing.Point(167, 77);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(430, 39);
            this.pnlSupplier.TabIndex = 15;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.DropDownHeight = 95;
            this.cmbSupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplierName.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.IntegralHeight = false;
            this.cmbSupplierName.ItemHeight = 19;
            this.cmbSupplierName.Location = new System.Drawing.Point(15, 6);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(401, 27);
            this.cmbSupplierName.TabIndex = 2;
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            this.cmbSupplierName.TextUpdate += new System.EventHandler(this.cmbSupplierName_TextUpdate);
            this.cmbSupplierName.Leave += new System.EventHandler(this.cmbSupplierName_Leave);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI.Properties.Resources.bgQuantityIngredientInput;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Location = new System.Drawing.Point(70, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 39);
            this.panel1.TabIndex = 14;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(12, 9);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(505, 20);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // pnlUnit
            // 
            this.pnlUnit.BackgroundImage = global::GUI.Properties.Resources.pnltext;
            this.pnlUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlUnit.Controls.Add(this.txtUnit);
            this.pnlUnit.Location = new System.Drawing.Point(358, 312);
            this.pnlUnit.Name = "pnlUnit";
            this.pnlUnit.Size = new System.Drawing.Size(240, 39);
            this.pnlUnit.TabIndex = 14;
            // 
            // txtUnit
            // 
            this.txtUnit.BackColor = System.Drawing.Color.White;
            this.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit.Enabled = false;
            this.txtUnit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(14, 9);
            this.txtUnit.Multiline = true;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(215, 20);
            this.txtUnit.TabIndex = 1;
            // 
            // pnlPriceUnit
            // 
            this.pnlPriceUnit.BackgroundImage = global::GUI.Properties.Resources.pnltext;
            this.pnlPriceUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlPriceUnit.Controls.Add(this.txtPriceUnit);
            this.pnlPriceUnit.Location = new System.Drawing.Point(70, 312);
            this.pnlPriceUnit.Name = "pnlPriceUnit";
            this.pnlPriceUnit.Size = new System.Drawing.Size(240, 39);
            this.pnlPriceUnit.TabIndex = 13;
            // 
            // txtPriceUnit
            // 
            this.txtPriceUnit.BackColor = System.Drawing.Color.White;
            this.txtPriceUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceUnit.Location = new System.Drawing.Point(12, 10);
            this.txtPriceUnit.MaxLength = 10;
            this.txtPriceUnit.Multiline = true;
            this.txtPriceUnit.Name = "txtPriceUnit";
            this.txtPriceUnit.Size = new System.Drawing.Size(203, 20);
            this.txtPriceUnit.TabIndex = 0;
            this.txtPriceUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPriceUnit_KeyDown);
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
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnReset_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnReset_MouseLeave);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(67, 380);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 18);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "Số lượng";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(355, 285);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(54, 18);
            this.lblUnit.TabIndex = 7;
            this.lblUnit.Text = "Đơn vị";
            // 
            // lblPriceUnit
            // 
            this.lblPriceUnit.AutoSize = true;
            this.lblPriceUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceUnit.Location = new System.Drawing.Point(67, 285);
            this.lblPriceUnit.Name = "lblPriceUnit";
            this.lblPriceUnit.Size = new System.Drawing.Size(103, 18);
            this.lblPriceUnit.TabIndex = 6;
            this.lblPriceUnit.Text = "Đơn giá nhập";
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientName.Location = new System.Drawing.Point(67, 196);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(115, 18);
            this.lblIngredientName.TabIndex = 5;
            this.lblIngredientName.Text = "Tên nguyên liệu";
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
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.pnlIngredient.ResumeLayout(false);
            this.pnlSupplier.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlUnit.ResumeLayout(false);
            this.pnlUnit.PerformLayout();
            this.pnlPriceUnit.ResumeLayout(false);
            this.pnlPriceUnit.PerformLayout();
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel pnlPriceUnit;
        private System.Windows.Forms.Panel pnlUnit;
        private System.Windows.Forms.TextBox txtPriceUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Panel pnlIngredient;
        private System.Windows.Forms.ComboBox cmbIngredientName;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriceUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    }
}
