using MySql.Data.MySqlClient;
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
    public partial class login : Form
    {
        studentClass student = new studentClass();
        public login()
        {
            InitializeComponent();
        }

        private void label_admin_Click(object sender, EventArgs e)
        {
            adminloginForm lib = new adminloginForm();
            this.Hide();
            lib.Show();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Please Enter Your Username and Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string uname = textBox_username.Text;
                string pass = textBox_password.Text;
                DataTable table = student.getlist(new MySqlCommand("SELECT * FROM `librariandetails` WHERE `FirstName`= '" + uname + "' AND `Password` = '" + pass + "'"));
                if (table.Rows.Count > 0)
                {
                    
                    mainform main = new mainform();
                    this.Hide();
                    main.Show();
               
                }
                else
                {
                  MessageBox.Show("Wrong Username or Password, Try Again", "Wrong Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_password.Clear();
                    textBox_username.Clear();  
                }
            }
        }



    }
}
