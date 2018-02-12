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
using MySql.Data.MySqlClient;

namespace PensionScheme
{
    public partial class ContributionHistory : Form
    {
        String MemID;
        CommonBUO com = new CommonBUO();
        public ContributionHistory(String tMemID)
        {
            InitializeComponent();
            this.MemID = tMemID;
            TEmpID.Text = this.MemID;
            com.FillDataGridCondition(ContriData, "ContributionPen", "OwnerID",MemID);
            //FillCHistory();
            
        }

        

        

        private void ContributionHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.ContributionPen' table. You can move, or remove it, as needed.
            //this.contributionPenTableAdapter.Fill(this.pensionSchemeAllTables.ContributionPen);

        }

       

        private void memIDToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member P10 = new Member();
            P10.Show();
        }
    }
}
