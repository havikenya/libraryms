using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace LibraryManagementSystem
{
    class issuebookClass
    {
        DBconnect connect = new DBconnect();

        public DataTable getissuebook(MySqlCommand command)
        {
            command.Connection = connect.Getconnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //creat a function to insert issue details into the database
        public bool addbookissued(int adm, string fname, string lname, int bookid, string serialno, string bookname, DateTime Issuedate)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `issuedetails`(`AdmNo`, `FirstName`, `LastName`, `BookId`, `serialno`, `BookName`, `IssueDate`) VALUES (@adm, @fn, @ln, @bid, @sno, @bname, @idate)", connect.Getconnection());
            //@adm, @fn, @ln, @bid, @bname, @idate 
            command.Parameters.Add("@adm", MySqlDbType.Int32).Value = adm;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bid", MySqlDbType.Int32).Value = bookid;
            command.Parameters.Add("@sno", MySqlDbType.VarChar).Value = serialno;
            command.Parameters.Add("@bname", MySqlDbType.VarChar).Value = bookname;
            command.Parameters.Add("@idate", MySqlDbType.Date).Value = Issuedate;

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
        //creat a function to update the the book issue details in the database
        public bool updateissuedetails(DateTime Issuedate)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `issuedetails` SET `IssueDate`=@idate WHERE `IssueId`=@adm", connect.Getconnection());
            command.Parameters.Add("@idate", MySqlDbType.Date).Value = Issuedate;

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
        //creat a function to delete the issue details in the database
        public bool deleteissuedetails(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `issuedetails` WHERE `IssueId`=@bid", connect.Getconnection());
            command.Parameters.Add("@bid", MySqlDbType.Int32).Value = id;
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

        internal bool addbookissued(int adm, string fname, string lname, int bid, string serialno, string bname, DateTime idate, string Eadress)
        {
            throw new NotImplementedException();
        }
    }
}
