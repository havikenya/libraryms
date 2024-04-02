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
    public partial class studentForm : Form
    {
        studentClass student = new studentClass();
        DBconnect connect = new DBconnect();
        public studentForm()
        {
            InitializeComponent();
        }

       private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text == "" || textBox_lastname.Text == "" || textBox_admno.Text == "" || comboBox_class.Text == "" || comboBox_stream.Text == "" || textBox_eadress.Text == "" )
            {
                MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fname = textBox_firstname.Text;
                string lname = textBox_lastname.Text;
                string adm = textBox_admno.Text;
                string clas= comboBox_class.Text;
                string strm = comboBox_stream.Text;
                string eadress = textBox_eadress.Text;


                if (student.addstudent(fname, lname, adm, clas, strm, eadress))
                {
                    MessageBox.Show("Student Details Added Succesfully", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Unable to Add Student", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

       private void button_edit_Click(object sender, EventArgs e)
       {
           if (textBox_firstname.Text == "" || textBox_lastname.Text == "" || textBox_admno.Text == "" || comboBox_class.Text == "" || comboBox_stream.Text == "" || textBox_eadress.Text == "")
           {
               MessageBox.Show("all fields are required", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
               string fname = textBox_firstname.Text;
               string lname = textBox_lastname.Text;
               string adm = textBox_admno.Text;
               string clas = comboBox_class.Text;
               string strm = comboBox_stream.Text;
               string eadress = textBox_eadress.Text;


                if (student.updatestudent(fname, lname, adm, clas, strm, eadress))
               {
                   MessageBox.Show("student details updated successfully", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   showdata();
                   button_clear.PerformClick();
               }
               else
               {
                   MessageBox.Show("unable to update student details", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

           }
       }

       private void button_clear_Click(object sender, EventArgs e)
       {
           textBox_admno.Clear();
           textBox_firstname.Clear();
           textBox_lastname.Clear();
           comboBox_class.SelectedIndex = -1;
           comboBox_stream.SelectedIndex = -1;
           textBox_eadress.Clear();
       }

       private void button_delete_Click(object sender, EventArgs e)
       {
           int id = Convert.ToInt32(textBox_admno.Text);
              if (MessageBox.Show("Are  You Sure You Want to DELETE The Selected Return Book Record?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (student.deletestudent(id))
                {
                    MessageBox.Show("Student Record Deleted Succesfully", "Delete Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showdata();
                    button_clear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Unable to Delete the Students Records", "Delete Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
       }

       private void dataGridView_studentdetails_Click(object sender, EventArgs e)
       {
           textBox_firstname.Text = dataGridView_studentdetails.CurrentRow.Cells[0].Value.ToString();
           textBox_lastname.Text = dataGridView_studentdetails.CurrentRow.Cells[1].Value.ToString();
           textBox_admno.Text = dataGridView_studentdetails.CurrentRow.Cells[2].Value.ToString();
           comboBox_class.Text = dataGridView_studentdetails.CurrentRow.Cells[3].Value.ToString();
           comboBox_stream.Text = dataGridView_studentdetails.CurrentRow.Cells[4].Value.ToString();
           textBox_eadress.Text = dataGridView_studentdetails.CurrentRow.Cells[5].Value.ToString();

        }

       private void studentForm_Load(object sender, EventArgs e)
       {
           showdata();
           comboBox_class.SelectedIndex = 0;
           comboBox_stream.SelectedIndex = 0;
       }
       public void showdata() 
       {
           dataGridView_studentdetails.DataSource = student.getlist(new MySqlCommand("SELECT * FROM `student`", connect.Getconnection()));
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

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
