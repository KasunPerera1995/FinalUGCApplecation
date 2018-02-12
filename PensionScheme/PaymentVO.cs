using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionScheme
{
    class PaymentVO
    {
        private int PaymentID;
        private string OwnerID;
        private double PaymentValue;
        private bool Approval;
        private int PaymentMonth;
        private int PaymentYear;
        private int PaymentBank;
        private string AccountNo;
        private DateTime PaymentSubDate;
        private int VoucherNo;
        private int Type;

        public PaymentVO(string ownerID, double paymentValue, bool approval, int paymentMonth, int paymentYear, int paymentBank, string accountNo, DateTime paymentSubDate, int voucherNo, int type)
        {
            OwnerID = ownerID;
            PaymentValue = paymentValue;
            Approval = approval;
            PaymentMonth = paymentMonth;
            PaymentYear = paymentYear;
            PaymentBank = paymentBank;
            AccountNo = accountNo;
            PaymentSubDate = paymentSubDate;
            VoucherNo = voucherNo;
            Type = type;
        }
     /*   public PaymentVO(DataTable dt) {
            OwnerID = dt.Rows[0][1].ToString();
            PaymentValue = paymentValue;
            Approval = approval;
            PaymentMonth = paymentMonth;
            PaymentYear = paymentYear;
            PaymentBank = paymentBank;
            AccountNo = accountNo;
            PaymentSubDate = paymentSubDate;
            VoucherNo = voucherNo;
            Type = type;


        }
        */
        public int PaymentID1 { get => PaymentID; set => PaymentID = value; }
        public string OwnerID1 { get => OwnerID; set => OwnerID = value; }
        public double PaymentValue1 { get => PaymentValue; set => PaymentValue = value; }
        public bool Approval1 { get => Approval; set => Approval = value; }
        public int PaymentMonth1 { get => PaymentMonth; set => PaymentMonth = value; }
        public int PaymentYear1 { get => PaymentYear; set => PaymentYear = value; }
        public int PaymentBank1 { get => PaymentBank; set => PaymentBank = value; }
        public string AccountNo1 { get => AccountNo; set => AccountNo = value; }
        public DateTime PaymentSubDate1 { get => PaymentSubDate; set => PaymentSubDate = value; }
        public int VoucherNo1 { get => VoucherNo; set => VoucherNo = value; }
        public int Type1 { get => Type; set => Type = value; }
    }
}
