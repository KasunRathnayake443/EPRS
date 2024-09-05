namespace EPRS
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            PatientNameLbl = new Label();
            prescriptionsDataGridView = new DataGridView();
            detailsPanel = new Panel();
            searchBtn = new Button();
            searchBox = new TextBox();
            label2 = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            welcomeLabel = new Label();
            pictureBox1 = new PictureBox();
            unameLbl = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(30, 101);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1568, 824);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            // PatientNameLbl
            // 
            PatientNameLbl.AutoSize = true;
            PatientNameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PatientNameLbl.ForeColor = Color.Orange;
            PatientNameLbl.Location = new Point(32, 67);
            PatientNameLbl.Name = "PatientNameLbl";
            PatientNameLbl.Size = new Size(78, 32);
            PatientNameLbl.TabIndex = 5;
            PatientNameLbl.Text = "Name";
            // 
            // prescriptionsDataGridView
            // 
            prescriptionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prescriptionsDataGridView.Location = new Point(12, 467);
            prescriptionsDataGridView.Name = "prescriptionsDataGridView";
            prescriptionsDataGridView.RowHeadersWidth = 51;
            prescriptionsDataGridView.RowTemplate.Height = 29;
            prescriptionsDataGridView.Size = new Size(1531, 301);
            prescriptionsDataGridView.TabIndex = 4;
            // 
            // detailsPanel
            // 
            detailsPanel.Location = new Point(15, 117);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(1528, 344);
            detailsPanel.TabIndex = 3;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(750, 32);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 2;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
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
            label2.Location = new Point(15, 36);
            label2.Name = "label2";
            label2.Size = new Size(377, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Student Registration Number To Find The Profile";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1560, 791);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Medicine Inventory";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Gill Sans Ultra Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(577, 36);
            label1.TabIndex = 10;
            label1.Text = "Patient Record Management System";
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(461, 43);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(0, 20);
            welcomeLabel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1531, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // unameLbl
            // 
            unameLbl.AutoSize = true;
            unameLbl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            unameLbl.ForeColor = Color.Tomato;
            unameLbl.Location = new Point(1381, 43);
            unameLbl.Name = "unameLbl";
            unameLbl.Size = new Size(78, 32);
            unameLbl.TabIndex = 13;
            unameLbl.Text = "label3";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1622, 937);
            Controls.Add(unameLbl);
            Controls.Add(pictureBox1);
            Controls.Add(welcomeLabel);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DoctorForm";
            Text = "  EPRS - Doctor Dashboard";
            Load += DoctorForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prescriptionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button searchBtn;
        private TextBox searchBox;
        private Label label2;
        private Label label1;
        private Panel detailsPanel;
        private Label welcomeLabel;
        private Label nameLbl;
        private Label dobLbl;
        private Label idLbl;
        private PictureBox pictureBox1;
        private Label unameLbl;
        private DataGridView prescriptionsDataGridView;
        private Label PatientNameLbl;
    }
}