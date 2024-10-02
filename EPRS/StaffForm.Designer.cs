namespace EPRS
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            tabControl1 = new TabControl();
            addPatientBtn = new TabPage();
            label8 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            notificationPanel = new Panel();
            notificationLbl = new Label();
            PatientNameLbl = new Label();
            prescriptionsDataGridView = new DataGridView();
            detailsPanel = new Panel();
            patientDetaisLbl = new Label();
            searchBtn = new Button();
            searchBox = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            medicineView = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            notificationPanel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            medicineSearchTextBox = new TextBox();
            label1 = new Label();
            settingsBtn = new Button();
            unameLbl = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            AccountBtn = new Button();
            LogoutBtn = new Button();
            tabControl1.SuspendLayout();
            addPatientBtn.SuspendLayout();
            notificationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionsDataGridView).BeginInit();
            detailsPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            notificationPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(addPatientBtn);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.HotTrack = true;
            tabControl1.ImeMode = ImeMode.Alpha;
            tabControl1.Location = new Point(13, 64);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1372, 618);
            tabControl1.TabIndex = 1;
            // 
            // addPatientBtn
            // 
            addPatientBtn.Controls.Add(label8);
            addPatientBtn.Controls.Add(button1);
            addPatientBtn.Controls.Add(panel2);
            addPatientBtn.Controls.Add(panel1);
            addPatientBtn.Controls.Add(label3);
            addPatientBtn.Controls.Add(notificationPanel);
            addPatientBtn.Controls.Add(PatientNameLbl);
            addPatientBtn.Controls.Add(prescriptionsDataGridView);
            addPatientBtn.Controls.Add(detailsPanel);
            addPatientBtn.Controls.Add(searchBtn);
            addPatientBtn.Controls.Add(searchBox);
            addPatientBtn.Controls.Add(label2);
            addPatientBtn.Location = new Point(4, 24);
            addPatientBtn.Margin = new Padding(3, 2, 3, 2);
            addPatientBtn.Name = "addPatientBtn";
            addPatientBtn.Padding = new Padding(3, 2, 3, 2);
            addPatientBtn.Size = new Size(1364, 590);
            addPatientBtn.TabIndex = 0;
            addPatientBtn.Text = "Patient Records";
            addPatientBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSalmon;
            label8.Location = new Point(122, 457);
            label8.Name = "label8";
            label8.Size = new Size(283, 20);
            label8.TabIndex = 11;
            label8.Text = "Prescription Records will be Appeared Here";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = Color.White;
            button1.Location = new Point(712, 25);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 29);
            button1.TabIndex = 10;
            button1.Text = "Add Patient";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.MistyRose;
            panel2.Location = new Point(13, 386);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1298, 8);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Location = new Point(906, 88);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(9, 303);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(1054, 22);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 7;
            label3.Text = "Notifications";
            // 
            // notificationPanel
            // 
            notificationPanel.Controls.Add(notificationLbl);
            notificationPanel.Location = new Point(934, 88);
            notificationPanel.Margin = new Padding(3, 2, 3, 2);
            notificationPanel.Name = "notificationPanel";
            notificationPanel.Size = new Size(376, 294);
            notificationPanel.TabIndex = 6;
            // 
            // notificationLbl
            // 
            notificationLbl.AutoSize = true;
            notificationLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            notificationLbl.ForeColor = Color.DarkSalmon;
            notificationLbl.Location = new Point(57, 56);
            notificationLbl.Name = "notificationLbl";
            notificationLbl.Size = new Size(235, 20);
            notificationLbl.TabIndex = 1;
            notificationLbl.Text = "Notifications will be Appeared Here";
            // 
            // PatientNameLbl
            // 
            PatientNameLbl.AutoSize = true;
            PatientNameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PatientNameLbl.Location = new Point(29, 64);
            PatientNameLbl.Name = "PatientNameLbl";
            PatientNameLbl.Size = new Size(0, 25);
            PatientNameLbl.TabIndex = 5;
            // 
            // prescriptionsDataGridView
            // 
            prescriptionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            prescriptionsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            prescriptionsDataGridView.BorderStyle = BorderStyle.None;
            prescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prescriptionsDataGridView.Location = new Point(13, 399);
            prescriptionsDataGridView.Margin = new Padding(3, 2, 3, 2);
            prescriptionsDataGridView.Name = "prescriptionsDataGridView";
            prescriptionsDataGridView.RowHeadersWidth = 51;
            prescriptionsDataGridView.RowTemplate.Height = 29;
            prescriptionsDataGridView.Size = new Size(1340, 190);
            prescriptionsDataGridView.TabIndex = 4;
            // 
            // detailsPanel
            // 
            detailsPanel.AutoScroll = true;
            detailsPanel.Controls.Add(patientDetaisLbl);
            detailsPanel.Location = new Point(13, 88);
            detailsPanel.Margin = new Padding(3, 2, 3, 2);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(876, 294);
            detailsPanel.TabIndex = 3;
            // 
            // patientDetaisLbl
            // 
            patientDetaisLbl.AutoSize = true;
            patientDetaisLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            patientDetaisLbl.ForeColor = Color.DarkSalmon;
            patientDetaisLbl.Location = new Point(52, 44);
            patientDetaisLbl.Name = "patientDetaisLbl";
            patientDetaisLbl.Size = new Size(248, 20);
            patientDetaisLbl.TabIndex = 0;
            patientDetaisLbl.Text = "Patient Details will be Appeared Here";
            patientDetaisLbl.Click += patientDetaisLbl_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.RoyalBlue;
            searchBtn.ForeColor = Color.White;
            searchBtn.Location = new Point(605, 25);
            searchBtn.Margin = new Padding(3, 2, 3, 2);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(82, 29);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(360, 25);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(231, 23);
            searchBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 29);
            label2.Name = "label2";
            label2.Size = new Size(308, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Student Registration Number To Find The Profile : ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(medicineView);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(notificationPanel1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(medicineSearchTextBox);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1364, 590);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Medicine Inventory";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // medicineView
            // 
            medicineView.Location = new Point(34, 110);
            medicineView.Margin = new Padding(3, 2, 3, 2);
            medicineView.Name = "medicineView";
            medicineView.Size = new Size(539, 447);
            medicineView.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Linen;
            panel3.Location = new Point(836, 68);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(9, 506);
            panel3.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(1052, 22);
            label7.Name = "label7";
            label7.Size = new Size(136, 28);
            label7.TabIndex = 8;
            label7.Text = "Notifications";
            // 
            // notificationPanel1
            // 
            notificationPanel1.Controls.Add(label6);
            notificationPanel1.Location = new Point(954, 82);
            notificationPanel1.Margin = new Padding(3, 2, 3, 2);
            notificationPanel1.Name = "notificationPanel1";
            notificationPanel1.Size = new Size(376, 294);
            notificationPanel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSalmon;
            label6.Location = new Point(57, 56);
            label6.Name = "label6";
            label6.Size = new Size(235, 20);
            label6.TabIndex = 1;
            label6.Text = "Notifications will be Appeared Here";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 73);
            label5.Name = "label5";
            label5.Size = new Size(271, 15);
            label5.TabIndex = 4;
            label5.Text = "Search Medicine To Find Available Stock Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(34, 36);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 3;
            label4.Text = "All Available Medicine";
            // 
            // medicineSearchTextBox
            // 
            medicineSearchTextBox.Location = new Point(334, 68);
            medicineSearchTextBox.Margin = new Padding(3, 2, 3, 2);
            medicineSearchTextBox.Name = "medicineSearchTextBox";
            medicineSearchTextBox.Size = new Size(239, 23);
            medicineSearchTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Gill Sans Ultra Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 110, 73);
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(465, 31);
            label1.TabIndex = 11;
            label1.Text = "Patient Record Management System";
            // 
            // settingsBtn
            // 
            settingsBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            settingsBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Image = (Image)resources.GetObject("settingsBtn.Image");
            settingsBtn.Location = new Point(1387, 684);
            settingsBtn.Margin = new Padding(3, 2, 3, 2);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(30, 26);
            settingsBtn.TabIndex = 18;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // unameLbl
            // 
            unameLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            unameLbl.AutoSize = true;
            unameLbl.BackColor = Color.WhiteSmoke;
            unameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            unameLbl.ForeColor = Color.Tomato;
            unameLbl.Location = new Point(1198, 27);
            unameLbl.Name = "unameLbl";
            unameLbl.Size = new Size(104, 25);
            unameLbl.TabIndex = 16;
            unameLbl.Text = "Staff Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1332, 17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1162, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // AccountBtn
            // 
            AccountBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AccountBtn.BackColor = Color.Transparent;
            AccountBtn.FlatAppearance.BorderSize = 0;
            AccountBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            AccountBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            AccountBtn.FlatStyle = FlatStyle.Flat;
            AccountBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AccountBtn.ForeColor = Color.Black;
            AccountBtn.Location = new Point(1224, 689);
            AccountBtn.Margin = new Padding(3, 2, 3, 2);
            AccountBtn.Name = "AccountBtn";
            AccountBtn.Size = new Size(79, 22);
            AccountBtn.TabIndex = 21;
            AccountBtn.Text = "Account";
            AccountBtn.UseVisualStyleBackColor = false;
            AccountBtn.Click += AccountBtn_Click_1;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LogoutBtn.BackColor = Color.Transparent;
            LogoutBtn.FlatAppearance.BorderSize = 0;
            LogoutBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            LogoutBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutBtn.ForeColor = Color.Black;
            LogoutBtn.Location = new Point(1312, 689);
            LogoutBtn.Margin = new Padding(3, 2, 3, 2);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(70, 22);
            LogoutBtn.TabIndex = 22;
            LogoutBtn.Text = "Logout";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1431, 725);
            Controls.Add(AccountBtn);
            Controls.Add(LogoutBtn);
            Controls.Add(settingsBtn);
            Controls.Add(unameLbl);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1447, 764);
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPRS - Staff Dashboard";
            FormClosing += StaffForm_FormClosing;
            Load += StaffForm_Load;
            MouseClick += StaffForm_MouseClick;
            MouseEnter += StaffForm_MouseEnter;
            tabControl1.ResumeLayout(false);
            addPatientBtn.ResumeLayout(false);
            addPatientBtn.PerformLayout();
            notificationPanel.ResumeLayout(false);
            notificationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionsDataGridView).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            notificationPanel1.ResumeLayout(false);
            notificationPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage addPatientBtn;
        private Label label3;
        private Panel notificationPanel;
        private Label notificationLbl;
        private Label PatientNameLbl;
        private DataGridView prescriptionsDataGridView;
        private Panel detailsPanel;
        private Label patientDetaisLbl;
        private Button searchBtn;
        private TextBox searchBox;
        private Label label2;
        private TabPage tabPage2;
        private Label label7;
        private Panel notificationPanel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox medicineSearchTextBox;
        private Label label1;
        private Button settingsBtn;
        private Label unameLbl;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label8;
        private Panel panel3;
        private Panel medicineView;
        private PictureBox pictureBox2;
        private Button AccountBtn;
        private Button LogoutBtn;
    }
}