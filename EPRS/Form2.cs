using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EPRS
{
    public partial class DatabaseConfigForm : Form
    {
        public DatabaseConfigForm()
        {
            InitializeComponent();
            LoadConnectionString();
        }

        private void LoadConnectionString()
        {
            // Load the connection string from app.config
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

            var builder = new MySqlConnectionStringBuilder(connectionString);
            serverBox.Text = builder.Server;
            dbBox.Text = builder.Database;
            userBox.Text = builder.UserID;
            passBox.Text = builder.Password;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new connection string
                var builder = new MySqlConnectionStringBuilder
                {
                    Server = serverBox.Text,
                    Database = dbBox.Text,
                    UserID = userBox.Text,
                    Password = passBox.Text
                };

                string newConnectionString = builder.ConnectionString;

                // Open the configuration file
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Update the connection string
                if (config.ConnectionStrings.ConnectionStrings["MyDatabase"] != null)
                {
                    config.ConnectionStrings.ConnectionStrings["MyDatabase"].ConnectionString = newConnectionString;
                }
                else
                {
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("MyDatabase", newConnectionString, "MySql.Data.MySqlClient"));
                }

                // Save and refresh the configuration
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("Database connection string updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating connection string: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DatabaseConfigForm_Load(object sender, EventArgs e)
        {

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
