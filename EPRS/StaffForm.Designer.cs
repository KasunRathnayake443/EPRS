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
            tabPage1 = new TabPage();
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
            label7 = new Label();
            notificationPanel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            medicineSearchTextBox = new TextBox();
            medicineDataGridView = new DataGridView();
            label1 = new Label();
            settingsBtn = new Button();
            unameLbl = new Label();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            notificationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionsDataGridView).BeginInit();
            detailsPanel.SuspendLayout();
            tabPage2.SuspendLayout();
            notificationPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)medicineDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.HotTrack = true;
            tabControl1.ImeMode = ImeMode.Alpha;
            tabControl1.Location = new Point(15, 86);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1568, 824);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(notificationPanel);
            tabPage1.Controls.Add(PatientNameLbl);
            tabPage1.Controls.Add(prescriptionsDataGridView);
            tabPage1.Controls.Add(detailsPanel);
            tabPage1.Controls.Add(searchBtn);
            tabPage1.Controls.Add(searchBox);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1560, 791);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Patient Records";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.Location = new Point(15, 514);
            panel2.Name = "panel2";
            panel2.Size = new Size(1483, 10);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Location = new Point(1035, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 404);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(1204, 29);
            label3.Name = "label3";
            label3.Size = new Size(167, 35);
            label3.TabIndex = 7;
            label3.Text = "Notifications";
            // 
            // notificationPanel
            // 
            notificationPanel.Controls.Add(notificationLbl);
            notificationPanel.Location = new Point(1068, 117);
            notificationPanel.Name = "notificationPanel";
            notificationPanel.Size = new Size(430, 392);
            notificationPanel.TabIndex = 6;
            // 
            // notificationLbl
            // 
            notificationLbl.AutoSize = true;
            notificationLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            notificationLbl.ForeColor = Color.DarkSalmon;
            notificationLbl.Location = new Point(65, 75);
            notificationLbl.Name = "notificationLbl";
            notificationLbl.Size = new Size(292, 25);
            notificationLbl.TabIndex = 1;
            notificationLbl.Text = "Notifications will be Appeared Here";
            // 
            // PatientNameLbl
            // 
            PatientNameLbl.AutoSize = true;
            PatientNameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PatientNameLbl.Location = new Point(33, 85);
            PatientNameLbl.Name = "PatientNameLbl";
            PatientNameLbl.Size = new Size(0, 32);
            PatientNameLbl.TabIndex = 5;
            // 
            // prescriptionsDataGridView
            // 
            prescriptionsDataGridView.BackgroundColor = SystemColors.ControlLightLight;
            prescriptionsDataGridView.BorderStyle = BorderStyle.None;
            prescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prescriptionsDataGridView.Location = new Point(15, 532);
            prescriptionsDataGridView.Name = "prescriptionsDataGridView";
            prescriptionsDataGridView.RowHeadersWidth = 51;
            prescriptionsDataGridView.RowTemplate.Height = 29;
            prescriptionsDataGridView.Size = new Size(1531, 253);
            prescriptionsDataGridView.TabIndex = 4;
            // 
            // detailsPanel
            // 
            detailsPanel.Controls.Add(patientDetaisLbl);
            detailsPanel.Location = new Point(15, 117);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(1001, 392);
            detailsPanel.TabIndex = 3;
            // 
            // patientDetaisLbl
            // 
            patientDetaisLbl.AutoSize = true;
            patientDetaisLbl.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            patientDetaisLbl.ForeColor = Color.DarkSalmon;
            patientDetaisLbl.Location = new Point(60, 59);
            patientDetaisLbl.Name = "patientDetaisLbl";
            patientDetaisLbl.Size = new Size(307, 25);
            patientDetaisLbl.TabIndex = 0;
            patientDetaisLbl.Text = "Patient Details will be Appeared Here";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.LightBlue;
            searchBtn.ForeColor = Color.Black;
            searchBtn.Location = new Point(750, 32);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = false;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(453, 33);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(263, 27);
            searchBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(18, 39);
            label2.Name = "label2";
            label2.Size = new Size(388, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Student Registration Number To Find The Profile : ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(notificationPanel1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(medicineSearchTextBox);
            tabPage2.Controls.Add(medicineDataGridView);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1560, 791);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Medicine Inventory";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.AppWorkspace;
            label7.Location = new Point(1202, 30);
            label7.Name = "label7";
            label7.Size = new Size(167, 35);
            label7.TabIndex = 8;
            label7.Text = "Notifications";
            // 
            // notificationPanel1
            // 
            notificationPanel1.Controls.Add(label6);
            notificationPanel1.Location = new Point(1090, 109);
            notificationPanel1.Name = "notificationPanel1";
            notificationPanel1.Size = new Size(430, 392);
            notificationPanel1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSalmon;
            label6.Location = new Point(65, 75);
            label6.Name = "label6";
            label6.Size = new Size(292, 25);
            label6.TabIndex = 1;
            label6.Text = "Notifications will be Appeared Here";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 97);
            label5.Name = "label5";
            label5.Size = new Size(340, 20);
            label5.TabIndex = 4;
            label5.Text = "Search Medicine To Find Available Stock Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(39, 48);
            label4.Name = "label4";
            label4.Size = new Size(205, 28);
            label4.TabIndex = 3;
            label4.Text = "All Available Medicine";
            // 
            // medicineSearchTextBox
            // 
            medicineSearchTextBox.Location = new Point(382, 91);
            medicineSearchTextBox.Name = "medicineSearchTextBox";
            medicineSearchTextBox.Size = new Size(190, 27);
            medicineSearchTextBox.TabIndex = 1;
            // 
            // medicineDataGridView
            // 
            medicineDataGridView.BackgroundColor = SystemColors.Window;
            medicineDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medicineDataGridView.GridColor = SystemColors.InactiveCaption;
            medicineDataGridView.Location = new Point(36, 132);
            medicineDataGridView.Name = "medicineDataGridView";
            medicineDataGridView.RowHeadersWidth = 51;
            medicineDataGridView.RowTemplate.Height = 29;
            medicineDataGridView.Size = new Size(536, 639);
            medicineDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Gill Sans Ultra Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(44, 110, 73);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(577, 36);
            label1.TabIndex = 11;
            label1.Text = "Patient Record Management System";
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.Image = (Image)resources.GetObject("settingsBtn.Image");
            settingsBtn.Location = new Point(1585, 912);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(44, 46);
            settingsBtn.TabIndex = 17;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // unameLbl
            // 
            unameLbl.AutoSize = true;
            unameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            unameLbl.ForeColor = Color.Tomato;
            unameLbl.Location = new Point(1370, 51);
            unameLbl.Name = "unameLbl";
            unameLbl.Size = new Size(157, 32);
            unameLbl.TabIndex = 16;
            unameLbl.Text = "Doctor Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1526, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1633, 959);
            Controls.Add(settingsBtn);
            Controls.Add(unameLbl);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPRS Staff Dahboard";
            FormClosing += StaffForm_FormClosing;
            Load += StaffForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            notificationPanel.ResumeLayout(false);
            notificationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionsDataGridView).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            notificationPanel1.ResumeLayout(false);
            notificationPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)medicineDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
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
        private DataGridView medicineDataGridView;
        private Label label1;
        private Button settingsBtn;
        private Label unameLbl;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
    }
}