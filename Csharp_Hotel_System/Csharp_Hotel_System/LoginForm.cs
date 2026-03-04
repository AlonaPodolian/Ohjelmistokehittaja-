using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Csharp_Hotel_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `username`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = UsernameTB.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordTB.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //if the username and the password exists
            if (table.Rows.Count > 0 )
            {
                //show the main form
                this.Hide();
                Main_Form mform = new Main_Form();
                mform.Show();
            }
            else
            {
                if(UsernameTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login","Empty Username",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (PasswordTB.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This Username Or Password Doesn't Exits", "Wrrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
 