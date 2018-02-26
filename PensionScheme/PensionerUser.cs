using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PensionScheme
{
    class PensionerUser : MemberUser
    {
        private string id;
        private double addition;
        private double finalReserve;
        private double pensionRate;
        private double pension;
        private double additionRate;

        public PensionerUser()
        {
        }

        public PensionerUser(string id, double addition, double finalReserve, double pensionRate, double pension)
        {
            this.Id = id;
            this.Addition = addition;
            this.FinalReserve = finalReserve;
            this.PensionRate = pensionRate;
            this.Pension1 = pension;
        }
        public PensionerUser(DataTable dt)
        {
            this.Id = dt.Rows[0][0].ToString();
            this.Addition = Convert.ToDouble(dt.Rows[0][1].ToString());
            this.FinalReserve = Convert.ToDouble(dt.Rows[0][2].ToString());
            this.PensionRate = Convert.ToDouble(dt.Rows[0][3].ToString());
            this.Pension1 = Convert.ToDouble(dt.Rows[0][4].ToString());
        }
        public string Id { get => id; set => id = value; }
        public double Addition { get => addition; set => addition = value; }
        public double FinalReserve { get => finalReserve; set => finalReserve = value; }
        public double PensionRate { get => pensionRate; set => pensionRate = value; }
        public double Pension1 { get => pension; set => pension = value; }
        public double AdditionRate { get => additionRate; set => additionRate = value; }

        
    }
}
