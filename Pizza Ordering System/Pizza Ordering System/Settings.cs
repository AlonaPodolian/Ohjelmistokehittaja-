using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pizza_Ordering_System
{
    public partial class Settings : Form
    {
        Functions Con;
        public Settings()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Billing Obj = new Billing();
            Obj.Show();
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string Key;
            try
            {
                
                    int Pr = Convert.ToInt32(PriceTb.Text);
                
                
                if(PizzaCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select A Pizza!!!");
                }
                else if(PizzaCb.SelectedIndex == 0)
                {
                    Key = "Extra Large";
                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'"; 
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
                else if(PizzaCb.SelectedIndex == 1)
                {
                    Key = "Large";
                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
                else if (PizzaCb.SelectedIndex == 2)
                {
                    Key = "Medium";
                    string Query = "Update PizzaTbl set Price = {0} where Item = '{1}'";
                    Query = string.Format(Query, Pr, Key);
                    Con.setData(Query);
                    MessageBox.Show("Price Updated!!!");
                }
                else if (PizzaCb.SelectedIndex == 3)
                {
                    Key = "Small";

                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
    }
}
