using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PensionScheme
{
    class ContributionDAO
    {
        DBConnection conn = new DBConnection();

        public bool InsertCheque(DataTable dt) {
            try
            {
                string query = String.Format("insert into cheque(`CHEQREC_INSTITUTE`, `CHEQREC_REFNO`, `CHEQREC_AMOUNT`, `CHEQREC_YEAR`, `CHEQREC_PERIODNO`, `CHEQREC_STATUS`, `CHEQREC_DATE`) values(@University,@RefNo,@PaymentValue,@PaymentYear,@PaymentMonth,@Status,@SubDate)");
                MySqlParameter[] mySqlParameters = new MySqlParameter[7];
                mySqlParameters[0] = new MySqlParameter("@University", dt.Rows[0][0].ToString());
                mySqlParameters[1] = new MySqlParameter("@RefNo", dt.Rows[0][1].ToString());
                mySqlParameters[2] = new MySqlParameter("@PaymentValue", dt.Rows[0][2].ToString());
                mySqlParameters[3] = new MySqlParameter("@PaymentYear", dt.Rows[0][3].ToString());
                mySqlParameters[4] = new MySqlParameter("@PaymentMonth", dt.Rows[0][4].ToString());
                
                mySqlParameters[5] = new MySqlParameter("@Status", dt.Rows[0][5].ToString());
                mySqlParameters[6] = new MySqlParameter("@SubDate", Convert.ToDateTime(dt.Rows[0][6].ToString()).ToString("yyyy-MM-dd"));
                
                return conn.ExecuteInsertQuery(query, mySqlParameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public bool InsertContribution(DataTable dt)
        {
            try
            {
                string query = String.Format("insert into ContributionPen values(@ContributionID, @University, @Year, @Month, @SubDate, @Amount, @ReceiptNo, @OwnerID)");
                MySqlParameter[] mySqlParameters = new MySqlParameter[8];
                mySqlParameters[0] = new MySqlParameter("@ContributionID", dt.Rows[0][0].ToString());
                mySqlParameters[1] = new MySqlParameter("@University", dt.Rows[0][1].ToString());
                mySqlParameters[2] = new MySqlParameter("@Year", dt.Rows[0][2].ToString());
                mySqlParameters[3] = new MySqlParameter("@Month", dt.Rows[0][3].ToString());
                mySqlParameters[4] = new MySqlParameter("@SubDate", Convert.ToDateTime(dt.Rows[0][4].ToString()).ToString("yyyy-MM-dd"));
                mySqlParameters[5] = new MySqlParameter("@Amount", dt.Rows[0][5].ToString());
                mySqlParameters[6] = new MySqlParameter("@ReceiptNo", dt.Rows[0][6].ToString());
                mySqlParameters[7] = new MySqlParameter("@OwnerID", dt.Rows[0][7].ToString());
                return conn.ExecuteInsertQuery(query, mySqlParameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public DataTable LastUpdatedContribution() {
            string query = String.Format("select * from UpdateDB where LastConYr=YEAR(CURRENT_DATE) AND LastConMnth<MONTH(CURRENT_DATE) OR  LastConYr<YEAR(CURRENT_DATE)");
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);



        }

        public DataTable AvailableCOntributionTallied()
        {
            string query = String.Format("select distinct u.UniversityName,t.Year,t.Month,t.TotalCon from TotalColl t,Cheque c,University u,ContributionD cd where t.Year=c.CHEQREC_YEAR AND t.Month=c.CHEQREC_PERIODNO AND t.TotalCon=c.CHEQREC_AMOUNT AND u.UniversityID=c.CHEQREC_INSTITUTE AND c.CHEQREC_INSTITUTE=t.University AND cd.EntryVal=0 AND cd.Year=c.CHEQREC_YEAR AND cd.Month=c.CHEQREC_PERIODNO AND c.CHEQREC_INSTITUTE=cd.University");
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);

        }
        public DataTable TalliedContribution(string uni, string yr, string mnth) {
            try
            {
                string query = String.Format("SELECT MismatchID FROM(select distinct cd.OwnerID as MismatchID from ContributionD cd,Cheque c,University u where u.UniversityID=c.CHEQREC_INSTITUTE AND u.UniversityID=cd.University AND UniversityName='" + uni + "' AND cd.Year='" + yr + "'AND cd.Month='" + mnth + "'" + " UNION ALL select e.ID as MismatchID from Employee e,University u where u.UniversityName='" + uni + "' AND u.UniversityID=e.University AND e.Type='1' AND e.SystemValidity=true) t GROUP BY MismatchID HAVING COUNT(*) = 1 ORDER BY MismatchID");
                MySqlParameter[] mySqlParameters = new MySqlParameter[0];
                return conn.executeSelectQuery(query, mySqlParameters);
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return null;
            }

        }
        public DataTable ContributionList(string uni, string yr, string mnth)
        {
            string query = String.Format("select distinct cd.ContributionID,u.UniversityID,cd.Year,cd.Month,cd.SubDate,cd.Amount,c.CHEQREC_REFNO,cd.OwnerID from ContributionD cd,Cheque c,University u where u.UniversityID=c.CHEQREC_INSTITUTE AND u.UniversityID=cd.University AND UniversityName='" + uni + "' AND cd.Year='" + yr + "'AND cd.Month='" + mnth + "' AND CHEQREC_Year='" + yr + "' AND CHEQREC_PERIODNO='" + mnth + "'");
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);



        }
        public bool UpdateContribution(DataTable dt) {
            try
            {
                string query = String.Format("update ContributionPen set ContributionID=@ContributionID, University=@University, Year=@Year,Month=@Month, SubDate=@SubDate, Amount=@Amount, ReceiptNo=@ReceiptNo, OwnerID=@OwnerID where ContributionID=@ContributionID");
                MySqlParameter[] mySqlParameters = new MySqlParameter[8];
                mySqlParameters[0] = new MySqlParameter("@ContributionID", dt.Rows[0][0].ToString());
                mySqlParameters[1] = new MySqlParameter("@University", dt.Rows[0][1].ToString());
                mySqlParameters[2] = new MySqlParameter("@Year", dt.Rows[0][2].ToString());
                mySqlParameters[3] = new MySqlParameter("@Month", dt.Rows[0][3].ToString());
                mySqlParameters[4] = new MySqlParameter("@SubDate", Convert.ToDateTime(dt.Rows[0][4].ToString()).ToString("yyyy-MM-dd"));
                mySqlParameters[5] = new MySqlParameter("@Amount", dt.Rows[0][5].ToString());
                mySqlParameters[6] = new MySqlParameter("@ReceiptNo", dt.Rows[0][6].ToString());
                mySqlParameters[7] = new MySqlParameter("@OwnerID", dt.Rows[0][7].ToString());
                return conn.ExecuteUpdateQuery(query, mySqlParameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
    }
}
