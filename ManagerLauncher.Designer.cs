using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class ManagerLauncher
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
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblUserNameMessage = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(123, 135);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(156, 34);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(123, 175);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(156, 34);
            this.btnRemoveUser.TabIndex = 1;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(123, 265);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(156, 34);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // lblUserNameMessage
            // 
            this.lblUserNameMessage.AutoSize = true;
            this.lblUserNameMessage.Location = new System.Drawing.Point(146, 57);
            this.lblUserNameMessage.Name = "lblUserNameMessage";
            this.lblUserNameMessage.Size = new System.Drawing.Size(112, 25);
            this.lblUserNameMessage.TabIndex = 3;
            this.lblUserNameMessage.Text = "Signed in as:";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(146, 82);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(104, 25);
            this.labelUserName.TabIndex = 4;
            this.labelUserName.Text = "%username";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(146, 362);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // ManagerLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 428);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.lblUserNameMessage);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddUser);
            this.Name = "ManagerLauncher";
            this.Text = "ManagerLauncher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddUser;
        private Button btnRemoveUser;
        private Button btnReport;
        private Label lblUserNameMessage;
        private Label labelUserName;
        private Button btnLogout;
    }
}