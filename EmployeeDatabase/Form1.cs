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
    public partial class MainForm : Form
    {
        Form addNew = new AddEmployee();
        Form aboutNew = new AboutBox();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNew.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            aboutNew.Show();
        }
    }
}
