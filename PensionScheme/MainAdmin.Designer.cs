namespace PensionScheme
{
    partial class MainAdmin
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
            this.AdminReview = new System.Windows.Forms.Button();
            this.PaymentB = new System.Windows.Forms.Button();
            this.ContributionB = new System.Windows.Forms.Button();
            this.MemberHB = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Type = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.MyID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LoginName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Admin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminReview
            // 
            this.AdminReview.BackColor = System.Drawing.Color.Teal;
            this.AdminReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminReview.Location = new System.Drawing.Point(30, 27);
            this.AdminReview.Name = "AdminReview";
            this.AdminReview.Size = new System.Drawing.Size(190, 55);
            this.AdminReview.TabIndex = 0;
            this.AdminReview.Text = "Admin Review";
            this.AdminReview.UseVisualStyleBackColor = false;
            this.AdminReview.Click += new System.EventHandler(this.AdminReview_Click);
            // 
            // PaymentB
            // 
            this.PaymentB.BackColor = System.Drawing.Color.Teal;
            this.PaymentB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PaymentB.Location = new System.Drawing.Point(30, 231);
            this.PaymentB.Name = "PaymentB";
            this.PaymentB.Size = new System.Drawing.Size(190, 45);
            this.PaymentB.TabIndex = 1;
            this.PaymentB.Text = "Payment";
            this.PaymentB.UseVisualStyleBackColor = false;
            this.PaymentB.Click += new System.EventHandler(this.Payment_Click);
            // 
            // ContributionB
            // 
            this.ContributionB.BackColor = System.Drawing.Color.Teal;
            this.ContributionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContributionB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContributionB.Location = new System.Drawing.Point(30, 165);
            this.ContributionB.Name = "ContributionB";
            this.ContributionB.Size = new System.Drawing.Size(190, 43);
            this.ContributionB.TabIndex = 2;
            this.ContributionB.Text = "Contribution";
            this.ContributionB.UseVisualStyleBackColor = false;
            this.ContributionB.Click += new System.EventHandler(this.ContributionB_Click);
            // 
            // MemberHB
            // 
            this.MemberHB.BackColor = System.Drawing.Color.Teal;
            this.MemberHB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberHB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MemberHB.Location = new System.Drawing.Point(30, 97);
            this.MemberHB.Name = "MemberHB";
            this.MemberHB.Size = new System.Drawing.Size(190, 51);
            this.MemberHB.TabIndex = 3;
            this.MemberHB.Text = "Member Handling";
            this.MemberHB.UseVisualStyleBackColor = false;
            this.MemberHB.Click += new System.EventHandler(this.MemberHB_Click);
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.tabPage1);
            this.Admin.Controls.Add(this.tabPage5);
            this.Admin.Location = new System.Drawing.Point(34, 12);
            this.Admin.Name = "Admin";
            this.Admin.SelectedIndex = 0;
            this.Admin.Size = new System.Drawing.Size(373, 342);
            this.Admin.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.AdminReview);
            this.tabPage1.Controls.Add(this.MemberHB);
            this.tabPage1.Controls.Add(this.PaymentB);
            this.tabPage1.Controls.Add(this.ContributionB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Controls";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage5.Controls.Add(this.Type);
            this.tabPage5.Controls.Add(this.ChangePass);
            this.tabPage5.Controls.Add(this.label26);
            this.tabPage5.Controls.Add(this.label24);
            this.tabPage5.Controls.Add(this.MyID);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.LoginName);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(365, 316);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "My Details";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Type.Location = new System.Drawing.Point(281, 199);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(35, 13);
            this.Type.TabIndex = 8;
            this.Type.Text = "####";
            // 
            // ChangePass
            // 
            this.ChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePass.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ChangePass.Location = new System.Drawing.Point(140, 280);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(163, 29);
            this.ChangePass.TabIndex = 7;
            this.ChangePass.Text = "Change Password";
            this.ChangePass.UseVisualStyleBackColor = true;
            this.ChangePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(107, 53);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(92, 20);
            this.label26.TabIndex = 6;
            this.label26.Text = "My Details";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label24.Location = new System.Drawing.Point(108, 199);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 13);
            this.label24.TabIndex = 4;
            this.label24.Text = "Type";
            // 
            // MyID
            // 
            this.MyID.AutoSize = true;
            this.MyID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MyID.Location = new System.Drawing.Point(281, 152);
            this.MyID.Name = "MyID";
            this.MyID.Size = new System.Drawing.Size(35, 13);
            this.MyID.TabIndex = 3;
            this.MyID.Text = "####";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label22.Location = new System.Drawing.Point(108, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "My ID";
            // 
            // LoginName
            // 
            this.LoginName.AutoSize = true;
            this.LoginName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginName.Location = new System.Drawing.Point(281, 116);
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(35, 13);
            this.LoginName.TabIndex = 1;
            this.LoginName.Text = "####";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(108, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Login Name";
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(419, 366);
            this.Controls.Add(this.Admin);
            this.Name = "MainAdmin";
            this.Text = "MainAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAdmin_FormClosed);
            this.Admin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminReview;
        private System.Windows.Forms.Button PaymentB;
        private System.Windows.Forms.Button ContributionB;
        private System.Windows.Forms.Button MemberHB;
        private System.Windows.Forms.TabControl Admin;
        private System.Windows.Forms.TabPage tabPage1;
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