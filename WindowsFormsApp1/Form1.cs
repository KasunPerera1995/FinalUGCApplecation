
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static double x = 0.5;
        static Boolean validity = true;
        int len;
        string globalconnp = "server=localhost;user id=root;database=pen";
        //string globalconn = "server=localhost;user id=root;database=financialsection";
        /*public void Combo()
        {
            try
            {
                string sql = "select University from UniversityFin";
                MySqlConnection conn = new MySqlConnection(@globalconn);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox2.Items.Add(dr[0]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString())
                    ;
            }
        }
        */
        public void FillComboBoxUni()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@globalconnp);
                MySqlDataAdapter sql = new MySqlDataAdapter("select * from University", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                comboBox2.DataSource = ds;
                comboBox2.DisplayMember = "UniversityName";
                comboBox2.ValueMember = "UniversityID";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        public void Insert(DataTable dt, int length)
        {
           

            string conn = @globalconnp;
            MySqlConnection DBConnect = new MySqlConnection(conn);
            int progress;
            try
            {
                for (int n = 0; n < length; n++)
                {
                    DBConnect.Open();
                    //MessageBox.Show("You are connected");

                    String query = "Insert into ContributionD(OwnerID,University,Year,Month,SubDate,Amount) values('" + dt.Rows[n][0].ToString() + "','" + comboBox2.SelectedValue.ToString() + "','" + dt.Rows[n][1].ToString() + "','" + dt.Rows[n][2].ToString() + "','" + SubDate.Value.ToString("yyyy-MM-dd") + "','" + dt.Rows[n][3].ToString() + "')";
                    MySqlCommand cmd = new MySqlCommand(query, DBConnect);

                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                    }

                    DBConnect.Close();
                    progress = Convert.ToInt32((n + 1) * 100 / length);
                    progressBar1.Increment(progress);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Invalid Entry");
            }



        }
        public void CalRate()
        {
            string conn = @globalconnp;
            MySqlConnection DBConnect = new MySqlConnection(conn);
            try
            {
                DBConnect.Open();
                String query = "select Rate from rates where ID='6'";
                MySqlCommand cmd = new MySqlCommand(query, DBConnect);

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                x = Convert.ToDouble(dt.Rows[0][0].ToString());
                MessageBox.Show("Rate= " + x.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public Form1()
        {
            InitializeComponent();
            FillComboBoxUni();
            // Combo();
        }
        DataSet result;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                        IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                        result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });
                        comboBox1.Items.Clear();
                        foreach (DataTable dt in result.Tables)
                        {
                            comboBox1.Items.Add(dt.TableName);
                            reader.Close();
                        }
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Close the Excel Sheet before upload");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.Tables[comboBox1.SelectedIndex];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SubDate.Value.Year > DateTime.Now.Year || (SubDate.Value.Month > DateTime.Now.Month && SubDate.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }

            CalRate();
            try
            {
                DataTable val = result.Tables[comboBox1.SelectedIndex];
                len = val.Rows.Count;
                val.Columns.Add("Validity", System.Type.GetType("System.String"));
                for (int i = 0; i < len; i++)
                {
                    if (Convert.ToInt32(Convert.ToInt32(val.Rows[i][4].ToString()) * x) != Convert.ToInt32(val.Rows[i][3].ToString()))
                    {
                        validity = false;
                        val.Rows[i][5] = "Invalid";

                    }
                    else
                        val.Rows[i][5] = "Valid";
                }
                if (validity)
                {
                    MessageBox.Show("All are Valid");
                    Insert(val, len);
                    MessageBox.Show("Entry Successful");
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    progressBar1.Value = 0;
                }
            }
            catch (Exception t)
            {
                MessageBox.Show("Invalid Excel Sheet");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialSectionDataSet1.UniversityFin' table. You can move, or remove it, as needed.
        //    this.universityFinTableAdapter.Fill(this.financialSectionDataSet1.UniversityFin);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
