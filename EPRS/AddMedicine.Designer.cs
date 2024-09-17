namespace EPRS
{
    partial class AddMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            NameBox = new TextBox();
            AmountBox = new TextBox();
            SaveBtn = new Button();
            CancelBtn = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 0;
            label1.Text = "Add New Medicine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(103, 114);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(103, 172);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 221);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // NameBox
            // 
            NameBox.Location = new Point(216, 115);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(330, 27);
            NameBox.TabIndex = 4;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(216, 173);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(309, 27);
            AmountBox.TabIndex = 5;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.RoyalBlue;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(334, 248);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 39);
            SaveBtn.TabIndex = 6;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click_1;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.LightCoral;
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(452, 248);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 39);
            CancelBtn.TabIndex = 7;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(531, 177);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 8;
            label5.Text = "g";
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(628, 357);
            Controls.Add(label5);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(AmountBox);
            Controls.Add(NameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddMedicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMedicine";
            Load += AddMedicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NameBox;
        private TextBox AmountBox;
        private Button SaveBtn;
        private Button CancelBtn;
        private Label label5;
    }
}