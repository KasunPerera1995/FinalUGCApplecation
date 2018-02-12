namespace PensionScheme
{
    partial class PensionPayment
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
            this.PensionHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PensionPeriodSelect = new System.Windows.Forms.DateTimePicker();
            this.ShowAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PensionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // PensionHistory
            // 
            this.PensionHistory.AllowUserToAddRows = false;
            this.PensionHistory.AllowUserToDeleteRows = false;
            this.PensionHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PensionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PensionHistory.Location = new System.Drawing.Point(12, 83);
            this.PensionHistory.Name = "PensionHistory";
            this.PensionHistory.ReadOnly = true;
            this.PensionHistory.Size = new System.Drawing.Size(483, 329);
            this.PensionHistory.TabIndex = 0;
            this.PensionHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PensionHistory_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pensioner History";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PensionPeriodSelect
            // 
            this.PensionPeriodSelect.CustomFormat = "yyyy/MM";
            this.PensionPeriodSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PensionPeriodSelect.Location = new System.Drawing.Point(538, 107);
            this.PensionPeriodSelect.Name = "PensionPeriodSelect";
            this.PensionPeriodSelect.Size = new System.Drawing.Size(137, 20);
            this.PensionPeriodSelect.TabIndex = 3;
            this.PensionPeriodSelect.ValueChanged += new System.EventHandler(this.PensionMonth_ValueChanged);
            // 
            // ShowAll
            // 
            this.ShowAll.AutoSize = true;
            this.ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowAll.Location = new System.Drawing.Point(538, 165);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(84, 22);
            this.ShowAll.TabIndex = 4;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.CheckedChanged += new System.EventHandler(this.ShowAll_CheckedChanged);
            this.ShowAll.CheckStateChanged += new System.EventHandler(this.ShowAll_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(538, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate slip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(538, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PensionPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(799, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.PensionPeriodSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PensionHistory);
            this.Name = "PensionPayment";
            this.Text = "Pension Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PensionPayment_FormClosed);
            this.Load += new System.EventHandler(this.PensionPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PensionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PensionHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker PensionPeriodSelect;
        private System.Windows.Forms.CheckBox ShowAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}