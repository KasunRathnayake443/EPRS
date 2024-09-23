namespace EPRS
{
    partial class EditPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPatient));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            FNameBox = new TextBox();
            LNameBox = new TextBox();
            AddressBox = new TextBox();
            EmailBox = new TextBox();
            PhoneBox = new TextBox();
            GenderBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            IdLbl = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(42, 43);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 0;
            label1.Text = "Update Patient Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(99, 179);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(503, 179);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(99, 123);
            label4.Name = "label4";
            label4.Size = new Size(40, 28);
            label4.TabIndex = 3;
            label4.Text = "ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(99, 230);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 4;
            label5.Text = "Gender :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(503, 230);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 5;
            label6.Text = "Date Of Birth :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(99, 287);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 6;
            label7.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(99, 347);
            label8.Name = "label8";
            label8.Size = new Size(68, 28);
            label8.TabIndex = 7;
            label8.Text = "Email :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(503, 347);
            label9.Name = "label9";
            label9.Size = new Size(108, 28);
            label9.TabIndex = 8;
            label9.Text = "Phone No :";
            // 
            // FNameBox
            // 
            FNameBox.Location = new Point(220, 183);
            FNameBox.Name = "FNameBox";
            FNameBox.Size = new Size(255, 27);
            FNameBox.TabIndex = 9;
            // 
            // LNameBox
            // 
            LNameBox.Location = new Point(649, 183);
            LNameBox.Name = "LNameBox";
            LNameBox.Size = new Size(255, 27);
            LNameBox.TabIndex = 10;
            // 
            // AddressBox
            // 
            AddressBox.Location = new Point(220, 291);
            AddressBox.Name = "AddressBox";
            AddressBox.Size = new Size(684, 27);
            AddressBox.TabIndex = 11;
            // 
            // EmailBox
            // 
            EmailBox.Location = new Point(220, 351);
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(255, 27);
            EmailBox.TabIndex = 12;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(649, 348);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(255, 27);
            PhoneBox.TabIndex = 13;
            // 
            // GenderBox
            // 
            GenderBox.FormattingEnabled = true;
            GenderBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderBox.Location = new Point(220, 234);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(255, 28);
            GenderBox.TabIndex = 14;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(649, 235);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(255, 27);
            dateTimePicker.TabIndex = 15;
            // 
            // IdLbl
            // 
            IdLbl.AutoSize = true;
            IdLbl.ForeColor = SystemColors.ControlDarkDark;
            IdLbl.Location = new Point(220, 130);
            IdLbl.Name = "IdLbl";
            IdLbl.Size = new Size(42, 20);
            IdLbl.TabIndex = 16;
            IdLbl.Text = "IdLbl";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.RoyalBlue;
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(687, 448);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 39);
            saveBtn.TabIndex = 17;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.LightCoral;
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(810, 448);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 39);
            cancelBtn.TabIndex = 18;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // EditPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(974, 529);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(IdLbl);
            Controls.Add(dateTimePicker);
            Controls.Add(GenderBox);
            Controls.Add(PhoneBox);
            Controls.Add(EmailBox);
            Controls.Add(AddressBox);
            Controls.Add(LNameBox);
            Controls.Add(FNameBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Patient Details";
            Load += EditPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox FNameBox;
        private TextBox LNameBox;
        private TextBox AddressBox;
        private TextBox EmailBox;
        private TextBox PhoneBox;
        private ComboBox GenderBox;
        private DateTimePicker dateTimePicker;
        private Label IdLbl;
        private Button saveBtn;
        private Button cancelBtn;
    }
}