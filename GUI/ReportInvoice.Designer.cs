namespace GUI
{
    partial class ReportInvoice
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnBackToOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(-1, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1371, 724);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnBackToOrder
            // 
            this.btnBackToOrder.FlatAppearance.BorderSize = 0;
            this.btnBackToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToOrder.Image = global::GUI.Properties.Resources.btnBackToOrders;
            this.btnBackToOrder.Location = new System.Drawing.Point(12, 3);
            this.btnBackToOrder.Name = "btnBackToOrder";
            this.btnBackToOrder.Size = new System.Drawing.Size(55, 35);
            this.btnBackToOrder.TabIndex = 2;
            this.btnBackToOrder.UseVisualStyleBackColor = true;
            this.btnBackToOrder.Click += new System.EventHandler(this.btnBackToOrder_Click);
            // 
            // ReportInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.btnBackToOrder);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportInvoice";
            this.Text = "ReportInvoice";
            this.Load += new System.EventHandler(this.ReportInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnBackToOrder;
    }
}