using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace PensionScheme
{
    class MemberUser
    {
        private string nic;
        private string name;
        private DateTime dob;
        private DateTime serviceStartDate;
        private DateTime pensionSchemeRegisteredDate;
        private int type;
        private int university;
        private int post;
        private bool acadamic;
        private bool systemValidity;
        private int dependentStatus;
        private double totalContribution;
        private double salary;
        private double pension;
        private int bank;
        private string paymentActNo;
        private double basicSalary;
        private double allowances;
        private string password;
        private DateTime retirementDate;
        private string email;

        public MemberUser() {
        }

        public MemberUser(string nic, string name, DateTime dob, DateTime serviceStartDate, DateTime pensionSchemeRegisteredDate, int university, int post, bool acadamic, double salary, int bank, string paymentActNo, double basicSalary, double allowances, string email)
        {
            this.nic = nic;
            this.name = name;
            this.dob = dob;
            this.serviceStartDate = serviceStartDate;
            this.pensionSchemeRegisteredDate = pensionSchemeRegisteredDate;
            this.university = university;
            this.post = post;
            this.acadamic = acadamic;
            this.salary = salary;
            this.bank = bank;
            this.paymentActNo = paymentActNo;
            this.basicSalary = basicSalary;
            this.allowances = allowances;
            this.email = email;
        }

        public MemberUser(string nic, string name, DateTime dob, DateTime serviceStartDate, DateTime pensionSchemeRegisteredDate, int university, int post, bool acadamic, double salary, int bank, string paymentActNo, double basicSalary, double allowances, string password,string email)
        {
            this.nic = nic;
            this.name = name;
            this.dob = dob;
            this.serviceStartDate = serviceStartDate;
            this.pensionSchemeRegisteredDate = pensionSchemeRegisteredDate;
            this.university = university;
            this.post = post;
            this.acadamic = acadamic;
            this.salary = salary;
            this.bank = bank;
            this.paymentActNo = paymentActNo;
            this.basicSalary = basicSalary;
            this.allowances = allowances;
            this.password = password;
            this.email = email;
        }
        public MemberUser(string nic, string name, DateTime dob, DateTime serviceStartDate, DateTime pensionSchemeRegisteredDate, int type, int university, int post, bool acadamic, bool systemValidity, int dependentStatus, double totalContribution, double salary, double pension, int bank, string paymentActNo, double basicSalary, double allowances,  string email)
        {
            
                this.nic = nic;
                this.name = name;
                this.dob = dob;
                this.serviceStartDate = serviceStartDate;
                this.pensionSchemeRegisteredDate = pensionSchemeRegisteredDate;
                this.type = type;
                this.university = university;
                this.post = post;
                this.acadamic = acadamic;
                this.systemValidity = systemValidity;
                this.dependentStatus = dependentStatus;
                this.totalContribution = totalContribution;
                this.salary = salary;
                this.pension = pension;
                this.bank = bank;
                this.paymentActNo = paymentActNo;
                this.basicSalary = basicSalary;
                this.allowances = allowances;
                //this.retirementDate = retirementDate;
                this.email = email;
            
            }
        public MemberUser(DataGridViewRow r) {
            this.nic = r.Cells[0].Value.ToString();
            this.name = r.Cells[1].Value.ToString();
            this.dob = Convert.ToDateTime(r.Cells[2].Value.ToString());
            this.serviceStartDate = Convert.ToDateTime(r.Cells[3].Value.ToString());
            this.pensionSchemeRegisteredDate = Convert.ToDateTime(r.Cells[4].Value.ToString());
            this.type = Convert.ToInt32(r.Cells[5].Value.ToString());
            this.university = Convert.ToInt32(r.Cells[6].Value.ToString());
            this.post = Convert.ToInt32(r.Cells[7].Value.ToString());
            this.acadamic = Convert.ToBoolean(r.Cells[8].Value.ToString());
            this.systemValidity = Convert.ToBoolean(r.Cells[9].Value.ToString());
            this.dependentStatus = Convert.ToInt32(r.Cells[10].Value.ToString());
            this.totalContribution = Convert.ToDouble(r.Cells[11].Value.ToString());
            this.salary = Convert.ToDouble(r.Cells[12].Value.ToString());
            this.pension = Convert.ToDouble(r.Cells[13].Value.ToString());
            this.bank = Convert.ToInt32(r.Cells[14].Value.ToString());
            this.paymentActNo = r.Cells[15].Value.ToString();
            this.basicSalary = Convert.ToDouble(r.Cells[16].Value.ToString());
            this.allowances = Convert.ToDouble(r.Cells[17].Value.ToString());
            if(!(String.IsNullOrEmpty(r.Cells[18].Value.ToString())))
           this.retirementDate = Convert.ToDateTime(r.Cells[18].Value.ToString());
            this.email = r.Cells[19].Value.ToString();

        }
        public MemberUser(DataTable r) {
            if (r.Rows.Count <= 0) {
                MessageBox.Show("Member Removed");
                return;


            }
                
            this.nic = r.Rows[0][0].ToString();
            this.name = r.Rows[0][1].ToString();
            this.dob = Convert.ToDateTime(r.Rows[0][2].ToString());
            this.serviceStartDate = Convert.ToDateTime(r.Rows[0][3].ToString());
            this.pensionSchemeRegisteredDate = Convert.ToDateTime(r.Rows[0][4].ToString());
            this.type = Convert.ToInt32(r.Rows[0][5].ToString());
            this.university = Convert.ToInt32(r.Rows[0][6].ToString());
            this.post = Convert.ToInt32(r.Rows[0][7].ToString());
            this.acadamic = Convert.ToBoolean(r.Rows[0][8].ToString());
            this.systemValidity = Convert.ToBoolean(r.Rows[0][9].ToString());
            this.dependentStatus = Convert.ToInt32(r.Rows[0][10].ToString());
            this.totalContribution = Convert.ToDouble(r.Rows[0][11].ToString());
            this.salary = Convert.ToDouble(r.Rows[0][12].ToString());
            this.pension = Convert.ToDouble(r.Rows[0][13].ToString());
            this.bank = Convert.ToInt32(r.Rows[0][14].ToString());
            this.paymentActNo = r.Rows[0][15].ToString();
            this.basicSalary = Convert.ToDouble(r.Rows[0][16].ToString());
            this.allowances = Convert.ToDouble(r.Rows[0][17].ToString());
            if (!(String.IsNullOrEmpty(r.Rows[0][18].ToString())))
                this.retirementDate = Convert.ToDateTime(r.Rows[0][18].ToString());
            this.email = r.Rows[0][19].ToString();




        }

        public string Nic { get => nic; set => nic = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public DateTime ServiceStartDate { get => serviceStartDate; set => serviceStartDate = value; }
        public DateTime PensionSchemeRegisteredDate { get => pensionSchemeRegisteredDate; set => pensionSchemeRegisteredDate = value; }
        public int Type { get => type; set => type = value; }
        public int University { get => university; set => university = value; }
        public int Post { get => post; set => post = value; }
        public bool Acadamic { get => acadamic; set => acadamic = value; }
        public bool SystemValidity { get => systemValidity; set => systemValidity = value; }
        public int DependentStatus { get => dependentStatus; set => dependentStatus = value; }
        public double TotalContribution { get => totalContribution; set => totalContribution = value; }
        public double Salary { get => salary; set => salary = value; }
        public double Pension { get => pension; set => pension = value; }
        public int Bank { get => bank; set => bank = value; }
        public string PaymentActNo { get => paymentActNo; set => paymentActNo = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public double Allowances { get => allowances; set => allowances = value; }
        public string Password { get => password; set => password = value; }
        public DateTime RetirementDate { get => retirementDate; set => retirementDate = value; }
        public string Email { get => email; set => email = value; }



    }
}
