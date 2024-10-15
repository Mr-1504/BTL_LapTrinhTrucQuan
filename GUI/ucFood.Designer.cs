namespace GUI
{
    partial class ucFood
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
            this.pnlFoodItem = new System.Windows.Forms.Panel();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCountFood = new System.Windows.Forms.Label();
            this.lblNameFood = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.pnlFoodItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoodItem
            // 
            this.pnlFoodItem.BackColor = System.Drawing.Color.White;
            this.pnlFoodItem.Controls.Add(this.lblFoodID);
            this.pnlFoodItem.Controls.Add(this.pictureBox2);
            this.pnlFoodItem.Controls.Add(this.pictureBox1);
            this.pnlFoodItem.Controls.Add(this.lblCountFood);
            this.pnlFoodItem.Controls.Add(this.lblNameFood);
            this.pnlFoodItem.Controls.Add(this.lblName);
            this.pnlFoodItem.Controls.Add(this.lblPriceValue);
            this.pnlFoodItem.Controls.Add(this.lblPrice);
            this.pnlFoodItem.Controls.Add(this.picFood);
            this.pnlFoodItem.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFoodItem.Location = new System.Drawing.Point(0, 0);
            this.pnlFoodItem.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFoodItem.Name = "pnlFoodItem";
            this.pnlFoodItem.Size = new System.Drawing.Size(231, 180);
            this.pnlFoodItem.TabIndex = 0;
            this.pnlFoodItem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFoodItem_Paint);
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.Location = new System.Drawing.Point(10, 18);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(31, 15);
            this.lblFoodID.TabIndex = 10;
            this.lblFoodID.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.Plus;
            this.pictureBox2.Location = new System.Drawing.Point(136, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.Minus;
            this.pictureBox1.Location = new System.Drawing.Point(61, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblCountFood
            // 
            this.lblCountFood.AutoSize = true;
            this.lblCountFood.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountFood.Location = new System.Drawing.Point(102, 157);
            this.lblCountFood.Name = "lblCountFood";
            this.lblCountFood.Size = new System.Drawing.Size(15, 17);
            this.lblCountFood.TabIndex = 7;
            this.lblCountFood.Text = "0";
            this.lblCountFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.Location = new System.Drawing.Point(8, 133);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(54, 15);
            this.lblNameFood.TabIndex = 4;
            this.lblNameFood.Text = "Vịt Quay";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblName.Location = new System.Drawing.Point(10, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(10, 74);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(28, 15);
            this.lblPriceValue.TabIndex = 2;
            this.lblPriceValue.Text = "$52";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPrice.Location = new System.Drawing.Point(10, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 15);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // picFood
            // 
            this.picFood.Image = global::GUI.Properties.Resources.VitQuay;
            this.picFood.Location = new System.Drawing.Point(76, 18);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(152, 107);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            // 
            // ucFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFoodItem);
            this.Name = "ucFood";
            this.Size = new System.Drawing.Size(231, 180);
            this.pnlFoodItem.ResumeLayout(false);
            this.pnlFoodItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoodItem;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCountFood;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFoodID;
    }
}
