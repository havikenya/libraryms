using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    
    class bookreturnClass
    {
        DBconnect connect = new DBconnect();

        // Function to get the list of issued books
        public DataTable GetIssuedBooks()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `issuedetails`", connect.getconnection);
            return getissuebook(command);
        }

        // Function to send email to parent for overdue books
        public void SendOverdueEmails()
        {
            DataTable issuedBooks = GetIssuedBooks();
            foreach (DataRow row in issuedBooks.Rows)
            {
                DateTime issueDate = Convert.ToDateTime(row["IssueDate"]);
                TimeSpan duration = DateTime.Now - issueDate;
                if (duration.TotalDays > 7)
                {
                    // Book is overdue, send email to parent
                    string parentEmail = GetParentEmail(row["AdmNo"].ToString()); // Assuming you have a method to get parent's email based on Admission Number
                    if (!string.IsNullOrEmpty(parentEmail))
                    {
                        SendEmailToParent(parentEmail, row["BookName"].ToString());
                    }
                }
            }
        }

        // Function to send email to parent for an overdue book
        private void SendEmailToParent(string parentEmail, string bookName)
        {
            try
            {
                // Create and send email
                MailMessage message = new MailMessage();
                message.From = new MailAddress("harveyonyango45@gmail.com");
                message.To.Add(parentEmail);
                message.Subject = "Overdue Book Notification";
                message.Body = "Dear Parent,\n\nYour child has not returned the book '" + bookName + "' on time.\n\nPlease remind them to return it as soon as possible.\n\nRegards,\nThe Library Management System";

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential("harveyonyango45@gmail.com", "COM/0056/20");
                smtpClient.Send(message);

                Console.WriteLine("Email notification sent to "+ parentEmail +" for book "+ bookName +".");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email to " + parentEmail + " for book " + bookName + "." + ex.Message);
            }
        }

        // Function to get parent's email address based on Admission Number
        private string GetParentEmail(string admissionNumber)
        {
            string parentEmail = null;

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT email FROM issuedetails WHERE AdmNo = @admissionNumber", connect.getconnection);
                command.Parameters.Add("@admissionNumber", MySqlDbType.VarChar).Value = admissionNumber;

                connect.openconnect();
                object result = command.ExecuteScalar();
                connect.closeconnect();

                if (result != null)
                {
                    parentEmail = result.ToString(); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving parent email: " + ex.Message);
            }

            return parentEmail;
        }
        //creat a function to get the issue details
        public DataTable getissuebook(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
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
        public bool addbookreturn(int stdid, string fname, string lname, int bookid, string serialno, string bName, DateTime idate, DateTime rdate)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `booksreturn`(`AdmNo`, `FirstName`, `LastName`, `BookId`, `serialno`, `BookName`, `IssueDate`, `ReturnDate`) VALUES (@adm, @fn, @ln, @bid, @sno, @bname, @idate, @rdate)", connect.getconnection);
            //@adm, @fn, @ln, @bid, @bname, @idate, @rdate         
            command.Parameters.Add("@adm", MySqlDbType.Int32).Value = stdid;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bid", MySqlDbType.Int32).Value = bookid;
            command.Parameters.Add("@sno", MySqlDbType.VarChar).Value = serialno;
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
        public bool updatebookreturn(DateTime rdate, int id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `booksreturn` SET `ReturnDate`=@rdate WHERE `returnId`=@rid", connect.getconnection);
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = id;
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
        //creat a function to delete students return data
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

