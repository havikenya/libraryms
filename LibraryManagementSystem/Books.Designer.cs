namespace LibraryManagementSystem
{
    partial class Books
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
            this.dataGridView_booklist = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_home = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_bookname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_bookid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booklist)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_booklist
            // 
            this.dataGridView_booklist.AllowUserToAddRows = false;
            this.dataGridView_booklist.AllowUserToDeleteRows = false;
            this.dataGridView_booklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_booklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_booklist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_booklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_booklist.Location = new System.Drawing.Point(18, 293);
            this.dataGridView_booklist.Name = "dataGridView_booklist";
            this.dataGridView_booklist.ReadOnly = true;
            this.dataGridView_booklist.RowTemplate.Height = 60;
            this.dataGridView_booklist.RowTemplate.ReadOnly = true;
            this.dataGridView_booklist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_booklist.Size = new System.Drawing.Size(923, 226);
            this.dataGridView_booklist.TabIndex = 44;
            this.dataGridView_booklist.Click += new System.EventHandler(this.dataGridView_booklist_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(431, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Book List";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 247);
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
            this.label7.Location = new System.Drawing.Point(406, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Book Details ";
            // 
            // button_delete
            // 
            this.button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(736, 139);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(110, 32);
            this.button_delete.TabIndex = 30;
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
            this.button_clear.Location = new System.Drawing.Point(577, 139);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(110, 32);
            this.button_clear.TabIndex = 29;
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
            this.button_edit.Location = new System.Drawing.Point(399, 139);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(110, 32);
            this.button_edit.TabIndex = 28;
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
            this.button_save.Location = new System.Drawing.Point(209, 139);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(110, 32);
            this.button_save.TabIndex = 27;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(716, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quantity";
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
            this.button_exit.Location = new System.Drawing.Point(919, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(34, 38);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(383, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Publisher";
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_publisher.Location = new System.Drawing.Point(387, 87);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(163, 20);
            this.textBox_publisher.TabIndex = 23;
            this.textBox_publisher.Text = " ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(198, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(576, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // textBox_author
            // 
            this.textBox_author.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_author.Location = new System.Drawing.Point(202, 87);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(163, 20);
            this.textBox_author.TabIndex = 22;
            this.textBox_author.Text = " ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Book Name";
            // 
            // textBox_bookname
            // 
            this.textBox_bookname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_bookname.Location = new System.Drawing.Point(11, 87);
            this.textBox_bookname.Name = "textBox_bookname";
            this.textBox_bookname.Size = new System.Drawing.Size(163, 20);
            this.textBox_bookname.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_bookid);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox_quantity);
            this.panel3.Controls.Add(this.textBox_price);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.button_edit);
            this.panel3.Controls.Add(this.button_save);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.textBox_publisher);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox_author);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox_bookname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 203);
            this.panel3.TabIndex = 39;
            // 
            // textBox_bookid
            // 
            this.textBox_bookid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_bookid.Location = new System.Drawing.Point(834, 87);
            this.textBox_bookid.Name = "textBox_bookid";
            this.textBox_bookid.Size = new System.Drawing.Size(110, 20);
            this.textBox_bookid.TabIndex = 26;
            this.textBox_bookid.Text = " ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Crimson;
            this.label9.Location = new System.Drawing.Point(830, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Book id";
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_quantity.Location = new System.Drawing.Point(720, 87);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(91, 20);
            this.textBox_quantity.TabIndex = 25;
            this.textBox_quantity.Text = " ";
            // 
            // textBox_price
            // 
            this.textBox_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_price.Location = new System.Drawing.Point(580, 87);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(110, 20);
            this.textBox_price.TabIndex = 24;
            this.textBox_price.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(52, 173);
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
            this.panel1.Size = new System.Drawing.Size(953, 37);
            this.panel1.TabIndex = 40;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 536);
            this.Controls.Add(this.dataGridView_booklist);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "b";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_booklist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_booklist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_bookname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_bookid;
        private System.Windows.Forms.Label label9;
    }
}