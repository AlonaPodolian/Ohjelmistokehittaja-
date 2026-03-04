using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Csharp_Hotel_System
{
    public partial class ManageClientsForm : Form
    {
        CLIENT client = new CLIENT();
        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxCountry.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBoxFirstName.Text;
            String lname = textBoxLastName.Text;
            String phone = textBoxPhone.Text;
            String country = textBoxCountry.Text;

            if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("Reuired Fields - First & Last Name + Phone Number", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertClient = client.insertClient(fname, lname, phone, country);

                if (insertClient)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("New Client Inserted Successfuly", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

        
    }
}
