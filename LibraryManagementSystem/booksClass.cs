using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    class booksClass
    {

        DBconnect connect = new DBconnect();

        //creat a function to get the books
        public DataTable getlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        //creat a function to insert books into the database
        public bool addbooks(string bname, string author, string pub, int price, int Qnt)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `books`(`BookName`, `Author`, `Publisher`, `Price`, `Quantity`) VALUES ( @bName, @bAuthor, @pub, @pr, @Qt)", connect.getconnection);
            //@bName, @bAuthor, @pub, @pr, @Qt          
            command.Parameters.Add("@bName", MySqlDbType.VarChar).Value = bname;
            command.Parameters.Add("@bAuthor", MySqlDbType.VarChar).Value = author;
            command.Parameters.Add("@pub", MySqlDbType.VarChar).Value = pub;
            command.Parameters.Add("@pr", MySqlDbType.Int32).Value = price;
            command.Parameters.Add("@Qt", MySqlDbType.Int32).Value = Qnt;

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
        //creat a function to update the the books details in the database
        public bool updatebooks(int id, string bname, string author, string pub, int price, int Qnt)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `books` SET `BookName`=@bname,`Author`=@author,`Publisher`=@pub,`Price`=@pr,`Quantity`=@qt WHERE `bookId`=@bid", connect.getconnection);
            command.Parameters.Add("@bid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@bName", MySqlDbType.VarChar).Value = bname;
            command.Parameters.Add("@author", MySqlDbType.VarChar).Value = author;
            command.Parameters.Add("@pub", MySqlDbType.VarChar).Value = pub;
            command.Parameters.Add("@pr", MySqlDbType.Int32).Value = price;
            command.Parameters.Add("@Qt", MySqlDbType.Int32).Value = Qnt;

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
        //creat a function to delete a book from the database
        public bool deletebook(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `books` WHERE `bookId`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
