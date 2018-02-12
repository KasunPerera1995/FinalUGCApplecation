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
    public partial class PaymentHistory : Form
    {
        string MemID;
        CommonBUO com = new CommonBUO();
        public PaymentHistory(String tMemID)
        {
            InitializeComponent();
            this.MemID = tMemID;
            TEmpID.Text = this.MemID;
            com.FillDataGridCondition(PaymentData, "PensionPayment", "OwnerID", MemID);
 
        }


        private void PaymentHistory_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            this.Hide();
            Member p11 = new Member();
            p11.Show();
        }
    }
}
