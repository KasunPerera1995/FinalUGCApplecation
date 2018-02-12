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
        private int age;

        public DependentUser() { }
        public DependentUser(string id, string name, int type, string relatedEmployee, int age)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.relatedEmployee = relatedEmployee;
            this.age = age;
        }

        public DependentUser(DataGridViewRow r) {
            this.id = r.Cells[0].Value.ToString();
            this.name = r.Cells[1].Value.ToString();
            this.type = Convert.ToInt32(r.Cells[2].Value.ToString());
            this.relatedEmployee = r.Cells[3].Value.ToString();
            this.age = Convert.ToInt32(r.Cells[4].Value.ToString());


        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Type { get => type; set => type = value; }
        public string RelatedEmployee { get => relatedEmployee; set => relatedEmployee = value; }
        public int Age { get => age; set => age = value; }
    }
}
