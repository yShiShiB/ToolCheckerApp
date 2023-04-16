using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class CheckInTool
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
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblToolID = new System.Windows.Forms.Label();
            this.inputToolID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(306, 234);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(112, 34);
            this.btnCheckIn.TabIndex = 5;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // lblToolID
            // 
            this.lblToolID.AutoSize = true;
            this.lblToolID.Location = new System.Drawing.Point(221, 183);
            this.lblToolID.Name = "lblToolID";
            this.lblToolID.Size = new System.Drawing.Size(79, 25);
            this.lblToolID.TabIndex = 4;
            this.lblToolID.Text = "Tool ID#";
            // 
            // inputToolID
            // 
            this.inputToolID.Location = new System.Drawing.Point(306, 183);
            this.inputToolID.Name = "inputToolID";
            this.inputToolID.Size = new System.Drawing.Size(273, 31);
            this.inputToolID.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(467, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CheckInTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.lblToolID);
            this.Controls.Add(this.inputToolID);
            this.Name = "CheckInTool";
            this.Text = "CheckInTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCheckIn;
        private Label lblToolID;
        private TextBox inputToolID;
        private Button btnCancel;
    }
}