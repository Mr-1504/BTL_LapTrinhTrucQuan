namespace GUI
{
    partial class FoodManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodManager));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFood = new System.Windows.Forms.FlowLayoutPanel();
            this.pnFoodMNG = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fpnlPagination = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPage_st = new System.Windows.Forms.Button();
            this.btnPage_nd = new System.Windows.Forms.Button();
            this.btnPage_rd = new System.Windows.Forms.Button();
            this.btnPage_th = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnFoodMNG.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fpnlPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thực đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.flowLayoutPanelFood);
            this.panel1.Location = new System.Drawing.Point(48, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 667);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanelFood
            // 
            this.flowLayoutPanelFood.AutoScroll = true;
            this.flowLayoutPanelFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFood.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFood.Name = "flowLayoutPanelFood";
            this.flowLayoutPanelFood.Size = new System.Drawing.Size(980, 667);
            this.flowLayoutPanelFood.TabIndex = 0;
            // 
            // pnFoodMNG
            // 
            this.pnFoodMNG.Controls.Add(this.panel2);
            this.pnFoodMNG.Location = new System.Drawing.Point(0, 0);
            this.pnFoodMNG.Name = "pnFoodMNG";
            this.pnFoodMNG.Size = new System.Drawing.Size(1372, 815);
            this.pnFoodMNG.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fpnlPagination);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1730, 815);
            this.panel2.TabIndex = 25;
            // 
            // fpnlPagination
            // 
            this.fpnlPagination.Controls.Add(this.btnPrevious);
            this.fpnlPagination.Controls.Add(this.btnPage_st);
            this.fpnlPagination.Controls.Add(this.btnPage_nd);
            this.fpnlPagination.Controls.Add(this.btnPage_rd);
            this.fpnlPagination.Controls.Add(this.btnPage_th);
            this.fpnlPagination.Controls.Add(this.btnNext);
            this.fpnlPagination.Location = new System.Drawing.Point(362, 738);
            this.fpnlPagination.Margin = new System.Windows.Forms.Padding(0);
            this.fpnlPagination.Name = "fpnlPagination";
            this.fpnlPagination.Size = new System.Drawing.Size(315, 32);
            this.fpnlPagination.TabIndex = 10;
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Blue;
            this.btnPrevious.Location = new System.Drawing.Point(4, 4);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 21);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPage_st
            // 
            this.btnPage_st.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPage_st.FlatAppearance.BorderSize = 0;
            this.btnPage_st.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_st.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_st.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_st.Location = new System.Drawing.Point(95, 3);
            this.btnPage_st.Name = "btnPage_st";
            this.btnPage_st.Size = new System.Drawing.Size(30, 22);
            this.btnPage_st.TabIndex = 2;
            this.btnPage_st.Text = "1";
            this.btnPage_st.UseVisualStyleBackColor = true;
            this.btnPage_st.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // btnPage_nd
            // 
            this.btnPage_nd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPage_nd.FlatAppearance.BorderSize = 0;
            this.btnPage_nd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_nd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_nd.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_nd.Location = new System.Drawing.Point(131, 3);
            this.btnPage_nd.Name = "btnPage_nd";
            this.btnPage_nd.Size = new System.Drawing.Size(30, 22);
            this.btnPage_nd.TabIndex = 3;
            this.btnPage_nd.Text = "2";
            this.btnPage_nd.UseVisualStyleBackColor = true;
            this.btnPage_nd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // btnPage_rd
            // 
            this.btnPage_rd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPage_rd.FlatAppearance.BorderSize = 0;
            this.btnPage_rd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_rd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_rd.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_rd.Location = new System.Drawing.Point(167, 3);
            this.btnPage_rd.Name = "btnPage_rd";
            this.btnPage_rd.Size = new System.Drawing.Size(30, 22);
            this.btnPage_rd.TabIndex = 4;
            this.btnPage_rd.Text = "3";
            this.btnPage_rd.UseVisualStyleBackColor = true;
            this.btnPage_rd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // btnPage_th
            // 
            this.btnPage_th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPage_th.FlatAppearance.BorderSize = 0;
            this.btnPage_th.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPage_th.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPage_th.ForeColor = System.Drawing.Color.Blue;
            this.btnPage_th.Location = new System.Drawing.Point(203, 3);
            this.btnPage_th.Name = "btnPage_th";
            this.btnPage_th.Size = new System.Drawing.Size(30, 22);
            this.btnPage_th.TabIndex = 5;
            this.btnPage_th.Text = "4";
            this.btnPage_th.UseVisualStyleBackColor = true;
            this.btnPage_th.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PageButton_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Blue;
            this.btnNext.Location = new System.Drawing.Point(239, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 22);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(1132, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 52);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Location = new System.Drawing.Point(1132, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(170, 52);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::GUI.Properties.Resources.btn;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(1132, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 52);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // FoodManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnFoodMNG);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodManager";
            this.Text = "FoodManager";
            this.Shown += new System.EventHandler(this.FoodManager_Shown);
            this.panel1.ResumeLayout(false);
            this.pnFoodMNG.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fpnlPagination.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFood;
        private System.Windows.Forms.Panel pnFoodMNG;
        private System.Windows.Forms.FlowLayoutPanel fpnlPagination;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnPage_st;
        private System.Windows.Forms.Button btnPage_nd;
        private System.Windows.Forms.Button btnPage_rd;
        private System.Windows.Forms.Button btnPage_th;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel2;
    }
}