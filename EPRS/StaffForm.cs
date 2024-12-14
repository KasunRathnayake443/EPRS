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
            AccountBtn.Visible = false;
            LogoutBtn.Visible = false;


            settingsBtn.Click += settingsBtn_Click;

            AccountBtn.Click += Buttons_Click;
            LogoutBtn.Click += Buttons_Click;

            this.AutoScaleMode = AutoScaleMode.Dpi;

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            try
            {

                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;


                connection = new MySqlConnection(connectionString);


                connection.Open();

                InitializeSearchBox();
                LoadStaffName();
                LoadMedicineInventory();
                LoadPatientIDs();
                SetModernTabControl1();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetModernTabControl1()
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(140, 40);
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.Padding = new Point(10, 6);

            tabControl1.DrawItem += TabControl1_DrawItem;
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            Graphics g = e.Graphics;
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);


            Font font = new Font("Segoe UI", 9, FontStyle.Regular);
            tabBounds.Inflate(-2, -2);


            Color selectedTabBackColor = Color.FromArgb(102, 204, 153);
            Color selectedTabForeColor = Color.White;
            Color unselectedTabBackColor = Color.FromArgb(240, 255, 240);
            Color unselectedTabForeColor = Color.FromArgb(85, 107, 47);
            Color borderColor = Color.FromArgb(180, 230, 180);

            bool isSelected = e.Index == tabControl.SelectedIndex;


            using (SolidBrush backBrush = new SolidBrush(isSelected ? selectedTabBackColor : unselectedTabBackColor))
            {
                g.FillRectangle(backBrush, tabBounds);
            }


            using (Pen borderPen = new Pen(borderColor, 1))
            {
                g.DrawRectangle(borderPen, tabBounds);
            }

            TextRenderer.DrawText(
                g,
                tabControl.TabPages[e.Index].Text,
                font,
                tabBounds,
                isSelected ? selectedTabForeColor : unselectedTabForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
        public void ReloadPatientData(string patientID)
        {
            try
            {
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
                MessageBox.Show($"Error reloading patient data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isExitConfirmed = false;
        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Buttons_Click(object sender, EventArgs e)
        {

        }

        private void LoadMedicineInventory()
        {
            try
            {
                int low_stock = 0;


                string query1 = "SELECT low_stock FROM settings WHERE id = 1";
                using (MySqlCommand cmd1 = new MySqlCommand(query1, connection))
                {
                    using (MySqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            low_stock = reader1["low_stock"] != DBNull.Value ? Convert.ToInt32(reader1["low_stock"]) : 0;
                        }
                    }
                }

                string query = "SELECT name, amount_grams FROM medicine";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable medicineTable = new DataTable();
                adapter.Fill(medicineTable);


                medicineView.Controls.Clear();

                DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "EditButton",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };

                DataGridView medicineGridView = new DataGridView
                {
                    DataSource = medicineTable,
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    AllowUserToAddRows = false
                };

                medicineGridView.CellClick += MedicineGridView_CellClick;
                medicineGridView.Columns.Add(editButtonColumn);

                medicineView.Controls.Add(medicineGridView);


                int yOffset = 0;
                foreach (DataRow row in medicineTable.Rows)
                {
                    string medicineName = row["name"].ToString();
                    double amountGrams = Convert.ToDouble(row["amount_grams"]);

                    if (amountGrams < low_stock)
                    {
                        ShowLowStockNotification(medicineName, amountGrams, yOffset, notificationPanel1, notificationPanel);
                        yOffset += 30;

                        label6.Text = "";
                        notificationLbl.Text = "";
                    }
                }


                if (!medicineView.Controls.OfType<Button>().Any(b => b.Text == "Add New Medicine"))
                {
                    Button addNewMedicineButton = new Button
                    {
                        Text = "Add New Medicine",
                        Size = new Size(150, 40),
                        Dock = DockStyle.Bottom,
                        BackColor = Color.RoyalBlue,
                        Font = new Font("Segoe UI", 12, FontStyle.Regular),
                        ForeColor = Color.White
                    };
                    addNewMedicineButton.Click += AddNewBtn_Click;


                    medicineView.Controls.Add(addNewMedicineButton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicine inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MedicineGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ((DataGridView)sender).Columns["EditButton"].Index)
            {

                string selectedMedicineName = ((DataGridView)sender).Rows[e.RowIndex].Cells["name"].Value.ToString();


                EditMedicine editMedicineForm = new EditMedicine(selectedMedicineName);
                editMedicineForm.ShowDialog();

                ReloadMedicineInventory();

            }
        }

        public void ReloadMedicineInventory()
        {

            notificationPanel.Controls.Clear();
            notificationPanel1.Controls.Clear();


            LoadMedicineInventory();


            string query = "SELECT name, amount_grams FROM medicine";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable medicineTable = new DataTable();
            adapter.Fill(medicineTable);


            int yOffset = 0;
            foreach (DataRow row in medicineTable.Rows)
            {
                string medicineName = row["name"].ToString();
                double amountGrams = Convert.ToDouble(row["amount_grams"]);


                if (amountGrams < 100)
                {
                    ShowLowStockNotification(medicineName, amountGrams, yOffset, notificationPanel, notificationPanel1);
                    yOffset += 30;
                }
            }
        }



        private void ShowLowStockNotification(string medicineName, double amountGrams, int yOffset, Panel targetPanel1, Panel targetPanel2)
        {

            Label notificationLabel1 = new Label
            {
                Text = $"{medicineName} is low on stock. Available amount: {amountGrams} grams.",
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(5, yOffset)
            };


            Label notificationLabel2 = new Label
            {
                Text = $"{medicineName} is low on stock. Available amount: {amountGrams} grams.",
                AutoSize = true,
                ForeColor = Color.Red,
                Location = new Point(5, yOffset)
            };


            targetPanel1.Controls.Add(notificationLabel1);


            targetPanel2.Controls.Add(notificationLabel2);
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
            AccountBtn.Visible = true;
            LogoutBtn.Visible = true;

        }


        private void InitializeSearchBox()
        {
            searchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            searchBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
        }

        public void ReloadPatientIDs()
        {
            LoadPatientIDs();
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


            Button editDetailsButton = new Button
            {
                Text = "Edit Details",
                Size = new Size(150, 40),
                Location = new Point(80, 320),
                BackColor = Color.RoyalBlue,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = Color.White
            };


            editDetailsButton.Click += (sender, e) =>
            {
                string patientID = patientData["PatientID"].ToString();

                if (!string.IsNullOrEmpty(_userID))
                {
                    EditPatient editPatient = new EditPatient(patientID, this);
                    editPatient.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Doctor ID not found. Please check your login details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            detailsPanel.Controls.Add(editDetailsButton);
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatient AddPatient = new AddPatient(this);
            AddPatient.Show();
        }






        private void SearchBtn1_Click(object sender, EventArgs e)
        {

        }

        private void medicineDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicineForm = new AddMedicine();
            addMedicineForm.ShowDialog();


            LoadMedicineInventory();
        }






        private void AccountBtn_Click_1(object sender, EventArgs e)
        {
            ProfileUpdate profileUpdateForm = new ProfileUpdate(_userID, "Staff", this);
            profileUpdateForm.Show();

            LoadStaffName();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Are you sure you want to logout?", "Logout",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void StaffForm_MouseEnter(object sender, EventArgs e)
        {

        }

        private void StaffForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (AccountBtn.Visible || LogoutBtn.Visible)
            {
                AccountBtn.Visible = false;
                LogoutBtn.Visible = false;
            }
        }

        private void patientDetaisLbl_Click(object sender, EventArgs e)
        {

        }
    }

}
