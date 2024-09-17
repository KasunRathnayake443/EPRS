namespace EPRS
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            unameLbl = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            AddPatientsBtn = new Button();
            label20 = new Label();
            IdBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            GenderBox = new ComboBox();
            PhoneBox = new TextBox();
            EmailBox = new TextBox();
            AddressBox = new TextBox();
            LNameBox = new TextBox();
            FNameBox = new TextBox();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            PatientCount = new Label();
            panel3 = new Panel();
            label10 = new Label();
            tabPage2 = new TabPage();
            label19 = new Label();
            UserGrid = new DataGridView();
            button1 = new Button();
            RoleBox = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            UserNameBox = new TextBox();
            PasswordBox = new TextBox();
            NameBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            UserCountLbl = new Label();
            panel2 = new Panel();
            label3 = new Label();
            tabPage3 = new TabPage();
            settingsBtn = new Button();
            PatientDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserGrid).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Gill Sans Ultra Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 110, 73);
            label1.Location = new Point(40, 39);
            label1.Name = "label1";
            label1.Size = new Size(577, 36);
            label1.TabIndex = 11;
            label1.Text = "Patient Record Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1739, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // unameLbl
            // 
            unameLbl.AutoSize = true;
            unameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            unameLbl.ForeColor = Color.Tomato;
            unameLbl.Location = new Point(1576, 39);
            unameLbl.Name = "unameLbl";
            unameLbl.Size = new Size(155, 32);
            unameLbl.TabIndex = 14;
            unameLbl.Text = "Admin Name";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(40, 93);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1742, 836);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(PatientDataGrid);
            tabPage1.Controls.Add(AddPatientsBtn);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(IdBox);
            tabPage1.Controls.Add(dateTimePicker);
            tabPage1.Controls.Add(GenderBox);
            tabPage1.Controls.Add(PhoneBox);
            tabPage1.Controls.Add(EmailBox);
            tabPage1.Controls.Add(AddressBox);
            tabPage1.Controls.Add(LNameBox);
            tabPage1.Controls.Add(FNameBox);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(panel4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1734, 803);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Patients";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddPatientsBtn
            // 
            AddPatientsBtn.BackColor = Color.RoyalBlue;
            AddPatientsBtn.ForeColor = Color.White;
            AddPatientsBtn.Location = new Point(683, 395);
            AddPatientsBtn.Name = "AddPatientsBtn";
            AddPatientsBtn.Size = new Size(177, 41);
            AddPatientsBtn.TabIndex = 56;
            AddPatientsBtn.Text = "Add Patient";
            AddPatientsBtn.UseVisualStyleBackColor = false;
            AddPatientsBtn.Click += AddPatientsBtn_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.DimGray;
            label20.Location = new Point(562, 23);
            label20.Name = "label20";
            label20.Size = new Size(214, 35);
            label20.TabIndex = 55;
            label20.Text = "Add New Patient";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(683, 100);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(255, 27);
            IdBox.TabIndex = 54;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(1112, 208);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(255, 27);
            dateTimePicker.TabIndex = 53;
            // 
            // GenderBox
            // 
            GenderBox.FormattingEnabled = true;
            GenderBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderBox.Location = new Point(683, 207);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(255, 28);
            GenderBox.TabIndex = 52;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(1112, 321);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(255, 27);
            PhoneBox.TabIndex = 51;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(683, 324);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(255, 27);
            EmailBox.TabIndex = 50;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(683, 264);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(684, 27);
            AddressBox.TabIndex = 49;
            // 
            // LNameBox
            // 
            LNameBox.Location = new Point(1112, 156);
            LNameBox.Name = "LNameBox";
            LNameBox.Size = new Size(255, 27);
            LNameBox.TabIndex = 48;
            // 
            // FNameBox
            // 
            FNameBox.Location = new Point(683, 156);
            FNameBox.Name = "FNameBox";
            FNameBox.Size = new Size(255, 27);
            FNameBox.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(966, 320);
            label9.Name = "label9";
            label9.Size = new Size(108, 28);
            label9.TabIndex = 46;
            label9.Text = "Phone No :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(562, 320);
            label12.Name = "label12";
            label12.Size = new Size(68, 28);
            label12.TabIndex = 45;
            label12.Text = "Email :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(562, 260);
            label13.Name = "label13";
            label13.Size = new Size(91, 28);
            label13.TabIndex = 44;
            label13.Text = "Address :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(966, 203);
            label14.Name = "label14";
            label14.Size = new Size(134, 28);
            label14.TabIndex = 43;
            label14.Text = "Date Of Birth :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(562, 203);
            label15.Name = "label15";
            label15.Size = new Size(85, 28);
            label15.TabIndex = 42;
            label15.Text = "Gender :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Location = new Point(562, 96);
            label16.Name = "label16";
            label16.Size = new Size(40, 28);
            label16.TabIndex = 41;
            label16.Text = "ID :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.Black;
            label17.Location = new Point(966, 152);
            label17.Name = "label17";
            label17.Size = new Size(112, 28);
            label17.TabIndex = 40;
            label17.Text = "Last Name :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = Color.Black;
            label18.Location = new Point(562, 152);
            label18.Name = "label18";
            label18.Size = new Size(115, 28);
            label18.TabIndex = 39;
            label18.Text = "First Name :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.SlateGray;
            label11.Location = new Point(17, 20);
            label11.Name = "label11";
            label11.Size = new Size(236, 38);
            label11.TabIndex = 2;
            label11.Text = "Manage Patients";
            // 
            // panel4
            // 
            panel4.BackColor = Color.PaleGreen;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(PatientCount);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(67, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 132);
            panel4.TabIndex = 1;
            // 
            // PatientCount
            // 
            PatientCount.AutoSize = true;
            PatientCount.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PatientCount.ForeColor = Color.White;
            PatientCount.Location = new Point(110, 65);
            PatientCount.Name = "PatientCount";
            PatientCount.Size = new Size(56, 46);
            PatientCount.TabIndex = 3;
            PatientCount.Text = "45";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Location = new Point(-1, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 51);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(47, 11);
            label10.Name = "label10";
            label10.Size = new Size(180, 28);
            label10.TabIndex = 0;
            label10.Text = "Number of Patients";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(UserGrid);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(RoleBox);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(UserNameBox);
            tabPage2.Controls.Add(PasswordBox);
            tabPage2.Controls.Add(NameBox);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1734, 803);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Manage Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.DimGray;
            label19.Location = new Point(32, 480);
            label19.Name = "label19";
            label19.Size = new Size(118, 35);
            label19.TabIndex = 13;
            label19.Text = "All Users";
            // 
            // UserGrid
            // 
            UserGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserGrid.Location = new Point(32, 544);
            UserGrid.Name = "UserGrid";
            UserGrid.RowHeadersWidth = 51;
            UserGrid.RowTemplate.Height = 29;
            UserGrid.Size = new Size(1666, 240);
            UserGrid.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.ForeColor = Color.White;
            button1.Location = new Point(523, 458);
            button1.Name = "button1";
            button1.Size = new Size(177, 41);
            button1.TabIndex = 11;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RoleBox
            // 
            RoleBox.FormattingEnabled = true;
            RoleBox.Items.AddRange(new object[] { "Doctor", "Admin", "Staff" });
            RoleBox.Location = new Point(523, 226);
            RoleBox.Name = "RoleBox";
            RoleBox.Size = new Size(377, 28);
            RoleBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(523, 362);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 9;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(523, 274);
            label7.Name = "label7";
            label7.Size = new Size(99, 28);
            label7.TabIndex = 8;
            label7.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(523, 192);
            label6.Name = "label6";
            label6.Size = new Size(50, 28);
            label6.TabIndex = 7;
            label6.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(523, 111);
            label5.Name = "label5";
            label5.Size = new Size(69, 28);
            label5.TabIndex = 6;
            label5.Text = "Name ";
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(523, 312);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(377, 27);
            UserNameBox.TabIndex = 5;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(523, 401);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(377, 27);
            PasswordBox.TabIndex = 4;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(523, 147);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(377, 27);
            NameBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(516, 42);
            label4.Name = "label4";
            label4.Size = new Size(184, 35);
            label4.TabIndex = 2;
            label4.Text = "Add New User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateGray;
            label2.Location = new Point(10, 14);
            label2.Name = "label2";
            label2.Size = new Size(201, 38);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(UserCountLbl);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(88, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 132);
            panel1.TabIndex = 0;
            // 
            // UserCountLbl
            // 
            UserCountLbl.AutoSize = true;
            UserCountLbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            UserCountLbl.Location = new Point(110, 65);
            UserCountLbl.Name = "UserCountLbl";
            UserCountLbl.Size = new Size(56, 46);
            UserCountLbl.TabIndex = 3;
            UserCountLbl.Text = "45";
            UserCountLbl.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PapayaWhip;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 51);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 10);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 0;
            label3.Text = "Number of Users";
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1734, 803);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Manage Inventory";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.Image = (Image)resources.GetObject("settingsBtn.Image");
            settingsBtn.Location = new Point(1788, 925);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(44, 46);
            settingsBtn.TabIndex = 18;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // PatientDataGrid
            // 
            PatientDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PatientDataGrid.Location = new Point(20, 489);
            PatientDataGrid.Name = "PatientDataGrid";
            PatientDataGrid.RowHeadersWidth = 51;
            PatientDataGrid.RowTemplate.Height = 29;
            PatientDataGrid.Size = new Size(1684, 287);
            PatientDataGrid.TabIndex = 57;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1832, 973);
            Controls.Add(settingsBtn);
            Controls.Add(tabControl1);
            Controls.Add(unameLbl);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPRS - Admin Dahsboard";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label unameLbl;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button settingsBtn;
        private Label label2;
        private Panel panel1;
        private Label UserCountLbl;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox RoleBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox UserNameBox;
        private TextBox PasswordBox;
        private TextBox NameBox;
        private DataGridView UserGrid;
        private Label label11;
        private Panel panel4;
        private Label PatientCount;
        private Panel panel3;
        private Label label10;
        private TextBox IdBox;
        private DateTimePicker dateTimePicker;
        private ComboBox GenderBox;
        private TextBox PhoneBox;
        private TextBox EmailBox;
        private TextBox AddressBox;
        private TextBox LNameBox;
        private TextBox FNameBox;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button AddPatientsBtn;
        private Label label20;
        private DataGridView PatientDataGrid;
    }
}