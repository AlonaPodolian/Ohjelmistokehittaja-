using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Csharp_Hotel_System
{
    /*
     *create a class client to add a new client
     *                         edit client data
     *                         remove client
     *                         get all clients
     */
    internal class CLIENT
    {
        CONNECT conn = new CONNECT();   
        // create a function to insert a new client
        public bool insertClient(String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `clients`(`first name`, `last name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        // create a function to get the clients list
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `clients`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        // create a function to edit a client data
        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `clients` SET ,`first name` =@fnm,`last name`=@lnm,`phone`=@phn,`country`=@cnt WHERE `id`=@cid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @cid,@fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}
