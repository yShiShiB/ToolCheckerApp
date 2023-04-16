using System;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    public partial class HRLauncher : Form
    {
        public HRLauncher()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.ShowDialog();
        }
    }
}
