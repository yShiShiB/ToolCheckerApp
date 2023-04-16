using System.Drawing;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class HRLauncher
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
            btnReport = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnReport
            // 
            btnReport.Location = new Point(225, 125);
            btnReport.Margin = new Padding(2, 2, 2, 2);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(109, 20);
            btnReport.TabIndex = 16;
            btnReport.Text = "Generate Report";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(239, 184);
            btnLogout.Margin = new Padding(2, 2, 2, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(78, 20);
            btnLogout.TabIndex = 17;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // HRLauncher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnLogout);
            Controls.Add(btnReport);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HRLauncher";
            Text = "HRLauncher";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReport;
        private Button btnLogout;
    }
}