using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    class librarianClass
    {
        DBconnect connect = new DBconnect();

        //creat a function to get the fees
        public DataTable getlibrarian(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        //creat a function to insert librarian details into the database
        public bool addlibrarian(string fname, string lname, string phone, string password)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `librariandetails`(`FirstName`, `LastName`, `Phone`, `Password`) VALUES (@fn,@ln,@ph,@pass)", connect.getconnection);
            //@fn, @ln, @ph, @pass           
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

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
        //creat a function to update the librarian details in the database
        public bool updatelibrarian(int libdid, string fname, string lname, string phone, string password)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `librariandetails` SET `FirstName`= @fn,`LastName`= @ln,`Phone`= @ph,`Password`= @pass WHERE `LibrarianId`= @libid", connect.getconnection);
            //@libid, @fn, @ln, @ph, @pass           
            command.Parameters.Add("@libid", MySqlDbType.Int32).Value = libdid;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
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
        public bool deletelibrarian(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `librariandetails` WHERE `LibrarianId`=@libid", connect.getconnection);
            command.Parameters.Add("@libid", MySqlDbType.Int32).Value = id;
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
