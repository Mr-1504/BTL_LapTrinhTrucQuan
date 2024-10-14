namespace GUI
{
    partial class FoodManager2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodManager2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.nameFood = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FoodID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbFoodType = new System.Windows.Forms.ComboBox();
            this.btnChaneIm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnFood = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.addresspanel = new System.Windows.Forms.Panel();
            this.textMaking = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataIngredientMNG = new System.Windows.Forms.DataGridView();
            this.ingredientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameIngredient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maMon = new System.Windows.Forms.Label();
            this.pnIngredient = new System.Windows.Forms.Panel();
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbIngredient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.pnFood.SuspendLayout();
            this.addresspanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredientMNG)).BeginInit();
            this.pnIngredient.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 44);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameFood
            // 
            this.nameFood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nameFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameFood.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.nameFood.Location = new System.Drawing.Point(8, 6);
            this.nameFood.Name = "nameFood";
            this.nameFood.Size = new System.Drawing.Size(245, 22);
            this.nameFood.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.nameFood);
            this.panel2.Location = new System.Drawing.Point(330, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 33);
            this.panel2.TabIndex = 24;
            // 
            // FoodID
            // 
            this.FoodID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FoodID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FoodID.Enabled = false;
            this.FoodID.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.FoodID.Location = new System.Drawing.Point(8, 7);
            this.FoodID.Name = "FoodID";
            this.FoodID.ReadOnly = true;
            this.FoodID.Size = new System.Drawing.Size(237, 22);
            this.FoodID.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.cbFoodType);
            this.panel3.Controls.Add(this.FoodID);
            this.panel3.Location = new System.Drawing.Point(330, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 35);
            this.panel3.TabIndex = 25;
            // 
            // cbFoodType
            // 
            this.cbFoodType.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFoodType.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbFoodType.FormattingEnabled = true;
            this.cbFoodType.Location = new System.Drawing.Point(12, 4);
            this.cbFoodType.Name = "cbFoodType";
            this.cbFoodType.Size = new System.Drawing.Size(231, 27);
            this.cbFoodType.TabIndex = 6;
            // 
            // btnChaneIm
            // 
            this.btnChaneIm.BackColor = System.Drawing.Color.Transparent;
            this.btnChaneIm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChaneIm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChaneIm.FlatAppearance.BorderSize = 0;
            this.btnChaneIm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnChaneIm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnChaneIm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChaneIm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChaneIm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnChaneIm.Location = new System.Drawing.Point(98, 198);
            this.btnChaneIm.Name = "btnChaneIm";
            this.btnChaneIm.Size = new System.Drawing.Size(84, 28);
            this.btnChaneIm.TabIndex = 30;
            this.btnChaneIm.Text = "Chọn/Đổi ảnh";
            this.btnChaneIm.UseVisualStyleBackColor = false;
            this.btnChaneIm.Click += new System.EventHandler(this.btnChaneIm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Controls.Add(this.btnChaneIm);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(17, 92);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 240);
            this.panel6.TabIndex = 31;
            // 
            // pnFood
            // 
            this.pnFood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnFood.Controls.Add(this.btnAddFood);
            this.pnFood.Controls.Add(this.addresspanel);
            this.pnFood.Controls.Add(this.label8);
            this.pnFood.Controls.Add(this.btnSaveFood);
            this.pnFood.Controls.Add(this.panel4);
            this.pnFood.Controls.Add(this.button1);
            this.pnFood.Controls.Add(this.label3);
            this.pnFood.Controls.Add(this.dataIngredientMNG);
            this.pnFood.Controls.Add(this.label2);
            this.pnFood.Controls.Add(this.label1);
            this.pnFood.Controls.Add(this.panel6);
            this.pnFood.Controls.Add(this.panel2);
            this.pnFood.Controls.Add(this.panel3);
            this.pnFood.Controls.Add(this.maMon);
            this.pnFood.Location = new System.Drawing.Point(8, 8);
            this.pnFood.Name = "pnFood";
            this.pnFood.Size = new System.Drawing.Size(710, 800);
            this.pnFood.TabIndex = 24;
            this.pnFood.Paint += new System.Windows.Forms.PaintEventHandler(this.pnFood_Paint);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddFood.Location = new System.Drawing.Point(522, 732);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(171, 52);
            this.btnAddFood.TabIndex = 41;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            this.btnAddFood.MouseEnter += new System.EventHandler(this.btnAddFood_MouseEnter);
            this.btnAddFood.MouseLeave += new System.EventHandler(this.btnAddFood_MouseLeave);
            // 
            // addresspanel
            // 
            this.addresspanel.BackColor = System.Drawing.Color.Transparent;
            this.addresspanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addresspanel.BackgroundImage")));
            this.addresspanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addresspanel.Controls.Add(this.textMaking);
            this.addresspanel.Location = new System.Drawing.Point(152, 369);
            this.addresspanel.Name = "addresspanel";
            this.addresspanel.Size = new System.Drawing.Size(410, 40);
            this.addresspanel.TabIndex = 39;
            // 
            // textMaking
            // 
            this.textMaking.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textMaking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textMaking.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textMaking.Location = new System.Drawing.Point(10, 9);
            this.textMaking.Name = "textMaking";
            this.textMaking.Size = new System.Drawing.Size(389, 22);
            this.textMaking.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Cách làm";
            // 
            // btnSaveFood
            // 
            this.btnSaveFood.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveFood.BackgroundImage")));
            this.btnSaveFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveFood.FlatAppearance.BorderSize = 0;
            this.btnSaveFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSaveFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSaveFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFood.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveFood.Location = new System.Drawing.Point(522, 732);
            this.btnSaveFood.Name = "btnSaveFood";
            this.btnSaveFood.Size = new System.Drawing.Size(171, 52);
            this.btnSaveFood.TabIndex = 37;
            this.btnSaveFood.Text = "Lưu";
            this.btnSaveFood.UseVisualStyleBackColor = false;
            this.btnSaveFood.Click += new System.EventHandler(this.button2_Click);
            this.btnSaveFood.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSaveFood.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.Price);
            this.panel4.Location = new System.Drawing.Point(330, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 33);
            this.panel4.TabIndex = 34;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Price.Location = new System.Drawing.Point(8, 6);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(245, 22);
            this.Price.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Giá món ăn";
            // 
            // dataIngredientMNG
            // 
            this.dataIngredientMNG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataIngredientMNG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIngredientMNG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataIngredientMNG.ColumnHeadersHeight = 40;
            this.dataIngredientMNG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataIngredientMNG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientID,
            this.nameIngredient,
            this.number,
            this.unit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataIngredientMNG.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataIngredientMNG.Location = new System.Drawing.Point(17, 430);
            this.dataIngredientMNG.Name = "dataIngredientMNG";
            this.dataIngredientMNG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIngredientMNG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataIngredientMNG.RowHeadersVisible = false;
            this.dataIngredientMNG.RowTemplate.Height = 30;
            this.dataIngredientMNG.RowTemplate.ReadOnly = true;
            this.dataIngredientMNG.Size = new System.Drawing.Size(676, 268);
            this.dataIngredientMNG.TabIndex = 33;
            this.dataIngredientMNG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmployerMNG_CellContentClick);
            this.dataIngredientMNG.Paint += new System.Windows.Forms.PaintEventHandler(this.dataEmployerMNG_Paint);
            // 
            // ingredientID
            // 
            this.ingredientID.HeaderText = "Mã Nguyên Liệu";
            this.ingredientID.Name = "ingredientID";
            this.ingredientID.Width = 180;
            // 
            // nameIngredient
            // 
            this.nameIngredient.HeaderText = "Tên Nguyên Liệu";
            this.nameIngredient.Name = "nameIngredient";
            this.nameIngredient.Width = 265;
            // 
            // number
            // 
            this.number.HeaderText = "Số Lượng";
            this.number.Name = "number";
            this.number.Width = 130;
            // 
            // unit
            // 
            this.unit.HeaderText = "Đơn Vị";
            this.unit.Name = "unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Món ăn";
            // 
            // maMon
            // 
            this.maMon.AutoSize = true;
            this.maMon.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maMon.Location = new System.Drawing.Point(326, 92);
            this.maMon.Name = "maMon";
            this.maMon.Size = new System.Drawing.Size(112, 22);
            this.maMon.TabIndex = 4;
            this.maMon.Text = "Mã món ăn";
            // 
            // pnIngredient
            // 
            this.pnIngredient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnIngredient.Controls.Add(this.btnDeleteIngredient);
            this.pnIngredient.Controls.Add(this.btnSave);
            this.pnIngredient.Controls.Add(this.label7);
            this.pnIngredient.Controls.Add(this.panel7);
            this.pnIngredient.Controls.Add(this.label4);
            this.pnIngredient.Controls.Add(this.label5);
            this.pnIngredient.Controls.Add(this.panel9);
            this.pnIngredient.Controls.Add(this.panel10);
            this.pnIngredient.Controls.Add(this.label6);
            this.pnIngredient.Location = new System.Drawing.Point(724, 8);
            this.pnIngredient.Name = "pnIngredient";
            this.pnIngredient.Size = new System.Drawing.Size(635, 800);
            this.pnIngredient.TabIndex = 26;
            this.pnIngredient.Paint += new System.Windows.Forms.PaintEventHandler(this.pnIngredient_Paint);
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteIngredient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteIngredient.BackgroundImage")));
            this.btnDeleteIngredient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteIngredient.FlatAppearance.BorderSize = 0;
            this.btnDeleteIngredient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteIngredient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIngredient.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIngredient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteIngredient.Location = new System.Drawing.Point(26, 732);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(171, 52);
            this.btnDeleteIngredient.TabIndex = 40;
            this.btnDeleteIngredient.Text = "Xóa";
            this.btnDeleteIngredient.UseVisualStyleBackColor = false;
            this.btnDeleteIngredient.Click += new System.EventHandler(this.button2_Click_1);
            this.btnDeleteIngredient.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDeleteIngredient.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(443, 732);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 52);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSaveIngredient_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSaveIngredient_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(35, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nguyên liệu";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Controls.Add(this.cbUnit);
            this.panel7.Location = new System.Drawing.Point(87, 328);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 33);
            this.panel7.TabIndex = 34;
            // 
            // cbUnit
            // 
            this.cbUnit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbUnit.Enabled = false;
            this.cbUnit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.cbUnit.Location = new System.Drawing.Point(9, 5);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.ReadOnly = true;
            this.cbUnit.Size = new System.Drawing.Size(245, 22);
            this.cbUnit.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Số lượng";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Controls.Add(this.textNumber);
            this.panel9.Location = new System.Drawing.Point(87, 232);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(262, 33);
            this.panel9.TabIndex = 24;
            // 
            // textNumber
            // 
            this.textNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNumber.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textNumber.Location = new System.Drawing.Point(8, 6);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(245, 22);
            this.textNumber.TabIndex = 20;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Controls.Add(this.cbIngredient);
            this.panel10.Location = new System.Drawing.Point(87, 145);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(254, 35);
            this.panel10.TabIndex = 25;
            // 
            // cbIngredient
            // 
            this.cbIngredient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIngredient.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.cbIngredient.FormattingEnabled = true;
            this.cbIngredient.Location = new System.Drawing.Point(11, 4);
            this.cbIngredient.Name = "cbIngredient";
            this.cbIngredient.Size = new System.Drawing.Size(231, 27);
            this.cbIngredient.TabIndex = 0;
            this.cbIngredient.SelectedIndexChanged += new System.EventHandler(this.cbIngredient_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên nguyên liệu";
            // 
            // FoodManager2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 815);
            this.Controls.Add(this.pnFood);
            this.Controls.Add(this.pnIngredient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodManager2";
            this.Text = "FoodManager2";
            this.Load += new System.EventHandler(this.FoodManager2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.pnFood.ResumeLayout(false);
            this.pnFood.PerformLayout();
            this.addresspanel.ResumeLayout(false);
            this.addresspanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredientMNG)).EndInit();
            this.pnIngredient.ResumeLayout(false);
            this.pnIngredient.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox FoodID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChaneIm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataIngredientMNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnIngredient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbIngredient;
        private System.Windows.Forms.Button btnSaveFood;
        private System.Windows.Forms.TextBox cbUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel addresspanel;
        private System.Windows.Forms.TextBox textMaking;
        private System.Windows.Forms.ComboBox cbFoodType;
        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnAddFood;
    }
}