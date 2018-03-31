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
    public partial class LumpSum : Form
    {
        int VoucherNo;
        PaymentBUO pb = new PaymentBUO();
        public LumpSum()
        {
            InitializeComponent();
            pb.LumpsumView(LumpSumGrid);
            //View();

        }

        private void LumpSum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.Employee' table. You can move, or remove it, as needed.
       //     this.employeeTableAdapter.Fill(this.pensionSchemeAllTables.Employee);
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.LumpSumPayment' table. You can move, or remove it, as needed.


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

        
        public void LumpSumProcessMethod()
        {
            try
            {
                
                DataTable dt = pb.LumpsumView(LumpSumGrid);

                
                int progress = 0;
                int length = dt.Rows.Count;

                pb.CalVoucherNo();



                MessageBox.Show("Start Process");
                //PaymentVO pv = new PaymentVO(dt.Rows[n][0].ToString(),Convert.ToDouble(dt.Rows[n][2].ToString()),0,Convert.ToInt32(DateTime.Now.Month), Convert.ToInt32(DateTime.Now.Year.ToString()),Convert.ToInt32(dt.Rows[n][3].ToString()),dt.Rows[n][4].ToString(),DateTime.Now,Convert.ToInt32(VoucherNo.ToString()),3);
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
               // MessageBox.Show("Conneted");

                for (int n = 0; n < length; n++)
                {
                    PaymentVO pp = new PaymentVO(dt.Rows[n][0].ToString(), Convert.ToDouble(dt.Rows[n][2].ToString()), false, Convert.ToInt32(DateTime.Now.Month), Convert.ToInt32(DateTime.Now.Year.ToString()), Convert.ToInt32(dt.Rows[n][3].ToString()), dt.Rows[n][4].ToString(), DateTime.Now, Convert.ToInt32(VoucherNo.ToString()), 3);


                    if (pb.InsertPayment(pp) && pb.InvalidateMember(dt.Rows[n][0].ToString()))
                    {

                        progress = Convert.ToInt32((n + 1) * 100 / length);
                        progressBar1.Increment(progress);

                    }
                 }

                if (progress == 100)
                    MessageBox.Show("Sucessfull");
                progressBar1.Value = 0;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }
        private void LumpSumProcess_Click(object sender, EventArgs e)
        {
            LumpSumProcessMethod();
            pb.LumpsumView(LumpSumGrid);
            //View();
        }

       

        private void LumpsumHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            LumpSumHistory lh = new LumpSumHistory();
            lh.Show();
        }

        

        

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb.WriteData(DateTime.Now,3);
        }
       

        private void LumpSumGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            //Payment p5 = new Payment();
            //p5.Show();
        }

        private void LumpSum_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    
                    if (Application.OpenForms[i].Name == "Payment")
                    {
                     Application.OpenForms[i].Show();
                    }
                    


                }
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
