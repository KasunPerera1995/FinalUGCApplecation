namespace PensionScheme
{
    partial class Admin
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
            this.AdminView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NIC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tNIC = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tLoginName = new System.Windows.Forms.TextBox();
            this.NewEntry = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminView)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminView
            // 
            this.AdminView.AllowUserToAddRows = false;
            this.AdminView.AllowUserToDeleteRows = false;
            this.AdminView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AdminView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminView.Location = new System.Drawing.Point(3, 61);
            this.AdminView.Name = "AdminView";
            this.AdminView.ReadOnly = true;
            this.AdminView.Size = new System.Drawing.Size(347, 302);
            this.AdminView.TabIndex = 0;
            this.AdminView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminView_CellClick);
            this.AdminView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminView_CellContentClick);
            this.AdminView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            this.AdminView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin";
            // 
            // NIC
            // 
            this.NIC.AutoSize = true;
            this.NIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC.ForeColor = System.Drawing.SystemColors.Control;
            this.NIC.Location = new System.Drawing.Point(353, 104);
            this.NIC.Name = "NIC";
            this.NIC.Size = new System.Drawing.Size(78, 18);
            this.NIC.TabIndex = 2;
            this.NIC.Text = "Admin NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(353, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Admin Type";
            // 
            // tNIC
            // 
            this.tNIC.Location = new System.Drawing.Point(450, 105);
            this.tNIC.Name = "tNIC";
            this.tNIC.Size = new System.Drawing.Size(152, 20);
            this.tNIC.TabIndex = 4;
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(450, 131);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(152, 21);
            this.Type.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(437, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(514, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(353, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Login Name";
            // 
            // tLoginName
            // 
            this.tLoginName.Location = new System.Drawing.Point(450, 157);
            this.tLoginName.Name = "tLoginName";
            this.tLoginName.Size = new System.Drawing.Size(152, 20);
            this.tLoginName.TabIndex = 9;
            // 
            // NewEntry
            // 
            this.NewEntry.BackColor = System.Drawing.Color.DarkSlateGray;
            this.NewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEntry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewEntry.Location = new System.Drawing.Point(437, 317);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(152, 46);
            this.NewEntry.TabIndex = 10;
            this.NewEntry.Text = "Save as New Entry";
            this.NewEntry.UseVisualStyleBackColor = false;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(356, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ID.Location = new System.Drawing.Point(447, 74);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(40, 18);
            this.ID.TabIndex = 12;
            this.ID.Text = "####";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Back.Location = new System.Drawing.Point(437, 369);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 52);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(679, 440);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewEntry);
            this.Controls.Add(this.tLoginName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.tNIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminView);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AdminView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNIC;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLoginName;
        private System.Windows.Forms.Button NewEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Back;
    }
}