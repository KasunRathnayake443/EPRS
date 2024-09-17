using MySql.Data.MySqlClient;
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
using System.Windows.Forms;

namespace EPRS
{

    public partial class EditUser : Form
    {
        private MySqlConnection connection;

        private string UserID;
        public EditUser(string UserID)
        {
            InitializeComponent();
            this.UserID = UserID;


        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                connection = new MySqlConnection(connectionString);
                connection.Open();

                LoadUserDetails();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadUserDetails()
        {
            try
            {
                string query = "SELECT name, Username, Password, role FROM Users WHERE id = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", UserID);


                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    NameBox.Text = reader["name"].ToString();
                    UsernameBox.Text = reader["Username"].ToString();
                    PasswordBox.Text = reader["Password"].ToString();
                    string role = reader["role"].ToString();

                    UserId.Text = role + " ID: " + UserID;
                }


                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Users SET name = @Name, Username = @Username, Password = @Password WHERE id = @UserID";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Name", NameBox.Text);
            cmd.Parameters.AddWithValue("@Username", UsernameBox.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordBox.Text);
            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("User details updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
