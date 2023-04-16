using System.Drawing;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class MaintenanceLauncher
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
            this.btnReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(103, 54);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 16);
            this.labelUserName.TabIndex = 9;
            this.labelUserName.Text = "%username";
            // 
            // lblUserNameMessage
            // 
            this.lblUserNameMessage.AutoSize = true;
            this.lblUserNameMessage.Location = new System.Drawing.Point(103, 38);
            this.lblUserNameMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserNameMessage.Name = "lblUserNameMessage";
            this.lblUserNameMessage.Size = new System.Drawing.Size(84, 16);
            this.lblUserNameMessage.TabIndex = 8;
            this.lblUserNameMessage.Text = "Signed in as:";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(89, 175);
            this.btnReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(125, 27);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 100);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Check Out Tool";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 130);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Check In Tool";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(103, 234);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 29);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // MaintenanceLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 270);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.lblUserNameMessage);
            this.Controls.Add(this.btnReport);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaintenanceLauncher";
            this.Text = "MaintenanceLauncher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUserName;
        private Label lblUserNameMessage;
        private Button btnReport;
        private Button button1;
        private Button button2;
        private Button btnLogout;
    }
}