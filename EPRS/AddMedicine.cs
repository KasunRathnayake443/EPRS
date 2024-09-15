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
    public partial class AddMedicine : Form
    {
        private MySqlConnection connection;
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMedicine_Load(object sender, EventArgs e)
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            string medicineName = NameBox.Text.Trim();
            string amountText = AmountBox.Text.Trim();


            if (string.IsNullOrEmpty(medicineName))
            {
                MessageBox.Show("Please enter a medicine name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(amountText, out double amountGrams) || amountGrams <= 0)
            {
                MessageBox.Show("Please enter a valid medicine amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                if (connection.State != ConnectionState.Open)
                    connection.Open();


                string query = "INSERT INTO medicine (name, amount_grams) VALUES (@name, @amount)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", medicineName);
                command.Parameters.AddWithValue("@amount", amountGrams);


                int rowsAffected = command.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Medicine added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to add medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
