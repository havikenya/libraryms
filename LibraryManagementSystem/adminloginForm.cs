using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class adminloginForm : Form
    {
        BookreturnClass retan = new BookreturnClass();
        studentClass student = new studentClass();
        DBconnect connect = new DBconnect();
        public adminloginForm()
        {
            InitializeComponent();
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
              DataTable table = student.getlist(new MySqlCommand("SELECT * FROM `user` WHERE `username`= '" + uname + "' AND `password` = '" + pass + "'"));
              if (table.Rows.Count > 0)
              {
                  librariansForm main = new librariansForm();
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

        private void button_exit_Click(object sender, EventArgs e)
        {
            login log = new login();
            this.Hide();
            log.Show();
        }
        }
    }

