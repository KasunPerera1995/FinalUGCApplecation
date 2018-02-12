namespace PensionScheme
{
    partial class ContributionHistory
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
            this.ContriData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TEmpID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ContriData)).BeginInit();
            this.SuspendLayout();
            // 
            // ContriData
            // 
            this.ContriData.AllowUserToAddRows = false;
            this.ContriData.AllowUserToDeleteRows = false;
            this.ContriData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContriData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContriData.Location = new System.Drawing.Point(23, 35);
            this.ContriData.Name = "ContriData";
            this.ContriData.ReadOnly = true;
            this.ContriData.Size = new System.Drawing.Size(542, 397);
            this.ContriData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmployeeID";
            // 
            // TEmpID
            // 
            this.TEmpID.AutoSize = true;
            this.TEmpID.Location = new System.Drawing.Point(104, 9);
            this.TEmpID.Name = "TEmpID";
            this.TEmpID.Size = new System.Drawing.Size(42, 13);
            this.TEmpID.TabIndex = 2;
            this.TEmpID.Text = "#####";
            // 
            // ContributionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(674, 471);
            this.Controls.Add(this.TEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContriData);
            this.Name = "ContributionHistory";
            this.Text = "ContributionHistory";
            this.Load += new System.EventHandler(this.ContributionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContriData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContriData;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label TEmpID;
    }
}