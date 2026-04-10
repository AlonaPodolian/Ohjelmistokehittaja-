using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Pizza_Ordering_System
{
    public partial class Billing : Form
    {
        Functions Con;

        public Billing()
        {
            Con = new Functions();
            InitializeComponent();
            printDocument1.PrintPage += printDocument1_PrintPage;

            GrdTotalLbl.ForeColor = Color.Blue;
            GrdTotalLbl.Font = new Font("Century Gothic", 14, FontStyle.Bold);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }

        int Key = 0;
        int Price = 0;
        int GrdTotal = 0;
        int n = 0;
        string Items;

        private void GetPrice(int Key)
        {
            string Pizza = "";
            if (Key == 1) Pizza = "Small";
            else if (Key == 2) Pizza = "Medium";
            else if (Key == 3) Pizza = "Large";
            else if (Key == 4) Pizza = "Extra Large";
            else
            {
                MessageBox.Show("Please select a pizza size!");
                return;
            }

            string Query = string.Format("select * from PizzaTbl where Item = '{0}'", Pizza);
            var table = Con.GetData(Query);
            if (table.Rows.Count > 0)
            {
                Price = Convert.ToInt32(table.Rows[0][1].ToString());
            }
            else
            {
                MessageBox.Show("Pizza not found!");
                Price = 0;
            }
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (SmallBtn.Checked) { Key = 1; Items = "Small Pizza"; }
            else if (MediumBtn.Checked) { Key = 2; Items = "Medium Pizza"; }
            else if (LargeBtn.Checked) { Key = 3; Items = "Large Pizza"; }
            else if (ExtraLargeBtn.Checked) { Key = 4; Items = "Extra Large Pizza"; }
            else
            {
                MessageBox.Show("Please select a pizza size!");
                return;
            }

            GetPrice(Key);
            if (Price == 0) return;

            if (!int.TryParse(QtyTb.Text, out int Qty) || Qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity!");
                return;
            }

            int total = Qty * Price;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(BillDGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = Items;
            newRow.Cells[2].Value = Price;
            newRow.Cells[3].Value = Qty;
            newRow.Cells[4].Value = total;
            BillDGV.Rows.Add(newRow);

            n++;
            GrdTotal += total;
            GrdTotalLbl.Text = "Rs " + GrdTotal;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
           
            printDocument1.DefaultPageSettings.PaperSize =
                new System.Drawing.Printing.PaperSize("Receipt", 285, 600);

            printPreviewDialog1.Document = printDocument1; // <- tärkeä!

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

                // Cleaning after printing 
                BillDGV.Rows.Clear();
                GrdTotal = 0;
                n = 0;
                pos = 70;
            }
        }
            //printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
            //printDocument1.Print();
        

        int prodid, prodprice, prodqty, tottal, pos = 70;
        string prodname;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int pos = 20;
            StringFormat centerFormat = new StringFormat();
            centerFormat.Alignment = StringAlignment.Center;
            centerFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString("PIZZA ORDERING", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Rectangle(0, pos, 285, 20), centerFormat);
            pos += 30;
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Rectangle(0, pos, 285, 20), centerFormat);
            pos += 30;

           
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                if (row.IsNewRow) continue;

                prodid = Convert.ToInt32(row.Cells[0].Value);
                prodname = row.Cells[1].Value.ToString();
                prodprice = Convert.ToInt32(row.Cells[2].Value);
                prodqty = Convert.ToInt32(row.Cells[3].Value);
                tottal = Convert.ToInt32(row.Cells[4].Value);

                e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(10, pos));
                e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(30, pos));
                e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(140, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(180, pos));
                e.Graphics.DrawString("" + tottal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(230, pos));

                pos += 30;
            }
            pos = pos + 30;
            e.Graphics.DrawString("Grand Total: RS " + GrdTotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Rectangle(0, pos, 285, 20), centerFormat);
            pos = pos + 30;
            e.Graphics.DrawString("***************PIZZA***************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Rectangle(0, pos, 285, 20), centerFormat);

            e.HasMorePages = false;


          
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}