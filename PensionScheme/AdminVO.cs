using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PensionScheme
{
    class AdminVO
    {
        private string operatingEmployeeID;
        private string loginName;
        private int accountType;
        private int adminID;
        private string adminPassword;
       
        public string OperatingEmployeeID { get => operatingEmployeeID; set => operatingEmployeeID = value; }
        public string LoginName { get => loginName; set => loginName = value; }
        public int AccountType { get => accountType; set => accountType = value; }
        public int AdminID { get => adminID; set => adminID = value; }
        public string AdminPassword { get => adminPassword; set => adminPassword = value; }

        public AdminVO() { }

        public AdminVO(string operatingEmployeeID, string loginName, int accountType)
        {
            OperatingEmployeeID = operatingEmployeeID;
            LoginName = loginName;
            AccountType = accountType;
        }

        public AdminVO(string operatingEmployeeID, string loginName, int accountType, string adminPassword)
        {
            this.operatingEmployeeID = operatingEmployeeID;
            this.loginName = loginName;
            this.accountType = accountType;
            this.adminPassword = adminPassword;
        }

        public AdminVO(string operatingEmployeeID, string loginName, int accountType, int adminID, string adminPassword)
        {
            this.operatingEmployeeID = operatingEmployeeID;
            this.loginName = loginName;
            this.accountType = accountType;
            this.adminID = adminID;
            this.adminPassword = adminPassword;
        }

        public AdminVO(string operatingEmployeeID, string loginName, int accountType, int adminID)
        {
            this.operatingEmployeeID = operatingEmployeeID;
            this.loginName = loginName;
            this.accountType = accountType;
            this.adminID = adminID;
        }
    }
}
