using System.Diagnostics;
using System.Drawing.Text;

namespace Tehtävä15
{
    public partial class form : Form
    {
        private Stopwatch sekkari = new Stopwatch();

        public form()
        {
            InitializeComponent();

        }

        private void startBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void stopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();
        }

        private void resetB_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void ajastinTR_Tick(object sender, EventArgs e)
        {
            aikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}
