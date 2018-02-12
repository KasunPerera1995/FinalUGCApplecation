﻿
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
    public partial class Cheque : Form
    {
        Contribution co = new Contribution();
        public Cheque()
        {
            InitializeComponent();
            FillComboBoxUni();
            FillComboBoxStatus();
        }
        public void FillComboBoxUni()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from University", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                Uni.DataSource = ds;
                Uni.DisplayMember = "UniversityName";
                Uni.ValueMember = "UniversityID";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        public void FillComboBoxStatus()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from Status", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                Status.DataSource = ds;
                Status.DisplayMember = "Name";
                Status.ValueMember = "StatusID";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cheque_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeDataSet5.University' table. You can move, or remove it, as needed.
          //  this.universityTableAdapter1.Fill(this.pensionSchemeDataSet5.University);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet5.Status' table. You can move, or remove it, as needed.
            //this.statusTableAdapter1.Fill(this.pensionSchemeDataSet5.Status);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet3.Status' table. You can move, or remove it, as needed.
            //this.statusTableAdapter.Fill(this.pensionSchemeDataSet3.Status);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet3.University' table. You can move, or remove it, as needed.
            //this.universityTableAdapter.Fill(this.pensionSchemeDataSet3.University);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet2.Status' table. You can move, or remove it, as needed.
            //this.statusTableAdapter.Fill(this.pensionSchemeDataSet2.Status);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet1.University' table. You can move, or remove it, as needed.
            //this.universityTableAdapter.Fill(this.pensionSchemeDataSet1.University);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet.University' table. You can move, or remove it, as needed.
            // this.universityTableAdapter.Fill(this.pensionSchemeDataSet.University);
            // TODO: This line of code loads data into the 'databaseDataSet1.PensionPayment' table. You can move, or remove it, as needed.
            // this.pensionPaymentTableAdapter.Fill(this.databaseDataSet1.PensionPayment);


        }
        public void Insert()
        {

            if (Period.Value.Year > DateTime.Now.Year || (Period.Value.Month > DateTime.Now.Month && Period.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            if (String.IsNullOrEmpty(Amount.Text) || (Convert.ToInt32(Amount.Text)) == 0)
            {
                MessageBox.Show("Enter Arrear Value");
                return;
            }
            if (String.IsNullOrEmpty(ReNo.Text))
            {
                MessageBox.Show("Enter Receipt Number");
                return;
            }
            
            if (dateTimePicker1.Value > DateTime.Now) {

                MessageBox.Show("Do not enter future dates");
                return;
            }


            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                conn.Open();
                string query = "insert into Cheque(CHEQREC_INSTITUTE,CHEQREC_REFNO,CHEQREC_AMOUNT,CHEQREC_YEAR,CHEQREC_PERIODNO,CHEQREC_STATUS,CHEQREC_DATE) values('" + Uni.SelectedValue.ToString() + "','" + ReNo.Text + "','" + Amount.Text + "','" + Period.Value.Year.ToString() + "','" + Period.Value.Month.ToString() + "','" + Status.SelectedValue.ToString() + "','" + Period.Value.ToString("yyyy-MM-dd") + "')";
                MySqlCommand com = new MySqlCommand(query, conn);
                com.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
                conn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }



        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert();
            co.Refresh();
            co.Available();
            
        }

        private void universityBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ConOpen_Click(object sender, EventArgs e)
        {
            this.Close();
           // co.Show();
        }

        private void ReNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Period_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Cheque_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                co.Show();
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
