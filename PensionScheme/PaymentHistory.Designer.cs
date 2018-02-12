namespace PensionScheme
{
    partial class PaymentHistory
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
            this.PaymentData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TEmpID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentData)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentData
            // 
            this.PaymentData.AllowUserToAddRows = false;
            this.PaymentData.AllowUserToDeleteRows = false;
            this.PaymentData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaymentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentData.Location = new System.Drawing.Point(12, 56);
            this.PaymentData.Name = "PaymentData";
            this.PaymentData.ReadOnly = true;
            this.PaymentData.Size = new System.Drawing.Size(590, 365);
            this.PaymentData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmployeeID";
            // 
            // TEmpID
            // 
            this.TEmpID.AutoSize = true;
            this.TEmpID.Location = new System.Drawing.Point(134, 28);
            this.TEmpID.Name = "TEmpID";
            this.TEmpID.Size = new System.Drawing.Size(35, 13);
            this.TEmpID.TabIndex = 2;
            this.TEmpID.Text = "####";
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(709, 459);
            this.Controls.Add(this.TEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentData);
            this.Name = "PaymentHistory";
            this.Text = "PaymentHistory";
            this.Load += new System.EventHandler(this.PaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PaymentData;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label TEmpID;
    }
}