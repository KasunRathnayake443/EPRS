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
            tabPage2 = new TabPage();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1734, 803);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Manage Patients";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}