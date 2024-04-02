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
    public partial class Books : Form
    {
        booksClass book = new booksClass();
        DBconnect connect = new DBconnect();
        public Books()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_bookname.Text == "" || textBox_author.Text == "" || textBox_publisher.Text == "" || textBox_price.Text == "" || textBox_quantity.Text == "")
            {
                MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string bname = textBox_bookname.Text;
                string author = textBox_author.Text;
                string pub = textBox_publisher.Text;
                int price = Convert.ToInt32(textBox_price.Text);
                int quantity = Convert.ToInt32(textBox_quantity.Text);

                if (book.addbooks(bname, author, pub, price, quantity))
                {
                    MessageBox.Show("Book Details Added Succesfully", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();

                }
                else
                {
                    MessageBox.Show("Unable to Add Book Details", " Add Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_clear.PerformClick();

                }


            }


        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (textBox_bookname.Text == "" || textBox_author.Text == "" || textBox_publisher.Text == "" || textBox_price.Text == "" || textBox_quantity.Text == "" || textBox_bookid.Text == "")
            {
                MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int bid = Convert.ToInt32(textBox_bookid.Text);
                string bname = textBox_bookname.Text;
                string author = textBox_author.Text;
                string pub = textBox_publisher.Text;
                int price = Convert.ToInt32(textBox_price.Text);
                int quantity = Convert.ToInt32(textBox_quantity.Text);

                if (book.updatebooks(bid, bname, author, pub, price, quantity))
                {
                    MessageBox.Show("Book Details updated Succesfully", "update Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();

                }
                else
                {
                    MessageBox.Show("Unable to update Book Details", " update Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button_clear.PerformClick();

                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_bookname.Clear();
            textBox_author.Clear();
            textBox_publisher.Clear();
            textBox_price.Clear();
            textBox_quantity.Clear();
            textBox_bookid.Clear();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_bookid.Text);
            if (MessageBox.Show("Are  You Sure You Want to DELETE The Selected Book Issue Record?", "Delete Book Issue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (book.deletebook(id))
                {
                    MessageBox.Show("Book Record Deleted Succesfully", "Delete Book Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Book Issue Record Not Deleted ", "Delete Book Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void dataGridView_booklist_Click(object sender, EventArgs e)
        {
            textBox_bookname.Text = dataGridView_booklist.CurrentRow.Cells[1].Value.ToString();
            textBox_author.Text = dataGridView_booklist.CurrentRow.Cells[2].Value.ToString();
            textBox_publisher.Text = dataGridView_booklist.CurrentRow.Cells[3].Value.ToString();
            textBox_price.Text = dataGridView_booklist.CurrentRow.Cells[4].Value.ToString();
            textBox_quantity.Text = dataGridView_booklist.CurrentRow.Cells[5].Value.ToString();
            textBox_bookid.Text = dataGridView_booklist.CurrentRow.Cells[0].Value.ToString();


        }
        private void showdata()
        {
            dataGridView_booklist.DataSource = book.getlist(new MySqlCommand("SELECT * FROM `books`", connect.getconnection));
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
    }
}
