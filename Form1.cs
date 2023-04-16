using System;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmpLogin_Click(object sender, EventArgs e)
        {
            MaintenanceLauncher ML1 = new MaintenanceLauncher();
            ML1.ShowDialog();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            HRLauncher HR1 = new HRLauncher();
            HR1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
