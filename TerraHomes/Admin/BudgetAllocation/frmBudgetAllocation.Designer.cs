﻿namespace TerraHomes.Admin.BudgetAllocation
{
    partial class frmBudgetAllocation
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
            this.ucBudgetAllocation1 = new TerraHomes.Admin.BudgetAllocation.ucBudgetAllocation();
            this.SuspendLayout();
            // 
            // ucBudgetAllocation1
            // 
            this.ucBudgetAllocation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ucBudgetAllocation1.Location = new System.Drawing.Point(0, 0);
            this.ucBudgetAllocation1.Name = "ucBudgetAllocation1";
            this.ucBudgetAllocation1.Size = new System.Drawing.Size(674, 398);
            this.ucBudgetAllocation1.TabIndex = 0;
            // 
            // frmBudgetAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 395);
            this.Controls.Add(this.ucBudgetAllocation1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBudgetAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Allocation";
            this.ResumeLayout(false);

        }

        #endregion

        private ucBudgetAllocation ucBudgetAllocation1;
    }
}