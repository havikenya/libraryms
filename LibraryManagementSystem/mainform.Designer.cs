namespace LibraryManagementSystem
{
    partial class mainform
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
            this.label_return = new System.Windows.Forms.Label();
            this.label_books = new System.Windows.Forms.Label();
            this.label_issue = new System.Windows.Forms.Label();
            this.label_students = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox_return = new System.Windows.Forms.PictureBox();
            this.pictureBox_issue = new System.Windows.Forms.PictureBox();
            this.pictureBox_books = new System.Windows.Forms.PictureBox();
            this.pictureBox_student = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_issue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_return);
            this.panel1.Controls.Add(this.label_books);
            this.panel1.Controls.Add(this.label_issue);
            this.panel1.Controls.Add(this.label_students);
            this.panel1.Controls.Add(this.pictureBox_return);
            this.panel1.Controls.Add(this.pictureBox_issue);
            this.panel1.Controls.Add(this.pictureBox_books);
            this.panel1.Controls.Add(this.pictureBox_student);
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 196);
            this.panel1.TabIndex = 0;
            // 
            // label_return
            // 
            this.label_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_return.AutoSize = true;
            this.label_return.BackColor = System.Drawing.Color.White;
            this.label_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_return.ForeColor = System.Drawing.Color.Crimson;
            this.label_return.Location = new System.Drawing.Point(503, 155);
            this.label_return.Name = "label_return";
            this.label_return.Size = new System.Drawing.Size(76, 25);
            this.label_return.TabIndex = 10;
            this.label_return.Text = "Return";
            this.label_return.Click += new System.EventHandler(this.label_return_Click);
            // 
            // label_books
            // 
            this.label_books.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_books.AutoSize = true;
            this.label_books.BackColor = System.Drawing.Color.White;
            this.label_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_books.ForeColor = System.Drawing.Color.Crimson;
            this.label_books.Location = new System.Drawing.Point(193, 155);
            this.label_books.Name = "label_books";
            this.label_books.Size = new System.Drawing.Size(72, 25);
            this.label_books.TabIndex = 9;
            this.label_books.Text = "Books";
            this.label_books.Click += new System.EventHandler(this.label_books_Click);
            // 
            // label_issue
            // 
            this.label_issue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_issue.AutoSize = true;
            this.label_issue.BackColor = System.Drawing.Color.White;
            this.label_issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_issue.ForeColor = System.Drawing.Color.Crimson;
            this.label_issue.Location = new System.Drawing.Point(351, 155);
            this.label_issue.Name = "label_issue";
            this.label_issue.Size = new System.Drawing.Size(63, 25);
            this.label_issue.TabIndex = 8;
            this.label_issue.Text = "Issue";
            this.label_issue.Click += new System.EventHandler(this.label_issue_Click);
            // 
            // label_students
            // 
            this.label_students.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_students.AutoSize = true;
            this.label_students.BackColor = System.Drawing.Color.White;
            this.label_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_students.ForeColor = System.Drawing.Color.Crimson;
            this.label_students.Location = new System.Drawing.Point(23, 155);
            this.label_students.Name = "label_students";
            this.label_students.Size = new System.Drawing.Size(86, 25);
            this.label_students.TabIndex = 7;
            this.label_students.Text = "Student";
            this.label_students.Click += new System.EventHandler(this.label_students_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome To school Library  Management System";
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(645, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(34, 38);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox_return
            // 
            this.pictureBox_return.Image = global::LibraryManagementSystem.Properties.Resources.icons8_return_book_48px_1;
            this.pictureBox_return.Location = new System.Drawing.Point(493, 58);
            this.pictureBox_return.Name = "pictureBox_return";
            this.pictureBox_return.Size = new System.Drawing.Size(100, 82);
            this.pictureBox_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_return.TabIndex = 6;
            this.pictureBox_return.TabStop = false;
            // 
            // pictureBox_issue
            // 
            this.pictureBox_issue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_issue.Image = global::LibraryManagementSystem.Properties.Resources.icons8_borrow_book_48px;
            this.pictureBox_issue.Location = new System.Drawing.Point(335, 58);
            this.pictureBox_issue.Name = "pictureBox_issue";
            this.pictureBox_issue.Size = new System.Drawing.Size(100, 82);
            this.pictureBox_issue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_issue.TabIndex = 5;
            this.pictureBox_issue.TabStop = false;
            // 
            // pictureBox_books
            // 
            this.pictureBox_books.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_books.Image = global::LibraryManagementSystem.Properties.Resources.icons8_books_emoji_1;
            this.pictureBox_books.Location = new System.Drawing.Point(179, 58);
            this.pictureBox_books.Name = "pictureBox_books";
            this.pictureBox_books.Size = new System.Drawing.Size(100, 82);
            this.pictureBox_books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_books.TabIndex = 4;
            this.pictureBox_books.TabStop = false;
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_student.Image = global::LibraryManagementSystem.Properties.Resources.icons8_man_reading_a_book_48px;
            this.pictureBox_student.Location = new System.Drawing.Point(16, 58);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(100, 82);
            this.pictureBox_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_student.TabIndex = 3;
            this.pictureBox_student.TabStop = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(680, 337);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_issue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_books;
        private System.Windows.Forms.Label label_issue;
        private System.Windows.Forms.Label label_students;
        private System.Windows.Forms.PictureBox pictureBox_return;
        private System.Windows.Forms.PictureBox pictureBox_issue;
        private System.Windows.Forms.PictureBox pictureBox_books;
        private System.Windows.Forms.PictureBox pictureBox_student;
        private System.Windows.Forms.Label label_return;
        private System.Windows.Forms.Button button_exit;
    }
}