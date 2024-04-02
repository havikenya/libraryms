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
    public partial class bookreturnForm : Form
    {
        BookreturnClass bookreturn = new BookreturnClass();
        issuebookClass issue = new issuebookClass();
        DBconnect connect = new DBconnect();
        BookreturnClass retan = new BookreturnClass();
        public bookreturnForm()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_admno.Text == "" || textBox_bookid.Text == "" || textBox_serialno.Text =="" || textBox_bookname.Text == "" || textBox_fname.Text == "" || textBox_lname.Text == "")
            {
                MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int stdid = Convert.ToInt32(textBox_admno.Text);
                string fname = textBox_fname.Text;
                string lname = textBox_lname.Text;
                int bookid = Convert.ToInt32(textBox_bookid.Text);
                string serialno = textBox_serialno.Text;
                string bName = textBox_bookname.Text;
                DateTime idate = dateTimePicker_issuedate.Value;
                DateTime rdate = dateTimePicker_returndate.Value;


                if (bookreturn.addbookreturn(stdid, fname, lname, bookid, serialno, bName, idate,rdate))
                {
                    button2.PerformClick();
                    showdata2();
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Unable to Return book", "Return Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textBox_admno.Text == "" || textBox_bookid.Text == "" || textBox_bookname.Text == "" || textBox_fname.Text == "" || textBox_lname.Text == "")
            {
                MessageBox.Show("All Fields Are Requied", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(textBox_returnid.Text);
                DateTime rdate = dateTimePicker_returndate.Value;

                if (bookreturn.updatebookreturn(rdate, id))
                {
                    MessageBox.Show("book return updated successfully", "Update Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("book return EDIT not successfull", "Update Return", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_returnid.Clear();
            textBox_issueid.Clear();
            textBox_admno.Clear();
            textBox_fname.Clear();
            textBox_lname.Clear();
            textBox_serialno.Clear();
            textBox_bookid.Clear();
            textBox_bookname.Clear();
            dateTimePicker_returndate.Value = DateTime.Now;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_returnid.Text);
            if (MessageBox.Show("Are  You Sure You Want to DELETE The Selected Book Record?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bookreturn.deletebookreturn(id))
                {
                    MessageBox.Show("Book Record Deleted Succesfully", "Delete Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Book Record Not Deleted", "Delete Book Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void bookreturnForm_Load(object sender, EventArgs e)
        {
            dataGridView_issuedbooks.DataSource = issue.getissuebook(new MySqlCommand("SELECT * FROM `issuedetails`", connect.Getconnection()));
            dataGridView_returnedbook.DataSource = retan.getbookreturn(new MySqlCommand("SELECT * FROM `booksreturn`", connect.Getconnection()));
        }

        private void dataGridView_issuedbooks_Click(object sender, EventArgs e)
        {
            textBox_issueid.Text = dataGridView_issuedbooks.CurrentRow.Cells[0].Value.ToString();
            textBox_admno.Text = dataGridView_issuedbooks.CurrentRow.Cells[1].Value.ToString();
            textBox_fname.Text = dataGridView_issuedbooks.CurrentRow.Cells[2].Value.ToString();
            textBox_lname.Text = dataGridView_issuedbooks.CurrentRow.Cells[3].Value.ToString();
            textBox_bookid.Text = dataGridView_issuedbooks.CurrentRow.Cells[4].Value.ToString();
            textBox_serialno.Text = dataGridView_issuedbooks.CurrentRow.Cells[5].Value.ToString();
            textBox_bookname.Text = dataGridView_issuedbooks.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker_issuedate.Text = dataGridView_issuedbooks.CurrentRow.Cells[7].Value.ToString();

        }
        public void showdata()
        {
            dataGridView_returnedbook.DataSource = retan.getbookreturn(new MySqlCommand("SELECT * FROM `booksreturn`", connect.Getconnection()));
        }

        public void showdata2()
        {
            dataGridView_issuedbooks.DataSource = issue.getissuebook(new MySqlCommand("SELECT * FROM `issuedetails`", connect.Getconnection()));
        }


        private void dataGridView_returnedbook_Click(object sender, EventArgs e)
        {
            textBox_returnid.Text = dataGridView_returnedbook.CurrentRow.Cells[0].Value.ToString();
            textBox_admno.Text = dataGridView_returnedbook.CurrentRow.Cells[1].Value.ToString();
            textBox_fname.Text = dataGridView_returnedbook.CurrentRow.Cells[2].Value.ToString();
            textBox_lname.Text = dataGridView_returnedbook.CurrentRow.Cells[3].Value.ToString();
            textBox_bookid.Text = dataGridView_returnedbook.CurrentRow.Cells[4].Value.ToString();
            textBox_serialno.Text = dataGridView_returnedbook.CurrentRow.Cells[5].Value.ToString();
            textBox_bookname.Text = dataGridView_returnedbook.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker_issuedate.Text = dataGridView_returnedbook.CurrentRow.Cells[7].Value.ToString();
            dateTimePicker_returndate.Text = dataGridView_returnedbook.CurrentRow.Cells[8].Value.ToString();


        }

        private void button_searchadmno_Click(object sender, EventArgs e)
        {
            dataGridView_issuedbooks.DataSource = issue.getissuebook(new MySqlCommand("SELECT * FROM `issuedetails` WHERE CONCAT(`AdmNo`)LIKE '%" + textBox_searchadmno.Text + "%'"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView_returnedbook.DataSource = retan.getbookreturn(new MySqlCommand("SELECT * FROM `booksreturn` WHERE CONCAT(`AdmNo`)LIKE '%" + textBox1.Text + "%'"));
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            mainform main = new mainform();
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adm = Convert.ToInt32(textBox_issueid.Text);
            if (MessageBox.Show("Are  You Sure You Want to RETURN The Selected Book?", "Return Book ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (issue.deleteissuedetails(adm))
                {
                    MessageBox.Show("Book Returned Succesfully", "Return Book ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book Issue Record Not Deleted", "Return Book ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

       


        


    }
}
