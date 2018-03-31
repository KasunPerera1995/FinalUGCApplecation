using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PensionScheme
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        MemberBUO mem= new MemberBUO();
        private void Submit_Click(object sender, EventArgs e)
        {
            if (mem.ChangeAdminPassword(Log.LoginName,NewPass.Text, Oldpass.Text)) {
                MessageBox.Show("Password Changed");
            }
            else {
                MessageBox.Show("Error");

                    }
            this.Close();
        }
    }
}
