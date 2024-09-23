namespace EPRS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Login = new Label();
            userBox = new TextBox();
            passBox = new TextBox();
            panel1 = new Panel();
            loginBtn = new Button();
            pictureBox2 = new PictureBox();
            settingsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Gill Sans Ultra Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(787, 50);
            label1.TabIndex = 9;
            label1.Text = "Patient Record Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(47, 98);
            label2.Name = "label2";
            label2.Size = new Size(123, 35);
            label2.TabIndex = 10;
            label2.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 248);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(69, 143);
            label3.Name = "label3";
            label3.Size = new Size(284, 140);
            label3.TabIndex = 13;
            label3.Text = "• Use your credentials to log in.\n• Contact admin for help.\n• Manage patients\n• Manage doctors\n• Manage inventory";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 93);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 14;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 151);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 15;
            label5.Text = "Password";
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Login.Location = new Point(135, 21);
            Login.Name = "Login";
            Login.Size = new Size(80, 35);
            Login.TabIndex = 16;
            Login.Text = "Login";
            // 
            // userBox
            // 
            userBox.Location = new Point(140, 90);
            userBox.Name = "userBox";
            userBox.Size = new Size(166, 27);
            userBox.TabIndex = 17;
            // 
            // passBox
            // 
            passBox.Location = new Point(140, 148);
            passBox.Name = "passBox";
            passBox.Size = new Size(166, 27);
            passBox.TabIndex = 18;
            passBox.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(passBox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(userBox);
            panel1.Location = new Point(517, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 264);
            panel1.TabIndex = 19;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.Azure;
            loginBtn.BackgroundImage = (Image)resources.GetObject("loginBtn.BackgroundImage");
            loginBtn.BackgroundImageLayout = ImageLayout.Zoom;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.Turquoise;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(117, 192);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(132, 52);
            loginBtn.TabIndex = 19;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(580, 391);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(233, 145);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // settingsBtn
            // 
        
          
        
            settingsBtn.BackColor = Color.Transparent;
            settingsBtn.BackgroundImage = (Image)resources.GetObject("settingsBtn.BackgroundImage");
            settingsBtn.BackgroundImageLayout = ImageLayout.Stretch;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            settingsBtn.FlatAppearance.MouseOverBackColor = Color.LightGray;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Image = (Image)resources.GetObject("settingsBtn.Image");
            settingsBtn.Location = new Point(12, 485);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(34, 35);
            settingsBtn.TabIndex = 18;
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(890, 534);
            Controls.Add(settingsBtn);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EPRS - Login";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Login;
        private TextBox userBox;
        private TextBox passBox;
        private Panel panel1;
        private Button loginBtn;
        private PictureBox pictureBox2;
        private Button settingsBtn;
    }

    // Custom TabControl class to remove the border
    public class BorderlessTabControl : TabControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Parent.BackColor); // Set the background color to match the parent control
            for (int i = 0; i < TabPages.Count; i++)
            {
                Rectangle r = GetTabRect(i);
                e.Graphics.DrawString(TabPages[i].Text, Font, SystemBrushes.ControlText, new PointF(r.X + 3, r.Y + 3));
            }
        }
    }
}
