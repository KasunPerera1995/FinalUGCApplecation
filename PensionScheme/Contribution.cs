
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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
//using ExcelLibrary.BinaryDrawingFormat;
//using ExcelLibrary.BinaryFileFormat;

namespace PensionScheme
{
    public partial class Contribution : Form
    {
        public void InsertContribution(DataTable dt, int length)
        {

            string conn = @DBStr.connectionString;
            MySqlConnection DBConnect = new MySqlConnection(conn);
            int progress;
            try
            {
                for (int n = 0; n < length; n++)
                {
                    DBConnect.Open();
                    //MessageBox.Show("You are connected");
                    String update = "update ContributionD set EntryVal='1' where ContributionID='" + dt.Rows[n][0].ToString() + "'";
                    String query = "Insert into ContributionPen values('" + dt.Rows[n][0].ToString() + "','" + dt.Rows[n][1].ToString() + "','" + dt.Rows[n][2].ToString() + "','" + dt.Rows[n][3].ToString() + "','" + (Convert.ToDateTime(dt.Rows[n][4].ToString())).ToString("yyyy-MM-dd") + "','" + dt.Rows[n][5].ToString() + "','" + dt.Rows[n][6].ToString() + "','" + dt.Rows[n][7].ToString() + "')";
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect);
                    MySqlCommand up = new MySqlCommand(update, DBConnect);
                    up.ExecuteNonQuery();
                    //MessageBox.Show("Updated");

                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                    }

                    DBConnect.Close();
                    progress = Convert.ToInt32((n + 1) * 100 / length);
                    progressBar1.Increment(progress);

                }

                DisplayRemain();
                Available();
                progressBar1.Value = 0;
                MessageBox.Show("Data inserted");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
        public void DisplayRemain()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from UpdateDB where LastConYr<='" + DateTime.Now.Year.ToString() + "' AND LastConMnth<'" + DateTime.Now.Month.ToString() + "' OR  LastConYr<'" + DateTime.Now.Year.ToString() + "'", conn);
                DataTable dt = new DataTable();
                DataTable type = new DataTable();
                sql.Fill(dt);
                Remain.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        public void Available()
        {
            try
            {
                listView1.Items.Clear();
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select distinct u.UniversityName,t.Year,t.Month,t.TotalCon from TotalColl t,Cheque c,University u,ContributionD cd where t.Year=c.CHEQREC_YEAR AND t.Month=c.CHEQREC_PERIODNO AND t.TotalCon=c.CHEQREC_AMOUNT AND u.UniversityID=c.CHEQREC_INSTITUTE AND c.CHEQREC_INSTITUTE=t.University AND cd.EntryVal=0 AND cd.Year=c.CHEQREC_YEAR AND cd.Month=c.CHEQREC_PERIODNO AND c.CHEQREC_INSTITUTE=cd.University", conn);
                DataTable dt = new DataTable();
                DataTable type = new DataTable();
                sql.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[0].ToString());

                    item.SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    item.SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    item.SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
        public Contribution()
        {
            InitializeComponent();
            DisplayRemain();
            Available();
            timer1.Start();
        }

        /*private void button1_Click(object sender, EventArgs e)
         {
             SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kasun\source\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True");
             conn.Open();
             string query = "update Rates set Rate= '" + Rate.Text + "' where RateId='1'";
             SqlCommand com = new SqlCommand(query, conn);
             com.ExecuteNonQuery();
             MessageBox.Show("Update Successful");
             conn.Close();
         }

        private void button2_Click(object sender, EventArgs e)
         {
             SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kasun\source\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True");
             conn.Open();
             SqlDataAdapter sql = new SqlDataAdapter("select Rate from Rates where RateID='1'", conn);
             DataTable dt=new DataTable();
             sql.Fill(dt);
             MessageBox.Show("Contribution Rate= "+dt.Rows[0][0].ToString());
             conn.Close();
         }
         */
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cheque c = new Cheque();
            c.Show();
        }

        private void Rate_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void Contribution_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeDataSet6.University' table. You can move, or remove it, as needed.
           // this.universityTableAdapter.Fill(this.pensionSchemeDataSet6.University);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ContributionEntries ce = new ContributionEntries();
            ce.Show();
        }

        private void Selected_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count <= 0)
            {
                MessageBox.Show("Empty List");
                return;
            }
            else if (listView1.SelectedItems.Count <= 0)
            {

                MessageBox.Show("No item selected");
                return;
            }

            String uni = listView1.SelectedItems[0].SubItems[0].Text;
            String yr = listView1.SelectedItems[0].SubItems[1].Text;
            String mnth = listView1.SelectedItems[0].SubItems[2].Text;

            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select distinct cd.ContributionID,u.UniversityID,cd.Year,cd.Month,cd.SubDate,cd.Amount,c.CHEQREC_REFNO,cd.OwnerID from ContributionD cd,Cheque c,University u where u.UniversityID=c.CHEQREC_INSTITUTE AND u.UniversityID=cd.University AND UniversityName='" + uni + "' AND cd.Year='" + yr + "'AND cd.Month='" + mnth + "' AND CHEQREC_Year='"+yr+"' AND CHEQREC_PERIODNO='"+mnth+"'", conn);
                MySqlDataAdapter sql2 = new MySqlDataAdapter("select distinct cd.OwnerID from ContributionD cd,Cheque c,University u where u.UniversityID=c.CHEQREC_INSTITUTE AND u.UniversityID=cd.University AND UniversityName='" + uni + "' AND cd.Year='" + yr + "'AND cd.Month='" + mnth + "'", conn);
                // SqlDataAdapter sql = new SqlDataAdapter("select e.ID,cd.ContributionID,u.UniversityID,cd.Year,cd.Month,cd.SubDate,cd.Amount,c.CHEQREC_REFNO,cd.OwnerID from FinancialSection.dbo.ContributionD cd,PensionScheme.dbo.Cheque c,PensionScheme.dbo.University u,PensionScheme.dbo.Employee e where u.UniversityID=c.CHEQREC_INSTITUTE AND u.UniversityID=cd.University AND e.ID=cd.OwnerID AND UniversityName='" + uni + "' AND cd.Year='" + yr + "'AND cd.Month='" + mnth + "' AND e.University=u.UniversityID", conn);
                MySqlDataAdapter sall = new MySqlDataAdapter("select e.ID from Employee e,University u where u.UniversityName='" + listView1.SelectedItems[0].Text.ToString() + "' AND u.UniversityID=e.University AND e.Type='1' AND e.SystemValidity=true", conn);
                DataTable all = new DataTable();
                DataTable dt = new DataTable();
                DataTable dn = new DataTable();
                DataTable unmatch = new DataTable();
                unmatch.Columns.Add("Mismatch ID", typeof(string));
                //DataRow dr = unmatch.NewRow();
                sql.Fill(dn);
                sql2.Fill(dt);
                sall.Fill(all);
                //MessageBox.Show(dt.Rows.Count.ToString()+"  "+all.Rows.Count.ToString());



                int i = 0;
                int x;

                while (i < all.Rows.Count)
                {
                    for (x = 0; x < dt.Rows.Count; x++)
                    {
                        // MessageBox.Show(x.ToString());
                        if ((all.Rows[i][0].ToString()).Equals(dt.Rows[x][0].ToString()))
                        {
                            //MessageBox.Show(all.Rows[i][0].ToString());
                            break;
                        }

                    }
                    if (x >= dt.Rows.Count)
                    {
                        //MessageBox.Show("Different Entries");
                        //dr = unmatch.NewRow();
                        unmatch.Rows.Add(all.Rows[i][0].ToString());


                    }
                    i++;
                }

                i = 0;
                x = 0;
                //MessageBox.Show("Finished first while");
                while (i < dt.Rows.Count)
                {

                    for (x = 0; x < all.Rows.Count; x++)
                    {
                        //MessageBox.Show(x.ToString());
                        if ((all.Rows[x][0].ToString()).Equals(dt.Rows[i][0].ToString()))
                        {
                            break;
                        }
                    }
                    if (x >= all.Rows.Count)
                    {
                        //MessageBox.Show("Different Entries");
                        // dr[0].Equals(dt.Rows[i][5]);
                        //unmatch.Rows.Add(dr);
                        unmatch.Rows.Add(dt.Rows[i][0].ToString());
                    }
                    i++;

                }

                //MessageBox.Show("Finished second while");
                if (unmatch.Rows.Count == 0)
                {
                    MessageBox.Show("Entries are Equal");
                    InsertContribution(dn, dn.Rows.Count);
                }
                else
                {
                    MessageBox.Show("Different Entries");
                    DialogResult dg = MessageBox.Show("Different Entries Proceed?", "Alert", MessageBoxButtons.YesNo);

                    if (dg == DialogResult.Yes)
                    {
                        InsertContribution(dn, dn.Rows.Count);

                    }
                    else if (dg == DialogResult.No)
                    {
                        MessageBox.Show("Aborted");
                    }

                }

                ProcessView.DataSource = unmatch;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayRemain();
            Available();
            progressBar1.Value = 0;
            MessageBox.Show("Refreshed");
        }

        /*public void GenExcelMethod() {
            using Excel = Microsoft.Office.Interop.Excel;

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbook wb = excel.Workbooks.Open(excel_filename);
            Excel.Worksheet sh = wb.Sheets.Add();
            sh.Name = "TestSheet";
            sh.Cells[1, "A"].Value2 = "SNO";
            sh.Cells[2, "B"].Value2 = "A";
            sh.Cells[2, "C"].Value2 = "1122";
            wb.Close(true);
            excel.Quit();

        }
        */
        public void GenExcelMethod()
        {
            try
            {

                DataTable dt = new DataTable();
                dt=(DataTable)(ProcessView.DataSource);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;
                

                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                dt = (DataTable)(ProcessView.DataSource);
                ds.Tables.Add(dt);
                ExcelLibrary.DataSetHelper.CreateWorkbook("D:\\PaymentReports\\Mismatch.xls", ds);
                MessageBox.Show("Excel sheet created");
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }


        }
        private void GenExcel_Click(object sender, EventArgs e)
        {
            GenExcelMethod();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Remain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ProcessView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Contribution_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "Form1")
                    {

                      //  Application.OpenForms[i].Close();
                    }
                    else
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
