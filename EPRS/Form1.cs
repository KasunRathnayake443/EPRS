namespace EPRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = userBox.Text;
            String password = passBox.Text;

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            DatabaseConfigForm configForm = new DatabaseConfigForm();
            configForm.ShowDialog();
            
        }
    }
}