namespace EPRS
{
    partial class EditMedicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMedicine));
            label1 = new Label();
            ID = new Label();
            label3 = new Label();
            label4 = new Label();
            NameBox = new TextBox();
            AmountBox = new TextBox();
            label2 = new Label();
            CancelBtn = new Button();
            SaveBtn = new Button();
            IdLbl = new Label();
            DeleteBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(62, 30);
            label1.Name = "label1";
            label1.Size = new Size(155, 31);
            label1.TabIndex = 0;
            label1.Text = "Edit Medicine";
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            ID.ForeColor = Color.DimGray;
            ID.Location = new Point(130, 111);
            ID.Name = "ID";
            ID.Size = new Size(39, 25);
            ID.TabIndex = 1;
            ID.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(130, 171);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(130, 232);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Amount :";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(250, 171);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(285, 27);
            NameBox.TabIndex = 4;
            // 
            // AmountBox
            // 
            AmountBox.Location = new Point(250, 232);
            AmountBox.Name = "AmountBox";
            AmountBox.Size = new Size(260, 27);
            AmountBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 235);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 6;
            label2.Text = "g";
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.LemonChiffon;
            CancelBtn.Location = new Point(326, 300);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MediumSpringGreen;
            SaveBtn.ForeColor = SystemColors.ActiveCaptionText;
            SaveBtn.Location = new Point(212, 300);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(94, 29);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // IdLbl
            // 
            IdLbl.AutoSize = true;
            IdLbl.ForeColor = SystemColors.ControlDark;
            IdLbl.Location = new Point(250, 116);
            IdLbl.Name = "IdLbl";
            IdLbl.Size = new Size(24, 20);
            IdLbl.TabIndex = 10;
            IdLbl.Text = "ID";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.LightCoral;
            DeleteBtn.Location = new Point(441, 300);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(94, 29);
            DeleteBtn.TabIndex = 11;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditMedicine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(690, 402);
            Controls.Add(DeleteBtn);
            Controls.Add(IdLbl);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(label2);
            Controls.Add(AmountBox);
            Controls.Add(NameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ID);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditMedicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditMedicine";
            Load += EditMedicine_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ID;
        private Label label3;
        private Label label4;
        private TextBox NameBox;
        private TextBox AmountBox;
        private Label label2;
        private Button CancelBtn;
        private Button SaveBtn;
        private Label IdLbl;
        private Button DeleteBtn;
    }
}