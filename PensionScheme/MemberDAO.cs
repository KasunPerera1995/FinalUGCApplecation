using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace PensionScheme
{
    class MemberDAO
    {

        private DBConnection conn;

        public MemberDAO(){

            conn = new DBConnection();
        }


       

        public bool InsertMember(DataTable dt) {
            try
            {
                string query = string.Format("insert into Employee values( @NIC, @MemName,@DOB,@ServiceStartDate,@PensionReg,'1',@Uni,@Post,@Academic,'1',3,'0',@salary,'0',@Bank,@ActNo,@TBasicSalary,@TAllowances,@password,NULL,@Email)");
                MySqlParameter[] mySqlParameter = new MySqlParameter[15];
                mySqlParameter[0] = new MySqlParameter("@NIC", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@MemName", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@DOB", (Convert.ToDateTime(dt.Rows[0][2].ToString())).ToString("yyyy-MM-dd"));
                mySqlParameter[3] = new MySqlParameter("@ServiceStartDate", (Convert.ToDateTime(dt.Rows[0][3].ToString())).ToString("yyyy-MM-dd"));
                mySqlParameter[4] = new MySqlParameter("@PensionReg", (Convert.ToDateTime(dt.Rows[0][4].ToString())).ToString("yyyy-MM-dd"));
                mySqlParameter[5] = new MySqlParameter("@Uni", dt.Rows[0][5].ToString());
                mySqlParameter[6] = new MySqlParameter("@Post", dt.Rows[0][6].ToString());
                mySqlParameter[7] = new MySqlParameter("@Academic", Convert.ToBoolean(dt.Rows[0][7].ToString()));
                mySqlParameter[8] = new MySqlParameter("@salary", dt.Rows[0][8].ToString());
                mySqlParameter[9] = new MySqlParameter("@Bank", dt.Rows[0][9].ToString());
                mySqlParameter[10] = new MySqlParameter("@ActNo", dt.Rows[0][10].ToString());
                mySqlParameter[11] = new MySqlParameter("@TBasicSalary", dt.Rows[0][11].ToString());
                mySqlParameter[12] = new MySqlParameter("@TAllowances", dt.Rows[0][12].ToString());
                mySqlParameter[13] = new MySqlParameter("@password", dt.Rows[0][13].ToString());
                mySqlParameter[14] = new MySqlParameter("@Email", MySqlDbType.VarChar);
                mySqlParameter[14].Value = dt.Rows[0][14].ToString();

                return conn.ExecuteInsertQuery(query,mySqlParameter);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false;
            }


        }
        public DataTable ViewMember()
        {
                string query = String.Format("SELECT `ID`, `Name`, `DOB`, `ServiceStartDate`, `PensionSchemeRegisteredDate`, `Type`, `University`, `Post`, `Acadamic`, `SystemValidity`, `DependentStatus`, `TotalContribution`, `Salary`, `Pension`, `Bank`, `PaymentActNo`, `BasicSalary`, `Allowances`, `RetirementDate`, `email` FROM `employee` ", conn);
                MySqlParameter[] mySqlParameters = new MySqlParameter[0];
                return conn.executeSelectQuery(query, mySqlParameters);
        }
      public DataTable FilterMember(string column, object input) {
            string query = "select  `ID`, `Name`, `DOB`, `ServiceStartDate`, `PensionSchemeRegisteredDate`, `Type`, `University`, `Post`, `Acadamic`, `SystemValidity`, `DependentStatus`, `TotalContribution`, `Salary`, `Pension`, `Bank`, `PaymentActNo`, `BasicSalary`, `Allowances`, `RetirementDate`, `email` from Employee where " + column + "=@input";
            MySqlParameter[] mySqlParameters = new MySqlParameter[1];
            mySqlParameters[0] = new MySqlParameter("@input", input);
            return conn.executeSelectQuery(query, mySqlParameters);
        }
        public DataTable ColumnSelect()
        {
            string query = "select distinct column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME='Employee' AND column_name!='Password' order by ORDINAL_POSITION";
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);
        }
      
        public bool InsertDependent(DataTable dt)
        {
            try
            {
                string query = string.Format("insert into Dependent(`DependentID`, `DependentName`, `DependentType`, `RelatedEmployeeID`, `DependentAge`) values( @ID, @DepName,@DType,@REID,@Age)");
                MySqlParameter[] mySqlParameter = new MySqlParameter[5];
                mySqlParameter[0] = new MySqlParameter("@ID", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@DepName", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@DType", dt.Rows[0][2].ToString());
                mySqlParameter[3] = new MySqlParameter("@REID", dt.Rows[0][3].ToString());
                mySqlParameter[4] = new MySqlParameter("@Age", dt.Rows[0][4].ToString());
                return conn.ExecuteInsertQuery(query, mySqlParameter);
                
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                return false;
            }


        }
        public bool UpdateEmployee(DataTable dt) {
            try
            {
                string query = string.Format("update Employee set id=@NIC,name= @MemName,dob=@DOB,servicestartdate=@ServiceStartDate,PensionSchemeRegisteredDate=@PensionReg,Type=@Type,university=@Uni,Post=@Post,Acadamic=@Academic,SystemValidity=@SystemValidity,DependentStatus=@DepState,Salary=@salary,Pension=@Pension,Bank=@Bank,PaymentActNo=@ActNo,BasicSalary=@TBasicSalary,Allowances=@TAllowances,email=@Email where id=@NIC");
                MySqlParameter[] mySqlParameter = new MySqlParameter[18];
                mySqlParameter[0] = new MySqlParameter("@NIC", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@MemName", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@DOB", (Convert.ToDateTime(dt.Rows[0][2].ToString())).ToString("yyyy-MM-dd"));
                mySqlParameter[3] = new MySqlParameter("@ServiceStartDate", (Convert.ToDateTime(dt.Rows[0][3].ToString())).ToString("yyyy-MM-dd"));
                mySqlParameter[4] = new MySqlParameter("@PensionReg", (Convert.ToDateTime(dt.Rows[0][4].ToString())).ToString("yyyy-MM-dd"));
                mySqlParameter[5] = new MySqlParameter("@Type", dt.Rows[0][5].ToString());
                mySqlParameter[6] = new MySqlParameter("@Uni", dt.Rows[0][6].ToString());
                mySqlParameter[7] = new MySqlParameter("@Post", dt.Rows[0][7].ToString());
                mySqlParameter[8] = new MySqlParameter("@Academic", Convert.ToBoolean(dt.Rows[0][8].ToString()));
                mySqlParameter[9] = new MySqlParameter("@SystemValidity", dt.Rows[0][9].ToString());
                mySqlParameter[10] = new MySqlParameter("@DepState", dt.Rows[0][10].ToString());
                mySqlParameter[11] = new MySqlParameter("@salary", dt.Rows[0][11].ToString());
                mySqlParameter[12] = new MySqlParameter("@Pension", dt.Rows[0][12].ToString());
                mySqlParameter[13] = new MySqlParameter("@Bank", dt.Rows[0][13].ToString());
                mySqlParameter[14] = new MySqlParameter("@ActNo", dt.Rows[0][14].ToString());
                mySqlParameter[15] = new MySqlParameter("@TBasicSalary", dt.Rows[0][15].ToString());
                mySqlParameter[16] = new MySqlParameter("@TAllowances", dt.Rows[0][16].ToString());
                mySqlParameter[17] = new MySqlParameter("@Email", MySqlDbType.VarChar);
                mySqlParameter[17].Value = dt.Rows[0][17].ToString();
                
                return conn.ExecuteUpdateQuery(query, mySqlParameter);
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false;

            }

        }
        public bool InsertPensioner(DataTable dt) {
            try
            {
                string query = String.Format("insert into Pensioner values(@EID,@Addition,@FinalReserve,@PensionRate,@Pension)");
                MySqlParameter[] mySqlParameter = new MySqlParameter[5];
                mySqlParameter[0] = new MySqlParameter("@EID", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@Addition", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@FinalReserve", dt.Rows[0][2].ToString());
                mySqlParameter[3] = new MySqlParameter("@PensionRate", dt.Rows[0][3].ToString());
                mySqlParameter[4] = new MySqlParameter("@Pension", dt.Rows[0][4].ToString());
                return conn.ExecuteInsertQuery(query, mySqlParameter);
        }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
                return false;
            }
                    
                    }
        public bool UpdateRetiredEmployee(DataTable dt) {
            try {
                string query = String.Format("update Employee set Type=@Type,Pension=@Pension,RetirementDate=@RetDate where ID=@ID");
                MySqlParameter[] mySqlParameter = new MySqlParameter[4];
                mySqlParameter[0] = new MySqlParameter("@Type", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@Pension", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@RetDate", (Convert.ToDateTime(dt.Rows[0][2].ToString())).ToString("yyyy-MM-dd"));
                mySqlParameter[3] = new MySqlParameter("@ID", dt.Rows[0][3].ToString());
                return conn.ExecuteInsertQuery(query, mySqlParameter);
            }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
                return false;
            }

        }
        public bool UpdateDependent(DataTable dt) {
            try
            {
                string query = String.Format("update Dependent set DependentID=@DepID,DependentName=@DepName,DependentType=@DType,RelatedEmployeeID=@REID,DependentAge=@DAge where RelatedEmployeeID=@REID");
                MySqlParameter[] mySqlParameter = new MySqlParameter[5];
                mySqlParameter[0] = new MySqlParameter("@DepID", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@DepName", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@DType", dt.Rows[0][2].ToString());
                mySqlParameter[3] = new MySqlParameter("@REID", dt.Rows[0][3].ToString());
                mySqlParameter[4] = new MySqlParameter("@DAge", dt.Rows[0][4].ToString());
                return conn.ExecuteUpdateQuery(query, mySqlParameter);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return false;
            }
        }
        public bool UpdateAdmin(DataTable dt)
        {
            try
            {
                string query = String.Format("update Admin set OperatingEmployeeID=@NIC,LoginName=@LoginName,AccountType=@AType where AdminID=@AID");
                MySqlParameter[] mySqlParameter = new MySqlParameter[4];
                mySqlParameter[0] = new MySqlParameter("@NIC", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@LoginName", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@AType", dt.Rows[0][2].ToString());
                mySqlParameter[3] = new MySqlParameter("@AID", dt.Rows[0][3].ToString());
               
                return conn.ExecuteUpdateQuery(query, mySqlParameter);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return false;
            }
        }

        public bool InsertAdmin(DataTable dt)
        {
            try
            {
                string query = string.Format("insert into Admin(`OperatingEmployeeID`, `LoginName`, `AccountType`, `AdminPassword`) values( @EmpNIC, @LoginName,@Type,@Password)");
                MySqlParameter[] mySqlParameter = new MySqlParameter[4];
                mySqlParameter[0] = new MySqlParameter("@EmpNIC", dt.Rows[0][0].ToString());
                mySqlParameter[1] = new MySqlParameter("@LoginName", dt.Rows[0][1].ToString());
                mySqlParameter[2] = new MySqlParameter("@Type", dt.Rows[0][2].ToString());
                mySqlParameter[3] = new MySqlParameter("@Password", dt.Rows[0][3].ToString());
               
                return conn.ExecuteInsertQuery(query, mySqlParameter);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return false;
            }


        }
    }
}
