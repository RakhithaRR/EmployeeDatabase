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
    public partial class ViewDatabase : Form
    {
        public ViewDatabase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empData.employeedata' table. You can move, or remove it, as needed.
            this.employeedataTableAdapter.Fill(this.empData.employeedata);

        }
    }
}