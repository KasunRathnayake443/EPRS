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
                LoadUserGrid();




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
            String name = NameBox.Text.Trim();
            String username = UserNameBox.Text.Trim();
            String password = PasswordBox.Text.Trim();
            String role = RoleBox.Text.Trim();


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {

                MessageBox.Show("All fields are required. Please fill out all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if validation fails
            }

            try
            {
                // Insert the user into the database if all fields are filled
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


        public void LoadUserGrid()
        {
            try
            {
                string query = "SELECT id, name, username, role FROM Users";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable userTable = new DataTable();
                adapter.Fill(userTable);

                UserGrid.DataSource = userTable;


                UserGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                UserGrid.BackgroundColor = Color.White;
                UserGrid.BorderStyle = BorderStyle.None;
                UserGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                UserGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                UserGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
                UserGrid.RowHeadersVisible = false;
                UserGrid.AllowUserToAddRows = false;


                if (UserGrid.Columns["EditButton"] == null)
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "EditButton",
                        HeaderText = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    UserGrid.Columns.Add(editButtonColumn);
                }

                if (UserGrid.Columns["DeleteButton"] == null)
                {

                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "DeleteButton",
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    UserGrid.Columns.Add(deleteButtonColumn);
                }


                UserGrid.CellClick -= UserGrid_CellClick;
                UserGrid.CellClick += UserGrid_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UserGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == UserGrid.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                string userId = UserGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                EditUser(userId);
            }

            else if (e.ColumnIndex == UserGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                string userId = UserGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                DeleteUser(userId);
            }
        }

        private void EditUser(string userId)
        {
            EditUser EditUser = new EditUser(userId);
            EditUser.Show();
            LoadUserGrid();
        }

        private void DeleteUser(string userId)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Users WHERE id = @UserId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the grid after deletion
                    LoadUserGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
