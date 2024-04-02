using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class issuebookForm : Form
    {
        issuebookClass issue = new issuebookClass();
        studentClass student = new studentClass();
        booksClass book = new booksClass();
        DBconnect connect = new DBconnect();
        public issuebookForm()
        {

            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text == "" || textBox_lname.Text == "" || textBox_admno.Text == "" || textBox_serialnumber.Text == "" || textBox_bookname.Text == "" || textBox_bookid.Text == "" || textBox_eadress.Text == "")
            {
                MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string serianno = textBox_serialnumber.Text;
                DataTable table = student.getlist(new MySqlCommand("SELECT * FROM `issuedetails` WHERE `serialno`= '" + serianno + "' "));
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("The Book With That SERIAL Number is Already Issued to Another Student, Confirm The Serial Number And Try Again", "SERIAL NUMBER ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_serialnumber.Clear();

                }
                else
                {
                    string fname = textBox_firstname.Text;
                    string lname = textBox_lname.Text;
                    int bid = Convert.ToInt32(textBox_bookid.Text);
                    string serialno = textBox_serialnumber.Text;
                    int adm = Convert.ToInt32(textBox_admno.Text);
                    string bname = textBox_bookname.Text;
                    DateTime idate = dateTimePicker_issuedate.Value;
                    string Eadress = textBox_eadress.Text;


                    if (issue.addbookissued(adm, fname, lname, bid, serialno, bname, idate, Eadress))
                    {
                        MessageBox.Show("Book Issue Details Added Succesfully", "Issue Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Add Book Issue Details", " Issue Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
         
          MessageBox.Show("You cannot EDIT the details for an already issued book, try to DELETE instead", "update issue details", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_admno.Text);
            if (MessageBox.Show("Are  You Sure You Want to DELETE The Selected Book Issue Record?", "Delete Book Issue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (issue.deleteissuedetails(id))
                {
                    MessageBox.Show("Book Issue Record Deleted Succesfully", "Delete Book Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book Issue Record Not Deleted", "Delete Book Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_serialnumber.Clear();
            textBox_admno.Clear();
            textBox_firstname.Clear();
            textBox_lname.Clear();
            textBox_bookid.Clear();
            textBox_bookname.Clear();
            dateTimePicker_issuedate.Value = DateTime.Now;
            textBox_eadress.Clear();
          
        }

        private void issuebookForm_Load(object sender, EventArgs e)
        {
         dataGridView_studentdetails.DataSource = student.getlist(new MySqlCommand("SELECT * FROM `student`", connect.getconnection ));
         dataGridView_bookdetails.DataSource = book.getlist(new MySqlCommand("SELECT * FROM `books`", connect.getconnection));

        }

        private void button_searchadmno_Click(object sender, EventArgs e)
        {
            dataGridView_studentdetails.DataSource = student.getlist(new MySqlCommand("SELECT * FROM `student` WHERE CONCAT(`AdmNo`)LIKE '%"+textBox_searchadmno.Text+"%'"));
            textBox_searchadmno.Clear();
        }

        private void button_searchbookid_Click(object sender, EventArgs e)
        {
            dataGridView_bookdetails.DataSource = book.getlist(new MySqlCommand("SELECT `bookId`, `BookName`, `Author`, `Publisher`, `Price`, `Quantity` FROM `books` WHERE CONCAT(`bookId`)LIKE'%" + textBox_searchbookid.Text + "%'"));
            textBox_searchbookid.Clear();
        }

        private void dataGridView_studentdetails_Click(object sender, EventArgs e)
        {
            textBox_firstname.Text = dataGridView_studentdetails.CurrentRow.Cells[0].Value.ToString();
            textBox_lname.Text = dataGridView_studentdetails.CurrentRow.Cells[1].Value.ToString();
            textBox_admno.Text = dataGridView_studentdetails.CurrentRow.Cells[2].Value.ToString();
            textBox_eadress.Text = dataGridView_studentdetails.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void dataGridView_bookdetails_Click(object sender, EventArgs e)
        {
            textBox_bookid.Text = dataGridView_bookdetails.CurrentRow.Cells[0].Value.ToString();
            textBox_bookname.Text = dataGridView_bookdetails.CurrentRow.Cells[1].Value.ToString();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }

        private void dataGridView_studentdetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
    }
}
