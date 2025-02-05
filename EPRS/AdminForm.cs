﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            AccountBtn.Visible = false;
            LogoutBtn.Visible = false;


            settingsBtn.Click += settingsBtn_Click;

            AccountBtn.Click += Buttons_Click;
            LogoutBtn.Click += Buttons_Click;
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
                NumberofPatients();
                LoadPatientGrid();
                NumberofMedicines();
                LoadMedicineGrid();
                LowInventoryNotification();
                SetModernTabControl1();
                load_settings();





            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetModernTabControl1()
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(140, 40);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Padding = new Point(10, 6);

            tabControl1.DrawItem += TabControl1_DrawItem;
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Graphics g = e.Graphics;
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);


            Font font = new Font("Segoe UI", 9, FontStyle.Regular);
            tabBounds.Inflate(-2, -2);


            Color selectedTabBackColor = Color.FromArgb(102, 204, 153);
            Color selectedTabForeColor = Color.White;
            Color unselectedTabBackColor = Color.FromArgb(240, 255, 240);
            Color unselectedTabForeColor = Color.FromArgb(85, 107, 47);
            Color borderColor = Color.FromArgb(180, 230, 180);

            bool isSelected = e.Index == tabControl.SelectedIndex;


            using (SolidBrush backBrush = new SolidBrush(isSelected ? selectedTabBackColor : unselectedTabBackColor))
            {
                g.FillRectangle(backBrush, tabBounds);
            }


            using (Pen borderPen = new Pen(borderColor, 1))
            {
                g.DrawRectangle(borderPen, tabBounds);
            }

            TextRenderer.DrawText(
                g,
                tabControl.TabPages[e.Index].Text,
                font,
                tabBounds,
                isSelected ? selectedTabForeColor : unselectedTabForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }


        public void InsertLog(int userId, string type, string description)
        {
            string query = "INSERT INTO logs (user_id, type, description) VALUES (@userId, @type, @description)";

            using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@description", description);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {

                }
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

        private bool isExitConfirmed = false;

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isExitConfirmed)
            {
                DialogResult result = MessageBox.Show(
                   "Are you sure you want to close the program?",
                   "Confirm Exit",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isExitConfirmed = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }



        private void settingsBtn_Click(object sender, EventArgs e)
        {


            AccountBtn.Visible = true;
            LogoutBtn.Visible = true;

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
                return;
            }

            try
            {

                string query = "INSERT INTO Users (name, username, password, role) VALUES (@name, @username, @password, @role)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);


                cmd.ExecuteNonQuery();


                MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                InsertLog(Convert.ToInt32(_userID), "Add User Account", $"User {name} added successfully.");

                NumberofUsers();
                ReloadUserGrid();


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


        public void ReloadUserGrid()
        {
            LoadUserGrid();
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
            EditUser EditUser = new EditUser(userId, this);
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

                    InsertLog(Convert.ToInt32(_userID), "Delete User Account", $"User with ID {userId} deleted successfully.");

                    LoadUserGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void NumberofPatients()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Patients";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    PatientCount.Text = count.ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPatientsBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                return;
            }

            string patientID = IdBox.Text.Trim();
            string firstName = FNameBox.Text.Trim();
            string lastName = LNameBox.Text.Trim();
            string gender = GenderBox.SelectedItem.ToString();
            string address = AddressBox.Text.Trim();
            string email = EmailBox.Text.Trim();
            string phoneNumber = PhoneBox.Text.Trim();
            string dateOfBirth = dateTimePicker.Value.ToString("yyyy-MM-dd");

            try
            {

                string checkQuery = "SELECT COUNT(*) FROM Patients WHERE PatientID = @PatientID";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@PatientID", patientID);
                int idExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (idExists > 0)
                {
                    MessageBox.Show("Patient ID already exists. Please enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string insertQuery = "INSERT INTO Patients (PatientID, FirstName, LastName, Gender, Address, Email, PhoneNumber, DateOfBirth) " +
                                     "VALUES (@PatientID, @FirstName, @LastName, @Gender, @Address, @Email, @PhoneNumber, @DateOfBirth)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@PatientID", patientID);
                insertCmd.Parameters.AddWithValue("@FirstName", firstName);
                insertCmd.Parameters.AddWithValue("@LastName", lastName);
                insertCmd.Parameters.AddWithValue("@Gender", gender);
                insertCmd.Parameters.AddWithValue("@Address", address);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                insertCmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    NumberofPatients();
                    LoadPatientGrid();

                    InsertLog(Convert.ToInt32(_userID), "Add Patient", $"Patient with ID {patientID} added successfully.");

                }
                else
                {
                    MessageBox.Show("Failed to add patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(IdBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the Patient ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(FNameBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FNameBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(LNameBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LNameBox.Focus();
                return false;
            }

            if (GenderBox.SelectedItem == null)
            {
                MessageBox.Show("Please select the Gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenderBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(AddressBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(EmailBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(PhoneBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneBox.Focus();
                return false;
            }

            return true;
        }

        public void LoadPatientGrid()
        {
            try
            {

                string query = "SELECT PatientID, CONCAT(FirstName, ' ', LastName) AS FullName, Gender, Email, PhoneNumber FROM Patients";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable patientTable = new DataTable();
                adapter.Fill(patientTable);


                PatientDataGrid.DataSource = patientTable;


                PatientDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PatientDataGrid.BackgroundColor = Color.White;
                PatientDataGrid.BorderStyle = BorderStyle.None;
                PatientDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                PatientDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                PatientDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
                PatientDataGrid.RowHeadersVisible = false;
                PatientDataGrid.AllowUserToAddRows = false;


                if (PatientDataGrid.Columns["EditButton"] == null)
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "EditButton",
                        HeaderText = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    PatientDataGrid.Columns.Add(editButtonColumn);
                }

                if (PatientDataGrid.Columns["DeleteButton"] == null)
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "DeleteButton",
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    PatientDataGrid.Columns.Add(deleteButtonColumn);
                }


                PatientDataGrid.CellClick -= PatientDataGrid_CellClick;
                PatientDataGrid.CellClick += PatientDataGrid_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PatientDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == PatientDataGrid.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                string patientId = PatientDataGrid.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                EditPatient(patientId);
            }
            else if (e.ColumnIndex == PatientDataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                string patientId = PatientDataGrid.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                DeletePatient(patientId);
            }
        }

        public void ReloadPatientGrid()
        {
            LoadPatientGrid();
        }
        private void EditPatient(string patientId)
        {
            EditPatient editPatient = new EditPatient(patientId, this);
            editPatient.Show();
            ReloadPatientGrid();
        }

        private void DeletePatient(string patientId)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Patients WHERE PatientID = @PatientID";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadPatientGrid();
                    InsertLog(Convert.ToInt32(_userID), "Delete Patient", $"Patient with ID {patientId} deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void NumberofMedicines()
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Medicine";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    medicineCountLbl.Text = count.ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicine count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void addNewMedicineBtn_Click(object sender, EventArgs e)
        {
            if (!medicineFieldsValidation())
            {
                return;
            }

            string medicineName = MedicineNameBox.Text.Trim();
            string medicineAmount = MedicineAmountBox.Text.Trim();

            string query = "INSERT INTO Medicine (name, amount_grams) VALUES (@MedicineName, @Amount)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@MedicineName", medicineName);
            cmd.Parameters.AddWithValue("@Amount", medicineAmount);

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Medicine added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NumberofMedicines();
                    MedicineNameBox.Text = "";
                    MedicineAmountBox.Text = "";
                    LoadMedicineGrid();

                    InsertLog(Convert.ToInt32(_userID), "Add Medicine", $"Medicine {medicineName} added successfully.");

                }
                else
                {
                    MessageBox.Show("Failed to add medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool medicineFieldsValidation()
        {
            if (string.IsNullOrEmpty(MedicineNameBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the Medicine Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MedicineNameBox.Focus();
                return false;
            }



            if (string.IsNullOrEmpty(MedicineAmountBox.Text.Trim()))
            {
                MessageBox.Show("Please enter the Medicine Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MedicineAmountBox.Focus();
                return false;
            }

            return true;
        }

        public void LoadMedicineGrid()
        {
            try
            {
                string query = "SELECT id, name, amount_grams FROM Medicine";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable medicineTable = new DataTable();
                adapter.Fill(medicineTable);

                MedicineDataGrid.DataSource = medicineTable;

                MedicineDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                MedicineDataGrid.BackgroundColor = Color.White;
                MedicineDataGrid.BorderStyle = BorderStyle.None;
                MedicineDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                MedicineDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
                MedicineDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
                MedicineDataGrid.RowHeadersVisible = false;
                MedicineDataGrid.AllowUserToAddRows = false;

                if (MedicineDataGrid.Columns["EditButton"] == null)
                {
                    DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "EditButton",
                        HeaderText = "Edit",
                        Text = "Edit",
                        UseColumnTextForButtonValue = true
                    };
                    MedicineDataGrid.Columns.Add(editButtonColumn);
                }

                if (MedicineDataGrid.Columns["DeleteButton"] == null)
                {
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                    {
                        Name = "DeleteButton",
                        HeaderText = "Delete",
                        Text = "Delete",
                        UseColumnTextForButtonValue = true
                    };
                    MedicineDataGrid.Columns.Add(deleteButtonColumn);
                }

                MedicineDataGrid.CellClick -= MedicineDataGrid_CellClick;
                MedicineDataGrid.CellClick += MedicineDataGrid_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicine data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MedicineDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == MedicineDataGrid.Columns["EditButton"].Index && e.RowIndex >= 0)
            {
                string selectedMedicineName = (MedicineDataGrid).Rows[e.RowIndex].Cells["name"].Value.ToString();

                EditMedicine(selectedMedicineName);
            }
            else if (e.ColumnIndex == MedicineDataGrid.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
                string medicineId = MedicineDataGrid.Rows[e.RowIndex].Cells["id"].Value.ToString();
                DeleteMedicine(medicineId);
            }
        }

        private void EditMedicine(string selectedMedicineName)
        {


            EditMedicineAdmin editMedicine = new EditMedicineAdmin(selectedMedicineName, this);
            editMedicine.Show();
            LoadMedicineGrid();
            LowInventoryNotification();
        }

        private void DeleteMedicine(string medicineId)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this medicine?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Medicine WHERE id = @MedicineId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MedicineId", medicineId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Medicine deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InsertLog(Convert.ToInt32(_userID), "Delete Medicine", $"Medicine with ID {medicineId} deleted successfully.");

                    LoadMedicineGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void LowInventoryNotification()
        {
            notificationPanel.Controls.Clear();

            int low_stock = 0;


            string query1 = "SELECT low_stock FROM settings WHERE id = 1";
            using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
            {
                using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                {
                    if (reader1.Read())
                    {
                        low_stock = reader1["low_stock"] != DBNull.Value ? Convert.ToInt32(reader1["low_stock"]) : 0;
                    }
                }
            }

            string query = "SELECT name, amount_grams FROM medicine";
            DataTable medicineTable = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
            {
                adapter.Fill(medicineTable);
            }


            int yOffset = 0;
            foreach (DataRow row in medicineTable.Rows)
            {
                string medicineName = row["name"].ToString();
                double amountGrams = row["amount_grams"] != DBNull.Value ? Convert.ToDouble(row["amount_grams"]) : 0.0;

                if (amountGrams < low_stock)
                {
                    ShowLowStockNotification(medicineName, amountGrams, yOffset, notificationPanel);
                    yOffset += 30;
                }
            }
        }


        private void ShowLowStockNotification(string medicineName, double amountGrams, int yOffset, Panel targetPanel1)
        {

            Label notificationLabel1 = new Label
            {
                Text = $"{medicineName} is low on stock. Available amount: {amountGrams} grams.",
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(5, yOffset)
            };


            Label notificationLabel2 = new Label
            {
                Text = $"{medicineName} is low on stock. Available amount: {amountGrams} grams.",
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(5, yOffset)
            };


            targetPanel1.Controls.Add(notificationLabel1);



        }

        private void AdminForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (AccountBtn.Visible || LogoutBtn.Visible)
            {
                AccountBtn.Visible = false;
                LogoutBtn.Visible = false;
            }
        }

        private void AdminForm_Click(object sender, MouseEventArgs e)
        {
            if (AccountBtn.Visible || LogoutBtn.Visible)
            {

                AccountBtn.Visible = false;
                LogoutBtn.Visible = false;
            }
        }
        private void Buttons_Click(object sender, EventArgs e)
        {

        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate profileUpdateForm = new ProfileUpdate(_userID, "Admin", this);
            profileUpdateForm.Show();

            LoadAdminName();
        }



        private void LogoutBtn_Click(object sender, EventArgs e)
        {



            DialogResult result = MessageBox.Show(
               "Are you sure you want to logout?", "Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }

        }


        private void load_settings()
        {
            string query = "SELECT * FROM Settings where id = 1 ";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string low_stock = reader["low_stock"].ToString();


                Low_stock_box.Text = low_stock;

            }
            reader.Close();
            themeBox.SelectedIndex = 0;

        }

        private void settings_saveBtn_Click(object sender, EventArgs e)
        {
            string low_stock = Low_stock_box.Text.Trim();

            string query = "UPDATE Settings SET low_stock = @low_stock WHERE id = 1";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@low_stock", low_stock);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Close();
            MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LowInventoryNotification();
            load_settings();
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql",
                Title = "Save Backup File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BackupDatabase(saveFileDialog.FileName);
            }
        }

        public void BackupDatabase(string backupFilePath)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                string backupCommand = $"mysqldump -u root -pyourpassword yourdatabase > \"{backupFilePath}\"";

                var process = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {backupCommand}",
                        RedirectStandardInput = false,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                process.WaitForExit();

                MessageBox.Show("Backup completed successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during backup: {ex.Message}", "Error");
            }
        }

        public void RestoreDatabase(string backupFilePath)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                string restoreCommand = $"mysql -u root -pyourpassword yourdatabase < \"{backupFilePath}\"";

                var process = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/C {restoreCommand}",
                        RedirectStandardInput = false,
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();
                process.WaitForExit();

                MessageBox.Show("Database restored successfully!", "Success");
                InsertLog(Convert.ToInt32(_userID), "Restore Database", "Database restored successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during restoration: {ex.Message}", "Error");
            }
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "SQL Files (*.sql)|*.sql",
                Title = "Select Backup File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RestoreDatabase(openFileDialog.FileName);
            }
        }
    }
}
