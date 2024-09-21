﻿using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EPRS
{
    public partial class DoctorForm : Form
    {
        private MySqlConnection connection;
        private string _username;
        private string _userID;

        public DoctorForm(string username)
        {
            InitializeComponent();
            _username = username;

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;


                connection = new MySqlConnection(connectionString);


                connection.Open();


                InitializeSearchBox();


                LoadPatientIDs();


                LoadDoctorName();

                LoadMedicineInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadDoctorDetails()
        {

            LoadDoctorName();
        }

        public void ReloadMedicineInventory()
        {
            LoadMedicineInventory();

        }
        public void ReloadPrescriptionDetails(string patientID)
        {
            LoadPrescriptionDetails(patientID);
        }
        private void LoadMedicineInventory()
        {
            try
            {
                string query = "SELECT name, amount_grams FROM medicine";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable medicineTable = new DataTable();
                adapter.Fill(medicineTable);

                medicineDataGridView.DataSource = medicineTable;

                notificationPanel.Controls.Clear();
                notificationPanel1.Controls.Clear();

                int yOffset = 0;

                foreach (DataRow row in medicineTable.Rows)
                {
                    string medicineName = row["name"].ToString();
                    double amountGrams = Convert.ToDouble(row["amount_grams"]);

                    if (amountGrams < 100)
                    {
                        ShowLowStockNotification(medicineName, amountGrams, yOffset, notificationPanel);
                        ShowLowStockNotification(medicineName, amountGrams, yOffset, notificationPanel1);
                        yOffset += 30;

                        label6.Text = "";
                        notificationLbl.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicine inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowLowStockNotification(string medicineName, double amountGrams, int yOffset, Panel targetPanel)
        {
            Label notificationLabel = new Label
            {
                Text = $"{medicineName} is low on stock. Available amount: {amountGrams} grams.",
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(5, yOffset)
            };

            targetPanel.Controls.Add(notificationLabel);
        }




        private void LoadDoctorName()
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


        private void InitializeSearchBox()
        {
            searchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
        }

        public void LoadPatientIDs()
        {
            try
            {
                string query = "SELECT PatientID FROM Patients";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                AutoCompleteStringCollection patientIDs = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    patientIDs.Add(reader["PatientID"].ToString());
                }

                reader.Close();

                searchBox.AutoCompleteCustomSource = patientIDs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient IDs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayPatientDetails(DataRow patientData)
        {
            detailsPanel.Controls.Clear();

            CreateDetailLabel("Patient ID: ", patientData["PatientID"].ToString(), 0);
            CreateDetailLabel("First Name: ", patientData["FirstName"].ToString(), 1);
            CreateDetailLabel("Last Name: ", patientData["LastName"].ToString(), 2);
            CreateDetailLabel("Birthday: ", patientData["DateOfBirth"].ToString(), 3);
            CreateDetailLabel("Gender: ", patientData["Gender"].ToString(), 4);
            CreateDetailLabel("Address: ", patientData["Address"].ToString(), 5);
            CreateDetailLabel("Phone Number: ", patientData["PhoneNumber"].ToString(), 6);
            CreateDetailLabel("Email: ", patientData["Email"].ToString(), 7);
            CreateDetailLabel("Registered Date: ", patientData["DateRegistered"].ToString(), 8);

            PatientNameLbl.Text = patientData["FirstName"].ToString() + " " + patientData["LastName"].ToString();


            Button addRecordButton = new Button
            {
                Text = "Add New Record",
                Size = new Size(150, 40),
                Location = new Point(80, 320),
                BackColor = Color.RoyalBlue,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.White
            };


            addRecordButton.Click += (sender, e) =>
            {
                string patientID = patientData["PatientID"].ToString();

                if (!string.IsNullOrEmpty(_userID))
                {
                    AddNewRecordForm addNewRecordForm = new AddNewRecordForm(patientID, _userID, this);
                    addNewRecordForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Doctor ID not found. Please check your login details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            detailsPanel.Controls.Add(addRecordButton);
        }



        private void CreateDetailLabel(string label, string value, int position)
        {
            Label lbl = new Label
            {
                Text = label + value,
                AutoSize = true,
                Font = new Font("Segoe UI", 12),
                Location = new Point(20, 20 + position * 30),
                ForeColor = Color.DarkSlateGray
            };

            detailsPanel.Controls.Add(lbl);
        }

        private void ClearPatientDetails()
        {
            detailsPanel.Controls.Clear();
        }

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }



        }


        private void LoadPrescriptionDetails(string patientID)
        {
            try
            {
                string query = "SELECT PrescriptionID, PrescriptionDate, Medication, Description FROM Prescriptions WHERE PatientID = @PatientID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable prescriptionsTable = new DataTable();
                adapter.Fill(prescriptionsTable);

                if (prescriptionsTable.Rows.Count > 0)
                {
                    DisplayPrescriptionDetails(prescriptionsTable);
                }
                else
                {
                    MessageBox.Show("No prescriptions found for this patient.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPrescriptionDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving prescription data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPrescriptionDetails(DataTable prescriptionsTable)
        {

            prescriptionsDataGridView.DataSource = prescriptionsTable;


            prescriptionsDataGridView.Columns["PrescriptionID"].HeaderText = "Prescription ID";
            prescriptionsDataGridView.Columns["PrescriptionDate"].HeaderText = "Date";
            prescriptionsDataGridView.Columns["Medication"].HeaderText = "Medication";
            prescriptionsDataGridView.Columns["Description"].HeaderText = "Description";


            prescriptionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            label8.Text = "";
        }

        private void ClearPrescriptionDetails()
        {
            prescriptionsDataGridView.DataSource = null;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string patientID = searchBox.Text;

                if (string.IsNullOrEmpty(patientID))
                {
                    MessageBox.Show("Please enter a Patient ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "SELECT * FROM Patients WHERE PatientID = @PatientID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientID", patientID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DisplayPatientDetails(dataTable.Rows[0]);
                    LoadPrescriptionDetails(patientID);
                }
                else
                {
                    MessageBox.Show("Patient not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPatientDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PatientNameLbl_Click(object sender, EventArgs e)
        {

        }

        private bool isExitConfirmed = false;
        private void DoctorForm_FormClosing_1(object sender, FormClosingEventArgs e)
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


        private void medicineSearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string searchValue = medicineSearchTextBox.Text.ToLower();

            foreach (DataGridViewRow row in medicineDataGridView.Rows)
            {

                if (row.Cells["name"].Value != null)
                {
                    string medicineName = row.Cells["name"].Value.ToString().ToLower();

                    if (medicineName.Contains(searchValue))
                    {

                        row.Selected = true;

                        medicineDataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                    else
                    {

                        row.Selected = false;
                    }
                }
                else
                {

                    row.Selected = false;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate profileUpdateForm = new ProfileUpdate(_userID, "Doctor", this);
            profileUpdateForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
