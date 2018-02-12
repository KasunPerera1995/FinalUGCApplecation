namespace PensionScheme
{
    partial class Contribution
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Time = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.GenExcel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Selected = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.University = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Month = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remain = new System.Windows.Forms.DataGridView();
            this.ProcessView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Remain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1061, 603);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.Time);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.GenExcel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.Selected);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.Remain);
            this.tabPage1.Controls.Add(this.ProcessView);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1053, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contribution Processing";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Time.Location = new System.Drawing.Point(860, 17);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(41, 18);
            this.Time.TabIndex = 24;
            this.Time.Text = "Time";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(516, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // GenExcel
            // 
            this.GenExcel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.GenExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenExcel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenExcel.Location = new System.Drawing.Point(878, 197);
            this.GenExcel.Name = "GenExcel";
            this.GenExcel.Size = new System.Drawing.Size(152, 54);
            this.GenExcel.TabIndex = 21;
            this.GenExcel.Text = "Generate Excel Sheet";
            this.GenExcel.UseVisualStyleBackColor = false;
            this.GenExcel.Click += new System.EventHandler(this.GenExcel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(396, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Available Validated Contributions";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(841, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 56);
            this.button2.TabIndex = 18;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Selected
            // 
            this.Selected.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Selected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Selected.Location = new System.Drawing.Point(399, 257);
            this.Selected.Name = "Selected";
            this.Selected.Size = new System.Drawing.Size(94, 54);
            this.Selected.TabIndex = 17;
            this.Selected.Text = "Process Selected";
            this.Selected.UseVisualStyleBackColor = false;
            this.Selected.Click += new System.EventHandler(this.Selected_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.University,
            this.Year,
            this.Month,
            this.Amount});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(399, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 197);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // University
            // 
            this.University.Text = "University";
            // 
            // Year
            // 
            this.Year.Text = "Year";
            // 
            // Month
            // 
            this.Month.Text = "Month";
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            // 
            // Remain
            // 
            this.Remain.AllowUserToAddRows = false;
            this.Remain.AllowUserToDeleteRows = false;
            this.Remain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Remain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Remain.Location = new System.Drawing.Point(-4, 0);
            this.Remain.Name = "Remain";
            this.Remain.ReadOnly = true;
            this.Remain.Size = new System.Drawing.Size(365, 490);
            this.Remain.TabIndex = 15;
            this.Remain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Remain_CellContentClick);
            // 
            // ProcessView
            // 
            this.ProcessView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProcessView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessView.Location = new System.Drawing.Point(399, 317);
            this.ProcessView.Name = "ProcessView";
            this.ProcessView.Size = new System.Drawing.Size(388, 174);
            this.ProcessView.TabIndex = 10;
            this.ProcessView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProcessView_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Remaining Contributions upto today";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(878, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 63);
            this.button6.TabIndex = 8;
            this.button6.Text = "Process Details";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(878, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 64);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cheque Entry";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(922, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Contribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1095, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "Contribution";
            this.Text = "Contribution";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Contribution_FormClosed);
            this.Load += new System.EventHandler(this.Contribution_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Remain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProcessView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView Remain;
        private System.Windows.Forms.ColumnHeader University;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Month;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Selected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenExcel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
    }
}