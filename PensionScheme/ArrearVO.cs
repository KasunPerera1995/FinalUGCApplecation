using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionScheme
{
    class ArrearVO
    {
        private int id;
        private string ownerID;
        private int periodYear;
        private int periodMonth;
        private double amount;
        private bool paid;

        public ArrearVO(string ownerID, int periodYear, int periodMonth, double amount)
        {
            this.ownerID = ownerID;
            this.periodYear = periodYear;
            this.periodMonth = periodMonth;
            this.amount = amount;
        }

        public int Id { get => id; set => id = value; }
        public string OwnerID { get => ownerID; set => ownerID = value; }
        public int PeriodYear { get => periodYear; set => periodYear = value; }
        public int PeriodMonth { get => periodMonth; set => periodMonth = value; }
        public double Amount { get => amount; set => amount = value; }
        public bool Paid { get => paid; set => paid = value; }
    }
}
