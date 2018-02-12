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
        public LumpSum()
        {
            InitializeComponent();
            View();

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

        public void View()
        {
            try
            {
                MySqlConnection c1 = new MySqlConnection(@DBStr.connectionString);
                DataTable dt = new DataTable();

                MySqlDataAdapter sa = new MySqlDataAdapter("select ID,Name,TotalContribution,Bank,PaymentActNo,Type from Employee where Type='3' AND SystemValidity=true", c1);
                sa.Fill(dt);
                LumpSumGrid.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }



        }
        public void LumpSumProcessMethod()
        {
            try
            {
                MySqlConnection c1 = new MySqlConnection(@DBStr.connectionString);
                DataTable dt = new DataTable();

                MySqlDataAdapter sa = new MySqlDataAdapter("select ID,Name,TotalContribution,Bank,PaymentActNo,Type from Employee where Type='3' AND SystemValidity='1'", c1);
                sa.Fill(dt);
                LumpSumGrid.DataSource = dt;

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


                    sql = new MySqlCommand("insert into PensionPayment(OwnerID,PaymentValue,PaymentMonth,PaymentYear,PaymentBank,AccountNo,PaymentSubDate,VoucherNo,Type) values('" + dt.Rows[n][0].ToString() + "','" + dt.Rows[n][2].ToString() + "','" + DateTime.Now.Month.ToString() + "','" + DateTime.Now.Year.ToString() + "','" + dt.Rows[n][3].ToString() + "','" + dt.Rows[n][4].ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + VoucherNo.ToString() + "','3'); update Employee set SystemValidity='0' where Employee.ID='" + dt.Rows[n][0].ToString() + "'", conn);



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

                MessageBox.Show("Sucessful");
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
            View();
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
            WriteData();
        }
        public void WriteData()
        {
            try
            {
                FileStream fs = new FileStream("D:\\PaymentReports\\lumpsumslip.txt", FileMode.Create, FileAccess.Write);

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
                        using (MySqlCommand command = new MySqlCommand("SELECT ID,Name,University,Bank,PaymentActNo,TotalContribution FROM Employee,PensionPayment where  Employee.Type='3' AND PaymentYear='" + DateTime.Now.Year+"' AND PaymentMonth='"+DateTime.Now.Month+"' AND OwnerID=ID", conn))
                        {
                            conn.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                                if (!(reader.HasRows))
                                {
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
                                string str = "\t\t\b Lumpsum slip:\t\t\n";
                                sw.WriteLine(str);
                                while (reader.Read())
                                {
                                    first = reader[0].ToString();
                                    second = reader[1].ToString();
                                    third = reader[2].ToString();
                                    fourth = reader[3].ToString();
                                    fifth = reader[4].ToString();
                                    //sixth = reader[5].ToString();

                                    string st = "\t\t\b Employee lumpsum issue Bankslip:\t\t";
                                    //string str5 = "\Payment Value Amount:\t\t";
                                    string str1 = "\nEmployeeID:\t\t";
                                    string str2 = "\nEmployee Name:\t\t";
                                    string str3 = "\nUniversity:\t\t";
                                    string str4 = "\nBank No:\t\t";
                                    string str5 = "\nAccount No:\t\t";
                                    string str6 = "------------------------------------------------------\n";

                                    sw.Write(st);
                                    sw.Write(str1 + first);
                                    sw.Write(str2 + second);
                                    sw.Write(str3 + third);
                                    sw.Write(str4 + fourth);
                                    sw.Write(str5+fifth);
                                    sw.WriteLine(str6);
                                    // sw.WriteLine(str7);
                                }
                            }
                        }
                    }

                    MessageBox.Show("success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No entries for the current period");
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
                MessageBox.Show("Error");
            }

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
