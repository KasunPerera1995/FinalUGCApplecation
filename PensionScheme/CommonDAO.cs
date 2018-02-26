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
            mySqlParameters[0] = new MySqlParameter("@dinputName", inputName);
            return conn.executeSelectQuery(query, mySqlParameters);
        }
        public DataTable DefaultSearch(string tableName, string column1Name, object input1Name, string column2Name, object input2Name) {
            string query = string.Format("select * from " + tableName + " where " + column1Name + " = @dinput1Name AND " + column2Name + " = @dinput2Name");
            MySqlParameter[] mySqlParameters = new MySqlParameter[2];
            mySqlParameters[0] = new MySqlParameter("@dinput1Name", input1Name);
            mySqlParameters[1] = new MySqlParameter("@dinput2Name", input2Name);
            return conn.executeSelectQuery(query, mySqlParameters);

        }
        public DataTable DefaultSearch(string tableName, string column1Name, object input1Name, string column2Name, object input2Name,string column3Name,object input3Name)
        {
           
                string query = string.Format("select * from " + tableName + " where " + column1Name + " = @dinput1Name AND " + column2Name + " = @dinput2Name AND " + column3Name + " = @dinput3Name");
                MySqlParameter[] mySqlParameters = new MySqlParameter[3];
               // MessageBox.Show(input1Name.ToString() + "   " + input2Name.ToString() + "   " + input3Name.ToString() + "   ");
                mySqlParameters[0] = new MySqlParameter("@dinput1Name", input1Name);
                mySqlParameters[1] = new MySqlParameter("@dinput2Name", input2Name);
                mySqlParameters[2] = new MySqlParameter("@dinput3Name", input3Name);

                //MessageBox.Show(mySqlParameters[0].Value.ToString() + "   " + mySqlParameters[1].Value.ToString() + "   " + mySqlParameters[2].Value.ToString() + "   ");

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
