using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PensionScheme
{
    public partial class InsertPayment : Form
    {
        ContributionBUO cb = new ContributionBUO();
        CommonBUO com = new CommonBUO();
        PaymentBUO pb = new PaymentBUO();
        public InsertPayment()
        {
            InitializeComponent();
            tReceiptNo.Text = pb.CalVoucherNo().ToString();
            com.FillComboBox(tBank, "Bank", "BankName", "BankID");
            com.FillComboBox(tOwnerID, "Pensioner", "EmployeID", "EmployeID");
            com.FillComboBox(Type, "`employee type`", "Type","TypeID");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (tPeriod.Value.Year > DateTime.Now.Year || (tPeriod.Value.Month > DateTime.Now.Month && tPeriod.Value.Year == DateTime.Now.Year))
            {
                MessageBox.Show("Do not Enter Future Periods");
                return;
            }
            int voucherNo = pb.CalVoucherNo();
            tReceiptNo.Text = voucherNo.ToString();
            PaymentVO pv = new PaymentVO(tOwnerID.SelectedValue.ToString(), Convert.ToDouble(tAmount.Text), false, Convert.ToInt32(tPeriod.Value.Month.ToString()), Convert.ToInt32(tPeriod.Value.Year.ToString()), Convert.ToInt32(tBank.SelectedValue.ToString()),AccountNo.Text.ToString(), tSubDate.Value, voucherNo, Convert.ToInt32(Type.SelectedValue.ToString()));
            
            if (pb.InsertPayment(pv))
            {
                
                    MessageBox.Show("Insert Successful");
                //tContributionID.Clear();
                tAmount.Clear();
                tReceiptNo.Text = pb.CalVoucherNo().ToString() ;

            }
            else
                MessageBox.Show("Record Failed");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tSubDate_Validated(object sender, EventArgs e)
        {

        }

        private void tSubDate_Validating(object sender, CancelEventArgs e)
        {
            if (tSubDate.Value > DateTime.Now)
            {
                MessageBox.Show("Do not enter future periods");
                e.Cancel = true;
            }
        }

        private void Period(object sender, EventArgs e)
        {

        }

        private void tPeriod_Validating(object sender, CancelEventArgs e)
        {
            if (tPeriod.Value > DateTime.Now)
            {
                MessageBox.Show("Do not enter future periods");
                e.Cancel = true;
            }
        }
    }
}
