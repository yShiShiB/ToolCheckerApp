using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class AddUser
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
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputEmpID = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblJobRole = new System.Windows.Forms.Label();
            this.inputJobRole = new System.Windows.Forms.ListBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.lblAddUserTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(342, 82);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(256, 31);
            this.inputFirstName.TabIndex = 0;
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(342, 132);
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(256, 31);
            this.inputLastName.TabIndex = 1;
            // 
            // inputEmpID
            // 
            this.inputEmpID.Location = new System.Drawing.Point(342, 186);
            this.inputEmpID.Name = "inputEmpID";
            this.inputEmpID.Size = new System.Drawing.Size(256, 31);
            this.inputEmpID.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(239, 82);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 25);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(239, 138);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 25);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(223, 192);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(113, 25);
            this.lblEmpID.TabIndex = 5;
            this.lblEmpID.Text = "Employee ID";
            // 
            // lblJobRole
            // 
            this.lblJobRole.AutoSize = true;
            this.lblJobRole.Location = new System.Drawing.Point(257, 230);
            this.lblJobRole.Name = "lblJobRole";
            this.lblJobRole.Size = new System.Drawing.Size(79, 25);
            this.lblJobRole.TabIndex = 6;
            this.lblJobRole.Text = "Job Role";
            // 
            // inputJobRole
            // 
            this.inputJobRole.FormattingEnabled = true;
            this.inputJobRole.ItemHeight = 25;
            this.inputJobRole.Items.AddRange(new object[] {
            "Equipment",
            "Human Resources",
            "Manager",
            "Maintenance",
            "Security"});
            this.inputJobRole.Location = new System.Drawing.Point(342, 230);
            this.inputJobRole.Name = "inputJobRole";
            this.inputJobRole.Size = new System.Drawing.Size(256, 129);
            this.inputJobRole.TabIndex = 7;
            this.inputJobRole.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(342, 386);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(112, 34);
            this.btnCreateUser.TabIndex = 8;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // lblAddUserTitle
            // 
            this.lblAddUserTitle.AutoSize = true;
            this.lblAddUserTitle.Location = new System.Drawing.Point(342, 32);
            this.lblAddUserTitle.Name = "lblAddUserTitle";
            this.lblAddUserTitle.Size = new System.Drawing.Size(133, 25);
            this.lblAddUserTitle.TabIndex = 9;
            this.lblAddUserTitle.Text = "Add User Form";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(486, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAddUserTitle);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.inputJobRole);
            this.Controls.Add(this.lblJobRole);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.inputEmpID);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputFirstName);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputFirstName;
        private TextBox inputLastName;
        private TextBox inputEmpID;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmpID;
        private Label lblJobRole;
        private ListBox inputJobRole;
        private Button btnCreateUser;
        private Label lblAddUserTitle;
        private Button btnCancel;
    }
}