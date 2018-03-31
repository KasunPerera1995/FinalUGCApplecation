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
    public partial class InsertContribution : Form
    {
        ContributionBUO cb = new ContributionBUO();
        CommonBUO com = new CommonBUO();
        public InsertContribution()
        {
            InitializeComponent();
            com.FillComboBox(tUniversity, "University", "UniversityName", "UniversityID");
            com.FillComboBox(tOwnerID, "Employee", "ID", "ID");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (tPeriod.Value.Year > DateTime.Now.Year || (tPeriod.Value.Month > DateTime.Now.Month && tPeriod.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            ContributionVO cv = new ContributionVO(Convert.ToInt32(tContributionID.Text), Convert.ToInt32(tUniversity.SelectedValue.ToString()), Convert.ToInt32(tPeriod.Value.Year.ToString()), Convert.ToInt32(tPeriod.Value.Month.ToString()), tSubDate.Value, Convert.ToDouble(tAmount.Text), tReceiptNo.Text, tOwnerID.SelectedValue.ToString());

            if (cb.InsertContribution(cv))
            {
                
                    MessageBox.Show("Insert Successful");
                tContributionID.Clear();
                tAmount.Clear();
                tReceiptNo.Clear();

            }
            else
                MessageBox.Show("Record Failed");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tSubDate_Validated(object sender, EventArgs e)
        {

        }

        private void tSubDate_Validating(object sender, CancelEventArgs e)
        {
            if (tSubDate.Value > DateTime.Now)
            {
                MessageBox.Show("Do not enter future periods");
                e.Cancel = true;
            }
        }

        private void Period(object sender, EventArgs e)
        {

        }

        private void tPeriod_Validating(object sender, CancelEventArgs e)
        {
            if (tPeriod.Value > DateTime.Now)
            {
                MessageBox.Show("Do not enter future periods");
                e.Cancel = true;
            }
        }
    }
}
