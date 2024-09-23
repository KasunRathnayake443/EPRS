namespace EPRS
{
    partial class AddNewRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRecordForm));
            patientIdLabel = new Label();
            doctorIdLabel = new Label();
            medicineComboBox = new ComboBox();
            addMedicineButton = new Button();
            descriptionTextBox = new TextBox();
            saveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            doseBox = new TextBox();
            medicinesListBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            removeMedicineButton = new Button();
            SuspendLayout();
            // 
            // patientIdLabel
            // 
            patientIdLabel.AutoSize = true;
            patientIdLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            patientIdLabel.ForeColor = Color.Black;
            patientIdLabel.Location = new Point(124, 95);
            patientIdLabel.Name = "patientIdLabel";
            patientIdLabel.Size = new Size(117, 32);
            patientIdLabel.TabIndex = 0;
            patientIdLabel.Text = "Patient ID";
            // 
            // doctorIdLabel
            // 
            doctorIdLabel.AutoSize = true;
            doctorIdLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            doctorIdLabel.ForeColor = Color.Black;
            doctorIdLabel.Location = new Point(806, 95);
            doctorIdLabel.Name = "doctorIdLabel";
            doctorIdLabel.Size = new Size(116, 32);
            doctorIdLabel.TabIndex = 1;
            doctorIdLabel.Text = "Doctor ID";
            // 
            // medicineComboBox
            // 
            medicineComboBox.FormattingEnabled = true;
            medicineComboBox.Location = new Point(233, 227);
            medicineComboBox.Name = "medicineComboBox";
            medicineComboBox.Size = new Size(235, 28);
            medicineComboBox.TabIndex = 2;
            medicineComboBox.TextUpdate += medicineComboBox_TextUpdate_1;
            // 
            // addMedicineButton
            // 
            addMedicineButton.BackColor = Color.RoyalBlue;
            addMedicineButton.ForeColor = Color.White;
            addMedicineButton.Location = new Point(867, 221);
            addMedicineButton.Name = "addMedicineButton";
            addMedicineButton.Size = new Size(94, 39);
            addMedicineButton.TabIndex = 3;
            addMedicineButton.Text = "Add";
            addMedicineButton.UseVisualStyleBackColor = false;
            addMedicineButton.Click += addMedicineButton_Click_1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(233, 161);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(728, 27);
            descriptionTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.RoyalBlue;
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(233, 476);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 39);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save ";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(125, 164);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 8;
            label1.Text = "Description :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(125, 230);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "Medicine :";
            // 
            // doseBox
            // 
            doseBox.Location = new Point(614, 227);
            doseBox.Name = "doseBox";
            doseBox.Size = new Size(151, 27);
            doseBox.TabIndex = 10;
            // 
            // medicinesListBox
            // 
            medicinesListBox.FormattingEnabled = true;
            medicinesListBox.ItemHeight = 20;
            medicinesListBox.Location = new Point(233, 295);
            medicinesListBox.Name = "medicinesListBox";
            medicinesListBox.Size = new Size(619, 144);
            medicinesListBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(540, 230);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 12;
            label3.Text = "Dose :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(771, 230);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 13;
            label4.Text = "g";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(24, 18);
            label5.Name = "label5";
            label5.Size = new Size(277, 35);
            label5.TabIndex = 14;
            label5.Text = "Add a New Prescription";
            // 
            // removeMedicineButton
            // 
            removeMedicineButton.BackColor = Color.LightCoral;
            removeMedicineButton.ForeColor = Color.White;
            removeMedicineButton.Location = new Point(867, 295);
            removeMedicineButton.Name = "removeMedicineButton";
            removeMedicineButton.Size = new Size(94, 39);
            removeMedicineButton.TabIndex = 15;
            removeMedicineButton.Text = "Remove";
            removeMedicineButton.UseVisualStyleBackColor = false;
            removeMedicineButton.Click += removeMedicineButton_Click;
            // 
            // AddNewRecordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 227);
            ClientSize = new Size(1123, 577);
            Controls.Add(removeMedicineButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(medicinesListBox);
            Controls.Add(doseBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(descriptionTextBox);
            Controls.Add(addMedicineButton);
            Controls.Add(medicineComboBox);
            Controls.Add(doctorIdLabel);
            Controls.Add(patientIdLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddNewRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddNewRecordForm";
            Load += AddNewRecordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label patientIdLabel;
        private Label doctorIdLabel;
        private ComboBox medicineComboBox;
        private Button addMedicineButton;
        private TextBox descriptionTextBox;
        private Button saveButton;
        private Label label1;
        private Label label2;
        private TextBox doseBox;
        private ListBox medicinesListBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button removeMedicineButton;
    }
}