namespace PensionScheme
{
    partial class PenPro
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
            this.Period = new System.Windows.Forms.DateTimePicker();
            this.PensionPro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PensionerView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.ArrearData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PensionHistory = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PensionerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrearData)).BeginInit();
            this.SuspendLayout();
            // 
            // Period
            // 
            this.Period.CustomFormat = "yyyy/MM";
            this.Period.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Period.Location = new System.Drawing.Point(575, 28);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(248, 20);
            this.Period.TabIndex = 0;
            this.Period.ValueChanged += new System.EventHandler(this.Period_ValueChanged);
            // 
            // PensionPro
            // 
            this.PensionPro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PensionPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PensionPro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PensionPro.Location = new System.Drawing.Point(905, 69);
            this.PensionPro.Name = "PensionPro";
            this.PensionPro.Size = new System.Drawing.Size(101, 69);
            this.PensionPro.TabIndex = 1;
            this.PensionPro.Text = "Process";
            this.PensionPro.UseVisualStyleBackColor = false;
            this.PensionPro.Click += new System.EventHandler(this.PensionPro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(518, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Period";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(905, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "GeneraTe Bank Slip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PensionerView
            // 
            this.PensionerView.AllowUserToAddRows = false;
            this.PensionerView.AllowUserToDeleteRows = false;
            this.PensionerView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PensionerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PensionerView.Location = new System.Drawing.Point(0, 69);
            this.PensionerView.Name = "PensionerView";
            this.PensionerView.ReadOnly = true;
            this.PensionerView.Size = new System.Drawing.Size(823, 222);
            this.PensionerView.TabIndex = 4;
            this.PensionerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PensionerView_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(905, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "Arrears";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ArrearData
            // 
            this.ArrearData.AllowUserToAddRows = false;
            this.ArrearData.AllowUserToDeleteRows = false;
            this.ArrearData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArrearData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArrearData.Location = new System.Drawing.Point(3, 315);
            this.ArrearData.Name = "ArrearData";
            this.ArrearData.ReadOnly = true;
            this.ArrearData.Size = new System.Drawing.Size(820, 181);
            this.ArrearData.TabIndex = 8;
            this.ArrearData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArrearData_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pension Process";
            // 
            // PensionHistory
            // 
            this.PensionHistory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PensionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PensionHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PensionHistory.Location = new System.Drawing.Point(905, 264);
            this.PensionHistory.Name = "PensionHistory";
            this.PensionHistory.Size = new System.Drawing.Size(101, 63);
            this.PensionHistory.TabIndex = 10;
            this.PensionHistory.Text = "Pension History";
            this.PensionHistory.UseVisualStyleBackColor = false;
            this.PensionHistory.Click += new System.EventHandler(this.PensionHistory_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(905, 145);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(905, 441);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(905, 475);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 61);
            this.button4.TabIndex = 13;
            this.button4.Text = "Insert Payment";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PenPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1018, 531);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.PensionHistory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArrearData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PensionerView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PensionPro);
            this.Controls.Add(this.Period);
            this.Name = "PenPro";
            this.Text = "Process Pension";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PenPro_FormClosed);
            this.Load += new System.EventHandler(this.PenPro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PensionerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrearData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Period;
        private System.Windows.Forms.Button PensionPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView PensionerView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView ArrearData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PensionHistory;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}