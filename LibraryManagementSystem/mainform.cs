using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void label_students_Click(object sender, EventArgs e)
        {
            studentForm student = new studentForm();
            this.Hide();
            student.Show();
        }

        private void label_books_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            this.Hide();
            book.Show();
        }

        private void label_issue_Click(object sender, EventArgs e)
        {
            issuebookForm issue = new issuebookForm();
            this.Hide();
            issue.Show();
        }

        private void label_return_Click(object sender, EventArgs e)
        {
            bookreturnForm retan = new bookreturnForm();
            this.Hide();
            retan.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }

        



    }
}
