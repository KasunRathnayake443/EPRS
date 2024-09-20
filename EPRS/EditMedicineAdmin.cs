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
    public partial class EditMedicineAdmin : Form
    {
        private MySqlConnection connection;
        private string MedicineName;
        private Form _parentForm;
        public EditMedicineAdmin(string selectedMedicineName, Form parentForm)
        {
            InitializeComponent();
            this._parentForm = parentForm;
            this.MedicineName = selectedMedicineName;
        }

        private void EditMedicineAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                connection = new MySqlConnection(connectionString);
                connection.Open();


                LoadMedicineDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadMedicineDetails()
        {
            try
            {
                string query = "SELECT id,name, amount_grams FROM medicine WHERE name = @MedicineName";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@MedicineName", MedicineName);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idLbl.Text = reader["id"].ToString();
                    NameBox.Text = reader["name"].ToString();
                    AmountBox.Text = reader["amount_grams"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicine details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE medicine SET name = @Name, amount_grams = @Amount WHERE id = @Id";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name", NameBox.Text);
                cmd.Parameters.AddWithValue("@Amount", AmountBox.Text);
                cmd.Parameters.AddWithValue("@Id", idLbl.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (_parentForm is AdminForm adminForm)
                {
                    adminForm.LoadMedicineGrid();
                    adminForm.LowInventoryNotification();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
