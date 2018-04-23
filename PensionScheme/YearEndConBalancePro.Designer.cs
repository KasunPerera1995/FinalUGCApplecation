namespace PensionScheme
{
    partial class YearEndConBalancePro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tYear = new System.Windows.Forms.TextBox();
            this.tOBR = new System.Windows.Forms.TextBox();
            this.tYAR = new System.Windows.Forms.TextBox();
            this.CalSub = new System.Windows.Forms.Button();
            this.YearEndBal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opening Balance Interest Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year Addition Interest Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Year";
            // 
            // tYear
            // 
            this.tYear.Location = new System.Drawing.Point(305, 103);
            this.tYear.Name = "tYear";
            this.tYear.Size = new System.Drawing.Size(100, 20);
            this.tYear.TabIndex = 7;
            // 
            // tOBR
            // 
            this.tOBR.Location = new System.Drawing.Point(305, 149);
            this.tOBR.Name = "tOBR";
            this.tOBR.Size = new System.Drawing.Size(100, 20);
            this.tOBR.TabIndex = 9;
            // 
            // tYAR
            // 
            this.tYAR.Location = new System.Drawing.Point(305, 209);
            this.tYAR.Name = "tYAR";
            this.tYAR.Size = new System.Drawing.Size(100, 20);
            this.tYAR.TabIndex = 10;
            // 
            // CalSub
            // 
            this.CalSub.Location = new System.Drawing.Point(255, 334);
            this.CalSub.Name = "CalSub";
            this.CalSub.Size = new System.Drawing.Size(150, 23);
            this.CalSub.TabIndex = 12;
            this.CalSub.Text = "Calculate and Submit";
            this.CalSub.UseVisualStyleBackColor = true;
            this.CalSub.Click += new System.EventHandler(this.CalSub_Click);
            // 
            // YearEndBal
            // 
            this.YearEndBal.Location = new System.Drawing.Point(60, 334);
            this.YearEndBal.Name = "YearEndBal";
            this.YearEndBal.Size = new System.Drawing.Size(163, 23);
            this.YearEndBal.TabIndex = 13;
            this.YearEndBal.Text = "Year End Balances";
            this.YearEndBal.UseVisualStyleBackColor = true;
            this.YearEndBal.Click += new System.EventHandler(this.YearEndBal_Click);
            // 
            // YearEndConBalancePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 369);
            this.Controls.Add(this.YearEndBal);
            this.Controls.Add(this.CalSub);
            this.Controls.Add(this.tYAR);
            this.Controls.Add(this.tOBR);
            this.Controls.Add(this.tYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "YearEndConBalancePro";
            this.Text = "Total Contribution Process";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tYear;
        private System.Windows.Forms.TextBox tOBR;
        private System.Windows.Forms.TextBox tYAR;
        private System.Windows.Forms.Button CalSub;
        private System.Windows.Forms.Button YearEndBal;
    }
}