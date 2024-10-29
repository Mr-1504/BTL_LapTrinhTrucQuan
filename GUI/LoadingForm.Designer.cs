namespace GUI
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.pnProcessBar = new System.Windows.Forms.Panel();
            this.pnProcessBar2 = new System.Windows.Forms.Panel();
            this.logoBEA = new System.Windows.Forms.PictureBox();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnProcessBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBEA)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnProcessBar
            // 
            this.pnProcessBar.BackColor = System.Drawing.Color.White;
            this.pnProcessBar.Controls.Add(this.pnProcessBar2);
            this.pnProcessBar.Location = new System.Drawing.Point(28, 171);
            this.pnProcessBar.Margin = new System.Windows.Forms.Padding(2);
            this.pnProcessBar.Name = "pnProcessBar";
            this.pnProcessBar.Size = new System.Drawing.Size(541, 18);
            this.pnProcessBar.TabIndex = 2;
            this.pnProcessBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnProcessBar_Paint);
            // 
            // pnProcessBar2
            // 
            this.pnProcessBar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnProcessBar2.Location = new System.Drawing.Point(0, 0);
            this.pnProcessBar2.Margin = new System.Windows.Forms.Padding(2);
            this.pnProcessBar2.Name = "pnProcessBar2";
            this.pnProcessBar2.Size = new System.Drawing.Size(28, 20);
            this.pnProcessBar2.TabIndex = 3;
            // 
            // logoBEA
            // 
            this.logoBEA.Image = ((System.Drawing.Image)(resources.GetObject("logoBEA.Image")));
            this.logoBEA.Location = new System.Drawing.Point(112, 99);
            this.logoBEA.Margin = new System.Windows.Forms.Padding(2);
            this.logoBEA.Name = "logoBEA";
            this.logoBEA.Size = new System.Drawing.Size(359, 57);
            this.logoBEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoBEA.TabIndex = 3;
            this.logoBEA.TabStop = false;
            this.logoBEA.Click += new System.EventHandler(this.logoBEA_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.White;
            this.pnHeader.Controls.Add(this.logoBEA);
            this.pnHeader.Controls.Add(this.pnProcessBar);
            this.pnHeader.Location = new System.Drawing.Point(9, 10);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(582, 279);
            this.pnHeader.TabIndex = 4;
            this.pnHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnHeader_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoadingForm_Paint);
            this.pnProcessBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBEA)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnProcessBar;
        private System.Windows.Forms.Panel pnProcessBar2;
        private System.Windows.Forms.PictureBox logoBEA;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Timer timer1;
    }
}