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
            this.btnReturn = new System.Windows.Forms.Button();
            this.picArrowRight = new System.Windows.Forms.PictureBox();
            this.picStep2Status = new System.Windows.Forms.PictureBox();
            this.picStep1Status = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picArrowRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStep2Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStep1Status)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = global::GUI.Properties.Resources.btnReturn;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(281, 728);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 50);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = global::GUI.Properties.Resources.btnCancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(55, 728);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundImage = global::GUI.Properties.Resources.btnContinue;
            this.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContinue.FlatAppearance.BorderSize = 0;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Location = new System.Drawing.Point(1127, 728);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(200, 50);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // DetailPurchaseedIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1369, 814);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
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
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnContinue;
    }
}