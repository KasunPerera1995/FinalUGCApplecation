﻿using System;
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
    public partial class Arrears : Form
    {
        public Arrears()
        {
            InitializeComponent();
            FillArrearOwner();
            ArrearView();
            Period.Value = DateTime.Today;
        }
        public void FillArrearOwner()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from Employee where Type='2' AND SystemValidity=True", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                ID.DataSource = ds;
                ID.DisplayMember = "ID";
                ID.ValueMember = "ID";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }

        }

        public void ArrearView()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                //MessageBox.Show(MemID);
                MySqlDataAdapter sql = new MySqlDataAdapter("select ID,OwnerID,PeriodYear,PeriodMonth,Amount from Arrears", conn);
                DataTable dt = new DataTable();
                sql.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }
            Refresh();


        }
        private void Arrears_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeDataSet8.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.pensionSchemeDataSet8.Employee);
            // TODO: This line of code loads data into the 'pensionSchemeDataSet14.Arrears' table. You can move, or remove it, as needed.
          //  this.arrearsTableAdapter.Fill(this.pensionSchemeDataSet14.Arrears);
            // TODO: This line of code loads data into the 'databaseDataSet.Complaint' table. You can move, or remove it, as needed.
            //this.complaintTableAdapter.Fill(this.databaseDataSet.Complaint);

        }
        public void Insert()
        {

            if (Period.Value.Year > DateTime.Now.Year || (Period.Value.Month > DateTime.Now.Month && Period.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            try
            {
                if (String.IsNullOrEmpty(Value.Text) || (Convert.ToInt32(Value.Text)) == 0)
                {
                    MessageBox.Show("Enter Arrear Value");
                    return;
                }
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                conn.Open();
                string query = "insert into Arrears(OwnerID,PeriodYear,PeriodMonth,Amount) values('" + ID.SelectedValue.ToString() + "','" + Period.Value.Year.ToString() + "','" + Period.Value.Month.ToString() + "','" + Value.Text + "')";
                MySqlCommand com = new MySqlCommand(query, conn);
                com.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
                dataGridView1.Refresh();
                conn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show("Invalid Entry");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Insert();
            Refresh();
            ArrearView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Period_ValueChanged(object sender, EventArgs e)
        {
           // MessageBox.Show("You can not change time");
            Period.Value = DateTime.Today;
        }

        private void Period_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("You can not change time");
            //Period.Value = DateTime.Today;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PenPro p9 = new PenPro();
            p9.Show();
        }

        private void Arrears_FormClosed(object sender, FormClosedEventArgs e)
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
