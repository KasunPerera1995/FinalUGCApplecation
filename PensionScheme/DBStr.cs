using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace PensionScheme
{
    static class DBStr
    {
        public static String connectionString = "server=localhost;user id=root;database=pen";//(ConfigurationManager.ConnectionStrings["PensionScheme.Properties.Settings.PensionSchemeConnectionString"].ConnectionString).ToString();
        public static String conFinancialSection = @"server=localhost;user id=root;database=financialsection";
    }
}
