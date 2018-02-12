namespace PensionScheme
{
    partial class DependentPayments
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
            this.DependentView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.PeriodSelect = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DependentView)).BeginInit();
            this.SuspendLayout();
            // 
            // DependentView
            // 
            this.DependentView.AllowUserToAddRows = false;
            this.DependentView.AllowUserToDeleteRows = false;
            this.DependentView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DependentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DependentView.Location = new System.Drawing.Point(27, 96);
            this.DependentView.Name = "DependentView";
            this.DependentView.ReadOnly = true;
            this.DependentView.Size = new System.Drawing.Size(611, 276);
            this.DependentView.TabIndex = 0;
            this.DependentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DependentView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(583, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate and Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PeriodSelect
            // 
            this.PeriodSelect.CustomFormat = "yyyy-MM";
            this.PeriodSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PeriodSelect.Location = new System.Drawing.Point(27, 49);
            this.PeriodSelect.Name = "PeriodSelect";
            this.PeriodSelect.Size = new System.Drawing.Size(215, 20);
            this.PeriodSelect.TabIndex = 2;
            this.PeriodSelect.ValueChanged += new System.EventHandler(this.PeriodSelect_ValueChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(434, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DependentPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(716, 469);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PeriodSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DependentView);
            this.Name = "DependentPayments";
            this.Text = "Dependent Payments";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DependentPayments_FormClosed);
            this.Load += new System.EventHandler(this.DependentPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DependentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DependentView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker PeriodSelect;
        private System.Windows.Forms.Button button2;
    }
}