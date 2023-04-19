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
    public partial class empRpt : Form
    {
        public empRpt()
        {
            InitializeComponent();
        }

        private void empRpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toolCheckerDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.toolCheckerDataSet1.Employee);
            // TODO: This line of code loads data into the 'toolCheckerDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.toolCheckerDataSet.Employee);
            // TODO: This line of code loads data into the 'toolCheckerDataSet.ToolBox' table. You can move, or remove it, as needed.
            this.toolBoxTableAdapter.Fill(this.toolCheckerDataSet.ToolBox);
            // TODO: This line of code loads data into the 'toolCheckerDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.toolCheckerDataSet.Employee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.toolCheckerDataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.toolCheckerDataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy1(this.toolCheckerDataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
