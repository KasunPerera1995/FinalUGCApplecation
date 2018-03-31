using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionScheme
{
    class ContributionVO
    {
        private int ContributionID;
        private int University;
        private int Year;
        private int Month;
        private DateTime SubDate;
        private double Amount;
        private string ReceiptNo;
        private string OwnerID;

        public int ContributionID1 { get => ContributionID; set => ContributionID = value; }
        public int University1 { get => University; set => University = value; }
        public int Year1 { get => Year; set => Year = value; }
        public int Month1 { get => Month; set => Month = value; }
        public DateTime SubDate1 { get => SubDate; set => SubDate = value; }
        public double Amount1 { get => Amount; set => Amount = value; }
        public string ReceiptNo1 { get => ReceiptNo; set => ReceiptNo = value; }
        public string OwnerID1 { get => OwnerID; set => OwnerID = value; }

        public ContributionVO(DataTable dt) {
        ContributionID=Convert.ToInt32(dt.Rows[0][1].ToString());
        University= Convert.ToInt32(dt.Rows[0][2].ToString());
        Year= Convert.ToInt32(dt.Rows[0][3].ToString());
        Month= Convert.ToInt32(dt.Rows[0][4].ToString());
        SubDate= Convert.ToDateTime(dt.Rows[0][5].ToString());
        Amount= Convert.ToDouble(dt.Rows[0][6].ToString());
        ReceiptNo=dt.Rows[0][7].ToString();
        OwnerID= dt.Rows[0][8].ToString();


    }

        public ContributionVO(int contributionID, int university, int year, int month, DateTime subDate, double amount, string receiptNo, string ownerID)
        {
            ContributionID = contributionID;
            University = university;
            Year = year;
            Month = month;
            SubDate = subDate;
            Amount = amount;
            ReceiptNo = receiptNo;
            OwnerID = ownerID;
        }
    }
}
