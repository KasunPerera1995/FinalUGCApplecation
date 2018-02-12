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
    public partial class LumpSumHistory : Form
    {
        public void LumpSumSelection() {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from PensionPayment where Type='3'", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                LumpSumSelect.DataSource = ds;
                LumpSumSelect.DisplayMember = "PaymentSubDate";
                LumpSumSelect.ValueMember = "PaymentSubDate";


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }



        }
        public LumpSumHistory()
        {
            InitializeComponent();
            LumpSumSelection();
            
            LumpSumHistoryView();
        }
        
        public void LumpSumHistoryView()
        {

            try
            {
                
                if (ShowAll.Checked)
                {
                    MySqlConnection c = new MySqlConnection(@DBStr.connectionString);
                    //conn.Open();
                    MySqlDataAdapter all = new MySqlDataAdapter("select * from PensionPayment where Type='3'", c);
                    DataTable al = new DataTable();
                    all.Fill(al);
                    //conn.Close();
                    LumpSumView.DataSource = al;
                    return;


                }

                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                //conn.Open();
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from PensionPayment where PaymentSubDate='" + (Convert.ToDateTime(LumpSumSelect.SelectedValue.ToString())).ToString("yyyy-MM-dd") + "' AND Type='3'", conn);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                //conn.Close();
                LumpSumView.DataSource = dt;
            }
            catch (Exception en)
            {
                
            //    MessageBox.Show(en.ToString());
            }





        }

        private void LumpSumHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.PensionPayment' table. You can move, or remove it, as needed.
           // this.pensionPaymentTableAdapter.Fill(this.pensionSchemeAllTables.PensionPayment);
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.LumpSumPayment' table. You can move, or remove it, as needed.
            //this.lumpSumPaymentTableAdapter.Fill(this.pensionSchemeAllTables.LumpSumPayment);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LumpSumHistoryView();
        }

        private void PeriodSelect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LumpSumView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAll_CheckStateChanged(object sender, EventArgs e)
        {
            LumpSumHistoryView();
        }

        private void ShowAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LumpSum p7 = new LumpSum();
            p7.Show();
        }

        private void LumpSumHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            try {

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)

                {

                    if ((Application.OpenForms[i].Name == "Payment"))
                    {

                        Application.OpenForms[i].Show();
                    }            

            }
        }

            catch (Exception ee) {
                    MessageBox.Show(ee.ToString());
                }
}

        private void LumpSumView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
