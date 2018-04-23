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
    public partial class YearEndConBalancePro : Form
    {
        ContributionBUO cb = new ContributionBUO();
        public YearEndConBalancePro()
        {
            InitializeComponent();
        }

        private void CalSub_Click(object sender, EventArgs e)
        {
            if (DateTime.Today.Month.Equals(12))
            {
                if (cb.CalSubBal(Convert.ToInt32(tYear.Text), Convert.ToDouble(tOBR.Text), Convert.ToDouble(tYAR.Text)))
                    MessageBox.Show("Update Successful");
                else
                    MessageBox.Show("Error");
            }
            else
                MessageBox.Show("It is not December");
        }

        private void YearEndBal_Click(object sender, EventArgs e)
        {
            Balances b = new Balances();
            this.Hide();
            b.Show();
        }
    }
}
