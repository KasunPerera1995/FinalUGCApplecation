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
using System.Threading;



namespace PensionScheme
{
    public partial class MemberAccount : Form 
    {

        CommonBUO cb = new CommonBUO();
        MemberBUO mem = new MemberBUO();
       Boolean Academic;

        public void SelectAca() {

            if (A.Checked)
            {
                Academic = true;
            }
            else if (NonA.Checked) {
                Academic = false;
            }
        }
        public MemberAccount()
        {
            InitializeComponent();

            //ComboBoxes and DatagridViews
            mem.ViewMember(dataGridView1);
            cb.FillComboBox(CEID, "Employee", "ID", "ID");
            cb.FillComboBox(Uni,"University","UniversityName","UniversityID");
            cb.FillComboBox(Bank,"Bank","BankName","BankID");
            cb.FillComboBox(DType, "dependenttype", "DependentType", "DependentTypeID");
            cb.FillDataGrid(dataGridView2, "Dependent");
            mem.FillComboBoxColumn(ColumnS);
            cb.FillDataGrid(ComplaintGrid, "Complain");
           
            LoadMyDetails();
            //clock
            timer1.Start();
        }
    
        public void cleartxt()
        {
            NIC.Clear();
            MemName.Clear();
            ActNo.Clear();
            TBasicSalary.Clear();
            TAllowances.Clear();
        }

        
        private void SubmitEmployee_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32((NIC.Text.ToString()).Length) != 10)
            {
                MessageBox.Show("Invalid NIC");
                return;
            }

            if (DOB.Value.Year > DateTime.Now.Year || (DOB.Value.Month > DateTime.Now.Month && DOB.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }

            if (ServiceStartDate.Value.Year > DateTime.Now.Year || (ServiceStartDate.Value.Month > DateTime.Now.Month && ServiceStartDate.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            if (PensionReg.Value.Year > DateTime.Now.Year || (PensionReg.Value.Month > DateTime.Now.Month && PensionReg.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            

            try
            {   
                double salary;
                salary = (Convert.ToDouble(TBasicSalary.Text.ToString())) + (Convert.ToDouble(TAllowances.Text.ToString()));
                MemberUser mu=new MemberUser(NIC.Text.ToString(),MemName.Text.ToString(),DOB.Value, ServiceStartDate.Value, PensionReg.Value,Convert.ToInt32(Uni.SelectedValue.ToString()),Convert.ToInt32(Post.SelectedValue.ToString()),Academic,salary,Convert.ToInt32(Bank.SelectedValue.ToString()),ActNo.Text.ToString(),Convert.ToDouble(TBasicSalary.Text.ToString()),Convert.ToDouble(TAllowances.Text.ToString()),mem.HashCode("password123"),Email.Text.ToString());
                MemberBUO mbu = new MemberBUO();

                if (mbu.RegisterMember(mu))
                    MessageBox.Show("Update Successful");
                else
                    MessageBox.Show("Update Failed");

                cb.FillComboBox(DType, "dependenttype", "DependentType", "DependentTypeID");
               cleartxt();
                cb.FillComboBox(CEID,"Employee","ID","ID");
              

            }


            catch (Exception ex)
            {
                MessageBox.Show("Invalid Entry");
            }
            cb.FillComboBox(CEID, "Employee", "ID", "ID");
           

        }
        
        private void A_CheckedChanged(object sender, EventArgs e)
        {
            Academic = true;
            CommonBUO cb = new CommonBUO();
            cb.FillComboBoxCondition(Post, "Post", "PostName", "PostID","Academic",Convert.ToBoolean(A.Checked.ToString().ToString()));
        }

        private void NonA_CheckedChanged(object sender, EventArgs e)
        {
            Academic = false;
        }

   
        
        private void MemberAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void ColumnS_SelectedValueChanged(object sender, EventArgs e)
        {
            

            
            if (ColumnS.SelectedValue.ToString() != "System.Data.DataRowView" && ColumnS.SelectedValue != null)
            {
                cb.FillComboBox(Filter, "Employee", ColumnS.SelectedValue.ToString(), ColumnS.SelectedValue.ToString());
                
            }
           
        }

        private void Filter_SelectedValueChanged(object sender, EventArgs e)
        {
            

            if (ColumnS.SelectedValue.ToString() != "System.Data.DataRowView" && ColumnS.SelectedValue != null)
            {

                mem.ViewMember(dataGridView1, ColumnS.SelectedValue.ToString(), Filter.SelectedValue.ToString());
            }
            
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MemberUser mu = new MemberUser(this.dataGridView1.CurrentRow);
                mem.MemberFormOpen(mu);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        

     
        

     

        

        

        private void Submit_Click(object sender, EventArgs e)
        {
            DependentUser dp = new DependentUser(TDID.Text.ToString() ,TDName.Text.ToString(),Convert.ToInt32(DType.SelectedValue.ToString()),CEID.SelectedValue.ToString(),Convert.ToInt32(TDAge.Text.ToString()));
            if (mem.RegisterDependent(dp))
                MessageBox.Show("Update Successful");
            else
                MessageBox.Show("Update Failed");
            dataGridView2.Refresh();
            TDID.Clear();
            TDName.Clear();
            TDAge.Clear();

            cb.FillDataGrid(dataGridView2, "Dependent");
            //ViewDependent();
            
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DependentUser du = new DependentUser(this.dataGridView2.CurrentRow);
            mem.EditDependentForm(du);
           // EditDependent();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                mem.ViewMember(dataGridView1);
                
            }
            catch (Exception ee)
            {
                 MessageBox.Show(ee.ToString());
            }
        }

     
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // EditDependent();
            DependentUser du = new DependentUser(this.dataGridView2.CurrentRow);
            mem.EditDependentForm(du);
        }

        
        private void button2_Click_1(object sender, EventArgs e)
        {
            cb.FillDataGrid(dataGridView2, "Dependent");
            //ViewDependent();
            mem.ViewMember(dataGridView1);
            //ViewEmployee();
        }

        
       

        private void ComplaintGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ComplaintUser cu = new ComplaintUser(this.ComplaintGrid.CurrentRow);
            mem.EditComplaintForm(cu);

        }

        private void ComplaintGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ComplaintUser cu = new ComplaintUser(this.ComplaintGrid.CurrentRow);
            mem.EditComplaintForm(cu);

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            cb.FillDataGrid(ComplaintGrid,"Complain");
            //ComplainFill();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Time.Text = DateTime.Now.ToString();

        }

        private void RefreshAcc_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            cb.FillComboBox(Filter, "Employee", ColumnS.SelectedValue.ToString(), ColumnS.SelectedValue.ToString());
           MessageBox.Show(mem.HashCode("Kas"));
            //Search();
            //FilterData();
        }

        private void MemberAccount_FormClosed(object sender, FormClosedEventArgs e)
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

        private void MemberAccount_FormClosing(object sender, FormClosingEventArgs e)
        {

           // Application.Exit();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        public void LoadMyDetails() {
            //MessageBox.Show(Log.LoginName + Log.OperatingEmployee + Log.Type);
            LoginName.Text = Log.LoginName;
            MyID.Text = Log.OperatingEmployee;
            Type.Text = Log.Type;
            

        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
