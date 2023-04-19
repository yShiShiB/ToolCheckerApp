namespace ToolCheckerApp
{
    partial class empRpt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.toolCheckerDataSet = new ToolCheckerApp.ToolCheckerDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new ToolCheckerApp.ToolCheckerDataSetTableAdapters.EmployeeTableAdapter();
            this.toolCheckerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.toolBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolBoxTableAdapter = new ToolCheckerApp.ToolCheckerDataSetTableAdapters.ToolBoxTableAdapter();
            this.employeeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.toolCheckerDataSet1 = new ToolCheckerApp.ToolCheckerDataSet();
            this.employeeBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCheckerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCheckerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCheckerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource7)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.toolIDDataGridViewTextBoxColumn,
            this.toolNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource7;
            this.dataGridView1.Location = new System.Drawing.Point(12, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 498);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // employeeBindingSource5
            // 
            this.employeeBindingSource5.DataMember = "Employee";
            this.employeeBindingSource5.DataSource = this.toolCheckerDataSet;
            // 
            // toolCheckerDataSet
            // 
            this.toolCheckerDataSet.DataSetName = "ToolCheckerDataSet";
            this.toolCheckerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.toolCheckerDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // toolCheckerDataSetBindingSource
            // 
            this.toolCheckerDataSetBindingSource.DataSource = this.toolCheckerDataSet;
            this.toolCheckerDataSetBindingSource.Position = 0;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.toolCheckerDataSetBindingSource;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "Employee";
            this.employeeBindingSource2.DataSource = this.toolCheckerDataSet;
            // 
            // employeeBindingSource3
            // 
            this.employeeBindingSource3.DataMember = "Employee";
            this.employeeBindingSource3.DataSource = this.toolCheckerDataSet;
            // 
            // toolBoxBindingSource
            // 
            this.toolBoxBindingSource.DataMember = "ToolBox";
            this.toolBoxBindingSource.DataSource = this.toolCheckerDataSet;
            // 
            // toolBoxTableAdapter
            // 
            this.toolBoxTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource4
            // 
            this.employeeBindingSource4.DataMember = "Employee";
            this.employeeBindingSource4.DataSource = this.toolCheckerDataSetBindingSource;
            // 
            // employeeBindingSource6
            // 
            this.employeeBindingSource6.DataMember = "Employee";
            this.employeeBindingSource6.DataSource = this.toolCheckerDataSetBindingSource;
            // 
            // toolCheckerDataSet1
            // 
            this.toolCheckerDataSet1.DataSetName = "ToolCheckerDataSet";
            this.toolCheckerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource7
            // 
            this.employeeBindingSource7.DataMember = "Employee";
            this.employeeBindingSource7.DataSource = this.toolCheckerDataSet1;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "Employee_Name";
            this.employeeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // toolIDDataGridViewTextBoxColumn
            // 
            this.toolIDDataGridViewTextBoxColumn.DataPropertyName = "Tool ID";
            this.toolIDDataGridViewTextBoxColumn.HeaderText = "Tool ID";
            this.toolIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolIDDataGridViewTextBoxColumn.Name = "toolIDDataGridViewTextBoxColumn";
            // 
            // toolNameDataGridViewTextBoxColumn
            // 
            this.toolNameDataGridViewTextBoxColumn.DataPropertyName = "Tool Name";
            this.toolNameDataGridViewTextBoxColumn.HeaderText = "Tool Name";
            this.toolNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toolNameDataGridViewTextBoxColumn.Name = "toolNameDataGridViewTextBoxColumn";
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1220, 27);
            this.fillBy1ToolStrip.TabIndex = 1;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(56, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee Tool Report";
            // 
            // empRpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "empRpt";
            this.Text = "Employee Tool Report";
            this.Load += new System.EventHandler(this.empRpt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCheckerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCheckerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCheckerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource7)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ToolCheckerDataSet toolCheckerDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private ToolCheckerDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource toolCheckerDataSetBindingSource;
        private System.Windows.Forms.BindingSource employeeBindingSource3;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private System.Windows.Forms.BindingSource toolBoxBindingSource;
        private ToolCheckerDataSetTableAdapters.ToolBoxTableAdapter toolBoxTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource5;
        private System.Windows.Forms.BindingSource employeeBindingSource4;
        private System.Windows.Forms.BindingSource employeeBindingSource6;
        private ToolCheckerDataSet toolCheckerDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource7;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}