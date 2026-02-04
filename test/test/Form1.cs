namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tekstiBT_Click(object sender, EventArgs e)
        {
            tekstiLB.Visible = true;
            if (tekstiLB.Text == "Heippa maailma")
            {
                tekstiLB.Text = "Huomenta opiskelijat";
                tekstiBT.BackColor = Color.Red;
                BackColor = Color.Yellow;
                tekstiLB.ForeColor = Color.Blue;
            }
            else
            {
                tekstiLB.Text = "Heippa maailma";
                tekstiBT.BackColor= Color.Yellow;
                BackColor = Color.Red;
                tekstiLB.ForeColor = Color.White;
            }
        }
    }
}
