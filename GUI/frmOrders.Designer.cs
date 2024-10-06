namespace GUI
{
    partial class frmOrders
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlPrice = new System.Windows.Forms.Panel();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.pnlFoodName = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.fpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlThanhTien = new System.Windows.Forms.Panel();
            this.pnlSoLuong = new System.Windows.Forms.Panel();
            this.pnlTenMon = new System.Windows.Forms.Panel();
            this.btnPage_st = new System.Windows.Forms.Button();
            this.btnPage_nd = new System.Windows.Forms.Button();
            this.btnPage_rd = new System.Windows.Forms.Button();
            this.btnPage_th = new System.Windows.Forms.Button();
            this.pnlOrder.SuspendLayout();
            this.pnlPrice.SuspendLayout();
            this.pnlQuantity.SuspendLayout();
            this.pnlFoodName.SuspendLayout();
            this.fpnlPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(31, 27);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(62, 25);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "Menu";
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.White;
            this.pnlOrder.Controls.Add(this.pnlPrice);
            this.pnlOrder.Controls.Add(this.pnlQuantity);
            this.pnlOrder.Controls.Add(this.pnlFoodName);
            this.pnlOrder.Location = new System.Drawing.Point(563, 63);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(795, 675);
            this.pnlOrder.TabIndex = 5;
            this.pnlOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrder_Paint);
            // 
            // pnlPrice
            // 
            this.pnlPrice.Controls.Add(this.pnlThanhTien);
            this.pnlPrice.Location = new System.Drawing.Point(551, 18);
            this.pnlPrice.Name = "pnlPrice";
            this.pnlPrice.Size = new System.Drawing.Size(219, 632);
            this.pnlPrice.TabIndex = 1;
            this.pnlPrice.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrice_Paint);
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.pnlSoLuong);
            this.pnlQuantity.Location = new System.Drawing.Point(294, 18);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(219, 632);
            this.pnlQuantity.TabIndex = 1;
            this.pnlQuantity.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQuantity_Paint);
            // 
            // pnlFoodName
            // 
            this.pnlFoodName.Controls.Add(this.pnlTenMon);
            this.pnlFoodName.Location = new System.Drawing.Point(28, 18);
            this.pnlFoodName.Name = "pnlFoodName";
            this.pnlFoodName.Size = new System.Drawing.Size(219, 632);
            this.pnlFoodName.TabIndex = 0;
            this.pnlFoodName.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFoodName_Paint);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(560, 27);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(61, 25);
            this.lblOrder.TabIndex = 6;
            this.lblOrder.Text = "Order";
            // 
            // fpnlMenu
            // 
            this.fpnlMenu.Location = new System.Drawing.Point(12, 63);
            this.fpnlMenu.Name = "fpnlMenu";
            this.fpnlMenu.Size = new System.Drawing.Size(528, 675);
            this.fpnlMenu.TabIndex = 8;
            // 
            // fpnlPagination
            // 
            this.fpnlPagination.Controls.Add(this.btnPrevious);
            this.fpnlPagination.Controls.Add(this.btnPage_st);
            this.fpnlPagination.Controls.Add(this.btnPage_nd);
            this.fpnlPagination.Controls.Add(this.btnPage_rd);
            this.fpnlPagination.Controls.Add(this.btnPage_th);
            this.fpnlPagination.Controls.Add(this.btnNext);
            this.fpnlPagination.Location = new System.Drawing.Point(130, 753);
            this.fpnlPagination.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlPagination.Name = "fpnlPagination";
            this.fpnlPagination.Size = new System.Drawing.Size(286, 32);
            this.fpnlPagination.TabIndex = 9;
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Blue;
            this.btnPrevious.Location = new System.Drawing.Point(4, 4);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(67, 21);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Blue;
            this.btnNext.Location = new System.Drawing.Point(222, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 22);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next   >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Image = global::GUI.Properties.Resources.btnOrder;
            this.btnOrder.Location = new System.Drawing.Point(845, 753);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(231, 42);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOrder_Paint);
            // 
            // pnlThanhTien
            // 
            this.pnlThanhTien.BackgroundImage = global::GUI.Properties.Resources.ThanhTien;
            this.pnlThanhTien.Location = new System.Drawing.Point(20, 14);
            this.pnlThanhTien.Name = "pnlThanhTien";
            this.pnlThanhTien.Size = new System.Drawing.Size(177, 36);
            this.pnlThanhTien.TabIndex = 0;
            // 
            // pnlSoLuong
            // 
            this.pnlSoLuong.BackgroundImage = global::GUI.Properties.Resources.SoLuong;
            this.pnlSoLuong.Location = new System.Drawing.Point(24, 13);
            this.pnlSoLuong.Name = "pnlSoLuong";
            this.pnlSoLuong.Size = new System.Drawing.Size(157, 35);
            this.pnlSoLuong.TabIndex = 0;
            // 
            // pnlTenMon
            // 
            this.pnlTenMon.BackgroundImage = global::GUI.Properties.Resources.TenMon1;
            this.pnlTenMon.Location = new System.Drawing.Point(27, 14);
            this.pnlTenMon.Name = "pnlTenMon";
            this.pnlTenMon.Size = new System.Drawing.Size(157, 35);
            this.pnlTenMon.TabIndex = 0;
            // 
            // btnPage_st
            // 
            this.btnPage_st.FlatAppearance.BorderSize = 0;
            this.btnPage_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_st.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_st.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_st.Location = new System.Drawing.Point(78, 3);
            this.btnPage_st.Name = "btnPage_st";
            this.btnPage_st.Size = new System.Drawing.Size(30, 22);
            this.btnPage_st.TabIndex = 2;
            this.btnPage_st.Text = "1";
            this.btnPage_st.UseVisualStyleBackColor = true;
            this.btnPage_st.Click += new System.EventHandler(this.frmOrders_Load);
            this.btnPage_st.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // btnPage_nd
            // 
            this.btnPage_nd.FlatAppearance.BorderSize = 0;
            this.btnPage_nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_nd.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_nd.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_nd.Location = new System.Drawing.Point(114, 3);
            this.btnPage_nd.Name = "btnPage_nd";
            this.btnPage_nd.Size = new System.Drawing.Size(30, 22);
            this.btnPage_nd.TabIndex = 3;
            this.btnPage_nd.Text = "2";
            this.btnPage_nd.UseVisualStyleBackColor = true;
            this.btnPage_nd.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPage_Paint);
            this.btnPage_nd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // btnPage_rd
            // 
            this.btnPage_rd.FlatAppearance.BorderSize = 0;
            this.btnPage_rd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_rd.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_rd.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_rd.Location = new System.Drawing.Point(150, 3);
            this.btnPage_rd.Name = "btnPage_rd";
            this.btnPage_rd.Size = new System.Drawing.Size(30, 22);
            this.btnPage_rd.TabIndex = 4;
            this.btnPage_rd.Text = "3";
            this.btnPage_rd.UseVisualStyleBackColor = true;
            this.btnPage_rd.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPage_Paint);
            this.btnPage_rd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // btnPage_th
            // 
            this.btnPage_th.FlatAppearance.BorderSize = 0;
            this.btnPage_th.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_th.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_th.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_th.Location = new System.Drawing.Point(186, 3);
            this.btnPage_th.Name = "btnPage_th";
            this.btnPage_th.Size = new System.Drawing.Size(30, 22);
            this.btnPage_th.TabIndex = 5;
            this.btnPage_th.Text = "4";
            this.btnPage_th.UseVisualStyleBackColor = true;
            this.btnPage_th.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPage_Paint);
            this.btnPage_th.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.fpnlPagination);
            this.Controls.Add(this.fpnlMenu);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.pnlOrder.ResumeLayout(false);
            this.pnlPrice.ResumeLayout(false);
            this.pnlQuantity.ResumeLayout(false);
            this.pnlFoodName.ResumeLayout(false);
            this.fpnlPagination.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel pnlPrice;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.Panel pnlFoodName;
        private System.Windows.Forms.Panel pnlTenMon;
        private System.Windows.Forms.Panel pnlSoLuong;
        private System.Windows.Forms.Panel pnlThanhTien;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.FlowLayoutPanel fpnlMenu;
        private System.Windows.Forms.FlowLayoutPanel fpnlPagination;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPage_st;
        private System.Windows.Forms.Button btnPage_nd;
        private System.Windows.Forms.Button btnPage_rd;
        private System.Windows.Forms.Button btnPage_th;
    }
}