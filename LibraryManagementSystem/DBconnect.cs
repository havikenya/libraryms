using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    class DBconnect
    {
        MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=librarydb;Convert zero Datetime=true;");
        // to get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }
        //creat a function to open connectiom
        public void openconnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        //creat a function to close connectiom
        public void closeconnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

        internal MySqlConnection Getconnection()
        {
            throw new NotImplementedException();
        }
    }
}
