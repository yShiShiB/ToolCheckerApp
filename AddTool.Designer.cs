using System.Drawing;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class AddTool
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
            this.inputToolDescription = new System.Windows.Forms.TextBox();
            this.lblToolDescription = new System.Windows.Forms.Label();
            this.btnAddToolConfirmation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.inputToolID = new System.Windows.Forms.TextBox();
            this.lblToolID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputToolDescription
            // 
            this.inputToolDescription.Location = new System.Drawing.Point(366, 118);
            this.inputToolDescription.Name = "inputToolDescription";
            this.inputToolDescription.Size = new System.Drawing.Size(341, 31);
            this.inputToolDescription.TabIndex = 0;
            // 
            // lblToolDescription
            // 
            this.lblToolDescription.AutoSize = true;
            this.lblToolDescription.Location = new Point(220, 124);
            this.lblToolDescription.Name = "lblToolDescription";
            this.lblToolDescription.Size = new System.Drawing.Size(140, 25);
            this.lblToolDescription.TabIndex = 1;
            this.lblToolDescription.Text = "Tool Description";
            // 
            // btnAddToolConfirmation
            // 
            this.btnAddToolConfirmation.Location = new Point(220, 273);
            this.btnAddToolConfirmation.Name = "btnAddToolConfirmation";
            this.btnAddToolConfirmation.Size = new System.Drawing.Size(112, 34);
            this.btnAddToolConfirmation.TabIndex = 2;
            this.btnAddToolConfirmation.Text = "Add Tool";
            this.btnAddToolConfirmation.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new Point(390, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // inputToolID
            // 
            this.inputToolID.Location = new Point(366, 155);
            this.inputToolID.Name = "inputToolID";
            this.inputToolID.Size = new System.Drawing.Size(341, 31);
            this.inputToolID.TabIndex = 12;
            // 
            // lblToolID
            // 
            this.lblToolID.AutoSize = true;
            this.lblToolID.Location = new Point(281, 161);
            this.lblToolID.Name = "lblToolID";
            this.lblToolID.Size = new System.Drawing.Size(79, 25);
            this.lblToolID.TabIndex = 13;
            this.lblToolID.Text = "Tool ID#";
            // 
            // AddTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToolID);
            this.Controls.Add(this.inputToolID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddToolConfirmation);
            this.Controls.Add(this.lblToolDescription);
            this.Controls.Add(this.inputToolDescription);
            this.Name = "AddTool";
            this.Text = "AddTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputToolDescription;
        private Label lblToolDescription;
        private Button btnAddToolConfirmation;
        private Button btnCancel;
        private TextBox inputToolID;
        private Label lblToolID;
    }
}