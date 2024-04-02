namespace LibraryManagementSystem
{
    partial class bookreturnForm
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
            this.dataGridView_returnedbook = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_serialno = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_issueid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_returnid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_returndate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_issuedate = new System.Windows.Forms.DateTimePicker();
            this.textBox_bookname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_bookid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_admno = new System.Windows.Forms.TextBox();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_issuedbooks = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button_searchadmno = new System.Windows.Forms.Button();
            this.textBox_searchadmno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_returnedbook)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_issuedbooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_returnedbook
            // 
            this.dataGridView_returnedbook.AllowUserToAddRows = false;
            this.dataGridView_returnedbook.AllowUserToDeleteRows = false;
            this.dataGridView_returnedbook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_returnedbook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_returnedbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_returnedbook.Location = new System.Drawing.Point(641, 299);
            this.dataGridView_returnedbook.Name = "dataGridView_returnedbook";
            this.dataGridView_returnedbook.ReadOnly = true;
            this.dataGridView_returnedbook.RowTemplate.Height = 60;
            this.dataGridView_returnedbook.RowTemplate.ReadOnly = true;
            this.dataGridView_returnedbook.Size = new System.Drawing.Size(585, 234);
            this.dataGridView_returnedbook.TabIndex = 44;
            this.dataGridView_returnedbook.Click += new System.EventHandler(this.dataGridView_returnedbook_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(3, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Book Issued";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(636, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Book Returned";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(552, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Return Details ";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(808, 139);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(110, 32);
            this.button_delete.TabIndex = 34;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_clear.BackColor = System.Drawing.Color.Orange;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(649, 139);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(110, 32);
            this.button_clear.TabIndex = 33;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_edit
            // 
            this.button_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.ForeColor = System.Drawing.Color.White;
            this.button_edit.Location = new System.Drawing.Point(471, 139);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(110, 32);
            this.button_edit.TabIndex = 32;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_save.BackColor = System.Drawing.Color.Green;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Location = new System.Drawing.Point(281, 139);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(110, 32);
            this.button_save.TabIndex = 31;
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
            this.button_home.Location = new System.Drawing.Point(0, 0);
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
            this.button_exit.Location = new System.Drawing.Point(1201, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(34, 38);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_serialno);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.textBox_issueid);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.textBox_returnid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dateTimePicker_returndate);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dateTimePicker_issuedate);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.textBox_bookname);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.textBox_bookid);
            this.panel3.Controls.Add(this.button_edit);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.textBox_admno);
            this.panel3.Controls.Add(this.textBox_fname);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox_lname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1235, 203);
            this.panel3.TabIndex = 39;
            // 
            // textBox_serialno
            // 
            this.textBox_serialno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_serialno.Location = new System.Drawing.Point(123, 134);
            this.textBox_serialno.Name = "textBox_serialno";
            this.textBox_serialno.Size = new System.Drawing.Size(108, 20);
            this.textBox_serialno.TabIndex = 66;
            this.textBox_serialno.Text = " ";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Crimson;
            this.label16.Location = new System.Drawing.Point(119, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 24);
            this.label16.TabIndex = 65;
            this.label16.Text = "Serial No";
            // 
            // textBox_issueid
            // 
            this.textBox_issueid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_issueid.Location = new System.Drawing.Point(10, 66);
            this.textBox_issueid.Name = "textBox_issueid";
            this.textBox_issueid.Size = new System.Drawing.Size(91, 20);
            this.textBox_issueid.TabIndex = 64;
            this.textBox_issueid.Text = " ";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Crimson;
            this.label15.Location = new System.Drawing.Point(8, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 24);
            this.label15.TabIndex = 63;
            this.label15.Text = "Issue Id";
            // 
            // textBox_returnid
            // 
            this.textBox_returnid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_returnid.Location = new System.Drawing.Point(10, 133);
            this.textBox_returnid.Name = "textBox_returnid";
            this.textBox_returnid.Size = new System.Drawing.Size(91, 20);
            this.textBox_returnid.TabIndex = 61;
            this.textBox_returnid.Text = " ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(8, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "Return Id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(1011, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 59;
            this.label3.Text = "Date Returned";
            // 
            // dateTimePicker_returndate
            // 
            this.dateTimePicker_returndate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_returndate.Location = new System.Drawing.Point(1019, 66);
            this.dateTimePicker_returndate.Name = "dateTimePicker_returndate";
            this.dateTimePicker_returndate.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker_returndate.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(805, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "Date Issued";
            // 
            // dateTimePicker_issuedate
            // 
            this.dateTimePicker_issuedate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_issuedate.Location = new System.Drawing.Point(810, 66);
            this.dateTimePicker_issuedate.Name = "dateTimePicker_issuedate";
            this.dateTimePicker_issuedate.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker_issuedate.TabIndex = 56;
            // 
            // textBox_bookname
            // 
            this.textBox_bookname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_bookname.Location = new System.Drawing.Point(655, 66);
            this.textBox_bookname.Name = "textBox_bookname";
            this.textBox_bookname.Size = new System.Drawing.Size(135, 20);
            this.textBox_bookname.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(651, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 24);
            this.label10.TabIndex = 54;
            this.label10.Text = "Book Name";
            // 
            // textBox_bookid
            // 
            this.textBox_bookid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_bookid.Location = new System.Drawing.Point(540, 66);
            this.textBox_bookid.Name = "textBox_bookid";
            this.textBox_bookid.Size = new System.Drawing.Size(94, 20);
            this.textBox_bookid.TabIndex = 53;
            this.textBox_bookid.Text = " ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(109, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 24);
            this.label11.TabIndex = 52;
            this.label11.Text = "Adm No";
            // 
            // textBox_admno
            // 
            this.textBox_admno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_admno.Location = new System.Drawing.Point(113, 66);
            this.textBox_admno.Name = "textBox_admno";
            this.textBox_admno.Size = new System.Drawing.Size(93, 20);
            this.textBox_admno.TabIndex = 51;
            this.textBox_admno.Text = " ";
            // 
            // textBox_fname
            // 
            this.textBox_fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_fname.Location = new System.Drawing.Point(222, 66);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(137, 20);
            this.textBox_fname.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(536, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 24);
            this.label12.TabIndex = 50;
            this.label12.Text = "Book Id";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(218, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 47;
            this.label14.Text = "First Name";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(375, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 24);
            this.label13.TabIndex = 49;
            this.label13.Text = "Last Name";
            // 
            // textBox_lname
            // 
            this.textBox_lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_lname.Location = new System.Drawing.Point(379, 66);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(146, 20);
            this.textBox_lname.TabIndex = 48;
            this.textBox_lname.Text = " ";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(810, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 32);
            this.button2.TabIndex = 62;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 37);
            this.panel1.TabIndex = 40;
            // 
            // dataGridView_issuedbooks
            // 
            this.dataGridView_issuedbooks.AllowUserToAddRows = false;
            this.dataGridView_issuedbooks.AllowUserToDeleteRows = false;
            this.dataGridView_issuedbooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_issuedbooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_issuedbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_issuedbooks.Location = new System.Drawing.Point(8, 299);
            this.dataGridView_issuedbooks.Name = "dataGridView_issuedbooks";
            this.dataGridView_issuedbooks.ReadOnly = true;
            this.dataGridView_issuedbooks.RowTemplate.Height = 60;
            this.dataGridView_issuedbooks.RowTemplate.ReadOnly = true;
            this.dataGridView_issuedbooks.Size = new System.Drawing.Size(608, 234);
            this.dataGridView_issuedbooks.TabIndex = 45;
            this.dataGridView_issuedbooks.Click += new System.EventHandler(this.dataGridView_issuedbooks_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Location = new System.Drawing.Point(616, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 234);
            this.panel4.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(408, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Adm No";
            // 
            // button_searchadmno
            // 
            this.button_searchadmno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_searchadmno.BackColor = System.Drawing.Color.Orange;
            this.button_searchadmno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_searchadmno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_searchadmno.ForeColor = System.Drawing.Color.White;
            this.button_searchadmno.Location = new System.Drawing.Point(506, 271);
            this.button_searchadmno.Name = "button_searchadmno";
            this.button_searchadmno.Size = new System.Drawing.Size(110, 28);
            this.button_searchadmno.TabIndex = 51;
            this.button_searchadmno.Text = "Search";
            this.button_searchadmno.UseVisualStyleBackColor = false;
            this.button_searchadmno.Click += new System.EventHandler(this.button_searchadmno_Click);
            // 
            // textBox_searchadmno
            // 
            this.textBox_searchadmno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_searchadmno.Location = new System.Drawing.Point(412, 277);
            this.textBox_searchadmno.Name = "textBox_searchadmno";
            this.textBox_searchadmno.Size = new System.Drawing.Size(91, 20);
            this.textBox_searchadmno.TabIndex = 49;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1116, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 28);
            this.button1.TabIndex = 53;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(1022, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(1018, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Adm No";
            // 
            // bookreturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1235, 536);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_searchadmno);
            this.Controls.Add(this.textBox_searchadmno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView_issuedbooks);
            this.Controls.Add(this.dataGridView_returnedbook);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookreturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bookreturnForm";
            this.Load += new System.EventHandler(this.bookreturnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_returnedbook)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_issuedbooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_returnedbook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_issuedate;
        private System.Windows.Forms.TextBox textBox_bookname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_bookid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_admno;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.DataGridView dataGridView_issuedbooks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_returndate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_searchadmno;
        private System.Windows.Forms.TextBox textBox_searchadmno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_returnid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_issueid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_serialno;
        private System.Windows.Forms.Label label16;

    }
}