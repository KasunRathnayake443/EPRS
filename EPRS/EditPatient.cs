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
    public partial class EditPatient : Form
    {
        private MySqlConnection connection;
        private string _userID;

        private Form _parentForm;
        public EditPatient(string userID, Form parentForm)
        {
            InitializeComponent();
            this._userID = userID;

            this._parentForm = parentForm;
        }

        private void EditPatient_Load(object sender, EventArgs e)
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

            IdLbl.Text = _userID;
        }


        private void LoadUserDetails()
        {
            try
            {

                string query = "SELECT FirstName, LastName, Gender, Address, Email, PhoneNumber, DateOfBirth FROM Patients WHERE PatientID = @PatientID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PatientID", _userID);


                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    FNameBox.Text = reader["FirstName"].ToString();
                    LNameBox.Text = reader["LastName"].ToString();
                    GenderBox.SelectedItem = reader["Gender"].ToString();
                    AddressBox.Text = reader["Address"].ToString();
                    EmailBox.Text = reader["Email"].ToString();
                    PhoneBox.Text = reader["PhoneNumber"].ToString();
                    dateTimePicker.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                }
                else
                {
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Patients SET FirstName = @FirstName, LastName = @LastName, Gender = @Gender, Address = @Address, Email = @Email, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth WHERE PatientID = @PatientID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FirstName", FNameBox.Text);
                cmd.Parameters.AddWithValue("@LastName", LNameBox.Text);
                cmd.Parameters.AddWithValue("@Gender", GenderBox.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Address", AddressBox.Text);
                cmd.Parameters.AddWithValue("@Email", EmailBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneBox.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateTimePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@PatientID", _userID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (_parentForm is StaffForm staffForm)
                {
                    staffForm.ReloadPatientData(_userID);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating patient details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
