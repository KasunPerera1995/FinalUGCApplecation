using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace PensionScheme
{
    class PaymentBUO
    {
        PaymentDAO pd = new PaymentDAO();
        public void Notifications(ListView listView1)
        {
            try
            {
                int cYr = Convert.ToInt32(DateTime.Now.Year.ToString());
                int cMnth = Convert.ToInt32(DateTime.Now.Month.ToString());
                int oMnth = cMnth - 2;
                int oYr = cYr;
                if (oMnth <= 0)
                {
                    oMnth = oMnth + 12;
                    oYr = oYr - 1;
                }

                listView1.Items.Clear();
                
                DataTable dt=pd.NumberofNotificationsinPeriod(oYr, oMnth, cYr, cMnth);
                

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dt.Rows[i].ItemArray[0].ToString());

                    item.SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                    //item.SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                    // item.SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                    listView1.Items.Add(item);
                    if (Convert.ToInt32(dt.Rows[i][1].ToString()) >= 2)
                    {
                        item.BackColor = Color.LightSkyBlue;
                        //val = false;

                    }

                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
        }
    }
}
