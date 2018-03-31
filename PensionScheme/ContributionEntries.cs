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
        CommonBUO cb = new CommonBUO();
        public ContributionEntries()
        {
            InitializeComponent();
            cb.FillComboBox(comboBox1, "ContributionPen", "SubDate", "SubDate");
           // ContributionComboSelect();
            DataViewSelect();
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
                    cb.FillDataGrid(ContributionView, "ContributionPen");
                    return;


                }
                cb.FillDataGridCondition(ContributionView,"ContributionPen", "SubDate",(Convert.ToDateTime(comboBox1.SelectedValue.ToString())));

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
            string u=this.ContributionView.CurrentRow.Cells[1].Value.ToString();
            Edit_Contribution ec = new Edit_Contribution(u);
            ec.lContributionID.Text = this.ContributionView.CurrentRow.Cells[0].Value.ToString();
            //ec.tUniversity.SelectedValue = Convert.ToInt32(this.ContributionView.CurrentRow.Cells[1].Value.ToString());
            ec.tYear.Text = this.ContributionView.CurrentRow.Cells[2].Value.ToString();
            ec.tMonth.Text = this.ContributionView.CurrentRow.Cells[3].Value.ToString();
            ec.tSubDate.Text =(Convert.ToDateTime(this.ContributionView.CurrentRow.Cells[4].Value.ToString())).ToShortDateString();
            ec.tAmount.Text = this.ContributionView.CurrentRow.Cells[5].Value.ToString();
            ec.tReceiptNo.Text = this.ContributionView.CurrentRow.Cells[6].Value.ToString();
            ec.tOwnerID.SelectedValue = this.ContributionView.CurrentRow.Cells[7].Value.ToString();
            ec.Show();
            }

        private void ContributionView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string u = this.ContributionView.CurrentRow.Cells[1].Value.ToString();
            Edit_Contribution ec = new Edit_Contribution(u);
            ec.lContributionID.Text = this.ContributionView.CurrentRow.Cells[0].Value.ToString();
            //ec.tUniversity.Text = this.ContributionView.CurrentRow.Cells[1].Value.ToString();
            ec.tYear.Text = this.ContributionView.CurrentRow.Cells[2].Value.ToString();
            ec.tMonth.Text = this.ContributionView.CurrentRow.Cells[3].Value.ToString();
            ec.tSubDate.Text = (Convert.ToDateTime(this.ContributionView.CurrentRow.Cells[4].Value.ToString())).ToShortDateString();
            ec.tAmount.Text = this.ContributionView.CurrentRow.Cells[5].Value.ToString();
            ec.tReceiptNo.Text = this.ContributionView.CurrentRow.Cells[6].Value.ToString();
            ec.tOwnerID.Text = this.ContributionView.CurrentRow.Cells[7].Value.ToString();
            ec.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataViewSelect();
            Refresh();
            ContributionView.Refresh();
        }

        private void ShowAll_CheckStateChanged(object sender, EventArgs e)
        {
            DataViewSelect();
        }
    }
}
