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
    public partial class MaintenanceLauncher : Form
    {
        public GenerateReport genRpt = new GenerateReport();
        public MaintenanceLauncher()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            genRpt.ShowDialog();
        }
    }
}
