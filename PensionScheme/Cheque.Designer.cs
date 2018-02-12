namespace PensionScheme
{
    partial class Cheque
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
            this.ReNo = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Uni = new System.Windows.Forms.ComboBox();
            this.Period = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ConOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReNo
            // 
            this.ReNo.Location = new System.Drawing.Point(212, 30);
            this.ReNo.Name = "ReNo";
            this.ReNo.Size = new System.Drawing.Size(206, 24);
            this.ReNo.TabIndex = 0;
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(212, 108);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(206, 24);
            this.Amount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Receipt Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "University";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cheque Received Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Status";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(212, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 24);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Uni
            // 
            this.Uni.FormattingEnabled = true;
            this.Uni.Location = new System.Drawing.Point(212, 69);
            this.Uni.Name = "Uni";
            this.Uni.Size = new System.Drawing.Size(206, 26);
            this.Uni.TabIndex = 14;
            this.Uni.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Period
            // 
            this.Period.CustomFormat = "yyyy-MM";
            this.Period.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Period.Location = new System.Drawing.Point(212, 200);
            this.Period.MaxDate = new System.DateTime(2400, 1, 1, 0, 0, 0, 0);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(206, 24);
            this.Period.TabIndex = 16;
            this.Period.Value = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(455, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConOpen
            // 
            this.ConOpen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ConOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConOpen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConOpen.Location = new System.Drawing.Point(343, 332);
            this.ConOpen.Name = "ConOpen";
            this.ConOpen.Size = new System.Drawing.Size(106, 50);
            this.ConOpen.TabIndex = 18;
            this.ConOpen.Text = "ContributionPane";
            this.ConOpen.UseVisualStyleBackColor = false;
            this.ConOpen.Click += new System.EventHandler(this.ConOpen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.Period);
            this.groupBox1.Controls.Add(this.Uni);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.ReNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(4, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 318);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cheque Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // Status
            // 
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(212, 246);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(206, 26);
            this.Status.TabIndex = 17;
            // 
            // Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(586, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConOpen);
            this.Controls.Add(this.button1);
            this.Name = "Cheque";
            this.Text = "ChequeDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cheque_FormClosed);
            this.Load += new System.EventHandler(this.Cheque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ReNo;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Uni;
        private System.Windows.Forms.DateTimePicker Period;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Status;
    }
}