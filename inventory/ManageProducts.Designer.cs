namespace inventory
{
    partial class ManageProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProPriceTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProQtyTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProNameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProdIdTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sButton3 = new Sipaa.Framework.SButton();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.ProDiscTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.sButton5 = new Sipaa.Framework.SButton();
            this.sButton6 = new Sipaa.Framework.SButton();
            this.ProdBrandName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            this.SuspendLayout();
            // 
            // sButton2
            // 
            this.sButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.sButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton2.BorderRadius = 10;
            this.sButton2.BorderSize = 0;
            this.sButton2.FlatAppearance.BorderSize = 0;
            this.sButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton2.ForeColor = System.Drawing.Color.White;
            this.sButton2.Location = new System.Drawing.Point(81, 445);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(75, 30);
            this.sButton2.TabIndex = 22;
            this.sButton2.Text = "Edit";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 83);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::inventory.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(815, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Products";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doi PC Parts and Accessories Inventory Management System";
            // 
            // ProductGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.ProductGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGV.ColumnHeadersHeight = 40;
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.ProductGV.Location = new System.Drawing.Point(237, 148);
            this.ProductGV.Name = "ProductGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProductGV.RowHeadersVisible = false;
            this.ProductGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.RowTemplate.Height = 35;
            this.ProductGV.Size = new System.Drawing.Size(604, 324);
            this.ProductGV.TabIndex = 30;
            this.ProductGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.SeaGreen;
            this.ProductGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProductGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.ProductGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.ProductGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProductGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProductGV.ThemeStyle.HeaderStyle.Height = 40;
            this.ProductGV.ThemeStyle.ReadOnly = false;
            this.ProductGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.ProductGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProductGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductGV.ThemeStyle.RowsStyle.Height = 35;
            this.ProductGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.ProductGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // ProPriceTb
            // 
            this.ProPriceTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProPriceTb.BorderThickness = 5;
            this.ProPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProPriceTb.DefaultText = "";
            this.ProPriceTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProPriceTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProPriceTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProPriceTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProPriceTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProPriceTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProPriceTb.ForeColor = System.Drawing.Color.Teal;
            this.ProPriceTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProPriceTb.Location = new System.Drawing.Point(6, 350);
            this.ProPriceTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProPriceTb.Name = "ProPriceTb";
            this.ProPriceTb.PasswordChar = '\0';
            this.ProPriceTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProPriceTb.PlaceholderText = "Price";
            this.ProPriceTb.SelectedText = "";
            this.ProPriceTb.Size = new System.Drawing.Size(222, 42);
            this.ProPriceTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProPriceTb.TabIndex = 29;
            // 
            // ProQtyTb
            // 
            this.ProQtyTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProQtyTb.BorderThickness = 5;
            this.ProQtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProQtyTb.DefaultText = "";
            this.ProQtyTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProQtyTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProQtyTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProQtyTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProQtyTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProQtyTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProQtyTb.ForeColor = System.Drawing.Color.Teal;
            this.ProQtyTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProQtyTb.Location = new System.Drawing.Point(6, 300);
            this.ProQtyTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProQtyTb.Name = "ProQtyTb";
            this.ProQtyTb.PasswordChar = '\0';
            this.ProQtyTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProQtyTb.PlaceholderText = "Quantity";
            this.ProQtyTb.SelectedText = "";
            this.ProQtyTb.Size = new System.Drawing.Size(222, 42);
            this.ProQtyTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProQtyTb.TabIndex = 28;
            // 
            // ProNameTb
            // 
            this.ProNameTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProNameTb.BorderThickness = 5;
            this.ProNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProNameTb.DefaultText = "";
            this.ProNameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProNameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProNameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProNameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProNameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProNameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNameTb.ForeColor = System.Drawing.Color.Teal;
            this.ProNameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProNameTb.Location = new System.Drawing.Point(6, 150);
            this.ProNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProNameTb.Name = "ProNameTb";
            this.ProNameTb.PasswordChar = '\0';
            this.ProNameTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProNameTb.PlaceholderText = "Product Name";
            this.ProNameTb.SelectedText = "";
            this.ProNameTb.Size = new System.Drawing.Size(222, 42);
            this.ProNameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProNameTb.TabIndex = 27;
            // 
            // ProdIdTb
            // 
            this.ProdIdTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProdIdTb.BorderThickness = 5;
            this.ProdIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdIdTb.DefaultText = "";
            this.ProdIdTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdIdTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdIdTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdIdTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdIdTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdIdTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ProdIdTb.ForeColor = System.Drawing.Color.Teal;
            this.ProdIdTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdIdTb.Location = new System.Drawing.Point(6, 100);
            this.ProdIdTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProdIdTb.Name = "ProdIdTb";
            this.ProdIdTb.PasswordChar = '\0';
            this.ProdIdTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProdIdTb.PlaceholderText = "Product ID";
            this.ProdIdTb.SelectedText = "";
            this.ProdIdTb.Size = new System.Drawing.Size(222, 42);
            this.ProdIdTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdIdTb.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(356, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Product List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 22);
            this.panel2.TabIndex = 25;
            // 
            // sButton3
            // 
            this.sButton3.BackColor = System.Drawing.Color.SeaGreen;
            this.sButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton3.BorderRadius = 10;
            this.sButton3.BorderSize = 0;
            this.sButton3.FlatAppearance.BorderSize = 0;
            this.sButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton3.ForeColor = System.Drawing.Color.White;
            this.sButton3.Location = new System.Drawing.Point(156, 445);
            this.sButton3.Name = "sButton3";
            this.sButton3.Size = new System.Drawing.Size(75, 30);
            this.sButton3.TabIndex = 23;
            this.sButton3.Text = "Delete";
            this.sButton3.UseVisualStyleBackColor = false;
            this.sButton3.Click += new System.EventHandler(this.sButton3_Click);
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 10;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(6, 445);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(75, 30);
            this.sButton1.TabIndex = 21;
            this.sButton1.Text = "Add";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // ProDiscTb
            // 
            this.ProDiscTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProDiscTb.BorderThickness = 5;
            this.ProDiscTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProDiscTb.DefaultText = "";
            this.ProDiscTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProDiscTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProDiscTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProDiscTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProDiscTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProDiscTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProDiscTb.ForeColor = System.Drawing.Color.Teal;
            this.ProDiscTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProDiscTb.Location = new System.Drawing.Point(6, 250);
            this.ProDiscTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProDiscTb.Name = "ProDiscTb";
            this.ProDiscTb.PasswordChar = '\0';
            this.ProDiscTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProDiscTb.PlaceholderText = "Description";
            this.ProDiscTb.SelectedText = "";
            this.ProDiscTb.Size = new System.Drawing.Size(222, 42);
            this.ProDiscTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProDiscTb.TabIndex = 31;
            // 
            // CatCombo
            // 
            this.CatCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CatCombo.ForeColor = System.Drawing.Color.SeaGreen;
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(9, 398);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(222, 28);
            this.CatCombo.TabIndex = 32;
            this.CatCombo.Text = "Product Category";
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SearchCombo.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(317, 114);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(222, 28);
            this.SearchCombo.TabIndex = 33;
            this.SearchCombo.Text = "Select Category";
            this.SearchCombo.SelectedIndexChanged += new System.EventHandler(this.SearchCombo_SelectedIndexChanged);
            // 
            // sButton5
            // 
            this.sButton5.BackColor = System.Drawing.Color.SeaGreen;
            this.sButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton5.BorderRadius = 10;
            this.sButton5.BorderSize = 0;
            this.sButton5.FlatAppearance.BorderSize = 0;
            this.sButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton5.ForeColor = System.Drawing.Color.White;
            this.sButton5.Location = new System.Drawing.Point(580, 112);
            this.sButton5.Name = "sButton5";
            this.sButton5.Size = new System.Drawing.Size(86, 30);
            this.sButton5.TabIndex = 34;
            this.sButton5.Text = "Search";
            this.sButton5.UseVisualStyleBackColor = false;
            this.sButton5.Click += new System.EventHandler(this.sButton5_Click);
            // 
            // sButton6
            // 
            this.sButton6.BackColor = System.Drawing.Color.SeaGreen;
            this.sButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton6.BorderRadius = 10;
            this.sButton6.BorderSize = 0;
            this.sButton6.FlatAppearance.BorderSize = 0;
            this.sButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton6.ForeColor = System.Drawing.Color.White;
            this.sButton6.Location = new System.Drawing.Point(672, 112);
            this.sButton6.Name = "sButton6";
            this.sButton6.Size = new System.Drawing.Size(86, 30);
            this.sButton6.TabIndex = 35;
            this.sButton6.Text = "Refresh";
            this.sButton6.UseVisualStyleBackColor = false;
            this.sButton6.Click += new System.EventHandler(this.sButton6_Click);
            // 
            // ProdBrandName
            // 
            this.ProdBrandName.BorderColor = System.Drawing.Color.SeaGreen;
            this.ProdBrandName.BorderThickness = 5;
            this.ProdBrandName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdBrandName.DefaultText = "";
            this.ProdBrandName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdBrandName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdBrandName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdBrandName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdBrandName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdBrandName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdBrandName.ForeColor = System.Drawing.Color.Teal;
            this.ProdBrandName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdBrandName.Location = new System.Drawing.Point(6, 200);
            this.ProdBrandName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProdBrandName.Name = "ProdBrandName";
            this.ProdBrandName.PasswordChar = '\0';
            this.ProdBrandName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ProdBrandName.PlaceholderText = "Brand Name";
            this.ProdBrandName.SelectedText = "";
            this.ProdBrandName.Size = new System.Drawing.Size(222, 42);
            this.ProdBrandName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ProdBrandName.TabIndex = 36;
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 500);
            this.Controls.Add(this.ProdBrandName);
            this.Controls.Add(this.sButton6);
            this.Controls.Add(this.sButton5);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.ProDiscTb);
            this.Controls.Add(this.sButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.ProPriceTb);
            this.Controls.Add(this.ProQtyTb);
            this.Controls.Add(this.ProNameTb);
            this.Controls.Add(this.ProdIdTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sButton3);
            this.Controls.Add(this.sButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sipaa.Framework.SButton sButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ProductGV;
        private Guna.UI2.WinForms.Guna2TextBox ProPriceTb;
        private Guna.UI2.WinForms.Guna2TextBox ProQtyTb;
        private Guna.UI2.WinForms.Guna2TextBox ProNameTb;
        private Guna.UI2.WinForms.Guna2TextBox ProdIdTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Sipaa.Framework.SButton sButton3;
        private Sipaa.Framework.SButton sButton1;
        private Guna.UI2.WinForms.Guna2TextBox ProDiscTb;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.ComboBox SearchCombo;
        private Sipaa.Framework.SButton sButton5;
        private Sipaa.Framework.SButton sButton6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2TextBox ProdBrandName;
    }
}