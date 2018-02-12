using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PensionScheme
{
    class ComplaintUser
    {
        private int id;
        private string type;
        private string ownerID;
        private string complain;
        private bool read;

        public ComplaintUser(string type, string ownerID, string complain, bool read)
        {
            this.type = type;
            this.ownerID = ownerID;
            this.complain = complain;
            this.read = read;
        }

        public ComplaintUser(int id, string type, string ownerID, string complain, bool read)
        {
            this.id = id;
            this.type = type;
            this.ownerID = ownerID;
            this.complain = complain;
            this.read = read;
        }
        public ComplaintUser(DataGridViewRow r)
        {
            this.id = Convert.ToInt32(r.Cells[0].Value.ToString());
            this.type = r.Cells[1].Value.ToString();
            this.ownerID = r.Cells[2].Value.ToString();
            this.complain = r.Cells[3].Value.ToString();
            this.read = Convert.ToBoolean(r.Cells[4].Value.ToString());


        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string OwnerID { get => ownerID; set => ownerID = value; }
        public string Complain { get => complain; set => complain = value; }
        public bool Read { get => read; set => read = value; }
    }
}
