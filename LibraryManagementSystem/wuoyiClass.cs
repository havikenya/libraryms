using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class wuoyiClass
    {
        
        DBconnect connect = new DBconnect();

        //creat a function to get the fees
        public DataTable getbookreturn(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        //creat a function to insert fees into the database
        public bool addbookreturn(int returnid, int stdid, string fname, string lname, int bookid, string bName, DateTime idate, DateTime rdate)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `booksreturn`(`returnId`, `AdmNo`, `FirstName`, `LastName`, `BookId`, `BookName`, `IssueDate`, `ReturnDate`) VALUES (@rid, @adm, @fn, @ln, @bid, @bname, @idate, @rdate)", connect.getconnection);
            //@rid, @adm, @fn, @ln, @bid, @bname, @idate, @rdate         
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = returnid;
            command.Parameters.Add("@adm", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bid", MySqlDbType.Int32).Value = bookid;
            command.Parameters.Add("@bname", MySqlDbType.VarChar).Value = bName;
            command.Parameters.Add("@idate", MySqlDbType.Date).Value = idate;
            command.Parameters.Add("@rdate", MySqlDbType.Date).Value = rdate;

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
        //creat a function to update the student fee payment data
        public bool updatebookreturn(DateTime rdate)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `booksreturn` SET `ReturnDate`=@rdate WHERE `returnId`=@rid", connect.getconnection);
            command.Parameters.Add("@rdate", MySqlDbType.Date).Value = rdate;

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
        public bool deletebookreturn(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `booksreturn` WHERE `returnId`=@rid", connect.getconnection);
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = id;
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
