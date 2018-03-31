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
    public partial class Payment : Form
    {
        MemberBUO mem = new MemberBUO();
        PaymentBUO pb = new PaymentBUO();
        Boolean val = true;

       
        public void Notifications()
        {
            try
            {
                int cYr = Convert.ToInt32(DateTime.Now.Year.ToString());
                int cMnth = Convert.ToInt32(DateTime.Now.Month.ToString());
                int oMnth = cMnth - 2;
                int oYr = cYr;
                if (oMnth < 0)
                {
                    oMnth = oMnth + 12;
                    oYr = oYr - 1;
                }

                listView1.Items.Clear();
                DataTable dt = new DataTable();
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                if (cMnth != 2)
                {
                    MySqlDataAdapter sql = new MySqlDataAdapter("select p.OwnerID,count(p.Approval) as Approvals from PensionPayment p where p.Approval=0 And (p.PaymentMonth>='" + oMnth.ToString() + "' AND p.PaymentYear='" + oYr.ToString() + "' AND p.PaymentMonth!='" + cMnth.ToString() + "') group by p.OwnerID", conn);
                    sql.Fill(dt);

                }
                else
                {
                    MySqlDataAdapter sql2 = new MySqlDataAdapter("select OwnerID,count(Approval) as Approvals from PensionPayment p where Approval=0 And (PaymentMonth='12' AND PaymentYear='" + (cYr - 1).ToString() + "' Or PaymentMonth='1' AND PaymentYear='" + cYr.ToString() + "') group by OwnerID", conn);
                    sql2.Fill(dt);
                }



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
                        val = false;

                    }

                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
        /*public void PaymentReview() {
            try
            {
                SqlConnection conn = new SqlConnection(@DBStr.connectionString);
                SqlDataAdapter sql = new SqlDataAdapter("select ID,Salary,Type,Pension from PensionScheme.dbo.Employee ee where ee.SystemValidity='True'", conn);
                DataTable dt = new DataTable();
                Pensioners.DataSource = dt;
            }
            catch (Exception e) {

                MessageBox.Show(e.ToString());
            }

            
        }*/
        public Payment()
        {
            InitializeComponent();
            pb.Notifications(listView1);
            if (listView1.Items.Count > 0)
            {

                notificationP.Icon = SystemIcons.Information;
                notificationP.BalloonTipTitle = "Alert";
                notificationP.BalloonTipText = "You have " + listView1.Items.Count.ToString() + " Notifications";

                notificationP.ShowBalloonTip(1000);
            }
            LoadMyDetails();
            // Notifications();
            timer1.Start();
            // PaymentReview();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /* private void PReport_Click(object sender, EventArgs e)
         {
             SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kasun\source\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True");
             conn.Open();
             SqlDataAdapter sql = new SqlDataAdapter("select * from PensionPayment,RegisteredMember where PaymentID='" + PaymentID.Text + "' AND PensionerID=ID", conn);

             DataTable dt = new DataTable();
             sql.Fill(dt);
             DisplayP.DataSource = dt;
             conn.Close();
         }*/

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 p = new Form1();
            //p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PenPro pp = new PenPro();
            pp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeDataSet7.PaymentUpdate' table. You can move, or remove it, as needed.
           // this.paymentUpdateTableAdapter.Fill(this.pensionSchemeDataSet7.PaymentUpdate);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotificationReview nr = new NotificationReview();
            nr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            LumpSum ls = new LumpSum();
            ls.Show();
        }

        private void PaymentDetails_Click(object sender, EventArgs e)
        {

        }

        private void SelectNotification(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text.ToString());

            MemberUser mu = mem.SearchByID(listView1.SelectedItems[0].Text.ToString());
            mem.MemberFormOpen(mu);
        }

        private void Dependent_Click(object sender, EventArgs e)
        {
            this.Hide();
            DependentPayments dp = new DependentPayments();
            dp.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            pb.Notifications(listView1);
            if (listView1.Items.Count > 0)
            {
                
                notificationP.Icon=SystemIcons.Information;
                notificationP.BalloonTipTitle = "Alert";
                notificationP.BalloonTipText = "You have " + listView1.Items.Count.ToString() + " Notifications";

                notificationP.ShowBalloonTip(1000);
            }
            //Notifications();
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                {

                    Application.OpenForms[i].Close();
                }
                else
                {
                    Application.OpenForms[i].Show();
                }
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ChangePass_Click(object sender, EventArgs e)
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
