using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
namespace PensionScheme
{
    public partial class NotificationReview : Form
    {
        CommonBUO cb = new CommonBUO();
        public NotificationReview()
        {
            InitializeComponent();
            cb.FillDataGridCondition(dataGridView1, "PensionPayment", "Approval",0);
           // NotificationLoad();
        }
        public void NotificationLoad() {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select PaymentID,OwnerID,PaymentValue,PaymentMonth,PaymentYear,PaymentBank,AccountNo,PaymentSubDate,VoucherNo,Type,ApprovedDate from PensionPayment p where Approval='0'", conn);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }
            Refresh();



        }
        private void NotificationReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.PensionPayment' table. You can move, or remove it, as needed.
            //this.pensionPaymentTableAdapter.Fill(this.pensionSchemeAllTables.PensionPayment);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
