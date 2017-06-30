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

namespace EmployeeDatabase
{
    public partial class AddEmployee : Form
    {
        
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empData.employeedata' table. You can move, or remove it, as needed.
            this.employeedataTableAdapter.Fill(this.empData.employeedata);
            employeedataBindingSource.DataSource = this.empData.employeedata;
            DefaultFormSettings(false);
            btnNew.Enabled = true;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                employeedataBindingSource.EndEdit();
                employeedataTableAdapter.Update(this.empData.employeedata);
                DefaultFormSettings(false);
                btnNew.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            employeedataBindingSource.ResetBindings(false);
            DefaultFormSettings(true);
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultFormSettings(true);
            tbFullname.Focus();
            this.empData.employeedata.AddemployeedataRow(this.empData.employeedata.NewemployeedataRow());
            employeedataBindingSource.MoveLast();
            btnNew.Enabled = false;
            
        }

        private void DefaultFormSettings(bool value)
        {
            Control[] ctr = { tbFullname, tbFname, tbLname, tbPosition, tbResident, tbEmail, tbDept, tbAddress,tbMobile, cbGender, dtDob, dtHire };
            foreach (Control c in ctr)
            {
                c.ResetText();
                c.Enabled = value;
            }
        }
    }
}
