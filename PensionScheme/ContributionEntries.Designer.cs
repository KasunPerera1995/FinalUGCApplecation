namespace PensionScheme
{
    partial class ContributionEntries
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
            this.ContributionView = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ShowAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ContributionView)).BeginInit();
            this.SuspendLayout();
            // 
            // ContributionView
            // 
            this.ContributionView.AllowUserToAddRows = false;
            this.ContributionView.AllowUserToDeleteRows = false;
            this.ContributionView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContributionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContributionView.Location = new System.Drawing.Point(12, 12);
            this.ContributionView.Name = "ContributionView";
            this.ContributionView.ReadOnly = true;
            this.ContributionView.Size = new System.Drawing.Size(442, 466);
            this.ContributionView.TabIndex = 0;
            this.ContributionView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContributionView_CellContentDoubleClick);
            this.ContributionView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContributionView_CellDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "SubDate";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "SubDate";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ShowAll
            // 
            this.ShowAll.AutoSize = true;
            this.ShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowAll.Location = new System.Drawing.Point(535, 241);
            this.ShowAll.Name = "ShowAll";
            this.ShowAll.Size = new System.Drawing.Size(84, 22);
            this.ShowAll.TabIndex = 2;
            this.ShowAll.Text = "Show All";
            this.ShowAll.UseVisualStyleBackColor = true;
            this.ShowAll.CheckStateChanged += new System.EventHandler(this.ShowAll_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(592, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContributionEntries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(682, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowAll);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ContributionView);
            this.Name = "ContributionEntries";
            this.Text = "ContributionEntries";
            this.Load += new System.EventHandler(this.ContributionEntries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContributionView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContributionView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox ShowAll;
        private System.Windows.Forms.Button button1;
    }
}