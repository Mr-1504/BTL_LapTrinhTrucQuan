namespace GUI
{
    partial class boxFoodManager
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
            this.lblNameFood = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.picFood = new System.Windows.Forms.PictureBox();
            this.pnlFoodItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFoodItem
            // 
            this.pnlFoodItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlFoodItem.Controls.Add(this.lblNameFood);
            this.pnlFoodItem.Controls.Add(this.lblName);
            this.pnlFoodItem.Controls.Add(this.lblPriceValue);
            this.pnlFoodItem.Controls.Add(this.lblPrice);
            this.pnlFoodItem.Controls.Add(this.picFood);
            this.pnlFoodItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFoodItem.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFoodItem.Location = new System.Drawing.Point(0, 0);
            this.pnlFoodItem.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFoodItem.Name = "pnlFoodItem";
            this.pnlFoodItem.Size = new System.Drawing.Size(265, 195);
            this.pnlFoodItem.TabIndex = 0;
            this.pnlFoodItem.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFoodItem_Paint);
            // 
            // lblNameFood
            // 
            this.lblNameFood.AutoSize = true;
            this.lblNameFood.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.Location = new System.Drawing.Point(19, 155);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(66, 18);
            this.lblNameFood.TabIndex = 4;
            this.lblNameFood.Text = "Vịt Quay";
            this.lblNameFood.Click += new System.EventHandler(this.lblNameFood_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblName.Location = new System.Drawing.Point(18, 122);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 20);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(19, 64);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(32, 18);
            this.lblPriceValue.TabIndex = 2;
            this.lblPriceValue.Text = "$52";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblPrice.Location = new System.Drawing.Point(18, 34);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price";
            // 
            // picFood
            // 
            this.picFood.Location = new System.Drawing.Point(101, 22);
            this.picFood.Name = "picFood";
            this.picFood.Size = new System.Drawing.Size(152, 117);
            this.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFood.TabIndex = 0;
            this.picFood.TabStop = false;
            // 
            // boxFoodManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(265, 195);
            this.Controls.Add(this.pnlFoodItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "boxFoodManager";
            this.pnlFoodItem.ResumeLayout(false);
            this.pnlFoodItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFoodItem;
        private System.Windows.Forms.PictureBox picFood;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNameFood;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPriceValue;
    }
}