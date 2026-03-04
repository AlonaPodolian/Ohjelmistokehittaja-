using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    /*
     * this class will make the connection between our app and mysql database
     * first you need to download the mysql connector and add it to your project
     * download link -> https://dev.mysql.com/downloads/connector/j/
     */
    internal class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Csharp_Hotel_DB");

        //create a function to return our connection
        public MySqlConnection getConnection()
        {
            return connection; 
        }

        //create a function to open the connection
        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        //create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
