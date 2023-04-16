using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class RemoveUser
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
            this.listEmpNames = new System.Windows.Forms.ListBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listEmpNames
            // 
            this.listEmpNames.FormattingEnabled = true;
            this.listEmpNames.ItemHeight = 25;
            this.listEmpNames.Items.AddRange(new object[] {
            "%username",
            "%username",
            "%username",
            "%username",
            "%username",
            "%username",
            "%username",
            "%username"});
            this.listEmpNames.Location = new System.Drawing.Point(249, 47);
            this.listEmpNames.Name = "listEmpNames";
            this.listEmpNames.Size = new System.Drawing.Size(317, 254);
            this.listEmpNames.TabIndex = 0;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(249, 331);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(142, 34);
            this.btnRemoveUser.TabIndex = 1;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(454, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.listEmpNames);
            this.Name = "RemoveUser";
            this.Text = "RemoveUser";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listEmpNames;
        private Button btnRemoveUser;
        private Button btnCancel;
    }
}