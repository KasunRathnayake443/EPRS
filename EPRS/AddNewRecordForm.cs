using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EPRS
{
    public partial class AddNewRecordForm : Form
    {
        private MySqlConnection connection;
        private string patientID;
        private string _doctorID;
        private List<(string medicineName, string dose)> selectedMedicines = new List<(string, string)>();

        public AddNewRecordForm(string patientID, string _doctorID)
        {
            InitializeComponent();
            this.patientID = patientID;
            this._doctorID = _doctorID;
            patientIdLabel.Text = "Patient ID: " + patientID;
            doctorIdLabel.Text = "Doctor ID: " + _doctorID;
        }

        private void AddNewRecordForm_Load(object sender, EventArgs e)
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

        private void FetchMedicineSuggestions(string searchText)
        {
            try
            {
                string query = "SELECT name FROM medicine WHERE name LIKE @searchText";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@searchText", $"%{searchText}%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable medicineTable = new DataTable();
                adapter.Fill(medicineTable);

                medicineComboBox.Items.Clear();
                foreach (DataRow row in medicineTable.Rows)
                {
                    medicineComboBox.Items.Add(row["name"].ToString());
                }

                medicineComboBox.DroppedDown = true;
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching medicine suggestions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void medicineComboBox_TextUpdate_1(object sender, EventArgs e)
        {
            string searchText = medicineComboBox.Text;
            if (searchText.Length > 1)
            {
                FetchMedicineSuggestions(searchText);
            }
        }


        private void addMedicineButton_Click_1(object sender, EventArgs e)
        {
            string selectedMedicine = medicineComboBox.Text;
            string dose = doseBox.Text;


            if (!string.IsNullOrWhiteSpace(selectedMedicine) && !selectedMedicines.Any(m => m.medicineName == selectedMedicine))
            {
                if (string.IsNullOrWhiteSpace(dose))
                {
                    dose = "0.5";
                }


                selectedMedicines.Add((selectedMedicine, dose));


                medicinesListBox.Items.Add($"{selectedMedicine} - Dose: {dose}");


                medicineComboBox.Text = "";
                doseBox.Text = "0.5";
            }
        }


        private void removeMedicineButton_Click(object sender, EventArgs e)
        {

            if (medicinesListBox.SelectedIndex != -1)
            {

                string selectedItem = medicinesListBox.SelectedItem.ToString();


                string medicineName = selectedItem.Split('-')[0].Trim();


                medicinesListBox.Items.RemoveAt(medicinesListBox.SelectedIndex);


                selectedMedicines.RemoveAll(m => m.medicineName == medicineName);
            }
        }


        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string description = descriptionTextBox.Text;
            if (string.IsNullOrWhiteSpace(description) || selectedMedicines.Count == 0)
            {
                MessageBox.Show("Please fill in the prescription description and add at least one medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (var (medicine, dose) in selectedMedicines)
                {
                    double doseValue = double.Parse(dose);
                    double doseToReduce = doseValue * 9;


                    string updateQuery = "UPDATE medicine SET amount_grams = amount_grams - @doseToReduce WHERE name = @medicineName";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@doseToReduce", doseToReduce);
                    updateCmd.Parameters.AddWithValue("@medicineName", medicine);
                    updateCmd.ExecuteNonQuery();
                }


                string medication = string.Join(", ", selectedMedicines.Select(m => $"{m.medicineName} (Dose: {m.dose})"));
                string insertQuery = "INSERT INTO prescriptions (DoctorID, PatientID, Description, PrescriptionDate, Medication) VALUES (@DoctorID, @PatientID, @Description, @PrescriptionDate, @Medication)";

                MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                cmd.Parameters.AddWithValue("@DoctorID", _doctorID);
                cmd.Parameters.AddWithValue("@PatientID", patientID);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@PrescriptionDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@Medication", medication);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Prescription saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving prescription: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
