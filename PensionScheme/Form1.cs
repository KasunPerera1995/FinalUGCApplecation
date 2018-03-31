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
    public partial class Form1 : Form
    {
        MemberBUO mem = new MemberBUO();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
               
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                //MySqlConnection con = new MySqlConnection(@DBStr.connectionString);//"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kasun\source\WebSites\WebSite4\App_Data\Database.mdf;Integrated Security=True");
                //MySqlDataAdapter sql = new MySqlDataAdapter("select count(*) from Admin where LoginName='" + UserName.Text + "' AND AdminPassword='" + AdminPassword.Text + "'", con);

                //DataTable dt = new DataTable();
                //DataTable type = new DataTable();
                //sql.Fill(dt);
                
                bool x = mem.CheckAdminPassword(UserName.Text, AdminPassword.Text);


            if (x)//dt.Rows[0][0].ToString() == "1"
                {


                   AdminVO ad= mem.LoginAdmin(UserName.Text, AdminPassword.Text);
                    //MySqlDataAdapter check = new MySqlDataAdapter("select AccountType,OperatingEmployeeID from Admin where LoginName='" + UserName.Text + "' AND AdminPassword='" + AdminPassword.Text + "'", con);

                //check.Fill(type);
                    Log.LoginName = UserName.Text;
                    Log.OperatingEmployee = ad.OperatingEmployeeID.ToString();//type.Rows[0][1].ToString();
                    Log.Type = ad.AccountType.ToString();//type.Rows[0][0].ToString();
                    int type= ad.AccountType;
                    if (type==1)
                    {

                        this.Hide();
                        Payment p = new Payment();
                        p.Show();
                    }
                    else if (type==2)
                    {
                        this.Hide();
                        Contribution c = new Contribution();
                        c.Show();
                    }

                    else if (type==3)
                    {
                        this.Hide();
                        MemberAccount m = new MemberAccount();
                        m.Show();
                    }
                    else if (type==4) {
                        this.Hide();
                        MainAdmin m = new MainAdmin();
                        m.Show();

                    }
                    else
                        MessageBox.Show("You Do not have system privilleges");

                   
            }
            else
            {
                MessageBox.Show("Check your username or password");
            }
        }
                catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ContributionReport crpt = new ContributionReport();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Exit the Applecation?","Are you sure?",MessageBoxButtons.YesNo);

            e.Cancel = (window == DialogResult.No);
        }
    }
}
