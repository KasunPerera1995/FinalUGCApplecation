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
    public partial class DependentPayments : Form
    {
        public DependentPayments()
        {
            InitializeComponent();
            PeriodSelect.Value = DateTime.Today;
            ViewDependents();
        }

        public void Insert(DataTable dt)
        {

            int length = dt.Rows.Count;

            //  MessageBox.Show(length.ToString());

            //CalVoucherNo();

            MessageBox.Show("Start Process");
            MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
            // MessageBox.Show("Conneted");
            MySqlCommand sql;

            for (int n = 0; n < length; n++)
            {
                conn.Open();


                //MessageBox.Show(dt.Rows[n][7].ToString());
                sql = new MySqlCommand("insert into DependentPaymnts values('" + dt.Rows[n][6].ToString() + "','" + dt.Rows[n][0].ToString() + "','" + dt.Rows[n][7].ToString() + "','" + PeriodSelect.Value.Year.ToString() + "','" + PeriodSelect.Value.Month.ToString() + "','" + dt.Rows[n][8].ToString() + "','" + dt.Rows[n][2].ToString() + "','" + dt.Rows[n][3].ToString() + "')", conn);

                //sql.ExecuteNonQuery();

                MySqlDataReader reader;
                reader = sql.ExecuteReader();
                // MessageBox.Show("Sql" + n.ToString());
                while (reader.Read())
                {
                }

                conn.Close();
                //MessageBox.Show(n.ToString());
            }

            MessageBox.Show("Sucessfull");




        }
        public void ViewDependents()
        {

            try
            {
                MySqlConnection c1 = new MySqlConnection(@DBStr.connectionString);
                DataTable dt = new DataTable();

                MySqlDataAdapter sa = new MySqlDataAdapter("select ID,Pension,Bank,PaymentActNo,Type,DependentName,DependentID,DependentType from Employee,Dependent where Type='2' AND SystemValidity='0' AND DependentStatus<3 AND RelatedEmployeeID=ID", c1);
                sa.Fill(dt);
                DependentView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }



        }
        public void CalculateAndSubmit()
        {
           
            if (PeriodSelect.Value.Year>DateTime.Now.Year||(PeriodSelect.Value.Month>DateTime.Now.Month && PeriodSelect.Value.Year==DateTime.Now.Year)) {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            try
            {
                MySqlConnection c1 = new MySqlConnection(@DBStr.connectionString);
                DataTable dt = new DataTable();

                MySqlDataAdapter sa = new MySqlDataAdapter("select ID,Pension,Bank,PaymentActNo,Type,DependentName,DependentID,DependentType from Employee,Dependent where Type='2' AND SystemValidity='0' AND DependentStatus<3 AND RelatedEmployeeID=ID", c1);
                sa.Fill(dt);
                dt.Columns.Add("Actual Payment", System.Type.GetType("System.Double"));

                foreach (DataRow row in dt.Rows)
                {

                    //MessageBox.Show(Convert.ToInt32(row[7]).ToString());
                    if (Convert.ToInt32(row[7]) == 1)
                    {
                        row[8] = Convert.ToDouble((Convert.ToInt32(row[1])) * 0.75);
                    }
                    else
                        row[8] = Convert.ToDouble((Convert.ToInt32(row[1])) * 0.50);



                }

                Insert(dt);

                DependentView.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Invalid Entry");

            }



        }
        private void DependentPayments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateAndSubmit();
        }

        private void DependentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //Payment p8 = new Payment();
           // p8.Show();
        }

        private void DependentPayments_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "Payment")
                    {

                        Application.OpenForms[i].Show();
                        break;
                    }
                    


                }
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());

            }
        }

        private void PeriodSelect_ValueChanged(object sender, EventArgs e)
        {
            PeriodSelect.Value = DateTime.Today;
        }
    }
}
