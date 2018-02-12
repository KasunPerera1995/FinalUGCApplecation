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
        public Edit_Contribution()
        {
            InitializeComponent();
        }

        public void UpdateContribution() {

            try
            {
                SqlConnection conn = new SqlConnection(@DBStr.connectionString);
                conn.Open();
                SqlCommand sql = new SqlCommand("Update ContributionPen set University='" + tUniversity.Text.ToString() + "',Year='" + tYear.Text.ToString() + "',Month='" + tMonth.Text.ToString() + "',SubDate='" + tSubDate.Text.ToString() + "',Amount='" + tAmount.Text.ToString() + "',ReceiptNo='" + tReceiptNo.Text.ToString() + "',OwnerID='" + tOwnerID.Text.ToString() + "' where ContributionID='" + lContributionID.Text.ToString() + "'", conn);
                sql.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Update Successful");
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
    }
}
