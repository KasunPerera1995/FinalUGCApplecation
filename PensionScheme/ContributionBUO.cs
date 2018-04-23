using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;

namespace PensionScheme
{
    class ContributionBUO
    {
        ContributionDAO cd = new ContributionDAO();
        CommonDAO com = new CommonDAO();
        public bool InsertCheque(ChequeVO p)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
               


                dt.Rows.Add(new Object[] { p.CHEQREC_INSTITUTE, p.CHEQREC_REFNO, p.CHEQREC_AMOUNT, p.CHEQREC_YEAR, p.CHEQREC_PERIODNO, p.CHEQREC_STATUS,   p.CHEQREC_DATE});

                return cd.InsertCheque(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }



        }
        public bool InsertContribution(ContributionVO p)
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();



                dt.Rows.Add(new Object[] { p.ContributionID1,    p.University1, p.Year1, p.Month1, p.SubDate1, p.Amount1, p.ReceiptNo1,p.OwnerID1 });
                
                return cd.InsertContribution(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public bool UpdateEntryCon(string id) {
           return com.defaultUpdate("ContributionD", "EntryVal", "1", "ContributionID", id);
        }
        public void DisplayRemain(DataGridView dg)
        {
            try
            {
                  DataTable dt = cd.LastUpdatedContribution();
               
              
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        public DataTable TalliedContribution() {

            return cd.AvailableCOntributionTallied();
        }
        public DataTable TallyEntries(string uni, string yr, string mnth) {
            return cd.TalliedContribution(uni, yr, mnth);


        }
        public DataTable ContributionList(string uni,string yr,string mnth) {
            try {
                return cd.ContributionList(uni,yr,mnth);


               }
            catch (Exception ee) {
                MessageBox.Show(ee.ToString());
                return null;
            }


        }
        public void GenExcelMethod(DataGridView ProcessView)
        {
            try
            {

                DataTable dt = new DataTable();
                dt = (DataTable)(ProcessView.DataSource);
                BindingSource bsource = new BindingSource();

                bsource.DataSource = dt;


                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = System.Threading.Thread.CurrentThread.CurrentCulture;
                dt = (DataTable)(ProcessView.DataSource);
                ds.Tables.Add(dt);
                ExcelLibrary.DataSetHelper.CreateWorkbook("D:\\PaymentReports\\Mismatch.xls", ds);
                MessageBox.Show("Excel sheet created");
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }


        }
        public bool EditContribution(ContributionVO p) {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();
                dt.Columns.Add();



                dt.Rows.Add(new Object[] { p.ContributionID1, p.University1, p.Year1, p.Month1, p.SubDate1, p.Amount1, p.ReceiptNo1, p.OwnerID1 });

                return cd.UpdateContribution(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public bool DeleteContribution(string identifier) {
            return com.DefaultDelete("ContributionPen", "ContributionID", identifier);

        }

        public bool CalSubBal(int year,double orate,double yrate) {
            bool re=true;
            bool it;
            try {

                DataTable dt = com.DefaultSearch("Employee", "Type", "1");
                
                foreach (DataRow dr in dt.Rows) {
                    string id = dr[0].ToString();
                    int prev = year - 1;
                    MessageBox.Show(prev.ToString()); 
                    DataTable obd = com.DefaultSearch("YearEndConBal", "Year", prev.ToString(), "EmployeeID", id);
                    DataTable yad = com.DefaultSearch("YearBalances", "OwnerID", id, "Year", year.ToString());

                    //MessageBox.Show(year.ToString()+"   "+id.ToString()+"      "+yad.Rows.Count.ToString()+"    "+obd.Rows.Count.ToString());
                    

                    double ob;
                    double ya;
                    int nm;

                    if (obd.Rows.Count > 0)
                        ob = Convert.ToDouble(obd.Rows[0][0].ToString());
                    else
                        ob = 0;

                    if (yad.Rows.Count > 0)
                    {
                       // MessageBox.Show(yad.Rows[0][2].ToString());
                        ya = Convert.ToDouble(yad.Rows[0][2].ToString());
                        nm = Convert.ToInt32(yad.Rows[0][3].ToString());
                    }
                    else {
                        ya = 0;
                        nm = 0;
                    }

                    double cb = ob + ya + ob * orate + ya * yrate;
                    //MessageBox.Show(cb.ToString()+"                  "+ob.ToString()+"            "+nm.ToString());
                    
                   
                   it= cd.InsertYearEndBal(year,id,ob,orate,ya,yrate,cb,nm);
                    re = re && it;
                }
                return re;

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                return false;

            }

        }
    
        
    }
}
 