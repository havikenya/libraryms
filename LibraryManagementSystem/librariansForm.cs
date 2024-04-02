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
    public partial class librariansForm : Form
    {
        librarianClass librarian = new librarianClass();
        DBconnect connect = new DBconnect();
        public librariansForm()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text == "" || textBox_lastname.Text == "" || textBox_phonenumber.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                  
                string fname = textBox_firstname.Text;
                string lname = textBox_lastname.Text;
                string phone = textBox_phonenumber.Text;
                string pass = textBox_password.Text;

                if (librarian.addlibrarian(fname, lname, phone, pass))
                {
                    MessageBox.Show("Librarian Details Added Succesfully", "Add Librarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Unable to Add Librarian", "Add Librarian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
                        if (textBox_firstname.Text == "" || textBox_lastname.Text == "" || textBox_phonenumber.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        else
                        {
                            int libid = Convert.ToInt32(textBox_librarianid.Text);
                            string fname = textBox_firstname.Text;
                            string lname = textBox_lastname.Text;
                            string phone = textBox_phonenumber.Text;
                            string pass = textBox_password.Text;

                            if (librarian.updatelibrarian(libid,fname, lname, phone, pass))
                            {
                                MessageBox.Show("student details updated successfully", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                showdata();
                                button_clear.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("student details not updated ", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }                       

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_phonenumber.Clear();
            textBox_firstname.Clear();
            textBox_lastname.Clear();
            textBox_password.Clear();
            textBox_librarianid.Clear();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_librarianid.Text);
            if (MessageBox.Show("Are  You Sure You Want to DELETE this librarian?", "Delete librarian", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (librarian.deletelibrarian(id))
                {
                    MessageBox.Show("librarian record deleted sucessfully", "Delete Librarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("librarian records Not deleted ", "Delete Librarian", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void dataGridView_librariansdetails_Click(object sender, EventArgs e)
        {
            textBox_librarianid.Text = dataGridView_librariansdetails.CurrentRow.Cells[0].Value.ToString();
            textBox_firstname.Text = dataGridView_librariansdetails.CurrentRow.Cells[1].Value.ToString();
            textBox_lastname.Text = dataGridView_librariansdetails.CurrentRow.Cells[2].Value.ToString();
            textBox_phonenumber.Text = dataGridView_librariansdetails.CurrentRow.Cells[3].Value.ToString();
            textBox_password.Text = dataGridView_librariansdetails.CurrentRow.Cells[4].Value.ToString();


        }

        public void showdata()
        {
            dataGridView_librariansdetails.DataSource = librarian.getlibrarian(new MySqlCommand("SELECT * FROM `librariandetails`", connect.getconnection));
        }

        private void librariansForm_Load(object sender, EventArgs e)
        {
            showdata();
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
