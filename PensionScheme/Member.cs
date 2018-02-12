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
    public partial class Member : Form
    {
        //Fill combo boxes
        CommonBUO cb = new CommonBUO();
        MemberBUO mem = new MemberBUO();
     
        
       

        
        public Member() {
            InitializeComponent();
            cb.FillComboBox(UniversitySelect, "University", "UniversityName", "UniversityID");
            cb.FillComboBox(BankSelect, "Bank", "BankName", "BankID");
            cb.FillComboBox(PostSelect, "Post", "PostName", "PostID");
            cb.FillComboBox(TypeSelect,"`employee type`","Type","TypeID");
            cb.FillComboBox(DependentStatus, "dependenttype", "DependentType", "DependentTypeID");
            
        }

        
        int uni, post, dep, type,bank;
        public Member(int tuni,int tpost,int tdep,int ttype,int tbank)
        {

            InitializeComponent();
            cb.FillComboBox(UniversitySelect, "University", "UniversityName", "UniversityID");
            cb.FillComboBox(BankSelect, "Bank", "BankName", "BankID");
            cb.FillComboBox(PostSelect, "Post", "PostName", "PostID");

            cb.FillComboBox(TypeSelect, "`employee type`", "Type", "TypeID");                              //Active constructer
            cb.FillComboBox(DependentStatus, "dependenttype", "DependentType", "DependentTypeID");
            
            this.uni = tuni;
            this.post = tpost;
            this.dep = tdep;
            this.type = ttype;
            this.bank = tbank;
            
        }

        //Retirement Date for Pensioner
        public void RetDateMethod() {

            if (Convert.ToInt32(TypeSelect.SelectedValue.ToString()) != 1)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                    MySqlDataAdapter sql = new MySqlDataAdapter("select RetirementDate from Employee where ID='" + textBox1.Text + "'", conn);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                    // MessageBox.Show(ds.Rows[0][0].ToString());
                    RetDate.Text = (Convert.ToDateTime(ds.Rows[0][0].ToString())).ToString("yyyy-MM-dd");                     
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                RetDate.Text = "Not Retired";
        }


        //Total Reserve for pensioner
        public void TotalReserve() {
            if (Convert.ToInt32(TypeSelect.SelectedValue.ToString()) == 2)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                    MySqlDataAdapter sql = new MySqlDataAdapter("select FinalReserve from Pensioner where EmployeID='"+ textBox1.Text + "'", conn);
                    DataTable ds = new DataTable();
                    sql.Fill(ds);
                   // MessageBox.Show(ds.Rows[0][0].ToString());
                    lFinalReserve.Text = ds.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                lFinalReserve.Text = "0";

        }

        //Selecting from combo boxes when initializing
        public void SelectedValues() {

            this.UniversitySelect.SelectedValue = uni;
            this.PostSelect.SelectedValue = post;
            this.TypeSelect.SelectedValue = type;
            this.DependentStatus.SelectedValue = dep;
            this.BankSelect.SelectedValue = bank;

        }

        //post validation
        bool postType;
        public  void CheckPost() {
            try
            {
                MySqlConnection conn = new MySqlConnection(@DBStr.connectionString);
                MySqlDataAdapter sql = new MySqlDataAdapter("select Academic from Post where PostID='"+ this.PostSelect.SelectedValue + "'", conn);
                DataTable ds = new DataTable();
                sql.Fill(ds);
                 postType=Convert.ToBoolean(ds.Rows[0][0].ToString());
                
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }


        }

        //Update
        

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }


        //Retirement
        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(TypeSelect.SelectedValue.ToString()) == 1)
            {
                MemberUser mu = new MemberUser();
                mu.Nic = this.textBox1.Text.ToString();
                mu.Name = this.textBox2.Text.ToString();
                mu.University = Convert.ToInt32(this.UniversitySelect.SelectedValue.ToString());//this.textBox3.Text.ToString();
                mu.Acadamic = Convert.ToBoolean(this.AcadamicC.SelectedItem.ToString());
                mu.PensionSchemeRegisteredDate = Convert.ToDateTime(this.textBox14.Text.ToString());
                mu.TotalContribution= Convert.ToDouble(this.textBox12.Text.ToString());
                mu.Salary = Convert.ToDouble(this.textBox18.Text.ToString());
                mem.RetirementFormOpen(mu);
                this.Hide();
            }
            else
                MessageBox.Show("Already Retired");
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        //contribution history
        private void ContributionHistory_Click(object sender, EventArgs e)
        {
           // this.Hide();
            ContributionHistory ch = new ContributionHistory(textBox1.Text);
            ch.Show();
            ch.TEmpID.Text = textBox1.Text;
        }

        //payment history
        private void PaymentHistory_Click(object sender, EventArgs e)
        {
          //  this.Hide();
            PaymentHistory ph = new PaymentHistory(textBox1.Text);
            ph.Show();
            ph.TEmpID.Text = textBox1.Text;
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {

                if (postType != Convert.ToBoolean(AcadamicC.SelectedItem.ToString()))
                {
                    MessageBox.Show("Invalid Post");
                    return;
                }
                MemberUser mu = new MemberUser(textBox1.Text.ToString(), textBox2.Text.ToString(), (Convert.ToDateTime(textBox4.Text.ToString())), (Convert.ToDateTime(textBox13.Text.ToString())), (Convert.ToDateTime(textBox14.Text.ToString())), Convert.ToInt32(TypeSelect.SelectedValue.ToString()), Convert.ToInt32(UniversitySelect.SelectedValue.ToString()), Convert.ToInt32(PostSelect.SelectedValue.ToString()), Convert.ToBoolean(AcadamicC.SelectedItem.ToString()), Convert.ToBoolean(ValidityC.SelectedItem.ToString()), Convert.ToInt32(DependentStatus.SelectedValue.ToString()), Convert.ToDouble(textBox12.Text.ToString()), (Convert.ToDouble(textBox18.Text.ToString()) + Convert.ToDouble(textBox19.Text.ToString())), Convert.ToDouble(textBox5.Text.ToString()), Convert.ToInt32(BankSelect.SelectedValue.ToString()), textBox6.Text.ToString(), Convert.ToDouble(textBox18.Text.ToString()), Convert.ToDouble(textBox19.Text.ToString()), Email.Text.ToString());
                if (mem.UpdateEmployee(mu))
                {
                    MessageBox.Show("Update Successfull");
                }
                else
                    MessageBox.Show("Update Failed");
                //UpdateEmployee();
            }
            catch (NullReferenceException ee) {
                MessageBox.Show("All Fields must be filled");
            }
        }

        

      

      

      

      

      
        

        private void Delete_Click(object sender, EventArgs e)
        {
            var window = MessageBox.Show("Delete "+ textBox1 .Text+ " Completely?", "Are you sure?", MessageBoxButtons.YesNo);

            if (window == DialogResult.Yes)
            {
                if (mem.DeleteMember(textBox1.Text.ToString()))
                {
                    MessageBox.Show("Delete Successful");
                    this.Close();
                }
                else
                    MessageBox.Show("Delete Failed");

            }
            else
            {
                MessageBox.Show("Process Aborted");
            }

        }

       

       

        private void TypeSelect_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You can not change Type");
        }

       

       
        private void PostSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            CheckPost();
        }

        

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (!(String.IsNullOrEmpty(textBox18.Text)) || !(String.IsNullOrEmpty(textBox19.Text)))
                {
                    textBox11.Text = (Convert.ToDouble(textBox18.Text.ToString()) + Convert.ToDouble(textBox19.Text.ToString())).ToString();
                }
            }
            catch (Exception ee) {
                //MessageBox.Show(ee.ToString());
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (!(String.IsNullOrEmpty(textBox18.Text)) || !(String.IsNullOrEmpty(textBox19.Text)))
                {
                    textBox11.Text = (Convert.ToDouble(textBox18.Text.ToString()) + Convert.ToDouble(textBox19.Text.ToString())).ToString();
                }
            }
            catch (Exception ee)
            {
                //MessageBox.Show(ee.ToString());
            }

        }

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (Email.Text.Length > 0 && Email.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(Email.Text.Trim()))
                {
                    MessageBox.Show("check email id");
                    Email.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        

        private void Member_Load(object sender, EventArgs e)
        {
        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.TypeSelect.SelectedValue = type;
        }
    }
}
