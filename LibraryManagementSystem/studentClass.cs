using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    class studentClass
    {

        DBconnect connect = new DBconnect();

        //creat a function to get the fees
        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.Getconnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        //creat a function to add student details into the database
        public bool addstudent(string fname, string lname, string adm, string clas, string stream, string emailAddress)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`FirstName`, `LastName`, `AdmNo`, `Class`, `Stream`, 'emailAddress') VALUES (@fn,@ln,@adm,@cl, @st, @ea)", connect.Getconnection());
            //@fn,@ln,@adm,@cl, @st , @ea         
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@adm", MySqlDbType.VarChar).Value = adm;
            command.Parameters.Add("@cl", MySqlDbType.VarChar).Value = clas;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = stream;
            command.Parameters.Add("@ea", MySqlDbType.VarChar).Value = emailAddress;


            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }
        //creat a function to update the student details in the database
        public bool updatestudent(string fname, string lname, string adm, string clas, string stream, string emailAddress)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `student` SET `FirstName`= @fn,`LastName`=@ln,`Class`= @cl,`Stream`=@st, 'emailAddress'=@ea WHERE `AdmNo`= @adm", connect.Getconnection());
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@adm", MySqlDbType.VarChar).Value = adm;
            command.Parameters.Add("@cl", MySqlDbType.VarChar).Value = clas;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = stream;
            command.Parameters.Add("@ea", MySqlDbType.VarChar).Value = emailAddress;



            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }
        //creat a function to delete the fees data
        public bool deletestudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE `AdmNo`=@adm", connect.Getconnection());
            command.Parameters.Add("@adm", MySqlDbType.Int32).Value = id;
            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }

    }
}
