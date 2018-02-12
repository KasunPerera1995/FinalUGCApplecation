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
        Boolean val = true;

        public void EditNotification()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("Select * from Employee where ID='" + listView1.SelectedItems[0].Text.ToString() + "'", conn);
                sql.Fill(dt);

                int u, p, d, t, b;

                u = Convert.ToInt32(dt.Rows[0][6].ToString());
                p = Convert.ToInt32(dt.Rows[0][7].ToString());
                d = Convert.ToInt32(dt.Rows[0][10].ToString());
                t = Convert.ToInt32(dt.Rows[0][5].ToString());
                b = Convert.ToInt32(dt.Rows[0][14].ToString());
                Member mb = new Member(u, p, d, t, b);
                mb.textBox1.Text = dt.Rows[0][0].ToString();  //Cells[0].Value.ToString();
                mb.textBox2.Text = dt.Rows[0][1].ToString();
                // mb.UniversitySelect.SelectedValue= dt.Rows[0][6].ToString();//mb.textBox3.Text = dt.Rows[0][6].ToString();
                mb.textBox4.Text = (Convert.ToDateTime(dt.Rows[0][2].ToString())).ToString("yyyy-MM-dd"); //dt.Rows[0][2].ToString();
                mb.textBox5.Text = dt.Rows[0][13].ToString();
                mb.textBox6.Text = dt.Rows[0][15].ToString();                                  //this.dt.CurrentRow.Cells[15].Value.ToString();
                                                                                              //   mb.textBox7.Text = dt.Rows[0][14].ToString();//this.dt.CurrentRow.Cells[14].Value.ToString();
                                                                                             //mb.PostSelect.SelectedValue = dt.Rows[0][7].ToString(); //this.dt.CurrentRow.Cells[7].Value.ToString();
                mb.AcadamicC.SelectedItem= dt.Rows[0][8].ToString();                        //this.dt.CurrentRow.Cells[8].Value.ToString();mb.textBox9.Text = dt.Rows[0][8].ToString();
                                                                                           // mb.DependentStatus.SelectedValue = dt.Rows[0][10].ToString(); //this.dt.CurrentRow.Cells[10].Value.ToString();
                mb.textBox11.Text = dt.Rows[0][12].ToString();                            //this.dt.CurrentRow.Cells[12].Value.ToString();
                mb.textBox12.Text = dt.Rows[0][11].ToString();                           //this.dt.CurrentRow.Cells[11].Value.ToString();
                mb.textBox13.Text = (Convert.ToDateTime(dt.Rows[0][3].ToString())).ToString("yyyy-MM-dd");//dt.Rows[0][3].ToString(); //this.dt.CurrentRow.Cells[3].Value.ToString();
                mb.textBox14.Text = (Convert.ToDateTime(dt.Rows[0][4].ToString())).ToString("yyyy-MM-dd");
                mb.ValidityC.SelectedItem= dt.Rows[0][9].ToString();                          // this.dt.CurrentRow.Cells[9].Value.ToString();mb.textBox15.Text = dt.Rows[0][9].ToString(); 
                                                                                              //mb.TypeSelect.SelectedValue = dt.Rows[0][5].ToString(); //this.dt.CurrentRow.Cells[5].Value.ToString();
                mb.textBox18.Text = dt.Rows[0][16].ToString();                                   //this.dt.CurrentRow.Cells[16].Value.ToString();
                mb.textBox19.Text = dt.Rows[0][17].ToString();                                //this.dt.CurrentRow.Cells[17].Value.ToString();
                mb.Email.Text = dt.Rows[0][20].ToString();
                mb.Show();
                mb.SelectedValues();
                mb.TotalReserve();
                mb.RetDateMethod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
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
                    MySqlDataAdapter sql = new MySqlDataAdapter("select p.OwnerID,count(p.Approval) as Approvals from PensionScheme.PensionPayment p where p.Approval=0 And (p.PaymentMonth>='" + oMnth.ToString() + "' AND p.PaymentYear='" + oYr.ToString() + "' AND p.PaymentMonth!='" + cMnth.ToString() + "') group by p.OwnerID", conn);
                    sql.Fill(dt);

                }
                else
                {
                    MySqlDataAdapter sql2 = new MySqlDataAdapter("select OwnerID,count(Approval) as Approvals from PensionScheme.PensionPayment p where Approval=0 And (PaymentMonth='12' AND PaymentYear='" + (cYr - 1).ToString() + "' Or PaymentMonth='1' AND PaymentYear='" + cYr.ToString() + "') group by OwnerID", conn);
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
            Notifications();
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
            EditNotification();
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
            Notifications();
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
    }
}
