using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PensionScheme
{
    class DependentUser
    {
        private string id;
        private string name;
        private int type;
        private string relatedEmployee;
        private DateTime DOB;
        private bool status;

        public DependentUser() { }
        public DependentUser(string id, string name, int type, string relatedEmployee, DateTime DOB)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.relatedEmployee = relatedEmployee;
            this.DOB = DOB;
        }

        public DependentUser(DataGridViewRow r) {
            this.id = r.Cells[0].Value.ToString();
            this.name = r.Cells[1].Value.ToString();
            this.type = Convert.ToInt32(r.Cells[2].Value.ToString());
            this.relatedEmployee = r.Cells[3].Value.ToString();
            this.DOB = Convert.ToDateTime(r.Cells[4].Value.ToString());
            this.status = Convert.ToBoolean(r.Cells[5].Value.ToString());

        }

        public DependentUser(string id, string name, int type, string relatedEmployee, DateTime dOB, bool status)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.relatedEmployee = relatedEmployee;
            DOB = dOB;
            this.status = status;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
        public string RelatedEmployee { get => relatedEmployee; set => relatedEmployee = value; }
        public DateTime DOB1 { get => DOB; set => DOB = value; }
        public bool Status { get => status; set => status = value; }
    }
}
