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
    class DBConnection
    {

        private MySqlDataAdapter myAdapter;
        private MySqlConnection conn;
        

        public DBConnection()
        {
            myAdapter = new MySqlDataAdapter();
            conn = new MySqlConnection("server = localhost; user id = root; database = pen");
        }
        private MySqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State ==
                        ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public DataTable executeSelectQuery(String _query, MySqlParameter[] mySqlParameter)
        {
            MySqlCommand myCommand = new MySqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(mySqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
                return dataTable;
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.ToString());
                return null;
            }
            finally
            {

            }
            
        }
        public bool ExecuteInsertQuery(String _query, MySqlParameter[] mySqlParameter)
        {
            MySqlCommand myCommand = new MySqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(mySqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.ToString());
                return false;
            }
            finally
            {
            }
            
        }
        public bool ExecuteUpdateQuery(String _query, MySqlParameter[] mySqlParameter)
        {
            MySqlCommand myCommand = new MySqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(mySqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.ToString());
                return false;
            }
            finally
            {
            }

            
        }
        public bool ExecuteDeleteQuery(String _query, MySqlParameter[] mySqlParameter)
        {
            MySqlCommand myCommand = new MySqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(mySqlParameter);
                myAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException ee)
            {
                MessageBox.Show(ee.ToString());
                return false;
            }
            finally
            {
            }


        }
    }
}
