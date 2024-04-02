namespace LibraryManagementSystem
{
    partial class issuebookForm
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
            this.dataGridView_bookdetails = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_serialnumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_bookname = new System.Windows.Forms.TextBox();
            this.textBox_bookid = new System.Windows.Forms.TextBox();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.textBox_admno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_issuedate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_studentdetails = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_searchadmno = new System.Windows.Forms.TextBox();
            this.button_searchadmno = new System.Windows.Forms.Button();
            this.button_searchbookid = new System.Windows.Forms.Button();
            this.textBox_searchbookid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_eadress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookdetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_bookdetails
            // 
            this.dataGridView_bookdetails.AllowUserToAddRows = false;
            this.dataGridView_bookdetails.AllowUserToDeleteRows = false;
            this.dataGridView_bookdetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_bookdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_bookdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bookdetails.Location = new System.Drawing.Point(541, 299);
            this.dataGridView_bookdetails.Name = "dataGridView_bookdetails";
            this.dataGridView_bookdetails.ReadOnly = true;
            this.dataGridView_bookdetails.RowTemplate.Height = 60;
            this.dataGridView_bookdetails.RowTemplate.ReadOnly = true;
            this.dataGridView_bookdetails.Size = new System.Drawing.Size(545, 226);
            this.dataGridView_bookdetails.TabIndex = 44;
            this.dataGridView_bookdetails.Click += new System.EventHandler(this.dataGridView_bookdetails_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(536, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Books Details";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(0, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1097, 40);
            this.panel2.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(309, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 24);
            this.label11.TabIndex = 39;
            this.label11.Text = "Adm No";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(879, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "Book Id";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(497, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Issue Details ";
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_clear.BackColor = System.Drawing.Color.Orange;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(579, 142);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(110, 32);
            this.button_clear.TabIndex = 29;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_save.BackColor = System.Drawing.Color.Green;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(407, 142);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(110, 32);
            this.button_save.TabIndex = 27;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(-1, 0);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(64, 38);
            this.button_home.TabIndex = 41;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(1063, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(34, 38);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(286, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(133, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_firstname.Location = new System.Drawing.Point(137, 87);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(137, 20);
            this.textBox_firstname.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_eadress);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBox_serialnumber);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox_bookname);
            this.panel3.Controls.Add(this.textBox_bookid);
            this.panel3.Controls.Add(this.textBox_lname);
            this.panel3.Controls.Add(this.textBox_admno);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dateTimePicker_issuedate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_firstname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1097, 203);
            this.panel3.TabIndex = 39;
            // 
            // textBox_serialnumber
            // 
            this.textBox_serialnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_serialnumber.Location = new System.Drawing.Point(558, 87);
            this.textBox_serialnumber.Name = "textBox_serialnumber";
            this.textBox_serialnumber.Size = new System.Drawing.Size(116, 20);
            this.textBox_serialnumber.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(554, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 24);
            this.label13.TabIndex = 47;
            this.label13.Text = "Serial No";
            // 
            // textBox_bookname
            // 
            this.textBox_bookname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_bookname.Location = new System.Drawing.Point(688, 87);
            this.textBox_bookname.Name = "textBox_bookname";
            this.textBox_bookname.Size = new System.Drawing.Size(137, 20);
            this.textBox_bookname.TabIndex = 24;
            // 
            // textBox_bookid
            // 
            this.textBox_bookid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_bookid.Location = new System.Drawing.Point(443, 87);
            this.textBox_bookid.Name = "textBox_bookid";
            this.textBox_bookid.Size = new System.Drawing.Size(94, 20);
            this.textBox_bookid.TabIndex = 23;
            // 
            // textBox_lname
            // 
            this.textBox_lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_lname.Location = new System.Drawing.Point(290, 87);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(137, 20);
            this.textBox_lname.TabIndex = 22;
            // 
            // textBox_admno
            // 
            this.textBox_admno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_admno.Location = new System.Drawing.Point(34, 87);
            this.textBox_admno.Name = "textBox_admno";
            this.textBox_admno.Size = new System.Drawing.Size(91, 20);
            this.textBox_admno.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(836, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 45;
            this.label9.Text = "Date Issued";
            // 
            // dateTimePicker_issuedate
            // 
            this.dateTimePicker_issuedate.Location = new System.Drawing.Point(840, 87);
            this.dateTimePicker_issuedate.Name = "dateTimePicker_issuedate";
            this.dateTimePicker_issuedate.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker_issuedate.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(684, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Book Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(30, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adm No";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(439, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Book Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(52, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 37);
            this.panel1.TabIndex = 40;
            // 
            // dataGridView_studentdetails
            // 
            this.dataGridView_studentdetails.AllowUserToAddRows = false;
            this.dataGridView_studentdetails.AllowUserToDeleteRows = false;
            this.dataGridView_studentdetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_studentdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_studentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studentdetails.Location = new System.Drawing.Point(7, 298);
            this.dataGridView_studentdetails.Name = "dataGridView_studentdetails";
            this.dataGridView_studentdetails.ReadOnly = true;
            this.dataGridView_studentdetails.RowTemplate.Height = 60;
            this.dataGridView_studentdetails.RowTemplate.ReadOnly = true;
            this.dataGridView_studentdetails.Size = new System.Drawing.Size(510, 226);
            this.dataGridView_studentdetails.TabIndex = 45;
            this.dataGridView_studentdetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_studentdetails_CellContentClick);
            this.dataGridView_studentdetails.Click += new System.EventHandler(this.dataGridView_studentdetails_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(518, 300);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 225);
            this.panel4.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(0, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 47;
            this.label10.Text = "Student Details";
            // 
            // textBox_searchadmno
            // 
            this.textBox_searchadmno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_searchadmno.Location = new System.Drawing.Point(313, 275);
            this.textBox_searchadmno.Name = "textBox_searchadmno";
            this.textBox_searchadmno.Size = new System.Drawing.Size(91, 20);
            this.textBox_searchadmno.TabIndex = 31;
            // 
            // button_searchadmno
            // 
            this.button_searchadmno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_searchadmno.BackColor = System.Drawing.Color.Orange;
            this.button_searchadmno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchadmno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchadmno.ForeColor = System.Drawing.Color.White;
            this.button_searchadmno.Location = new System.Drawing.Point(407, 271);
            this.button_searchadmno.Name = "button_searchadmno";
            this.button_searchadmno.Size = new System.Drawing.Size(110, 28);
            this.button_searchadmno.TabIndex = 32;
            this.button_searchadmno.Text = "Search";
            this.button_searchadmno.UseVisualStyleBackColor = false;
            this.button_searchadmno.Click += new System.EventHandler(this.button_searchadmno_Click);
            // 
            // button_searchbookid
            // 
            this.button_searchbookid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_searchbookid.BackColor = System.Drawing.Color.Orange;
            this.button_searchbookid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchbookid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchbookid.ForeColor = System.Drawing.Color.White;
            this.button_searchbookid.Location = new System.Drawing.Point(977, 270);
            this.button_searchbookid.Name = "button_searchbookid";
            this.button_searchbookid.Size = new System.Drawing.Size(110, 28);
            this.button_searchbookid.TabIndex = 34;
            this.button_searchbookid.Text = "Search";
            this.button_searchbookid.UseVisualStyleBackColor = false;
            this.button_searchbookid.Click += new System.EventHandler(this.button_searchbookid_Click);
            // 
            // textBox_searchbookid
            // 
            this.textBox_searchbookid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_searchbookid.Location = new System.Drawing.Point(883, 276);
            this.textBox_searchbookid.Name = "textBox_searchbookid";
            this.textBox_searchbookid.Size = new System.Drawing.Size(91, 20);
            this.textBox_searchbookid.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(30, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 24);
            this.label14.TabIndex = 48;
            this.label14.Text = "email";
            // 
            // textBox_eadress
            // 
            this.textBox_eadress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_eadress.Location = new System.Drawing.Point(91, 134);
            this.textBox_eadress.Name = "textBox_eadress";
            this.textBox_eadress.Size = new System.Drawing.Size(137, 20);
            this.textBox_eadress.TabIndex = 49;
            // 
            // issuebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 536);
            this.Controls.Add(this.button_searchbookid);
            this.Controls.Add(this.textBox_searchbookid);
            this.Controls.Add(this.button_searchadmno);
            this.Controls.Add(this.textBox_searchadmno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_studentdetails);
            this.Controls.Add(this.dataGridView_bookdetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "issuebookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "issuebookForm";
            this.Load += new System.EventHandler(this.issuebookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bookdetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_bookdetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_issuedate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_bookid;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.TextBox textBox_admno;
        private System.Windows.Forms.TextBox textBox_bookname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView_studentdetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_searchadmno;
        private System.Windows.Forms.Button button_searchadmno;
        private System.Windows.Forms.Button button_searchbookid;
        private System.Windows.Forms.TextBox textBox_searchbookid;
        private System.Windows.Forms.TextBox textBox_serialnumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_eadress;
        private System.Windows.Forms.Label label14;



    }
}