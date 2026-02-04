namespace toinen_tehtava
{
    public partial class Harjoitus2 : Form
    {
        public Harjoitus2()
        {
            InitializeComponent();
        }

        private void TulostaBT_Click(object sender, EventArgs e)
        {
            string teksti = ViestiTB.Text;
            TulostaLB.Visible = true;
            if (teksti.Length > 0)
            {
                TulostaLB.Text = teksti;
            }
            else
            {
                TulostaLB.Text = "Et syöttänyt mitään tekstiä";
                ViestiTB.Focus();
                TulostaLB.Visible=false;
            }
        }
    }
}
