using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;

namespace PensionScheme
{
    class PaymentBUO
    {
        PaymentDAO pd = new PaymentDAO();
        CommonDAO com = new CommonDAO();
        public void Notifications(ListView listView1)
        {
            try
            {
                int cYr = Convert.ToInt32(DateTime.Now.Year.ToString());
                int cMnth = Convert.ToInt32(DateTime.Now.Month.ToString());
                int oMnth = cMnth - 2;
                int oYr = cYr;
                if (oMnth <= 0)
                {
                    oMnth = oMnth + 12;
                    oYr = oYr - 1;
                }

                listView1.Items.Clear();

                DataTable dt = pd.NumberofNotificationsinPeriod(oYr, oMnth, cYr, cMnth);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[0].ToString());

                    item.SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    //item.SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    // item.SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView1.Items.Add(item);
                    if (Convert.ToInt32(dt.Rows[i][1].ToString()) >= 2)
                    {
                        item.BackColor = Color.LightSkyBlue;
                        //val = false;

                    }

                }

            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }

        public bool InsertArrear(ArrearVO ar) {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();


                dt.Rows.Add(new Object[] { ar.OwnerID, ar.PeriodYear, ar.PeriodMonth, ar.Amount });

                return pd.InsertArrear(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }



        }
        public void ArrearOwnerCombo(ComboBox combo) {
            try
            {
                DataTable ds = com.DefaultSearch("Employee", "Type", "2", "SystemValidity", "1");
                combo.DataSource = ds;
                combo.DisplayMember = "ID";
                combo.ValueMember = "ID";
            }
            catch (Exception ee)
            {
                //MessageBox.Show(combo.Name + "Error" + table + "  " + display + "   " + value);
                MessageBox.Show(ee.ToString());

            }
        }
        public void PaymentGridFill(DataGridView dg, DateTime date, string type) {
            if (type == "pension")
            {
                dg.DataSource = com.DefaultSearch("PensionPayment", "PaymentYear", date.Year.ToString(), "PaymentMonth", date.Month.ToString(), "Type", 2);
            }
            else if (type == "lumpsum") {
                dg.DataSource = com.DefaultSearch("PensionPayment", "PaymentSubDate", date.ToString("yyyy-MM-dd"), "Type", 3);
            }


        }
        public bool InsertPayment(PaymentVO p)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();


                dt.Rows.Add(new Object[] { p.OwnerID1, p.PaymentValue1, p.PaymentYear1, p.PaymentMonth1, p.PaymentBank1, p.AccountNo1, p.PaymentSubDate1, p.VoucherNo1, p.Type1 });

                return pd.InsertPayment(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }



        }
        public DataTable Arrear(DateTime period)
        {
            try
            {
                DataTable ar = new DataTable();
                ar = pd.Arrear(period);
                return ar;
            }
            catch (Exception n)
            {
                MessageBox.Show(n.ToString());
                return null;
            }
        }
        public DataTable PenData(DateTime period, DataGridView dg)
        {

            DataTable dt = new DataTable();
            DataTable ar = new DataTable();
            ar = Arrear(period);
            dt = pd.PaymentProcessView();
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

            dg.DataSource = dt;
            return dt;
        }
        public int CalVoucherNo()
        {
            try
            {
                DataTable dt = pd.MaxVoucher();
                int VoucherNo = Convert.ToInt32(dt.Rows[0][0].ToString()) + 1;
                return VoucherNo;
            }
            catch (Exception en)
            {
                MessageBox.Show("Errors");
                return -1;
            }
        }

        public void WriteData(DateTime period, int type)
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

                    DataTable dt = pd.SlipList(period, type);
                    if (dt.Rows.Count <= 0)
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
                    foreach (DataRow dr in dt.Rows)
                    {
                        first = dr[0].ToString();
                        second = dr[1].ToString();
                        third = dr[2].ToString();
                        fourth = dr[3].ToString();
                        fifth = dr[4].ToString();
                        sixth = dr[5].ToString();

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
        public DataTable LumpsumView(DataGridView dg) {

            DataTable dt = pd.LumpSumProView();
            dg.DataSource = dt;
            return dt;


        }

        public bool InvalidateMember(string id)
        {
            return com.defaultUpdate("employee","systemvalidity",false,"id",id);


        }
    }
}
