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
    public partial class EditMedicine : Form

    {
        private MySqlConnection connection;

        private string MedicineName;
        public EditMedicine(string selectedMedicineName)
        {
            InitializeComponent();
            this.MedicineName = selectedMedicineName;
        }

        private void EditMedicine_Load(object sender, EventArgs e)
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
                    IdLbl.Text = reader["id"].ToString();
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
                cmd.Parameters.AddWithValue("@Id", IdLbl.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicine updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this medicine?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    string query = "DELETE FROM medicine WHERE id = @Id";


                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", IdLbl.Text);
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Medicine has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error deleting medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
