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
    public partial class ContributionEntries : Form
    {
        public ContributionEntries()
        {
            InitializeComponent();
            ContributionComboSelect();
            DataViewSelect();
        }

        public void ContributionComboSelect() {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from ContributionPen", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                comboBox1.DataSource = ds;
                comboBox1.DisplayMember = "SubDate";
                comboBox1.ValueMember = "SubDate";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }


        }

        //public void Contribution
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataViewSelect();

        }

        public void DataViewSelect() {
            try
            {
                if (ShowAll.Checked)
                {
                    MySqlConnection c = new MySqlConnection(@DBStr.connectionString);
                    //conn.Open();
                    MySqlDataAdapter all = new MySqlDataAdapter("select * from ContributionPen", c);
                    DataTable al = new DataTable();
                    all.Fill(al);
                    //conn.Close();
                    ContributionView.DataSource = al;
                    return;


                }

                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                //conn.Open();
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from ContributionPen where SubDate='" + (Convert.ToDateTime(comboBox1.SelectedValue.ToString())).ToString("yyyy-MM-dd") + "'", conn);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                //conn.Close();
                ContributionView.DataSource = dt;
            }
            catch (Exception en)
            {
                MessageBox.Show(en.ToString());
            }


        }

        private void ContributionEntries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.ContributionPen' table. You can move, or remove it, as needed.
           // this.contributionPenTableAdapter.Fill(this.pensionSchemeAllTables.ContributionPen);

        }

        private void ContributionView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit_Contribution ec = new Edit_Contribution();
            ec.lContributionID.Text = this.ContributionView.CurrentRow.Cells[0].Value.ToString();
            ec.tUniversity.Text = this.ContributionView.CurrentRow.Cells[1].Value.ToString();
            ec.tYear.Text = this.ContributionView.CurrentRow.Cells[2].Value.ToString();
            ec.tMonth.Text = this.ContributionView.CurrentRow.Cells[3].Value.ToString();
            ec.tSubDate.Text =(Convert.ToDateTime(this.ContributionView.CurrentRow.Cells[4].Value.ToString())).ToShortDateString();
            ec.tAmount.Text = this.ContributionView.CurrentRow.Cells[5].Value.ToString();
            ec.tReceiptNo.Text = this.ContributionView.CurrentRow.Cells[6].Value.ToString();
            ec.tOwnerID.Text = this.ContributionView.CurrentRow.Cells[7].Value.ToString();
            ec.Show();
            }

        private void ContributionView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            ContributionView.Refresh();
        }

        private void ShowAll_CheckStateChanged(object sender, EventArgs e)
        {
            DataViewSelect();
        }
    }
}
