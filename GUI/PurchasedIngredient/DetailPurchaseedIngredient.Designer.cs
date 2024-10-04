namespace GUI.PurchasedIngredient
{
    partial class DetailPurchaseedIngredient
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
            this.picArrowRight = new System.Windows.Forms.PictureBox();
            this.picStep2Status = new System.Windows.Forms.PictureBox();
            this.picStep1Status = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStep2Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStep1Status)).BeginInit();
            this.SuspendLayout();
            // 
            // picArrowRight
            // 
            this.picArrowRight.Image = global::GUI.Properties.Resources.arrowRight;
            this.picArrowRight.Location = new System.Drawing.Point(670, 30);
            this.picArrowRight.Name = "picArrowRight";
            this.picArrowRight.Size = new System.Drawing.Size(28, 28);
            this.picArrowRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrowRight.TabIndex = 2;
            this.picArrowRight.TabStop = false;
            // 
            // picStep2Status
            // 
            this.picStep2Status.Image = global::GUI.Properties.Resources.step2;
            this.picStep2Status.Location = new System.Drawing.Point(888, 8);
            this.picStep2Status.Name = "picStep2Status";
            this.picStep2Status.Size = new System.Drawing.Size(320, 73);
            this.picStep2Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStep2Status.TabIndex = 1;
            this.picStep2Status.TabStop = false;
            // 
            // picStep1Status
            // 
            this.picStep1Status.Image = global::GUI.Properties.Resources.step1Wait;
            this.picStep1Status.Location = new System.Drawing.Point(161, 8);
            this.picStep1Status.Name = "picStep1Status";
            this.picStep1Status.Size = new System.Drawing.Size(320, 73);
            this.picStep1Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStep1Status.TabIndex = 0;
            this.picStep1Status.TabStop = false;
            // 
            // DetailPurchaseedIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1369, 814);
            this.Controls.Add(this.picArrowRight);
            this.Controls.Add(this.picStep2Status);
            this.Controls.Add(this.picStep1Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailPurchaseedIngredient";
            this.Text = "DetailPurchaseedIngredient";
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStep2Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStep1Status)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picStep1Status;
        private System.Windows.Forms.PictureBox picStep2Status;
        private System.Windows.Forms.PictureBox picArrowRight;
    }
}