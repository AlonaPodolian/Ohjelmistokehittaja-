namespace Tehtävä7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilometriCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            double laina, nesteet, vakuutus, pesut, huollot, renkaat, muut, energia, kilometrit, kustannukset;
            laina =  double.Parse(lainanTB.Text);
            nesteet = double.Parse(nesteetTB.Text);
            pesut = double.Parse(pesutTB.Text);
            huollot = double.Parse(huollotTB.Text);
            renkaat = double.Parse(renkaatTB.Text);
            muut = double.Parse(muutTB.Text);
            energia = double.Parse(polttonesteTB.Text);
            vakuutus = double.Parse(vakuukuksetTB.Text);
            kilometrit = double.Parse(kilometriCB.Text);
            kustannukset = (laina + nesteet + pesut + huollot + renkaat + muut + energia + vakuutus) / kilometrit;
            vastausLB.Text = "Kustannukset kilometriä kohti ovat: " + kustannukset;
            vastausLB.Visible = true;
        }

       
    }
}
