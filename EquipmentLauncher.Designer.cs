using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class EquipmentLauncher
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.lblUserNameMessage = new System.Windows.Forms.Label();
            this.btnAddTool = new System.Windows.Forms.Button();
            this.btnRemoveTool = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(340, 103);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(104, 25);
            this.labelUserName.TabIndex = 11;
            this.labelUserName.Text = "%username";
            // 
            // lblUserNameMessage
            // 
            this.lblUserNameMessage.AutoSize = true;
            this.lblUserNameMessage.Location = new System.Drawing.Point(340, 78);
            this.lblUserNameMessage.Name = "lblUserNameMessage";
            this.lblUserNameMessage.Size = new System.Drawing.Size(112, 25);
            this.lblUserNameMessage.TabIndex = 10;
            this.lblUserNameMessage.Text = "Signed in as:";
            // 
            // btnAddTool
            // 
            this.btnAddTool.Location = new System.Drawing.Point(340, 165);
            this.btnAddTool.Name = "btnAddTool";
            this.btnAddTool.Size = new System.Drawing.Size(124, 34);
            this.btnAddTool.TabIndex = 12;
            this.btnAddTool.Text = "Add Tool";
            this.btnAddTool.UseVisualStyleBackColor = true;
            // 
            // btnRemoveTool
            // 
            this.btnRemoveTool.Location = new System.Drawing.Point(340, 205);
            this.btnRemoveTool.Name = "btnRemoveTool";
            this.btnRemoveTool.Size = new System.Drawing.Size(124, 34);
            this.btnRemoveTool.TabIndex = 13;
            this.btnRemoveTool.Text = "Remove Tool";
            this.btnRemoveTool.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(340, 381);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(340, 297);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(156, 34);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // EquipmentLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRemoveTool);
            this.Controls.Add(this.btnAddTool);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.lblUserNameMessage);
            this.Name = "EquipmentLauncher";
            this.Text = "EquipmentLauncher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUserName;
        private Label lblUserNameMessage;
        private Button btnAddTool;
        private Button btnRemoveTool;
        private Button btnLogout;
        private Button btnReport;
    }
}