using System;
using System.Data.SqlClient;

namespace StudentManagementWF
{
    class DatabaseConnection
    {
        //Make the object public in the propertie so it can be called from other classes.
        public SqlConnection Con { get; set; }
        private string conString { get; set; }


        public void conOpen()
        {
            conString = "Server=DESKTOP-6016I2G\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;"; //Connection string
            Con = new SqlConnection(conString);
            try
            {
                Con.Open();

            }
            catch (Exception)
            {
                //Poorly written exeception if the connection fails
                Console.WriteLine("Connection didn't connect.");
            }

        }
        public void conClose()
        {
            //Close the connection
            Con.Close();
        }
    }
}
