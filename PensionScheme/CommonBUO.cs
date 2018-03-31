using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Diagnostics;

namespace PensionScheme
{
    class CommonBUO
    {
        private CommonDAO com;

        public CommonBUO()
        {
            com = new CommonDAO();

        }
        public void FillComboBox(ComboBox combo, string table, string display, string value)
        {
            try
            {
                DataTable ds = com.GetTable(table);
                combo.DataSource = ds;
                combo.DisplayMember = display;
                combo.ValueMember = value;   
            }
            catch (Exception ee)
            {
                MessageBox.Show(combo.Name+"Error"+table+"  " + display+"   " + value);
                MessageBox.Show(ee.ToString());

            }

        }
        public void FillComboBoxCondition(ComboBox combo, string table, string display, string value,string column,object input)
        {
            try
            {
                
                DataTable ds = com.DefaultSearch(table, column, input);
                combo.DataSource = ds;
                combo.DisplayMember = display;
                combo.ValueMember = value;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }

        }
        public void FillDataGrid(DataGridView dg,string table) {
            
            DataTable dt = com.GetTable(table);
            dg.DataSource = dt;
        }
        public void FillDataGridCondition(DataGridView dg, string table, string column, object input) {
            DataTable dt = com.DefaultSearch(table, column, input);
            dg.DataSource = dt;
        }

        public void TextBoxClear(TextBox[] t) {

            foreach (TextBox i in t) {
                i.Clear();
            }

        }
        
      
    }
}
