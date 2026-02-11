namespace Tehtävä6
{
    public partial class salasanaFM : Form
    {
        public salasanaFM()
        {
            InitializeComponent();
        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Alona" && SalasanaTB.Text == "A100#001")
            {
                salasanaPL.Visible = false;
                salasanaOikeinPL.Visible = true;
            }
            else
            {
                virheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                virheViestiLB.Visible = true;
            }
        }

        private void KayttajaTB_TextChanged(object sender, EventArgs e)
        { 

        }

        private void SalasanaTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
