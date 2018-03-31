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
using System.IO;
using MySql.Data.MySqlClient;
namespace PensionScheme
{
    public partial class PensionPayment : Form
    {
        CommonBUO cb = new CommonBUO();
        PaymentBUO pb = new PaymentBUO();
        public PensionPayment()
        {
            InitializeComponent();
            PensionHistorySelect();//get the all pension details
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void PensionHistorySelect()
        {
            try
            {
                if (ShowAll.Checked)//if select all
                {
                    cb.FillDataGridCondition(PensionHistory, "PensionPayment", "Type", 2);
                    return;


                }//if select date
                pb.PaymentGridFill(PensionHistory, PensionPeriodSelect.Value, "pension");
               
            }
            catch (Exception en)
            {
                MessageBox.Show(en.ToString());
            }


        }
        private void PensionMonth_ValueChanged(object sender, EventArgs e)
        {
            PensionHistorySelect();
            Refresh();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            pb.WriteData(PensionPeriodSelect.Value,2);
        }

        private void PensionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PensionPayment_Load(object sender, EventArgs e)
        {

        }

        private void PensionProcess_Click(object sender, EventArgs e)
        {

        }

        private void ShowAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowAll_CheckStateChanged(object sender, EventArgs e)
        {
            PensionHistorySelect();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PenPro p3 = new PenPro();
            p3.Show();
        }

        private void PensionHistory_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PensionPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                try
                {
                    if ((Application.OpenForms[i].Name) == "Payment")
                    {
                        Application.OpenForms[i].Show();
                        break;
                    }
                    
                }
                catch (Exception ee) {
                    MessageBox.Show(ee.ToString());
                }


            }
        }
    }
}
