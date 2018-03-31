namespace PensionScheme
{
    partial class LumpSum
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
            this.LumpSumGrid = new System.Windows.Forms.DataGridView();
            this.LumpSumProcess = new System.Windows.Forms.Button();
            this.LumpsumHistory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LumpSumGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LumpSumGrid
            // 
            this.LumpSumGrid.AllowUserToAddRows = false;
            this.LumpSumGrid.AllowUserToDeleteRows = false;
            this.LumpSumGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LumpSumGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LumpSumGrid.Location = new System.Drawing.Point(12, 70);
            this.LumpSumGrid.Name = "LumpSumGrid";
            this.LumpSumGrid.ReadOnly = true;
            this.LumpSumGrid.Size = new System.Drawing.Size(993, 180);
            this.LumpSumGrid.TabIndex = 0;
            // 
            // LumpSumProcess
            // 
            this.LumpSumProcess.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LumpSumProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumpSumProcess.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LumpSumProcess.Location = new System.Drawing.Point(727, 331);
            this.LumpSumProcess.Name = "LumpSumProcess";
            this.LumpSumProcess.Size = new System.Drawing.Size(106, 72);
            this.LumpSumProcess.TabIndex = 1;
            this.LumpSumProcess.Text = "LumpSum process";
            this.LumpSumProcess.UseVisualStyleBackColor = false;
            this.LumpSumProcess.Click += new System.EventHandler(this.LumpSumProcess_Click);
            // 
            // LumpsumHistory
            // 
            this.LumpsumHistory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LumpsumHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LumpsumHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LumpsumHistory.Location = new System.Drawing.Point(845, 331);
            this.LumpsumHistory.Name = "LumpsumHistory";
            this.LumpsumHistory.Size = new System.Drawing.Size(117, 72);
            this.LumpsumHistory.TabIndex = 2;
            this.LumpsumHistory.Text = "Lumpsum History ";
            this.LumpsumHistory.UseVisualStyleBackColor = false;
            this.LumpsumHistory.Click += new System.EventHandler(this.LumpsumHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valid LumpSum Owners";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(733, 409);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(613, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 72);
            this.button1.TabIndex = 9;
            this.button1.Text = "Payment Slip";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(462, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LumpSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1017, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LumpsumHistory);
            this.Controls.Add(this.LumpSumProcess);
            this.Controls.Add(this.LumpSumGrid);
            this.Name = "LumpSum";
            this.Text = "LumpSum";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LumpSum_FormClosed);
            this.Load += new System.EventHandler(this.LumpSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LumpSumGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LumpSumGrid;
        private System.Windows.Forms.Button LumpSumProcess;
        private System.Windows.Forms.Button LumpsumHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}