using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EPRS
{
    public partial class AdminForm : Form
    {
        private MySqlConnection connection;
        private string _username;
        private string _userID;
        public AdminForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;


                connection = new MySqlConnection(connectionString);


                connection.Open();
                LoadAdminName();
                NumberofUsers();




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadAdminName()
        {
            try
            {

                string query = "SELECT id, name FROM Users WHERE Username = @Username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", _username);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    _userID = reader["ID"].ToString();
                    string fullName = reader["name"].ToString();

                    if (!string.IsNullOrEmpty(fullName))
                    {
                        unameLbl.Text = fullName;
                    }
                    else
                    {
                        unameLbl.Text = "Unknown User";
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user information: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to close the program?",
               "Confirm Exit",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate profileUpdateForm = new ProfileUpdate(_userID, "Admin", this);
            profileUpdateForm.Show();

            LoadAdminName();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void NumberofUsers()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Users";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    UserCountLbl.Text = count.ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = NameBox.Text;
            String username = UserNameBox.Text;
            String password = PasswordBox.Text;
            String role = RoleBox.Text;

            try{
                string query = "INSERT INTO Users (name, username, password, role) VALUES (@name, @username, @password, @role)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumberofUsers();

                NameBox.Text = "";
                UserNameBox.Text = "";
                PasswordBox.Text = "";
                RoleBox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
