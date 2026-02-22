namespace Tehtävä16
{

    public partial class stopBT : Form
    {
        private int kokonaisaika;
        public stopBT()
        {
            InitializeComponent();
            Stop1BT.Enabled = false;
            for (int i = 0; i <= 59; i++)
            {
                minuuttitCB.Items.Add(i.ToString());
                sekunnitCB.Items.Add(i.ToString());
            }
            minuuttitCB.SelectedIndex = 1;
            sekunnitCB.SelectedIndex = 7;
        }

        private void startBT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = false;
            Stop1BT.Enabled = true;
            int minuutit = int.Parse(minuuttitCB.SelectedItem.ToString());
            int sekunnit = int.Parse(sekunnitCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            ajastinTR.Enabled = true;

        }

        private void Stop1BT_Click(object sender, EventArgs e)
        {
            startBT.Enabled = true;
            Stop1BT.Enabled = false;
            kokonaisaika = 0;
            ajastinTR.Enabled = true;
            aikaLB.Text = "00:00";
        }

        private void ajastinTR_Tick(object sender, EventArgs e)
        {
            if (kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika % 60;
                aikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                ajastinTR.Stop();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("C:\temp\alarm.");
                player.Play();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
