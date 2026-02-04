namespace Harjoitus4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paivinaLB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nyt = DateTime.Now;
            DateTime synttarit = syntymaAikaDT.Value;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            vuosinaLB.Text = Math.Floor(erotus / 365.25).ToString();
            kuukausinaLB.Text = Math.Floor(erotus / 12).ToString();
            paivinaLB.Text = erotus.ToString();
            tunteinaLB.Text = (erotus * 24).ToString();
            minuutteinaLB.Text = (erotus * 24 * 60).ToString();
            sekunteinaLB.Text = (erotus * 24 * 60 * 60).ToString();
            vuosinaLB.Visible = true; kuukausinaLB.Visible = true;
            paivinaLB.Visible = true;
            tunteinaLB.Visible = true;
            minuutteinaLB.Visible = true;
            sekunteinaLB.Visible = true;
        }

        private void syntymaAikaDT_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
