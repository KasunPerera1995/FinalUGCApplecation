
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
        ContributionBUO cb = new ContributionBUO();
        public void InsertContribution(DataTable dt, int length)
        {
            
            string conn = @DBStr.connectionString;
            MySqlConnection DBConnect = new MySqlConnection(conn);
            int progress=0;
            try
            {
                for (int n = 0; n < length; n++)
                {

                    ContributionVO cv = new ContributionVO(Convert.ToInt32(dt.Rows[n][0].ToString()), Convert.ToInt32(dt.Rows[n][1].ToString()), Convert.ToInt32(dt.Rows[n][2].ToString()), Convert.ToInt32(dt.Rows[n][3].ToString()), (Convert.ToDateTime(dt.Rows[n][4].ToString())), Convert.ToDouble(dt.Rows[n][5].ToString()), dt.Rows[n][6].ToString(), dt.Rows[n][7].ToString());

                    if ( cb.InsertContribution(cv))
                    {
                        if (cb.UpdateEntryCon(dt.Rows[n][0].ToString()))
                        {
                            progress = Convert.ToInt32((n + 1) * 100 / length);
                            progressBar1.Increment(progress);
                        }
                        
                    }
                    
                  

                }
                if (progress == 100)
                    MessageBox.Show("Sucessfull");
                
                cb.DisplayRemain(Remain);
                Available();
                progressBar1.Value = 0;
                MessageBox.Show("Data inserted");


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
                 DataTable dt = cb.TalliedContribution();
                DataTable type = new DataTable();
                
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
            cb.DisplayRemain(Remain);
            Available();
            LoadMyDetails();
            timer1.Start();
        }

       
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
                
                DataTable dn = cb.ContributionList(uni, yr, mnth);
                DataTable unmatch = cb.TallyEntries(uni, yr, mnth);
                

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
            cb.DisplayRemain(Remain);
            Available();
            progressBar1.Value = 0;
            MessageBox.Show("Refreshed");
        }

       
        
        private void GenExcel_Click(object sender, EventArgs e)
        {
            cb.GenExcelMethod(ProcessView);
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

        private void InsertC_Click(object sender, EventArgs e)
        {
            InsertContribution ic = new InsertContribution();
            ic.Show();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void ChangePass_Click_1(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }
        public void LoadMyDetails()
        {
            //MessageBox.Show(Log.LoginName + Log.OperatingEmployee + Log.Type);
            LoginName.Text = Log.LoginName;
            MyID.Text = Log.OperatingEmployee;
            Text = Log.Type;


        }
    }
}
