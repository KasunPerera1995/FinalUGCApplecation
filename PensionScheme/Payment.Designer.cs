namespace PensionScheme
{
    partial class Payment
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
            this.PaymentDetails = new System.Windows.Forms.TabPage();
            this.Refresh = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.Dependent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.OwnerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NoOfNotifications = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notificationP = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.PaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PaymentDetails);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // PaymentDetails
            // 
            this.PaymentDetails.BackColor = System.Drawing.Color.Teal;
            this.PaymentDetails.Controls.Add(this.Refresh);
            this.PaymentDetails.Controls.Add(this.Time);
            this.PaymentDetails.Controls.Add(this.Dependent);
            this.PaymentDetails.Controls.Add(this.button1);
            this.PaymentDetails.Controls.Add(this.button2);
            this.PaymentDetails.Controls.Add(this.listView1);
            this.PaymentDetails.Controls.Add(this.button4);
            this.PaymentDetails.Controls.Add(this.Logout);
            this.PaymentDetails.Location = new System.Drawing.Point(4, 27);
            this.PaymentDetails.Name = "PaymentDetails";
            this.PaymentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.PaymentDetails.Size = new System.Drawing.Size(878, 434);
            this.PaymentDetails.TabIndex = 0;
            this.PaymentDetails.Text = "Payment Details";
            this.PaymentDetails.Click += new System.EventHandler(this.PaymentDetails_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Refresh.Location = new System.Drawing.Point(632, 378);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(95, 50);
            this.Refresh.TabIndex = 15;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Time.Location = new System.Drawing.Point(686, 3);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(41, 18);
            this.Time.TabIndex = 14;
            this.Time.Text = "Time";
            // 
            // Dependent
            // 
            this.Dependent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Dependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dependent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dependent.Location = new System.Drawing.Point(118, 319);
            this.Dependent.Name = "Dependent";
            this.Dependent.Size = new System.Drawing.Size(137, 109);
            this.Dependent.TabIndex = 13;
            this.Dependent.Text = "Dependent Payments";
            this.Dependent.UseVisualStyleBackColor = false;
            this.Dependent.Click += new System.EventHandler(this.Dependent_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(118, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 108);
            this.button1.TabIndex = 12;
            this.button1.Text = "Lumpsum";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(118, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 125);
            this.button2.TabIndex = 6;
            this.button2.Text = "Pension Payment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OwnerID,
            this.NoOfNotifications});
            this.listView1.Location = new System.Drawing.Point(420, 95);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(372, 197);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectNotification);
            // 
            // OwnerID
            // 
            this.OwnerID.Text = "OwnerID";
            this.OwnerID.Width = 116;
            // 
            // NoOfNotifications
            // 
            this.NoOfNotifications.Text = "NoOfNotifications";
            this.NoOfNotifications.Width = 102;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(420, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Notification Review";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout.Location = new System.Drawing.Point(762, 378);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(95, 50);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notificationP
            // 
            this.notificationP.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notificationP.Text = "notifyIcon1";
            this.notificationP.Visible = true;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(913, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Payment_FormClosed);
            this.Load += new System.EventHandler(this.Payment_Load);
            this.tabControl1.ResumeLayout(false);
            this.PaymentDetails.ResumeLayout(false);
            this.PaymentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PaymentDetails;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader OwnerID;
        private System.Windows.Forms.ColumnHeader NoOfNotifications;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Dependent;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.NotifyIcon notificationP;
    }
}