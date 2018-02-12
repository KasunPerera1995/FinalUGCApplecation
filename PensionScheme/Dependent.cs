using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PensionScheme
{
    public partial class Dependent : Form
    {
        int type;
        CommonBUO com = new CommonBUO();
        MemberBUO mem = new MemberBUO();
        public Dependent(int t)
        {
            InitializeComponent();
            com.FillComboBox(CDType, "`dependenttype`", "DependentType", "DependentTypeID");
            
            this.type = t;
        }
        

        public void TypeSelect() {
            this.CDType.SelectedValue = type;

        }
        
        

        public void UpdateDependent() {
            try
            {
                DependentUser dp = new DependentUser(TDID.Text.ToString(), TDName.Text.ToString(), Convert.ToInt32(CDType.SelectedValue.ToString()), TDREID.Text.ToString(), Convert.ToInt32(TDAge.Text.ToString()));
                if (mem.UpdateDependent(dp))
                    MessageBox.Show("Update Successful");
                else
                    MessageBox.Show("Update Failed");
                                
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

        }

        
        private void Dependent_Load(object sender, EventArgs e)
        {
        
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateDependent();
            

        }

        private void CDType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var window = MessageBox.Show("Delete Dependent of " + TDREID.Text.ToString() + " Completely?", "Are you sure?", MessageBoxButtons.YesNo);

            if (window == DialogResult.Yes)
            {
                if (mem.DeleteDependent(TDREID.Text.ToString()))
                {
                    MessageBox.Show("Delete Successful");
                    this.Close();
                }
                else
                    MessageBox.Show("Delete Failed");

            }
            else
            {
                MessageBox.Show("Process Aborted");
            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TDREID_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You can not change Related Employee ID delete and add dependent again");
        }
    }
}
