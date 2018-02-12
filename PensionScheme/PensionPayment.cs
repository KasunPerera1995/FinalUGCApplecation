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
    public partial class PensionPayment : Form
    {
        public PensionPayment()
        {
            InitializeComponent();
            PensionHistorySelect();//get the all pension details
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void PensionHistorySelect()
        {
            try
            {
                if (ShowAll.Checked)//if select all
                {
                    MySqlConnection c = new MySqlConnection(@DBStr.connectionString);
                    //conn.Open();
                    MySqlDataAdapter all = new MySqlDataAdapter("select * from PensionPayment where Type='2'", c);
                    DataTable al = new DataTable();
                    all.Fill(al);
                    //conn.Close();
                    PensionHistory.DataSource = al;
                    return;


                }//if select date
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                //conn.Open();
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from PensionPayment where PaymentYear='" + PensionPeriodSelect.Value.Year.ToString() + "' AND PaymentMonth='" + PensionPeriodSelect.Value.Month.ToString() + "' AND Type='2'", conn);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                //conn.Close();
                PensionHistory.DataSource = dt;
            }
            catch (Exception en)
            {
                MessageBox.Show(en.ToString());
            }


        }
        private void PensionMonth_ValueChanged(object sender, EventArgs e)
        {
            PensionHistorySelect();
            Refresh();
        }

        public void WriteData()
        {

            FileStream fs = new FileStream("D:\\test5.txt", FileMode.Create, FileAccess.Write);

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
                    using (MySqlCommand command = new MySqlCommand("SELECT ID,Name,University,Bank,Pension,PaymentActNo FROM Employee,PensionPayment where OwnerID=ID AND PaymentYear = '" + PensionPeriodSelect.Value.Year.ToString() + "' AND PaymentMonth = '" + PensionPeriodSelect.Value.Month.ToString() + "' AND Employee.Type = '2'", conn))
                    {


                        conn.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            if (!(reader.HasRows))
                            {
                                MessageBox.Show("No records for selected Period");
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
                                string str5 = "\nPension Amount:\t\t";
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
                MessageBox.Show(ex.ToString());
            }

            // Console.WriteLine ("Enter the text which you want to write to the file");

            // string str = "arosha";

            // sw.WriteLine(str);

            sw.Flush();

            sw.Close();

            fs.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WriteData();
        }

        private void PensionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PensionPayment_Load(object sender, EventArgs e)
        {

        }

        private void PensionProcess_Click(object sender, EventArgs e)
        {

        }

        private void ShowAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowAll_CheckStateChanged(object sender, EventArgs e)
        {
            PensionHistorySelect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PenPro p3 = new PenPro();
            p3.Show();
        }

        private void PensionHistory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PensionPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                try
                {
                    if ((Application.OpenForms[i].Name) == "Payment")
                    {
                        Application.OpenForms[i].Show();
                        break;
                    }
                    
                }
                catch (Exception ee) {
                    MessageBox.Show(ee.ToString());
                }


            }
        }
    }
}
