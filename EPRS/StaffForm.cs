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
    public partial class StaffForm : Form
    {
        private MySqlConnection connection;
        private string _username;
        private string _userID;
        public StaffForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;


                connection = new MySqlConnection(connectionString);


                connection.Open();

                LoadStaffName();
                LoadMedicineInventory();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to close the program?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
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



        public void LoadStaffName()
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

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ProfileUpdate profileUpdateForm = new ProfileUpdate(_userID, "Staff", this);
            profileUpdateForm.Show();
        }
    }

}
