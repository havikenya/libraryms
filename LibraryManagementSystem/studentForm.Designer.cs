namespace LibraryManagementSystem
{
    partial class studentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_stream = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_admno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_class = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_studentdetails = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_eadress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 37);
            this.panel1.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(919, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(34, 38);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.Location = new System.Drawing.Point(-1, -1);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(64, 38);
            this.button_home.TabIndex = 1;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(52, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = " ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_eadress);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.button_edit);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.comboBox_stream);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox_admno);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox_class);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_lastname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_firstname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 203);
            this.panel3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(393, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Student Details ";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(667, 139);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(110, 32);
            this.button_delete.TabIndex = 29;
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
            this.button_clear.Location = new System.Drawing.Point(508, 139);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(110, 32);
            this.button_clear.TabIndex = 28;
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
            this.button_edit.Location = new System.Drawing.Point(330, 139);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(110, 32);
            this.button_edit.TabIndex = 27;
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
            this.button_save.Location = new System.Drawing.Point(140, 139);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(110, 32);
            this.button_save.TabIndex = 26;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_stream
            // 
            this.comboBox_stream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_stream.FormattingEnabled = true;
            this.comboBox_stream.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "green"});
            this.comboBox_stream.Location = new System.Drawing.Point(668, 87);
            this.comboBox_stream.Name = "comboBox_stream";
            this.comboBox_stream.Size = new System.Drawing.Size(64, 21);
            this.comboBox_stream.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(663, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Stream";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(390, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Adm No";
            // 
            // textBox_admno
            // 
            this.textBox_admno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_admno.Location = new System.Drawing.Point(394, 87);
            this.textBox_admno.Name = "textBox_admno";
            this.textBox_admno.Size = new System.Drawing.Size(163, 20);
            this.textBox_admno.TabIndex = 23;
            this.textBox_admno.Text = " ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(205, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Last Name";
            // 
            // comboBox_class
            // 
            this.comboBox_class.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_class.FormattingEnabled = true;
            this.comboBox_class.Items.AddRange(new object[] {
            "FORM 1",
            "FORM 2",
            "FORM 3",
            "FORM 4"});
            this.comboBox_class.Location = new System.Drawing.Point(587, 86);
            this.comboBox_class.Name = "comboBox_class";
            this.comboBox_class.Size = new System.Drawing.Size(75, 21);
            this.comboBox_class.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(583, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Class";
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_lastname.Location = new System.Drawing.Point(209, 87);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(163, 20);
            this.textBox_lastname.TabIndex = 22;
            this.textBox_lastname.Text = " ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_firstname.Location = new System.Drawing.Point(3, 88);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(163, 20);
            this.textBox_firstname.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(410, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Student List";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 40);
            this.panel2.TabIndex = 37;
            // 
            // dataGridView_studentdetails
            // 
            this.dataGridView_studentdetails.AllowUserToAddRows = false;
            this.dataGridView_studentdetails.AllowUserToDeleteRows = false;
            this.dataGridView_studentdetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_studentdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_studentdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_studentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studentdetails.Location = new System.Drawing.Point(18, 298);
            this.dataGridView_studentdetails.Name = "dataGridView_studentdetails";
            this.dataGridView_studentdetails.ReadOnly = true;
            this.dataGridView_studentdetails.RowTemplate.Height = 60;
            this.dataGridView_studentdetails.RowTemplate.ReadOnly = true;
            this.dataGridView_studentdetails.Size = new System.Drawing.Size(923, 226);
            this.dataGridView_studentdetails.TabIndex = 38;
            this.dataGridView_studentdetails.Click += new System.EventHandler(this.dataGridView_studentdetails_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(744, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 36;
            this.label9.Text = "email address";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox_eadress
            // 
            this.textBox_eadress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_eadress.Location = new System.Drawing.Point(748, 88);
            this.textBox_eadress.Name = "textBox_eadress";
            this.textBox_eadress.Size = new System.Drawing.Size(163, 20);
            this.textBox_eadress.TabIndex = 37;
            this.textBox_eadress.Text = " ";
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 536);
            this.Controls.Add(this.dataGridView_studentdetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.studentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_stream;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_admno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_class;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_studentdetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_eadress;
    }
}