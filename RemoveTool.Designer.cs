using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class RemoveTool
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRemoveTool = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.inputToolID = new System.Windows.Forms.TextBox();
            this.lblToolID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID",
            "%ToolName %ToolID"});
            this.listBox1.Location = new System.Drawing.Point(304, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 204);
            this.listBox1.TabIndex = 0;
            // 
            // btnRemoveTool
            // 
            this.btnRemoveTool.Location = new System.Drawing.Point(304, 374);
            this.btnRemoveTool.Name = "btnRemoveTool";
            this.btnRemoveTool.Size = new System.Drawing.Size(129, 34);
            this.btnRemoveTool.TabIndex = 1;
            this.btnRemoveTool.Text = "Remove Tool";
            this.btnRemoveTool.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(454, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // inputToolID
            // 
            this.inputToolID.Location = new System.Drawing.Point(304, 328);
            this.inputToolID.Name = "inputToolID";
            this.inputToolID.Size = new System.Drawing.Size(338, 31);
            this.inputToolID.TabIndex = 12;
            // 
            // lblToolID
            // 
            this.lblToolID.AutoSize = true;
            this.lblToolID.Location = new System.Drawing.Point(219, 334);
            this.lblToolID.Name = "lblToolID";
            this.lblToolID.Size = new System.Drawing.Size(79, 25);
            this.lblToolID.TabIndex = 13;
            this.lblToolID.Text = "Tool ID#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Or enter tool ID#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select a Tool to Remove";
            // 
            // RemoveTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToolID);
            this.Controls.Add(this.inputToolID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveTool);
            this.Controls.Add(this.listBox1);
            this.Name = "RemoveTool";
            this.Text = "RemoveTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button btnRemoveTool;
        private Button btnCancel;
        private TextBox inputToolID;
        private Label lblToolID;
        private Label label1;
        private Label label2;
    }
}