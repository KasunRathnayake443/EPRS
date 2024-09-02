using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;


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
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

            var builder = new SqlConnectionStringBuilder(connectionString);
            serverBox.Text = builder.DataSource;
            dbBox.Text = builder.InitialCatalog;
            userBox.Text = builder.UserID;
            passBox.Text = builder.Password;
        }

        private void DatabaseConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var builder = new SqlConnectionStringBuilder
                {
                    DataSource = serverBox.Text,
                    InitialCatalog = dbBox.Text,
                    UserID = userBox.Text,
                    Password = passBox.Text
                };

                string newConnectionString = builder.ConnectionString;

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["MyDatabase"].ConnectionString = newConnectionString;
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
