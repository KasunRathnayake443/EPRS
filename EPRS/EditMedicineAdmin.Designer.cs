namespace EPRS
{
    partial class EditMedicineAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMedicineAdmin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idLbl = new Label();
            label6 = new Label();
            NameBox = new TextBox();
            AmountBox = new TextBox();
            SaveBtn = new Button();
            Deletebtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(37, 25);
            label1.Name = "label1";
            label1.Size = new Size(165, 35);
            label1.TabIndex = 0;
            label1.Text = "Edit Medicine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 161);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 215);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 2;
            label3.Text = "Amount :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 105);
            label4.Name = "label4";
            label4.Size = new Size(40, 28);
            label4.TabIndex = 3;
            label4.Text = "ID :";
            // 
            // idLbl
            // 
            idLbl.AutoSize = true;
            idLbl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            idLbl.ForeColor = Color.DimGray;
            idLbl.Location = new Point(181, 108);
            idLbl.Name = "idLbl";
            idLbl.Size = new Size(63, 25);
            idLbl.TabIndex = 4;
            idLbl.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(423, 219);
            label6.Name = "label6";
            label6.Size = new Size(24, 28);
            label6.TabIndex = 5;
            label6.Text = "g";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(181, 161);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(255, 27);
            NameBox.TabIndex = 6;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(181, 219);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(236, 27);
            AmountBox.TabIndex = 7;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.RoyalBlue;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(222, 288);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 41);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Gray;
            Deletebtn.ForeColor = Color.White;
            Deletebtn.Location = new Point(342, 288);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(94, 41);
            Deletebtn.TabIndex = 9;
            Deletebtn.Text = "Cancel";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // EditMedicineAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(538, 364);
            Controls.Add(Deletebtn);
            Controls.Add(SaveBtn);
            Controls.Add(AmountBox);
            Controls.Add(NameBox);
            Controls.Add(label6);
            Controls.Add(idLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditMedicineAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Medicine";
            Load += EditMedicineAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label idLbl;
        private Label label6;
        private TextBox NameBox;
        private TextBox AmountBox;
        private Button SaveBtn;
        private Button Deletebtn;
    }
}