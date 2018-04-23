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
    public partial class Balances : Form
    {
        CommonBUO cb = new CommonBUO();
        public Balances()
        {
            InitializeComponent();
            cb.FillDataGrid(BalancesView, "YearEndConBal");
        }

        private void Balances_Load(object sender, EventArgs e)
        {

        }

        private void Balances_FormClosing(object sender, FormClosingEventArgs e)
        {
            YearEndConBalancePro y = new YearEndConBalancePro();
            y.Show();
        }
    }
}
