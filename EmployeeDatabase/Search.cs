using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDatabase
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empData.employeedata' table. You can move, or remove it, as needed.
            this.employeedataTableAdapter.Fill(this.empData.employeedata);
            empDataBindingSource.DataSource = this.empData.employeedata;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.Trim().Length==0 )
            {
                this.employeedataTableAdapter.Fill(this.empData.employeedata);
                empDataBindingSource.DataSource = this.empData.employeedata;
                MessageBox.Show("Search field cannot be empty!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var searchQuery = from data in this.empData.employeedata
                                  where data.Full_Name.Contains(tbSearch.Text) || data.First_Name.Contains(tbSearch.Text) || data.Last_Name.Contains(tbSearch.Text)
                                  select data;

                empDataBindingSource.DataSource = searchQuery.CopyToDataTable();
               
            }
        }

        
    }
}
