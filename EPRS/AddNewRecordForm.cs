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
        private DoctorForm doctorForm;

        public AddNewRecordForm(string patientID, string _doctorID, DoctorForm form)
        {
            InitializeComponent();
            this.patientID = patientID;
            this._doctorID = _doctorID;
            patientIdLabel.Text = "Patient ID: " + patientID;
            doctorIdLabel.Text = "Doctor ID: " + _doctorID;
            this.doctorForm = form;
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

                int cursorPosition = medicineComboBox.SelectionStart;
                FetchMedicineSuggestions(searchText);
                medicineComboBox.SelectionStart = cursorPosition;
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
            else
            {
                MessageBox.Show("Please enter a valid medicine and dose, or ensure the medicine hasn't been added already.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                MessageBox.Show("Please select a medicine to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    string checkMedicineQuery = "SELECT COUNT(*) FROM medicine WHERE name = @medicineName";
                    MySqlCommand checkCmd = new MySqlCommand(checkMedicineQuery, connection);
                    checkCmd.Parameters.AddWithValue("@medicineName", medicine);

                    int medicineExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (medicineExists > 0)
                    {

                        double doseValue = double.Parse(dose);
                        double doseToReduce = doseValue * 9;

                        string updateQuery = "UPDATE medicine SET amount_grams = amount_grams - @doseToReduce WHERE name = @medicineName";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@doseToReduce", doseToReduce);
                        updateCmd.Parameters.AddWithValue("@medicineName", medicine);
                        updateCmd.ExecuteNonQuery();
                    }
                    else
                    {

                        MessageBox.Show($"The medicine '{medicine}' does not exist in the database. It will still be added to the prescription.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                doctorForm.ReloadMedicineInventory();
                doctorForm.ReloadPrescriptionDetails(patientID);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving prescription: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
