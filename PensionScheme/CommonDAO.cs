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
    class CommonDAO
    {
        private DBConnection conn;

        public CommonDAO()
        {

            conn = new DBConnection();
        }
        public DataTable DefaultSearch(string tableName, string columnName, object inputName)
        {
            string query = string.Format("select * from " + tableName + " where " + columnName + " = @dinputName");
            MySqlParameter[] mySqlParameters = new MySqlParameter[1];
            mySqlParameters[0] = new MySqlParameter("@dinPutName", inputName);
            return conn.executeSelectQuery(query, mySqlParameters);
        }

        public DataTable GetTable(string tableName) {
            string query = string.Format("select * from " + tableName);
            MySqlParameter[] mySqlParameters = new MySqlParameter[0];
            return conn.executeSelectQuery(query, mySqlParameters);
        }
        
        public bool defaultUpdate(string table,string column,object input,string identifiercolumn,object identifier)
        {
            string query = string.Format("update " + table + " set " + column + " =@input where " + identifiercolumn + " = @identifier");
            MySqlParameter[] mySqlParameters = new MySqlParameter[2];
            mySqlParameters[0] = new MySqlParameter("@input",input);
            mySqlParameters[1] = new MySqlParameter("@identifier", identifier);
            return conn.ExecuteUpdateQuery(query,mySqlParameters);
        }
        public bool DefaultDelete(string table, string identifiercoumn, string identifier) {
            
            string query = String.Format("delete from "+table+" where "+identifiercoumn+"=@identifier");
            MySqlParameter[] mySqlParameters = new MySqlParameter[1];
            mySqlParameters[0] = new MySqlParameter("@identifier", identifier);
            return conn.ExecuteDeleteQuery(query, mySqlParameters);

        }
    }
}
