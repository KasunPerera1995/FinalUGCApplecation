using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PensionScheme
{
    public partial class LumpSumHistory : Form
    {
        CommonBUO cb = new CommonBUO();
        PaymentBUO pb=new PaymentBUO();
        
        public LumpSumHistory()
        {
            InitializeComponent();
            cb.FillComboBoxCondition(LumpSumSelect, "PensionPayment", "PaymentSubDate", "PaymentSubDate", "Type", 3);
            
            
            LumpSumHistoryView();
        }
        
        public void LumpSumHistoryView()
        {

            try
            {
                
                if (ShowAll.Checked)
                {
                    cb.FillDataGridCondition(LumpSumView, "PensionPayment", "Type", 3);
                    return;


                }
                pb.PaymentGridFill(LumpSumView, (Convert.ToDateTime(LumpSumSelect.SelectedValue.ToString())), "lumpsum");
                
            }
            catch (Exception en)
            {
                
            //    MessageBox.Show(en.ToString());
            }





        }

        private void LumpSumHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.PensionPayment' table. You can move, or remove it, as needed.
           // this.pensionPaymentTableAdapter.Fill(this.pensionSchemeAllTables.PensionPayment);
            // TODO: This line of code loads data into the 'pensionSchemeAllTables.LumpSumPayment' table. You can move, or remove it, as needed.
            //this.lumpSumPaymentTableAdapter.Fill(this.pensionSchemeAllTables.LumpSumPayment);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LumpSumHistoryView();
        }

        private void PeriodSelect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LumpSumView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAll_CheckStateChanged(object sender, EventArgs e)
        {
            LumpSumHistoryView();
        }

        private void ShowAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LumpSum p7 = new LumpSum();
            p7.Show();
        }

        private void LumpSumHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            try {

                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)

                {

                    if ((Application.OpenForms[i].Name == "Payment"))
                    {

                        Application.OpenForms[i].Show();
                    }            

            }
        }

            catch (Exception ee) {
                    MessageBox.Show(ee.ToString());
                }
}

        private void LumpSumView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
