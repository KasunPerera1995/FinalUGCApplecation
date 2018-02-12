using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PensionScheme
{
    public partial class Complaint : Form
    {
        public Complaint()
        {
            InitializeComponent();
        }

        private void Complaint_Load(object sender, EventArgs e)
        {

        }

        private void Review_Click(object sender, EventArgs e)
        {
            try
            {

                /*if (Convert.ToInt32((textBox1.Text.ToString()).Length) != 10) {
                    MessageBox.Show("Invalid NIC");
                    return;
                }*/


                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                conn.Open();
                MySqlCommand sql = new MySqlCommand("Update complain set complain.Read='1' where id='" + ID.Text.ToString() + "'", conn);
                sql.ExecuteNonQuery();
                conn.Close();
                Reviewed.Text = "True";
                MessageBox.Show("Update Successful");
                Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
