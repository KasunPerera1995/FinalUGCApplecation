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
                string query = String.Format("select p.OwnerID, count(p.Approval) as Approvals from PensionScheme.PensionPayment p where p.Approval = 0 And((p.PaymentMonth >= @lMnth AND p.PaymentYear < @uYr AND p.PaymentYear=@lYr) OR (p.PaymentMonth < @uMnth AND p.PaymentYear > @lYr AND p.PaymentYear=@uYr) OR (p.PaymentMonth >= @lMnth AND p.PaymentYear = @uYr AND p.PaymentYear=@lYr AND p.PaymentMonth<@uMnth) OR (p.PaymentYear>@lYr AND p.PaymentMonth<@uYr)   ) group by p.OwnerID");
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
        
        }

}
