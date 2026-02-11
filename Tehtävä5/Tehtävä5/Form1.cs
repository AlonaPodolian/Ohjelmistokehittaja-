using System.Diagnostics.Eventing.Reader;

namespace Tehtävä5
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void uusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (luvutTB.Text = ".999")
                {
                    VastausLB.Text = "";
                    luvutTB.Text = "";
                    int[] taulu = jono.ToArray();
                    Array.Sort(taulu);
                    foreach (int luku in taulu)
                    {
                        VastausLB.Text += luku.ToString() + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(int.Parse(luvutLB.Text));
                    luvutTB.Text = " ";
                }
            }
            else if (e.KeyChar == (char)Keys.Escape) 
            {
                TyhjaaLomake();
            }

        }
        private void TyhjaaLomake()
        {
            luvutTB.Text = " ";
        }
        
    }
}
