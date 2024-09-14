using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace EPRS
{
    public partial class AddPatient : Form
    {
        private MySqlConnection connection;
        private Form _parentForm;

        public AddPatient(Form parentForm)
        {
            InitializeComponent();
            this._parentForm = parentForm;
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
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
                    if (_parentForm is StaffForm staffForm)
                    {
                        staffForm.ReloadPatientIDs();
                    }
                    this.Close();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
