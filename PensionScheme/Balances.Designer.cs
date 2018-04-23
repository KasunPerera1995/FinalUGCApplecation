namespace PensionScheme
{
    partial class Balances
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
            this.BalancesView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BalancesView)).BeginInit();
            this.SuspendLayout();
            // 
            // BalancesView
            // 
            this.BalancesView.AllowUserToAddRows = false;
            this.BalancesView.AllowUserToDeleteRows = false;
            this.BalancesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalancesView.Location = new System.Drawing.Point(33, 46);
            this.BalancesView.Name = "BalancesView";
            this.BalancesView.ReadOnly = true;
            this.BalancesView.Size = new System.Drawing.Size(528, 408);
            this.BalancesView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balances";
            // 
            // Balances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BalancesView);
            this.Name = "Balances";
            this.Text = "Year End Balances";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Balances_FormClosing);
            this.Load += new System.EventHandler(this.Balances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BalancesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BalancesView;
        private System.Windows.Forms.Label label1;
    }
}