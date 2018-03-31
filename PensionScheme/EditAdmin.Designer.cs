namespace PensionScheme
{
    partial class EditAdmin
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
            this.NIC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NIC
            // 
            this.NIC.AutoSize = true;
            this.NIC.Location = new System.Drawing.Point(48, 75);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(74, 13);
            this.NIC.TabIndex = 0;
            this.NIC.Text = "Employee NIC";
            this.NIC.Click += new System.EventHandler(this.NIC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Admin Type";
            // 
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NIC);
            this.Name = "EditAdmin";
            this.Text = "EditAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NIC;
        private System.Windows.Forms.Label label2;
    }
}