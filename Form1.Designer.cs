using System.Drawing;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class Form1
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
            btnEmpLogin = new Button();
            lblWelcomeMessage = new Label();
            btnAdminLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEmpLogin
            // 
            btnEmpLogin.Font = new Font("Candara", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnEmpLogin.Location = new Point(158, 165);
            btnEmpLogin.Margin = new Padding(2);
            btnEmpLogin.Name = "btnEmpLogin";
            btnEmpLogin.Size = new Size(217, 77);
            btnEmpLogin.TabIndex = 0;
            btnEmpLogin.Text = "Employee Login";
            btnEmpLogin.UseVisualStyleBackColor = true;
            btnEmpLogin.Click += btnEmpLogin_Click;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Lato", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblWelcomeMessage.Location = new Point(173, 66);
            lblWelcomeMessage.Margin = new Padding(2, 0, 2, 0);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(423, 33);
            lblWelcomeMessage.TabIndex = 7;
            lblWelcomeMessage.Text = "Welcome to the Tool Checker App";
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Font = new Font("Candara", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            btnAdminLogin.Location = new Point(389, 166);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(217, 77);
            btnAdminLogin.TabIndex = 8;
            btnAdminLogin.Text = "Adminstrator Login";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(264, 271);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(217, 77);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit Program";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 474);
            Controls.Add(btnExit);
            Controls.Add(btnAdminLogin);
            Controls.Add(lblWelcomeMessage);
            Controls.Add(btnEmpLogin);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEmpLogin;
        private Label lblWelcomeMessage;
        private Button btnAdminLogin;
        private Button btnExit;

    }
}

