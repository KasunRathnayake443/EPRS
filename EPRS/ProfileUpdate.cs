using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace EPRS
{
    public partial class ProfileUpdate : Form
    {
        private MySqlConnection connection;
        private string _userID;
        private string _role;
        private Form _parentForm;

        public ProfileUpdate(string userID, string role, Form parentForm)
        {
            InitializeComponent();
            this._userID = userID;
            this._role = role;
            this._parentForm = parentForm;
        }

        private void ProfileUpdate_Load(object sender, EventArgs e)
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

            label1.Text = _role + " ID: " + _userID;
        }

        

        private void LoadUserDetails()
        {
            try
            {
                string query = "SELECT name, Username, Password FROM Users WHERE id = @StaffID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@StaffID", _userID);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nameBox.Text = reader["name"].ToString();
                    userBox.Text = reader["Username"].ToString();
                    passBox.Text = reader["Password"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Users SET name = @Name, Username = @Username, Password = @Password WHERE id = @UserID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", nameBox.Text);
                cmd.Parameters.AddWithValue("@Username", userBox.Text);
                cmd.Parameters.AddWithValue("@Password", passBox.Text);
                cmd.Parameters.AddWithValue("@UserID", _userID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_parentForm is DoctorForm doctorForm)
                    {
                        doctorForm.ReloadDoctorDetails();
                    }
                    else if (_parentForm is StaffForm staffForm)
                    {
                        staffForm.LoadStaffName();
                    }
                }
                else
                {
                    MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfileUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}