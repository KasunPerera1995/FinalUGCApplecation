using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace PensionScheme
{
    class MemberBUO
    {
        private MemberDAO mem;
        private CommonDAO com;
        public MemberBUO()
        {

            mem = new MemberDAO();
            com = new CommonDAO();

        }

        public bool RegisterMember(MemberUser mu)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();

                dt.Rows.Add(new Object[] { mu.Nic, mu.Name, mu.Dob, mu.ServiceStartDate, mu.PensionSchemeRegisteredDate, mu.University, mu.Post, mu.Acadamic, mu.Salary, mu.Bank, mu.PaymentActNo, mu.BasicSalary, mu.Allowances,mu.Password ,mu.Email });

                return mem.InsertMember(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


                return false;
            }

        }
        public void ViewMember(DataGridView dg)
        {
            //MessageBox.Show(dg.Name);
            DataTable dt = mem.ViewMember();
            dg.DataSource = dt;
        }

        public void ViewMember(DataGridView dg, string column, object input)
        {
            try
            {
                // MessageBox.Show();
                //Thread.Sleep(1000);
                if (column == "DOB" || column == "ServiceStartDate" || column == "PensionSchemeRegisteredDate")
                {
                    input = Convert.ToDateTime(input).ToString("yyyy-MM-dd");
                }

                DataTable dt = mem.FilterMember(column, input);
                dg.DataSource = dt;
            }
            catch (Exception ee)
            {
                MessageBox.Show(column + "   " + input.ToString());
                MessageBox.Show(ee.ToString());
            }
        }
        public void FillComboBoxColumn(ComboBox combo)
        {
            try
            {

                DataTable ds = mem.ColumnSelect();

                combo.DataSource = ds;
                combo.DisplayMember = "column_name";
                combo.ValueMember = "column_name";


            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }

        }
        public bool RegisterDependent(DependentUser d)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();


                dt.Rows.Add(new Object[] { d.Id, d.Name, d.Type, d.RelatedEmployee, d.Age });

                return mem.InsertDependent(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public bool RegisterAdmin(AdminVO d)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                


                dt.Rows.Add(new Object[] { d.OperatingEmployeeID, d.LoginName, d.AccountType, d.AdminPassword});

                return mem.InsertAdmin(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public void MemberFormOpen(MemberUser mu)
        {
            if (String.IsNullOrEmpty(mu.Nic)) {
                MessageBox.Show("Member Removed");
                return;
            }

            int u, p, d, t, b;
            u = mu.University;
            p = mu.Post;
            d = mu.DependentStatus;
            t = mu.Type;
            b = mu.Bank;
            Member mb = new Member(u, p, d, t, b);
            mb.textBox1.Text = mu.Nic;
            mb.textBox2.Text = mu.Name;
            mb.textBox4.Text = mu.Dob.ToString("yyyy-MM-dd");
            mb.textBox5.Text = mu.Pension.ToString();
            mb.textBox6.Text = mu.PaymentActNo;
            mb.AcadamicC.SelectedItem = mu.Acadamic.ToString();
            mb.textBox11.Text = mu.Salary.ToString();
            mb.textBox12.Text = mu.TotalContribution.ToString();
            mb.textBox13.Text = mu.ServiceStartDate.ToString("yyyy-MM-dd");
            mb.textBox14.Text = mu.PensionSchemeRegisteredDate.ToString("yyyy-MM-dd");
            mb.ValidityC.SelectedItem = mu.SystemValidity.ToString();
            mb.textBox18.Text = mu.BasicSalary.ToString();
            mb.textBox19.Text = mu.Allowances.ToString();
            mb.Email.Text = mu.Email;
            if (mu.Type != 1)
                mb.RetDate.Text = mu.RetirementDate.ToString("yyyy-MM-dd");
            else
                mb.RetDate.Text = "Not Retired";
            mb.Show();
            mb.Refresh();
            mb.SelectedValues();

            if (Convert.ToInt32(mb.TypeSelect.SelectedValue.ToString()) == 2)
                mb.lFinalReserve.Text = this.PensionerInfo(mu.Nic).FinalReserve.ToString();
            else
                mb.lFinalReserve.Text = "0";
            //mb.TotalReserve();
            //mb.RetDateMethod();

        }
        public void EditDependentForm(DependentUser du)
        {
            try
            {
                Dependent de = new Dependent(du.Type);
                de.TDID.Text = du.Id;
                de.TDName.Text = du.Name;

                de.TDREID.Text = du.RelatedEmployee;
                de.TDAge.Text = du.Age.ToString();
                de.Show();
                de.TypeSelect();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }

        }
        public void EditComplaintForm(ComplaintUser cu)
        {
            Complaint c = new Complaint();
            c.ID.Text = cu.Id.ToString();
            c.Type.Text = cu.Type;
            c.OwnerID.Text = cu.OwnerID;
            c.Complain.Text = cu.Complain;
            c.Reviewed.Text = cu.Read.ToString();
            c.Show();


        }
        public bool UpdateEmployee(MemberUser mu)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();

                dt.Rows.Add(new Object[] { mu.Nic, mu.Name, mu.Dob, mu.ServiceStartDate, mu.PensionSchemeRegisteredDate, mu.Type, mu.University, mu.Post, mu.Acadamic, mu.SystemValidity, mu.DependentStatus, mu.Salary, mu.Pension, mu.Bank, mu.PaymentActNo, mu.BasicSalary, mu.Allowances, mu.Email });

                return mem.UpdateEmployee(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


                return false;
            }


        }
        public PensionerUser PensionerInfo(string eid)
        {
            DataTable dt = com.DefaultSearch("Pensioner", "EmployeID", eid);
            PensionerUser pen = new PensionerUser(dt);
            return pen;



        }
        public void RetirementFormOpen(MemberUser pu) {
            try
            {
                NewPen np = new NewPen();
                np.l1.Text = pu.Nic;
                np.l2.Text = pu.Name;
                np.l3.Text = pu.University.ToString();//this.textBox3.Text.ToString();
                np.l4.Text = pu.Acadamic.ToString();
                np.l5.Text = pu.PensionSchemeRegisteredDate.ToString("yyyy-MM-dd");
                np.l6.Text = pu.TotalContribution.ToString();
                np.lBSalary.Text = pu.Salary.ToString();
                np.RetDate.Value = DateTime.Today;
                np.Show();
                
                np.PensionRateCal();

            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
            }

        }
        public PensionerUser PensionCal(DateTime penregdate,DateTime retdate,double salary)
        {
            try
            {
                Rate r = new Rate();
                DateTime ds = penregdate;
                DateTime dr = retdate;
                TimeSpan t = dr - ds;
                int years = t.Days / 365;
                
                int type;

                
                if (years >= 30)
                {
                    r.Id = 3;
                    type = 2;
                }
                else if (years >= 25)
                {
                    r.Id = 2;
                    type = 2;
                }
                else if (years >= 20)
                {
                    r.Id = 1;
                    type = 2;
                }
                else
                {

                    r.Id = 5;
                    type = 3;
                 
                }

                //Database sql
                DataTable dt=com.DefaultSearch("Rates","ID",r.Id);
                r.Rate1 = Convert.ToDouble(dt.Rows[0][2].ToString());
                PensionerUser pu = new PensionerUser();
               
                pu.PensionRate = r.Rate1;
                
                pu.Type = type;
                pu.Pension = r.Rate1*salary;
                return pu;
            
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return null;
            }

        }
        public PensionerUser ReserveCal(DateTime retdate,int type,double totalcontribution)
        {


            try
            {
                Rate r = new Rate();
                DataTable dt=com.DefaultSearch("Rates", "ID", "4");
                r.Rate1 = Convert.ToDouble(dt.Rows[0][2].ToString());
                

                DateTime dr = retdate;
                DateTime n = DateTime.Now.Date;

                TimeSpan t = n - dr;
                int latency = Convert.ToInt32(t.Days);

                double Addition;                                //Calculations

                //MessageBox.Show("Latency is "+latency.ToString()+" Rate is " + rate.ToString() + " Addition is " + Addition.ToString());


                if (type == 2)
                {
                    Addition = totalcontribution * latency * r.Rate1 / 365;
                    Addition = Math.Round(Addition, 2);
                }
                else
                {
                    Addition = 0;
                    Addition = Math.Round(Addition, 2);
                }

                PensionerUser pu = new PensionerUser();
                double FinalReserve = totalcontribution + Addition;
                pu.Addition = Addition;
                pu.FinalReserve = FinalReserve;
                pu.AdditionRate = r.Rate1;
                return pu;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return null;
            }
        }
        public bool UpdateRetirement(PensionerUser pu) {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();

                dt.Rows.Add(new object[] { pu.Id, pu.Addition, pu.FinalReserve, pu.PensionRate, pu.Pension1 });

                bool s1 = mem.InsertPensioner(dt);

                DataTable du = new DataTable();
                du.Columns.Add();
                du.Columns.Add();
                du.Columns.Add();
                du.Columns.Add();

                du.Rows.Add(new object[] { pu.Type, pu.Pension1, pu.RetirementDate ,pu.Id});
                bool s2 = mem.UpdateRetiredEmployee(du);

                return (s1 && s2);
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
                return false;
            }
            }

        public bool DeleteMember(string id) {
            return com.DefaultDelete("Employee", "ID", id);
        }
        public bool DeleteDependent(string id) {
            return com.DefaultDelete("Dependent","RelatedEmployeeID",id);

        }
        public bool DeleteAdmin(string id) {
            return com.DefaultDelete("Admin", "AdminID", id);

        }
        public bool UpdateDependent(DependentUser du) {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();

                dt.Rows.Add(new object[] { du.Id, du.Name, du.Type, du.RelatedEmployee, du.Age });
                return mem.UpdateDependent(dt);
            }
            catch(Exception ee) {
                MessageBox.Show(ee.ToString());
                return false;
            }
        }

        public MemberUser SearchByID(string id) {
            DataTable dt=mem.FilterMember("ID", id);
            MemberUser mb = new MemberUser(dt);
            return mb;

        }
        public string HashCode(string data) {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(data));
            StringBuilder returnvalue = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++) {
                returnvalue.Append(hashdata[i].ToString());

            }
            return returnvalue.ToString();
        }

        public bool UpdateAdmin(AdminVO du) {

            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();

                dt.Rows.Add(new object[] { du.OperatingEmployeeID, du.LoginName, du.AccountType,du.AdminID });
                return mem.UpdateAdmin(dt);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return false;
            }

        }
        public bool CheckAdminPassword(string id, string password)
        {
            
                DataTable dt = com.DefaultSearch("Admin", "LoginName", id, "AdminPassword", HashCode(password));
                return (dt.Rows.Count > 0);
            
            
        }
        public bool ChangeAdminPassword(string id, string newpassword, string oldpassword)
        {
            if (CheckAdminPassword(id, oldpassword))
            {
                return com.defaultUpdate("Admin", "AdminPassword", HashCode(newpassword), "LoginName", id);
            }
            else
                return false;

        }

        public AdminVO LoginAdmin(string userName,string password) {
            DataTable dt = com.DefaultSearch("Admin", "LoginName", userName, "AdminPassword", HashCode(password));
            AdminVO ad = new AdminVO();
            ad.OperatingEmployeeID = dt.Rows[0][3].ToString();
            ad.LoginName = userName;
            ad.AdminPassword = password;
            ad.AccountType = Convert.ToInt32(dt.Rows[0][2].ToString());
            ad.AdminID = Convert.ToInt32(dt.Rows[0][4].ToString());
            return ad;
        }

        
    }
}
