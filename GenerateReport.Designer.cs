using System.Drawing;
using System.Windows.Forms;

namespace ToolCheckerApp
{
    partial class GenerateReport
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
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnLSD = new System.Windows.Forms.Button();
            this.btnEmpRpt = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnInventory.Location = new System.Drawing.Point(40, 136);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(236, 94);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory Report";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnLSD
            // 
            this.btnLSD.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnLSD.Location = new System.Drawing.Point(350, 136);
            this.btnLSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLSD.Name = "btnLSD";
            this.btnLSD.Size = new System.Drawing.Size(236, 94);
            this.btnLSD.TabIndex = 1;
            this.btnLSD.Text = "Lost, Stolen, Damaged Report";
            this.btnLSD.UseVisualStyleBackColor = true;
            this.btnLSD.Click += new System.EventHandler(this.btnLSD_Click);
            // 
            // btnEmpRpt
            // 
            this.btnEmpRpt.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEmpRpt.Location = new System.Drawing.Point(663, 136);
            this.btnEmpRpt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEmpRpt.Name = "btnEmpRpt";
            this.btnEmpRpt.Size = new System.Drawing.Size(236, 94);
            this.btnEmpRpt.TabIndex = 2;
            this.btnEmpRpt.Text = "Employee Report";
            this.btnEmpRpt.UseVisualStyleBackColor = true;
            this.btnEmpRpt.Click += new System.EventHandler(this.btnEmpRpt_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnMainMenu.Location = new System.Drawing.Point(236, 259);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(451, 94);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "Return to Previous Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(223, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generate Reports";
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnEmpRpt);
            this.Controls.Add(this.btnLSD);
            this.Controls.Add(this.btnInventory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateReport";
            this.Text = "Generate Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInventory;
        private Button btnLSD;
        private Button btnEmpRpt;
        private Button btnMainMenu;
        private Label label1;
    }
}