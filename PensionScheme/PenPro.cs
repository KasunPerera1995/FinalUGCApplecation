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
using System.IO;
using MySql.Data.MySqlClient;

namespace PensionScheme
{
    public partial class PenPro : Form
    {
        int VoucherNo;
        PaymentBUO pb = new PaymentBUO();
        

       


        public void ArrearView()
        {
            ArrearData.DataSource = pb.Arrear(Period.Value);
        }
        public void CalVoucherNo()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                conn.Open();
                MySqlCommand sql = new MySqlCommand("select Max(VoucherNo) from PensionPayment ", conn);
                VoucherNo = Convert.ToInt32(sql.ExecuteScalar().ToString()) + 1;
                conn.Close();
            }
            catch (Exception en)
            {
                MessageBox.Show("Errors");
            }
        }
        public PenPro()
        {
            InitializeComponent();
            ArrearData.DataSource = pb.Arrear(Period.Value);
            pb.PenData(Period.Value,PensionerView);
            
        }

       

        private void PensionPro_Click(object sender, EventArgs e)
        {

            //Validations check the date
            if (Period.Value.Year > DateTime.Now.Year || (Period.Value.Month > DateTime.Now.Month && Period.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            if (Period.Value.Year != DateTime.Today.Year && Period.Value.Month != DateTime.Today.Month) {
                MessageBox.Show("Only the current period is allowed");
                Period.Value = DateTime.Today;
                return;
            }


            try
            {
                
                DataTable dt = new DataTable();



                dt = pb.PenData(Period.Value, PensionerView);
                int progress = 0;
                int length = dt.Rows.Count;



                VoucherNo=pb.CalVoucherNo();

                MessageBox.Show("Start Process");
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                // MessageBox.Show("Conneted");

                for (int n = 0; n < length; n++)
                {
                    
                    //MySqlCommand sql;

                    //    MessageBox.Show(dt.Rows[n][7].ToString());
                    PaymentVO pv = new PaymentVO(dt.Rows[n][0].ToString(),Convert.ToDouble(dt.Rows[n][7].ToString()), false,Convert.ToInt32(Period.Value.Month.ToString()),Convert.ToInt32(Period.Value.Year.ToString()),Convert.ToInt32(dt.Rows[n][4].ToString()) , dt.Rows[n][5].ToString(),DateTime.Now,VoucherNo,2);
                    if (pb.InsertPayment(pv))
                    {
                        /*sql = new MySqlCommand("insert into PensionPayment(OwnerID,PaymentValue,PaymentMonth,PaymentYear,PaymentBank,AccountNo,PaymentSubDate,VoucherNo,Type,Approval) values('" + dt.Rows[n][0].ToString() + "','" + dt.Rows[n][7].ToString() + "','" + Period.Value.Month.ToString() + "','" + Period.Value.Year.ToString() + "','" + dt.Rows[n][4].ToString() + "','" + dt.Rows[n][5].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + VoucherNo.ToString() + "','2',0)", conn);
                        //insert to the database


                        MySqlDataReader reader;
                        reader = sql.ExecuteReader();
                        // MessageBox.Show("Sql" + n.ToString());
                        while (reader.Read())
                        {
                        }
                        */
                        progress = Convert.ToInt32((n + 1) * 100 / length);
                        progressBar1.Increment(progress);
                    }
                    //MessageBox.Show(n.ToString());
                }
                if(progress==100)
                MessageBox.Show("Sucessfull");
                progressBar1.Value = 0;
            }

            catch (Exception ex)
            {

                MessageBox.Show("Duplicate Entries");
            }

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //Bank_slip();
            pb.WriteData(DateTime.Now,2);
        }

        private void PenPro_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Arrears ar = new Arrears();
            ar.Show();
        }

        private void Period_ValueChanged(object sender, EventArgs e)
        {
            ArrearView();
            pb.PenData(Period.Value, PensionerView);
            
        }

        private void PensionHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            PensionPayment pp = new PensionPayment();
            pp.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


       

        private void PensionerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //Payment p2 = new Payment();
            //p2.Show();
            //ArrearView();
            //PenData();
        }

        private void ArrearData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PensionerView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PenPro_FormClosed(object sender, FormClosedEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            InsertPayment ip = new InsertPayment();
            ip.Show();
        }
    }
}
