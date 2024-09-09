namespace EPRS
{
    partial class ProfileUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileUpdate));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            cancelBtn = new Button();
            saveBtn = new Button();
            passBox = new TextBox();
            userBox = new TextBox();
            nameBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(168, 89);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(34, 37);
            label3.Name = "label3";
            label3.Size = new Size(300, 31);
            label3.TabIndex = 12;
            label3.Text = "Update Your Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(50, 96);
            label2.Name = "label2";
            label2.Size = new Size(317, 60);
            label2.TabIndex = 13;
            label2.Text = "Please update your profile information below. \nMake sure all fields are accurate to keep your \naccount up to date.";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(passBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(userBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(383, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 347);
            panel1.TabIndex = 14;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Crimson;
            cancelBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(192, 280);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.Lime;
            saveBtn.Location = new Point(71, 280);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // passBox
            // 
            passBox.Location = new Point(168, 212);
            passBox.Name = "passBox";
            passBox.Size = new Size(158, 27);
            passBox.TabIndex = 8;
            // 
            // userBox
            // 
            userBox.Location = new Point(168, 166);
            userBox.Name = "userBox";
            userBox.Size = new Size(158, 27);
            userBox.TabIndex = 7;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(168, 125);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(158, 27);
            nameBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 215);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 4;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 173);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 3;
            label6.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 132);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 2;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 89);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 1;
            label4.Text = "ID ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(70, 22);
            label8.Name = "label8";
            label8.Size = new Size(216, 35);
            label8.TabIndex = 0;
            label8.Text = "Your Information";
            // 
            // ProfileUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 254, 227);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProfileUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Profie";
            Load += ProfileUpdate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Button cancelBtn;
        private Button saveBtn;
        private TextBox passBox;
        private TextBox userBox;
        private TextBox nameBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
    }
}