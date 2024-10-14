using System.Drawing;

namespace GUI
{
    partial class frmMenuOrder
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.fpnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPage_st = new System.Windows.Forms.Button();
            this.btnPage_nd = new System.Windows.Forms.Button();
            this.btnPage_rd = new System.Windows.Forms.Button();
            this.btnPage_th = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlHeaderTable = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.pnlSearchBarOrder = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.fpnlPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlSearchBarOrder.SuspendLayout();
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
            this.fpnlMenu.Location = new System.Drawing.Point(12, 107);
            this.fpnlMenu.Name = "fpnlMenu";
            this.fpnlMenu.Size = new System.Drawing.Size(517, 631);
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
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.Location = new System.Drawing.Point(565, 92);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(0);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(765, 643);
            this.dgvOrders.TabIndex = 10;
            // 
            // pnlHeaderTable
            // 
            this.pnlHeaderTable.BackgroundImage = global::GUI.Properties.Resources.dgvHeader1;
            this.pnlHeaderTable.Location = new System.Drawing.Point(565, 63);
            this.pnlHeaderTable.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHeaderTable.Name = "pnlHeaderTable";
            this.pnlHeaderTable.Size = new System.Drawing.Size(765, 50);
            this.pnlHeaderTable.TabIndex = 11;
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
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.btnOrder_Paint);
            // 
            // pnlSearchBarOrder
            // 
            this.pnlSearchBarOrder.BackgroundImage = global::GUI.Properties.Resources.SearchBarOrder;
            this.pnlSearchBarOrder.Controls.Add(this.txtSearch);
            this.pnlSearchBarOrder.Location = new System.Drawing.Point(116, 27);
            this.pnlSearchBarOrder.Name = "pnlSearchBarOrder";
            this.pnlSearchBarOrder.Size = new System.Drawing.Size(300, 48);
            this.pnlSearchBarOrder.TabIndex = 13;
            this.pnlSearchBarOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearchBarOrder_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(18, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 13);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Món ăn cần tìm ?";
            // 
            // frmMenuOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnlSearchBarOrder);
            this.Controls.Add(this.pnlHeaderTable);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.fpnlPagination);
            this.Controls.Add(this.fpnlMenu);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuOrder";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.fpnlPagination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlSearchBarOrder.ResumeLayout(false);
            this.pnlSearchBarOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.FlowLayoutPanel fpnlMenu;
        private System.Windows.Forms.FlowLayoutPanel fpnlPagination;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPage_st;
        private System.Windows.Forms.Button btnPage_nd;
        private System.Windows.Forms.Button btnPage_rd;
        private System.Windows.Forms.Button btnPage_th;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlHeaderTable;
        private System.Windows.Forms.Panel pnlSearchBarOrder;
        private System.Windows.Forms.TextBox txtSearch;
    }
}