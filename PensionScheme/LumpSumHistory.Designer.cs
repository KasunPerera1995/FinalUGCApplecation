namespace PensionScheme
{
    partial class LumpSumHistory
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
            this.LumpSumView = new System.Windows.Forms.DataGridView();
            this.LumpSumSelect = new System.Windows.Forms.ComboBox();
            this.ShowAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LumpSumView)).BeginInit();
            this.SuspendLayout();
            // 
            // LumpSumView
            // 
            this.LumpSumView.AllowUserToAddRows = false;
            this.LumpSumView.AllowUserToDeleteRows = false;
            this.LumpSumView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LumpSumView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LumpSumView.Location = new System.Drawing.Point(27, 63);
            this.LumpSumView.Name = "LumpSumView";
            this.LumpSumView.ReadOnly = true;
            this.LumpSumView.Size = new System.Drawing.Size(422, 302);
            this.LumpSumView.TabIndex = 0;
            this.LumpSumView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LumpSumView_CellContentClick_1);
            // 
            // LumpSumSelect
            // 
            this.LumpSumSelect.FormattingEnabled = true;
            this.LumpSumSelect.Location = new System.Drawing.Point(455, 63);
            this.LumpSumSelect.Name = "LumpSumSelect";
            this.LumpSumSelect.Size = new System.Drawing.Size(157, 21);
            this.LumpSumSelect.TabIndex = 1;
            this.LumpSumSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ShowAll
            // 
            this.ShowAll.AutoSize = true;
            this.ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowAll.Location = new System.Drawing.Point(466, 108);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(84, 22);
            this.ShowAll.TabIndex = 2;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.CheckedChanged += new System.EventHandler(this.ShowAll_CheckedChanged);
            this.ShowAll.CheckStateChanged += new System.EventHandler(this.ShowAll_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(490, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LumpSumHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(624, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.LumpSumSelect);
            this.Controls.Add(this.LumpSumView);
            this.Name = "LumpSumHistory";
            this.Text = "LumpSum History And Payment Slip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LumpSumHistory_FormClosed);
            this.Load += new System.EventHandler(this.LumpSumHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LumpSumView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LumpSumView;
        private System.Windows.Forms.ComboBox LumpSumSelect;
        private System.Windows.Forms.CheckBox ShowAll;
        private System.Windows.Forms.Button button1;
    }
}