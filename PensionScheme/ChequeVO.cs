using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionScheme
{
    class ChequeVO
    {
        private int chequeID;
        private int cHEQREC_INSTITUTE;
        private string cHEQREC_REFNO;
        private double cHEQREC_AMOUNT;
        private int cHEQREC_YEAR;
        private int cHEQREC_PERIODNO;
        private int cHEQREC_STATUS;
        private DateTime cHEQREC_DATE;

        public ChequeVO(int cHEQREC_INSTITUTE, string cHEQREC_REFNO, double cHEQREC_AMOUNT, int cHEQREC_YEAR, int cHEQREC_PERIODNO, int cHEQREC_STATUS, DateTime cHEQREC_DATE)
        {

            this.cHEQREC_INSTITUTE = cHEQREC_INSTITUTE;
            this.cHEQREC_REFNO = cHEQREC_REFNO;
            this.cHEQREC_AMOUNT = cHEQREC_AMOUNT;
            this.cHEQREC_YEAR = cHEQREC_YEAR;
            this.cHEQREC_PERIODNO = cHEQREC_PERIODNO;
            this.cHEQREC_STATUS = cHEQREC_STATUS;
            this.cHEQREC_DATE = cHEQREC_DATE;
            
        }

        public int ChequeID { get => chequeID; set => chequeID = value; }
        public int CHEQREC_INSTITUTE { get => cHEQREC_INSTITUTE; set => cHEQREC_INSTITUTE = value; }
        public string CHEQREC_REFNO { get => cHEQREC_REFNO; set => cHEQREC_REFNO = value; }
        public double CHEQREC_AMOUNT { get => cHEQREC_AMOUNT; set => cHEQREC_AMOUNT = value; }
        public int CHEQREC_YEAR { get => cHEQREC_YEAR; set => cHEQREC_YEAR = value; }
        public int CHEQREC_PERIODNO { get => cHEQREC_PERIODNO; set => cHEQREC_PERIODNO = value; }
        public int CHEQREC_STATUS { get => cHEQREC_STATUS; set => cHEQREC_STATUS = value; }
        public DateTime CHEQREC_DATE { get => cHEQREC_DATE; set => cHEQREC_DATE = value; }
    }
}
