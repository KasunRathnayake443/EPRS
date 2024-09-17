namespace EPRS
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameBox = new TextBox();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            UpdateBtn = new Button();
            CancelBtn = new Button();
            UserId = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 0;
            label1.Text = "Update User Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "User ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 145);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(100, 192);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "Username :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(100, 235);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 4;
            label5.Text = "Password :";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(228, 143);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(279, 27);
            NameBox.TabIndex = 5;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(228, 190);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(279, 27);
            UsernameBox.TabIndex = 6;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(228, 233);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(279, 27);
            PasswordBox.TabIndex = 7;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.RoyalBlue;
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(298, 294);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 38);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.LightCoral;
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(413, 294);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 38);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // UserId
            // 
            UserId.AutoSize = true;
            UserId.ForeColor = Color.DarkGray;
            UserId.Location = new Point(228, 105);
            UserId.Name = "UserId";
            UserId.Size = new Size(50, 20);
            UserId.TabIndex = 10;
            UserId.Text = "label6";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(610, 400);
            Controls.Add(UserId);
            Controls.Add(CancelBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(NameBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update User Details";
            FormClosing += EditUser_FormClosing;
            Load += EditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameBox;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button UpdateBtn;
        private Button CancelBtn;
        private Label UserId;
    }
}