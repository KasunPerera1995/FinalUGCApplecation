using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PensionScheme
{
    public partial class Edit_Contribution : Form
    {
        CommonBUO com = new CommonBUO();
        ContributionBUO cb = new ContributionBUO();
        public Edit_Contribution(string u)
        {
            InitializeComponent();
            com.FillComboBox(tUniversity, "University", "UniversityName", "UniversityID");
            com.FillComboBox(tOwnerID, "Employee", "ID", "ID");
            tUniversity.SelectedValue = u;
        }
        

        public void UpdateContribution() {

            try
            {

                ContributionVO cv = new ContributionVO(Convert.ToInt32(lContributionID.Text),Convert.ToInt32(tUniversity.SelectedValue.ToString()),Convert.ToInt32(tYear.Text.ToString()),Convert.ToInt32(tMonth.Text.ToString()),Convert.ToDateTime(tSubDate.Text.ToString()),Convert.ToDouble(tAmount.Text.ToString()),tReceiptNo.Text.ToString(), tOwnerID.SelectedValue.ToString());
                if (cb.EditContribution(cv))
                    MessageBox.Show("Update Successful");
                else
                    MessageBox.Show("Update Faailed");
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        private void Update_Click(object sender, EventArgs e)
        {
            UpdateContribution();
            Refresh();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            cb.DeleteContribution(lContributionID.Text);
            this.Close();
        }

        private void tUniversity_Validated(object sender, EventArgs e)
        {

        }
    }
}
