using System;
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

        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the connection string from app.config
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

                // Initialize the MySQL connection
                connection = new MySqlConnection(connectionString);

                // Open the connection
                connection.Open();

                // Initialize search box autocomplete
                InitializeSearchBox();

                // Load patient IDs for autocomplete
                LoadPatientIDs();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSearchBox()
        {
            searchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
        }

        private void LoadPatientIDs()
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

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close the connection when the form is closed
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
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

        private void DisplayPatientDetails(DataRow patientData)
        {
            detailsPanel.Controls.Clear(); // Clear previous details

            // Create labels for each piece of information
            CreateDetailLabel("Patient ID: ", patientData["PatientID"].ToString(), 0);
            CreateDetailLabel("First Name: ", patientData["FirstName"].ToString(), 1);
            CreateDetailLabel("Last Name: ", patientData["LastName"].ToString(), 2);
            CreateDetailLabel("Birthday: ", patientData["DateOfBirth"].ToString(), 3);
            CreateDetailLabel("Gender: ", patientData["Gender"].ToString(), 4);
            CreateDetailLabel("Address: ", patientData["Address"].ToString(), 5);
            CreateDetailLabel("Phone Number: ", patientData["PhoneNumber"].ToString(), 6);
            CreateDetailLabel("Email: ", patientData["Email"].ToString(), 7);
            CreateDetailLabel("Registered Date: ", patientData["DateRegistered"].ToString(), 8);

            // Add more fields as necessary
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
    }
}
