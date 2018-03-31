using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PensionScheme
{
    class PaymentDAO
    {
        
        DBConnection conn = new DBConnection();
        public DataTable NumberofNotificationsinPeriod(int lYr, int lMnth, int uYr, int uMnth) {
            try
            {
                
                string query = String.Format("select p.OwnerID, count(p.Approval) as Approvals from PensionPayment p where p.Approval = 0 And((p.PaymentMonth >= @lMnth AND p.PaymentYear < @uYr AND p.PaymentYear=@lYr) OR (p.PaymentMonth < @uMnth AND p.PaymentYear > @lYr AND p.PaymentYear=@uYr) OR (p.PaymentMonth >= @lMnth AND p.PaymentYear = @uYr AND p.PaymentYear=@lYr AND p.PaymentMonth<@uMnth) OR (p.PaymentYear>@lYr AND p.PaymentYear<@uYr)   ) group by p.OwnerID");
                MySqlParameter[] mySqlParameters = new MySqlParameter[4];
                mySqlParameters[0] = new MySqlParameter("@lYr", lYr);
                mySqlParameters[1] = new MySqlParameter("@lMnth", lMnth);
                mySqlParameters[2] = new MySqlParameter("@uYr", uYr);
                mySqlParameters[3] = new MySqlParameter("@uMnth", uMnth);
                return conn.executeSelectQuery(query, mySqlParameters);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return null;

            }
        }
        public bool InsertArrear(DataTable dt) {
            try
            {

                string query = String.Format("insert into Arrears(OwnerID,PeriodYear,PeriodMonth,Amount) values( @ID ,@PeriodYear,@PeriodMonth,@Amount)");
                MySqlParameter[] mySqlParameters = new MySqlParameter[4];
                mySqlParameters[0] = new MySqlParameter("@ID", dt.Rows[0][0].ToString());
                mySqlParameters[1] = new MySqlParameter("@PeriodYear", dt.Rows[0][1].ToString());
                mySqlParameters[2] = new MySqlParameter("@PeriodMonth", dt.Rows[0][2].ToString());
                mySqlParameters[3] = new MySqlParameter("@Amount", dt.Rows[0][3].ToString());
                //MessageBox.Show(dt.Rows[0][0].ToString() + "    " + dt.Rows[0][1].ToString() + "    " + dt.Rows[0][2].ToString() + "    " + dt.Rows[0][3].ToString() + "    ");
                //MessageBox.Show(mySqlParameters[0].Value.ToString()+"    "+ mySqlParameters[1].Value.ToString() + "    " + mySqlParameters[2].Value.ToString() + "    " + mySqlParameters[3].Value.ToString() + "    " );
                
                return conn.ExecuteInsertQuery(query, mySqlParameters);
            }
            catch(Exception ee) {
                MessageBox.Show(ee.ToString());
                    return false;
            }
        }

        public bool InsertPayment(DataTable dt) {
            try
            {
                string query = String.Format("insert into PensionPayment(OwnerID,PaymentValue,PaymentMonth,PaymentYear,PaymentBank,AccountNo,PaymentSubDate,VoucherNo,Type,Approval) values(@OwnerID,@PaymentValue,@PaymentMonth,@PaymentYear,@PaymentBank,@ActNo,@SubDate,@VoucherNo,@Type,0)");
                MySqlParameter[] mySqlParameters = new MySqlParameter[9];
                mySqlParameters[0] = new MySqlParameter("@OwnerID", dt.Rows[0][0].ToString());
                mySqlParameters[1] = new MySqlParameter("@PaymentValue", dt.Rows[0][1].ToString());
                mySqlParameters[3] = new MySqlParameter("@PaymentYear", dt.Rows[0][2].ToString());
                mySqlParameters[2] = new MySqlParameter("@PaymentMonth", dt.Rows[0][3].ToString());
                
                mySqlParameters[4] = new MySqlParameter("@PaymentBank", dt.Rows[0][4].ToString());
                mySqlParameters[5] = new MySqlParameter("@ActNo", dt.Rows[0][5].ToString());
                mySqlParameters[6] = new MySqlParameter("@SubDate", Convert.ToDateTime(dt.Rows[0][6].ToString()).ToString("yyyy-MM-dd"));
                mySqlParameters[7] = new MySqlParameter("@VoucherNo", dt.Rows[0][7].ToString());
                mySqlParameters[8] = new MySqlParameter("@Type", dt.Rows[0][8].ToString());
                return conn.ExecuteInsertQuery(query, mySqlParameters);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return false;
            }
            }
        public DataTable PaymentProcessView()
        {
            string query = String.Format("select ID, Salary, Type, Pension, Bank, PaymentActNo FROM Employee AS e where Type = '2' AND SystemValidity = True");
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);
        }
        public DataTable Arrear(DateTime period) {
            string query = String.Format("select ID,OwnerID,PeriodYear,PeriodMonth,Amount from Arrears where PeriodYear=@year AND PeriodMonth=@month");
            MySqlParameter[] mySqlParameters = new MySqlParameter[2];
            mySqlParameters[0] = new MySqlParameter("@year", period.Year.ToString());
            mySqlParameters[1] = new MySqlParameter("@month", period.Month.ToString());
            return conn.executeSelectQuery(query, mySqlParameters);
        }
        public DataTable MaxVoucher()
        {
            string query = String.Format("select Max(VoucherNo) from PensionPayment ");
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);


        }
        public DataTable SlipList(DateTime period,int type) {
            string query = String.Format("SELECT ID,Name,University,Bank,PaymentValue,PaymentActNo FROM Employee,PensionPayment where Employee.Type=@type AND  PaymentYear=@year AND PaymentMonth=@month AND ID=OwnerID");
            MySqlParameter[] mySqlParameters = new MySqlParameter[3];
            mySqlParameters[0] = new MySqlParameter("@year", period.Year.ToString());
            mySqlParameters[1] = new MySqlParameter("@month", period.Month.ToString());
            mySqlParameters[2] = new MySqlParameter("@type", type.ToString());
            return conn.executeSelectQuery(query, mySqlParameters);

        }
        public DataTable LumpSumProView()
        {
            string query = String.Format("select ID, Name, TotalContribution, Bank, PaymentActNo, Type from Employee where Type = '3' AND SystemValidity = '1'");
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);
        }

    }

}
