using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    public partial class GenerateReport : Form
    {
        public rptForm rptInv = new rptForm();
        public empRpt rptEmp = new empRpt();
        public GenerateReport()
        {
            InitializeComponent();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            rptInv.ShowDialog();
        }

        private void btnLSD_Click(object sender, EventArgs e)
        {
            string message = "No Lost, Stolen, or Damaged tools to report!";
            string title = "Report Info";
            MessageBox.Show(message, title);
        }

        private void btnEmpRpt_Click(object sender, EventArgs e)
        {
            rptEmp.ShowDialog();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
