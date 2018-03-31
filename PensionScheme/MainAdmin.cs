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
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
            LoadMyDetails();
        }

        private void AdminReview_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Hide();
            a.Show();
        }

        private void MainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                {

                    Application.OpenForms[i].Close();
                }
                else
                {
                    Application.OpenForms[i].Show();
                }
            }
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
            p.Show();
            this.Hide();
        }

        private void ContributionB_Click(object sender, EventArgs e)
        {
            Contribution c = new Contribution();
            c.Show();
            this.Hide();
        }

        private void MemberHB_Click(object sender, EventArgs e)
        {
            MemberAccount mb = new MemberAccount();
            mb.Show();
            this.Hide();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }
        public void LoadMyDetails()
        {
            //MessageBox.Show(Log.LoginName + Log.OperatingEmployee + Log.Type);
            LoginName.Text = Log.LoginName;
            MyID.Text = Log.OperatingEmployee;
            Type.Text = Log.Type;


        }
    }
}
