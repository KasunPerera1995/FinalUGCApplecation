using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PensionScheme
{
    public partial class Admin : Form
    {
        CommonBUO cb = new CommonBUO();
        MemberBUO mb = new MemberBUO();
        public Admin()
        {
            InitializeComponent();
            cb.FillComboBox(Type, "AdminType", "TypeName", "TypeID");
            cb.FillDataGrid(AdminView, "Admin");
           // AdminView.Columns["AdminID"].Visible = false;
            AdminView.Columns["AdminPassword"].Visible = false;
        }

        public void AdminViewText() {
            tNIC.Text = this.AdminView.CurrentRow.Cells[3].Value.ToString();
            Type.SelectedValue = this.AdminView.CurrentRow.Cells[2].Value.ToString();
            tLoginName.Text = this.AdminView.CurrentRow.Cells[0].Value.ToString();
            ID.Text = this.AdminView.CurrentRow.Cells[4].Value.ToString();

        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminViewText();
                    }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void AdminView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminViewText();
        }

        private void AdminView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminViewText();
        }

        private void AdminView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminViewText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminVO ad = new AdminVO(tNIC.Text,tLoginName.Text,Convert.ToInt32(Type.SelectedValue.ToString()),Convert.ToInt32(ID.Text));
            if (mb.UpdateAdmin(ad))
                MessageBox.Show("Update Successful");
            else
                MessageBox.Show("Update Failed");
            cb.FillDataGrid(AdminView, "Admin");
            AdminView.Columns["AdminPassword"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // mb.DeleteAdmin(this.AdminView.CurrentRow.Cells[3].Value.ToString());

            var window = MessageBox.Show("Delete Admin with ID " + this.AdminView.CurrentRow.Cells[3].Value.ToString() + " Completely?", "Are you sure?", MessageBoxButtons.YesNo);

            if (window == DialogResult.Yes)
            {
                if (mb.DeleteAdmin(ID.Text))
                {
                    MessageBox.Show("Delete Successful");
                    
                }
                else
                    MessageBox.Show("Delete Failed");

                cb.FillDataGrid(AdminView, "Admin");
                AdminView.Columns["AdminPassword"].Visible = false;

            }
            else
            {
                MessageBox.Show("Process Aborted");
            }

        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            AdminVO ad = new AdminVO(tNIC.Text, tLoginName.Text, Convert.ToInt32(Type.SelectedValue.ToString()), mb.HashCode("Admin"));
            if (mb.RegisterAdmin(ad))
                MessageBox.Show("Update Successful");
            else
                MessageBox.Show("Update Failed");

            cb.FillDataGrid(AdminView, "Admin");
            AdminView.Columns["AdminPassword"].Visible = false;
            Refresh();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name == "MainAdmin")
                    {

                        Application.OpenForms[i].Show();
                    }



                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
