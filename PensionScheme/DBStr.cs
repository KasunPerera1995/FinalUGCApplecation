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
        public static String connectionString = "server=192.248.15.244;user id=Kasun;database=pensionscheme";//(ConfigurationManager.ConnectionStrings["PensionScheme.Properties.Settings.PensionSchemeConnectionString"].ConnectionString).ToString();
        public static String conFinancialSection = @"server=localhost;user id=root;database=financialsection";
    }
}
