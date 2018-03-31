namespace PensionScheme
{
    partial class InsertContribution
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Insert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tReceiptNo = new System.Windows.Forms.TextBox();
            this.tAmount = new System.Windows.Forms.TextBox();
            this.tContributionID = new System.Windows.Forms.TextBox();
            this.tSubDate = new System.Windows.Forms.DateTimePicker();
            this.tPeriod = new System.Windows.Forms.DateTimePicker();
            this.tUniversity = new System.Windows.Forms.ComboBox();
            this.tOwnerID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tOwnerID);
            this.groupBox1.Controls.Add(this.tUniversity);
            this.groupBox1.Controls.Add(this.tPeriod);
            this.groupBox1.Controls.Add(this.tSubDate);
            this.groupBox1.Controls.Add(this.tContributionID);
            this.groupBox1.Controls.Add(this.Insert);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tReceiptNo);
            this.groupBox1.Controls.Add(this.tAmount);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(54, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 475);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contributions";
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Insert.Location = new System.Drawing.Point(429, 419);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 49);
            this.Insert.TabIndex = 16;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "OwnerID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "ReceiptNo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "SubDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Period";
            this.label4.TextChanged += new System.EventHandler(this.Period);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "University";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ContributionID";
            // 
            // tReceiptNo
            // 
            this.tReceiptNo.Location = new System.Drawing.Point(179, 283);
            this.tReceiptNo.Name = "tReceiptNo";
            this.tReceiptNo.Size = new System.Drawing.Size(185, 24);
            this.tReceiptNo.TabIndex = 5;
            // 
            // tAmount
            // 
            this.tAmount.Location = new System.Drawing.Point(179, 238);
            this.tAmount.Name = "tAmount";
            this.tAmount.Size = new System.Drawing.Size(185, 24);
            this.tAmount.TabIndex = 4;
            // 
            // tContributionID
            // 
            this.tContributionID.Location = new System.Drawing.Point(179, 73);
            this.tContributionID.Name = "tContributionID";
            this.tContributionID.Size = new System.Drawing.Size(185, 24);
            this.tContributionID.TabIndex = 17;
            // 
            // tSubDate
            // 
            this.tSubDate.CustomFormat = "yyyy-MM-dd";
            this.tSubDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tSubDate.Location = new System.Drawing.Point(179, 191);
            this.tSubDate.Name = "tSubDate";
            this.tSubDate.Size = new System.Drawing.Size(185, 24);
            this.tSubDate.TabIndex = 18;
            this.tSubDate.Value = new System.DateTime(2018, 3, 8, 0, 0, 0, 0);
            this.tSubDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.tSubDate.Validating += new System.ComponentModel.CancelEventHandler(this.tSubDate_Validating);
            this.tSubDate.Validated += new System.EventHandler(this.tSubDate_Validated);
            // 
            // tPeriod
            // 
            this.tPeriod.CustomFormat = "yyyy-MM-dd";
            this.tPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tPeriod.Location = new System.Drawing.Point(179, 150);
            this.tPeriod.Name = "tPeriod";
            this.tPeriod.Size = new System.Drawing.Size(185, 24);
            this.tPeriod.TabIndex = 19;
            this.tPeriod.Validating += new System.ComponentModel.CancelEventHandler(this.tPeriod_Validating);
            // 
            // tUniversity
            // 
            this.tUniversity.FormattingEnabled = true;
            this.tUniversity.Location = new System.Drawing.Point(179, 112);
            this.tUniversity.Name = "tUniversity";
            this.tUniversity.Size = new System.Drawing.Size(185, 26);
            this.tUniversity.TabIndex = 20;
            // 
            // tOwnerID
            // 
            this.tOwnerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tOwnerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tOwnerID.FormattingEnabled = true;
            this.tOwnerID.Location = new System.Drawing.Point(179, 322);
            this.tOwnerID.Name = "tOwnerID";
            this.tOwnerID.Size = new System.Drawing.Size(185, 26);
            this.tOwnerID.TabIndex = 21;
            // 
            // InsertContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(651, 520);
            this.Controls.Add(this.groupBox1);
            this.Name = "InsertContribution";
            this.Text = "InsertContribution";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tContributionID;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tReceiptNo;
        public System.Windows.Forms.TextBox tAmount;
        private System.Windows.Forms.DateTimePicker tSubDate;
        private System.Windows.Forms.DateTimePicker tPeriod;
        private System.Windows.Forms.ComboBox tUniversity;
        private System.Windows.Forms.ComboBox tOwnerID;
    }
}