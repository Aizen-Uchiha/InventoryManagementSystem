namespace inventory
{
    partial class ManageUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.sButton2 = new Sipaa.Framework.SButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.unameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.FnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpassTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.UphoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsersGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sButton4 = new Sipaa.Framework.SButton();
            this.UserLevel = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 83);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::inventory.Properties.Resources.delete;
            this.pictureBox3.Location = new System.Drawing.Point(765, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(312, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manage Users";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doi PC Parts and Accessories Inventory Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.sButton1.Location = new System.Drawing.Point(34, 410);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(86, 36);
            this.sButton1.TabIndex = 5;
            this.sButton1.Text = "Add";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
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
            this.sButton2.Location = new System.Drawing.Point(133, 410);
            this.sButton2.Name = "sButton2";
            this.sButton2.Size = new System.Drawing.Size(86, 36);
            this.sButton2.TabIndex = 6;
            this.sButton2.Text = "Edit";
            this.sButton2.UseVisualStyleBackColor = false;
            this.sButton2.Click += new System.EventHandler(this.sButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 22);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(486, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Users List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // unameTb
            // 
            this.unameTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.unameTb.BorderThickness = 5;
            this.unameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unameTb.DefaultText = "";
            this.unameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.unameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.unameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.unameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unameTb.ForeColor = System.Drawing.Color.Black;
            this.unameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.unameTb.Location = new System.Drawing.Point(34, 123);
            this.unameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unameTb.Name = "unameTb";
            this.unameTb.PasswordChar = '\0';
            this.unameTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.unameTb.PlaceholderText = "Username";
            this.unameTb.SelectedText = "";
            this.unameTb.Size = new System.Drawing.Size(281, 42);
            this.unameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.unameTb.TabIndex = 13;
            this.unameTb.TextChanged += new System.EventHandler(this.unameTb_TextChanged);
            // 
            // FnameTb
            // 
            this.FnameTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.FnameTb.BorderThickness = 5;
            this.FnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FnameTb.DefaultText = "";
            this.FnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FnameTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTb.ForeColor = System.Drawing.Color.Black;
            this.FnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FnameTb.Location = new System.Drawing.Point(34, 173);
            this.FnameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FnameTb.Name = "FnameTb";
            this.FnameTb.PasswordChar = '\0';
            this.FnameTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.FnameTb.PlaceholderText = "Full Name";
            this.FnameTb.SelectedText = "";
            this.FnameTb.Size = new System.Drawing.Size(281, 42);
            this.FnameTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FnameTb.TabIndex = 15;
            this.FnameTb.TextChanged += new System.EventHandler(this.FnameTb_TextChanged);
            // 
            // UpassTb
            // 
            this.UpassTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.UpassTb.BorderThickness = 5;
            this.UpassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UpassTb.DefaultText = "";
            this.UpassTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UpassTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UpassTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpassTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UpassTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpassTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpassTb.ForeColor = System.Drawing.Color.Black;
            this.UpassTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UpassTb.Location = new System.Drawing.Point(34, 223);
            this.UpassTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpassTb.Name = "UpassTb";
            this.UpassTb.PasswordChar = '\0';
            this.UpassTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UpassTb.PlaceholderText = "Password";
            this.UpassTb.SelectedText = "";
            this.UpassTb.Size = new System.Drawing.Size(281, 42);
            this.UpassTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UpassTb.TabIndex = 16;
            this.UpassTb.TextChanged += new System.EventHandler(this.UpassTb_TextChanged);
            // 
            // UphoneTb
            // 
            this.UphoneTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.UphoneTb.BorderThickness = 5;
            this.UphoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UphoneTb.DefaultText = "";
            this.UphoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UphoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UphoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UphoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UphoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UphoneTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UphoneTb.ForeColor = System.Drawing.Color.Black;
            this.UphoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UphoneTb.Location = new System.Drawing.Point(34, 273);
            this.UphoneTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UphoneTb.Name = "UphoneTb";
            this.UphoneTb.PasswordChar = '\0';
            this.UphoneTb.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UphoneTb.PlaceholderText = "Phone Number";
            this.UphoneTb.SelectedText = "";
            this.UphoneTb.Size = new System.Drawing.Size(281, 42);
            this.UphoneTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UphoneTb.TabIndex = 17;
            this.UphoneTb.TextChanged += new System.EventHandler(this.UphoneTb_TextChanged);
            // 
            // UsersGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.UsersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersGV.ColumnHeadersHeight = 40;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersGV.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UsersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.UsersGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UsersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.UsersGV.Location = new System.Drawing.Point(322, 123);
            this.UsersGV.Name = "UsersGV";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UsersGV.RowHeadersVisible = false;
            this.UsersGV.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersGV.RowTemplate.Height = 35;
            this.UsersGV.Size = new System.Drawing.Size(466, 349);
            this.UsersGV.TabIndex = 18;
            this.UsersGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UsersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.UsersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.UsersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UsersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UsersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UsersGV.ThemeStyle.HeaderStyle.Height = 40;
            this.UsersGV.ThemeStyle.ReadOnly = false;
            this.UsersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.UsersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UsersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UsersGV.ThemeStyle.RowsStyle.Height = 35;
            this.UsersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.UsersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick_2);
            // 
            // sButton4
            // 
            this.sButton4.BackColor = System.Drawing.Color.SeaGreen;
            this.sButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton4.BorderRadius = 10;
            this.sButton4.BorderSize = 0;
            this.sButton4.FlatAppearance.BorderSize = 0;
            this.sButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButton4.ForeColor = System.Drawing.Color.White;
            this.sButton4.Location = new System.Drawing.Point(229, 410);
            this.sButton4.Name = "sButton4";
            this.sButton4.Size = new System.Drawing.Size(86, 36);
            this.sButton4.TabIndex = 19;
            this.sButton4.Text = "Delete";
            this.sButton4.UseVisualStyleBackColor = false;
            this.sButton4.Click += new System.EventHandler(this.sButton4_Click_1);
            // 
            // UserLevel
            // 
            this.UserLevel.BorderColor = System.Drawing.Color.SeaGreen;
            this.UserLevel.BorderThickness = 5;
            this.UserLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserLevel.DefaultText = "";
            this.UserLevel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserLevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserLevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserLevel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLevel.ForeColor = System.Drawing.Color.Black;
            this.UserLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserLevel.Location = new System.Drawing.Point(34, 323);
            this.UserLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.PasswordChar = '\0';
            this.UserLevel.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UserLevel.PlaceholderText = "User Level";
            this.UserLevel.SelectedText = "";
            this.UserLevel.Size = new System.Drawing.Size(281, 42);
            this.UserLevel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.UserLevel.TabIndex = 20;
            this.UserLevel.TextChanged += new System.EventHandler(this.UserLevel_TextChanged);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.UserLevel);
            this.Controls.Add(this.sButton4);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.UphoneTb);
            this.Controls.Add(this.UpassTb);
            this.Controls.Add(this.FnameTb);
            this.Controls.Add(this.unameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sButton2);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sipaa.Framework.SButton sButton1;
        private Sipaa.Framework.SButton sButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox unameTb;
        private Guna.UI2.WinForms.Guna2TextBox FnameTb;
        private Guna.UI2.WinForms.Guna2TextBox UpassTb;
        private Guna.UI2.WinForms.Guna2TextBox UphoneTb;
        private Guna.UI2.WinForms.Guna2DataGridView UsersGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Sipaa.Framework.SButton sButton4;
        private Guna.UI2.WinForms.Guna2TextBox UserLevel;
    }
}