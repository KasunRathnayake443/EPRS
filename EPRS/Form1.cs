using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace EPRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = userBox.Text;
            string password = passBox.Text;

            string role = AuthenticateUser(username, password);

            if (role != null)
            {
                

                
                switch (role.ToLower())
                {
                    case "admin":
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        break;
                    case "doctor":
                        DoctorForm doctorForm = new DoctorForm();
                        doctorForm.Show();
                        break;
                    case "staff":
                        StaffForm staffForm = new StaffForm();
                        staffForm.Show();
                        break;
                    default:
                        MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }


                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string AuthenticateUser(string username, string password)
        {
            try
            {
                // Get the connection string from app.config
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return result.ToString(); 
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        private void settingsBtn_Click(object sender, EventArgs e)
        {
            DatabaseConfigForm configForm = new DatabaseConfigForm();
            configForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
