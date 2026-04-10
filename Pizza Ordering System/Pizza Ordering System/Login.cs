namespace Pizza_Ordering_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Information!!!");
            }else if(UnameTb.Text == "User"  && PasswordTb.Text == "Pass")
            {
                Billing Obj = new Billing();
                Obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Data!!!");
            }
        }
    }
}
