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
using System.Globalization;
using MySql.Data.MySqlClient;

namespace PensionScheme
{

  
    public partial class NewPen : Form
    {
        double FinalRate;
        MemberBUO mem = new MemberBUO();
        PensionerUser pu = new PensionerUser();
        public void FillComboBoxType()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("SELECT * FROM `employee type`", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                typeselect.DataSource = ds;
                typeselect.DisplayMember = "Type";
                typeselect.ValueMember = "TypeID";


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }

        }
        public void PensionRateCal()
        {
            if (RetDate.Value.Year > DateTime.Now.Year || (RetDate.Value.Month > DateTime.Now.Month && RetDate.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            try
            {
              
                PensionerUser pp = mem.PensionCal(DateTime.ParseExact(l5.Text.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture), RetDate.Value, Convert.ToDouble(lBSalary.Text));
                lPension.Text = pp.Pension.ToString();
                l10.Text = pp.PensionRate.ToString(); 
                typeselect.SelectedValue = pp.Type.ToString();
                Refresh();
              
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
            }
                
        }
        public void ReserveCal() {


            if (RetDate.Value.Year > DateTime.Now.Year || (RetDate.Value.Month > DateTime.Now.Month && RetDate.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            try
            {

                PensionerUser pu=mem.ReserveCal(RetDate.Value, Convert.ToInt32(typeselect.SelectedValue.ToString()), Convert.ToDouble(l6.Text.ToString()));

                l8.Text = pu.Addition.ToString();
                l9.Text = pu.FinalReserve.ToString();
                l7.Text = pu.AdditionRate.ToString();
                Refresh();
            }
            catch(Exception ee) {
                MessageBox.Show(ee.ToString());
            }
        }
        public NewPen()
        {
            InitializeComponent();
            FillComboBoxType();
            PensionRateCal();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReserveCal();
        }

        private void NewPen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeDataSet19.Employee_Type' table. You can move, or remove it, as needed.
         //   this.employee_TypeTableAdapter.Fill(this.pensionSchemeDataSet19.Employee_Type);

        }

        private void PensionCal(object sender, EventArgs e)  
        {
            try
            {
                
                if (Convert.ToInt32(typeselect.SelectedValue.ToString()) != 2)
                {
                    FinalRate = 0;
                }
                else
                {
                    PensionRateCal();
                }
            }
            catch (Exception r) {
                
                //MessageBox.Show(r.ToString());

            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                PensionerUser pu = new PensionerUser(l1.Text.ToString(), Convert.ToDouble(l8.Text.ToString()), Convert.ToDouble(l9.Text.ToString()), Convert.ToDouble(l10.Text.ToString()), Convert.ToDouble(lPension.Text.ToString()));
                pu.Type = Convert.ToInt32(typeselect.SelectedValue.ToString());
                pu.RetirementDate = RetDate.Value;
                if (mem.UpdateRetirement(pu))

                   MessageBox.Show("Update Successful");
                else
                    MessageBox.Show("Update Failed");
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void RetDate_ValueChanged(object sender, EventArgs e)
        {
            PensionRateCal();
        }

        private void l11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            //MemberAccount ma = new MemberAccount();
            this.Hide();
            //ma.Show();

        }
    }
}
