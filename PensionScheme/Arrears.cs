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
    public partial class Arrears : Form
    {
        CommonBUO cb = new CommonBUO();
        PaymentBUO pb = new PaymentBUO();
        public Arrears()
        {
            InitializeComponent();
            pb.ArrearOwnerCombo(ID);
            //FillArrearOwner();
            cb.FillDataGrid(dataGridView1, "Arrears");
           // ArrearView();
            Period.Value = DateTime.Today;
        }
        /*public void FillArrearOwner()
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
        */
      
        private void Arrears_Load(object sender, EventArgs e)
        {
           
        }
        public void Insert()
        {
            
            if (Period.Value.Year > DateTime.Now.Year || (Period.Value.Month > DateTime.Now.Month && Period.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            if (String.IsNullOrEmpty(Value.Text) || (Convert.ToInt32(Value.Text)) == 0)
                {
                    MessageBox.Show("Enter Arrear Value");
                    return;
                }
            ArrearVO ar = new ArrearVO(ID.SelectedValue.ToString(), Convert.ToInt32(Period.Value.Year.ToString()), Convert.ToInt32(Period.Value.Month.ToString()), Convert.ToDouble(Value.Text));
            if (pb.InsertArrear(ar))
            {
                MessageBox.Show("Insert Successful");
                dataGridView1.Refresh();
            }
            else {
                MessageBox.Show("Update Failed");
            }

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Insert();
            Refresh();
            cb.FillDataGrid(dataGridView1, "Arrears");
           // ArrearView();
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
