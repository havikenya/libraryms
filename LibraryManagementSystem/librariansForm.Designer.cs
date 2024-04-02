namespace LibraryManagementSystem
{
    partial class librariansForm
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
            this.dataGridView_librariansdetails = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_librarianid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_librariansdetails)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_librariansdetails
            // 
            this.dataGridView_librariansdetails.AllowUserToAddRows = false;
            this.dataGridView_librariansdetails.AllowUserToDeleteRows = false;
            this.dataGridView_librariansdetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_librariansdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_librariansdetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_librariansdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_librariansdetails.Location = new System.Drawing.Point(18, 292);
            this.dataGridView_librariansdetails.Name = "dataGridView_librariansdetails";
            this.dataGridView_librariansdetails.ReadOnly = true;
            this.dataGridView_librariansdetails.RowTemplate.Height = 60;
            this.dataGridView_librariansdetails.RowTemplate.ReadOnly = true;
            this.dataGridView_librariansdetails.Size = new System.Drawing.Size(923, 226);
            this.dataGridView_librariansdetails.TabIndex = 44;
            this.dataGridView_librariansdetails.Click += new System.EventHandler(this.dataGridView_librariansdetails_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 40);
            this.panel2.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(401, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 45;
            this.label7.Text = "Librarian List";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(695, 156);
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
            this.button_clear.Location = new System.Drawing.Point(536, 156);
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
            this.button_edit.Location = new System.Drawing.Point(358, 156);
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
            this.button_save.Location = new System.Drawing.Point(168, 156);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(110, 32);
            this.button_save.TabIndex = 31;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
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
            this.label1.TabIndex = 42;
            this.label1.Text = " ";
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
            this.button_home.TabIndex = 41;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(485, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone No";
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_phonenumber.Location = new System.Drawing.Point(489, 87);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(163, 20);
            this.textBox_phonenumber.TabIndex = 23;
            this.textBox_phonenumber.Text = " ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(300, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(669, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password";
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_lastname.Location = new System.Drawing.Point(304, 87);
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
            this.label2.Location = new System.Drawing.Point(109, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "First Name";
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_firstname.Location = new System.Drawing.Point(113, 87);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(163, 20);
            this.textBox_firstname.TabIndex = 21;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox_librarianid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox_password);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.button_edit);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox_phonenumber);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_lastname);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_firstname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 203);
            this.panel3.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(109, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Librarian Id";
            // 
            // textBox_librarianid
            // 
            this.textBox_librarianid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_librarianid.Location = new System.Drawing.Point(215, 133);
            this.textBox_librarianid.Name = "textBox_librarianid";
            this.textBox_librarianid.Size = new System.Drawing.Size(63, 20);
            this.textBox_librarianid.TabIndex = 25;
            this.textBox_librarianid.Text = " ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(417, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Librarians Details ";
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Location = new System.Drawing.Point(673, 87);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(163, 20);
            this.textBox_password.TabIndex = 24;
            this.textBox_password.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 37);
            this.panel1.TabIndex = 40;
            // 
            // librariansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 536);
            this.Controls.Add(this.dataGridView_librariansdetails);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "librariansForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "librariansForm";
            this.Load += new System.EventHandler(this.librariansForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_librariansdetails)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_librariansdetails;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_librarianid;
    }
}