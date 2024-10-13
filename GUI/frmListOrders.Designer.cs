using System.Windows.Forms;

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
            this.pnlSearchBarOrder = new System.Windows.Forms.Panel();
            this.txtSearchBarOrder = new System.Windows.Forms.TextBox();
            this.btnThemDonHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).BeginInit();
            this.pnlSearchBarOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListOrders
            // 
            this.dgvListOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvListOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListOrders.Location = new System.Drawing.Point(68, 170);
            this.dgvListOrders.Margin = new System.Windows.Forms.Padding(0);
            this.dgvListOrders.Name = "dgvListOrders";
            this.dgvListOrders.Size = new System.Drawing.Size(1274, 456);
            this.dgvListOrders.TabIndex = 0;
            this.dgvListOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListOrders_CellClick);
            // 
            // pnlSearchBarOrder
            // 
            this.pnlSearchBarOrder.BackgroundImage = global::GUI.Properties.Resources.SearchBarOrder;
            this.pnlSearchBarOrder.Controls.Add(this.txtSearchBarOrder);
            this.pnlSearchBarOrder.Location = new System.Drawing.Point(68, 46);
            this.pnlSearchBarOrder.Name = "pnlSearchBarOrder";
            this.pnlSearchBarOrder.Size = new System.Drawing.Size(300, 48);
            this.pnlSearchBarOrder.TabIndex = 2;
            this.pnlSearchBarOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearchBarOrder_Paint);
            // 
            // txtSearchBarOrder
            // 
            this.txtSearchBarOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchBarOrder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearchBarOrder.Location = new System.Drawing.Point(16, 18);
            this.txtSearchBarOrder.Name = "txtSearchBarOrder";
            this.txtSearchBarOrder.Size = new System.Drawing.Size(225, 13);
            this.txtSearchBarOrder.TabIndex = 0;
            this.txtSearchBarOrder.Text = "Đơn hàng cần tìm ?";
            this.txtSearchBarOrder.MouseEnter += new System.EventHandler(this.txtSearchBarOrder_MouseEnter);
            this.txtSearchBarOrder.MouseLeave += new System.EventHandler(this.txtSearchBarOrder_MouseLeave);
            // 
            // btnThemDonHang
            // 
            this.btnThemDonHang.BackgroundImage = global::GUI.Properties.Resources.btnThem;
            this.btnThemDonHang.FlatAppearance.BorderSize = 0;
            this.btnThemDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDonHang.Location = new System.Drawing.Point(1226, 53);
            this.btnThemDonHang.Name = "btnThemDonHang";
            this.btnThemDonHang.Size = new System.Drawing.Size(116, 41);
            this.btnThemDonHang.TabIndex = 1;
            this.btnThemDonHang.UseVisualStyleBackColor = true;
            this.btnThemDonHang.Click += new System.EventHandler(this.btnThemDonHang_Click);
            this.btnThemDonHang.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThemDonHang_Paint);
            // 
            // frmListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnlSearchBarOrder);
            this.Controls.Add(this.dgvListOrders);
            this.Controls.Add(this.btnThemDonHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListOrders";
            this.Text = "frmListOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOrders)).EndInit();
            this.pnlSearchBarOrder.ResumeLayout(false);
            this.pnlSearchBarOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThemDonHang;
        private System.Windows.Forms.DataGridView dgvListOrders;
        private Panel pnlSearchBarOrder;
        private TextBox txtSearchBarOrder;
    }
}