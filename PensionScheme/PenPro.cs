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

        public void PenData()
        {
            MySqlConnection c1 = new MySqlConnection(@DBStr.connectionString);
            DataTable dt = new DataTable();
            DataTable ar = new DataTable();
            ar = Arrear();
            MySqlDataAdapter sa = new MySqlDataAdapter("select ID, Salary, Type, Pension, Bank, PaymentActNo FROM .Employee AS e where Type = '2' AND SystemValidity = True", c1);
            sa.Fill(dt);
            dt.Columns.Add("Arears", System.Type.GetType("System.Double"));
            dt.Columns.Add("Total Payment", System.Type.GetType("System.Double"));
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataRow row2 in ar.Rows)
                {

                    row[7] = row[3];
                    if (row[0].ToString().Equals(row2[1].ToString()))
                    {

                        row[6] = row2[4];
                        //row[7] = "999.45";
                        row[7] = (Convert.ToInt32(row[3]) + Convert.ToInt32(row2[4])).ToString();
                        break;
                    }

                }

            }
            PensionerView.DataSource = dt;

        }

        public DataTable Arrear()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select ID,OwnerID,PeriodYear,PeriodMonth,Amount from Arrears where PeriodYear='" + Period.Value.Year.ToString() + "' AND PeriodMonth='" + Period.Value.Month.ToString() + "'", conn);
                DataTable ar = new DataTable();
                sql.Fill(ar);
                return ar;
            }
            catch (Exception n)
            {
                MessageBox.Show(n.ToString());
                return null;
            }
        }


        public void ArrearView()
        {
            ArrearData.DataSource = Arrear();
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
            ArrearData.DataSource = Arrear();
            PenData();
        }

        public void PenView()
        {
            try
            {

                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);

                MySqlDataAdapter sql = new MySqlDataAdapter("select ID,Salary,Type,Pension from PensionScheme.Employee ee where ee.SystemValidity='True' AND Type='2' ", conn);
                DataTable dt = new DataTable();
                PensionerView.DataSource = dt;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

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
                MySqlConnection c1 = new MySqlConnection(@DBStr.connectionString);
                DataTable dt = new DataTable();
                DataTable ar = new DataTable();

                ar = Arrear();
                MySqlDataAdapter sa = new MySqlDataAdapter("select ID, Salary, Type, Pension, Bank, PaymentActNo FROM .Employee AS e where Type = '2' AND SystemValidity = True", c1);
                sa.Fill(dt);
                dt.Columns.Add("Arears", System.Type.GetType("System.Double"));
                dt.Columns.Add("Total Payment", System.Type.GetType("System.Double"));
                foreach (DataRow row in dt.Rows)
                {

                    row[7] = (Convert.ToInt32(row[3])).ToString();
                    // MessageBox.Show(row[7].ToString());
                    foreach (DataRow row2 in ar.Rows)
                    {


                        if (row[0].ToString().Equals(row2[1].ToString()))
                        {

                            row[6] = row2[4];
                            //row[7] = "999.45";
                            row[7] = (Convert.ToInt32(row[3]) + Convert.ToInt32(row2[4])).ToString();
                            //MessageBox.Show(row[7].ToString());
                            break;
                        }




                    }

                }
                PensionerView.DataSource = dt;
                int progress = 0;
                int length = dt.Rows.Count;



                CalVoucherNo();

                MessageBox.Show("Start Process");
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                // MessageBox.Show("Conneted");

                for (int n = 0; n < length; n++)
                {
                    conn.Open();
                    MySqlCommand sql;

                    //    MessageBox.Show(dt.Rows[n][7].ToString());
                    sql = new MySqlCommand("insert into PensionPayment(OwnerID,PaymentValue,PaymentMonth,PaymentYear,PaymentBank,AccountNo,PaymentSubDate,VoucherNo,Type,Approval) values('" + dt.Rows[n][0].ToString() + "','" + dt.Rows[n][7].ToString() + "','" + Period.Value.Month.ToString() + "','" + Period.Value.Year.ToString() + "','" + dt.Rows[n][4].ToString() + "','" + dt.Rows[n][5].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + VoucherNo.ToString() + "','2',0)", conn);
                    //insert to the database


                    MySqlDataReader reader;
                    reader = sql.ExecuteReader();
                    // MessageBox.Show("Sql" + n.ToString());
                    while (reader.Read())
                    {
                    }
                    progress = Convert.ToInt32((n + 1) * 100 / length);
                    progressBar1.Increment(progress);
                    conn.Close();
                    //MessageBox.Show(n.ToString());
                }

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
            WriteData();
        }

        private void PenPro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeDataSet13.Pensioners' table. You can move, or remove it, as needed.
         //   this.pensionersTableAdapter7.Fill(this.pensionSchemeDataSet13.Pensioners);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet12.Pensioners' table. You can move, or remove it, as needed.
         //   this.pensionersTableAdapter6.Fill(this.pensionSchemeDataSet12.Pensioners);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet11.Pensioners' table. You can move, or remove it, as needed.
         //   this.pensionersTableAdapter5.Fill(this.pensionSchemeDataSet11.Pensioners);
            // TODO: This line of code loads data into the 'nEWW.Pensioners' table. You can move, or remove it, as needed.
          //  this.pensionersTableAdapter4.Fill(this.nEWW.Pensioners);
            // TODO: This line of code loads data into the '_new.Pensioners' table. You can move, or remove it, as needed.
          //  this.pensionersTableAdapter3.Fill(this._new.Pensioners);
            // TODO: This line of code loads data into the 'data.Pensioners' table. You can move, or remove it, as needed.
         //   this.pensionersTableAdapter2.Fill(this.data.Pensioners);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet10.Pensioners' table. You can move, or remove it, as needed.
         //   this.pensionersTableAdapter1.Fill(this.pensionSchemeDataSet10.Pensioners);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet9.Pensioners' table. You can move, or remove it, as needed.
         //   this.pensionersTableAdapter.Fill(this.pensionSchemeDataSet9.Pensioners);

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
            PenData();
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


        public void WriteData()
        {

            try
            {
                //D:\\pensionslip.txt
                FileStream fs = new FileStream("D:\\PaymentReports\\pensionslip.txt", FileMode.Create, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);
                try
                {
                    string first = string.Empty;
                    string second = string.Empty;
                    string third = string.Empty;
                    string fourth = string.Empty;
                    string fifth = string.Empty;
                    string sixth = string.Empty;

                    using (MySqlConnection conn = new MySqlConnection(@DBStr.connectionString))
                    {
                        using (MySqlCommand command = new MySqlCommand("SELECT ID,Name,University,Bank,PaymentValue,PaymentActNo FROM Employee,PensionPayment where Employee.Type='2' AND  PaymentYear='"+DateTime.Now.Year.ToString()+"' AND PaymentMonth='"+DateTime.Now.Month.ToString()+"' AND ID=OwnerID", conn))
                        {
                            conn.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (!(reader.HasRows)){
                                    MessageBox.Show("No records for Current Period");
                                    sw.Flush();

                                    sw.Close();

                                    fs.Close();
                                    if (File.Exists(@"D:\\PaymentReports\\pensionslip.txt"))
                                    {
                                        File.Delete(@"D:\\PaymentReports\\pensionslip.txt");
                                    }
                                    return;
                                }
                                while (reader.Read())
                                {
                                    first = reader[0].ToString();
                                    second = reader[1].ToString();
                                    third = reader[2].ToString();
                                    fourth = reader[3].ToString();
                                    fifth = reader[4].ToString();
                                    sixth = reader[5].ToString();

                                    string str = "\t\t\b Employee Pension issue Bankslip:\t\t";
                                    string str5 = "\nPayment Amount:\t\t";
                                    string str1 = "\nEmployeeID:\t\t";
                                    string str2 = "\nEmployee Name:\t\t";
                                    string str4 = "\nBank Name:\t\t";
                                    string str3 = "\nUniversity:\t\t";
                                    string str6 = "\nBank Account NO:\t";
                                    string str7 = "------------------------------------------------------\n";
                                    sw.WriteLine(str);
                                    sw.WriteLine(str1 + first);
                                    sw.WriteLine(str2 + second);
                                    sw.WriteLine(str3 + third);
                                    sw.WriteLine(str4 + fourth);
                                    sw.WriteLine(str5 + fifth);
                                    sw.WriteLine(str6 + sixth);
                                    sw.WriteLine(str7);
                                }
                            }
                        }
                    }

                    MessageBox.Show("success");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                    MessageBox.Show("Error");
                }

                // Console.WriteLine ("Enter the text which you want to write to the file");

                // string str = "arosha";

                // sw.WriteLine(str);

                sw.Flush();

                sw.Close();

                fs.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
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
    }
}
