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
            this.InsertC = new System.Windows.Forms.Button();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Type = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.MyID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LoginName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Remain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage1.Controls.Add(this.InsertC);
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
            // InsertC
            // 
            this.InsertC.BackColor = System.Drawing.Color.DarkSlateGray;
            this.InsertC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InsertC.Location = new System.Drawing.Point(878, 257);
            this.InsertC.Name = "InsertC";
            this.InsertC.Size = new System.Drawing.Size(152, 54);
            this.InsertC.TabIndex = 25;
            this.InsertC.Text = "Insert Contribution";
            this.InsertC.UseVisualStyleBackColor = false;
            this.InsertC.Click += new System.EventHandler(this.InsertC_Click);
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
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Teal;
            this.tabPage5.Controls.Add(this.Type);
            this.tabPage5.Controls.Add(this.ChangePass);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.MyID);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.LoginName);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1053, 572);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "My Details";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.Type.Location = new System.Drawing.Point(281, 199);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(40, 18);
            this.Type.TabIndex = 8;
            this.Type.Text = "####";
            // 
            // ChangePass
            // 
            this.ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ChangePass.Location = new System.Drawing.Point(140, 280);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(163, 29);
            this.ChangePass.TabIndex = 7;
            this.ChangePass.Text = "Change Password";
            this.ChangePass.UseVisualStyleBackColor = true;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click_1);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label26.Location = new System.Drawing.Point(108, 61);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 20);
            this.label26.TabIndex = 6;
            this.label26.Text = "My Details";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label24.Location = new System.Drawing.Point(108, 199);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 18);
            this.label24.TabIndex = 4;
            this.label24.Text = "Type";
            // 
            // MyID
            // 
            this.MyID.AutoSize = true;
            this.MyID.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.MyID.Location = new System.Drawing.Point(281, 152);
            this.MyID.Name = "MyID";
            this.MyID.Size = new System.Drawing.Size(40, 18);
            this.MyID.TabIndex = 3;
            this.MyID.Text = "####";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label22.Location = new System.Drawing.Point(108, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 18);
            this.label22.TabIndex = 2;
            this.label22.Text = "My ID";
            // 
            // LoginName
            // 
            this.LoginName.AutoSize = true;
            this.LoginName.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.LoginName.Location = new System.Drawing.Point(281, 116);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(40, 18);
            this.LoginName.TabIndex = 1;
            this.LoginName.Text = "####";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label11.Location = new System.Drawing.Point(108, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Login Name";
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.Button InsertC;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Button ChangePass;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label MyID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LoginName;
        private System.Windows.Forms.Label label11;
    }
}