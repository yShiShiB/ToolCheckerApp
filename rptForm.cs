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
    public partial class rptForm : Form
    {
        public rptForm()
        {
            InitializeComponent();
        }

        private void rptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'toolCheckerDataSet2.ToolBox' table. You can move, or remove it, as needed.
            this.toolBoxTableAdapter1.Fill(this.toolCheckerDataSet2.ToolBox);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolBoxTableAdapter1.FillBy(this.toolCheckerDataSet2.ToolBox);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private ToolCheckerDataSetTableAdapters.ToolBoxTableAdapter GetToolBoxTableAdapter()
        //{
        //    return toolBoxTableAdapter;
        //}

        //private void rptForm_Load(object sender, EventArgs e, ToolCheckerDataSetTableAdapters.ToolBoxTableAdapter toolBoxTableAdapter)
        // {
        //     // TODO: This line of code loads data into the 'toolCheckerDataSet.ToolBox' table. You can move, or remove it, as needed.
        //     toolBoxTableAdapter.Fill(toolCheckerDataSet.ToolBox);
        //
        // }
    }
}
