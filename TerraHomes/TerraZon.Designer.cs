namespace TerraHomes
{
    partial class frmTerraZon
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
            this.components = new System.ComponentModel.Container();
            this.gpnlMainPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ucAdminSideBar1 = new TerraHomes.Admin.ucAdminSideBar();
            this.ucTopPanel1 = new TerraHomes.ucTopPanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.gpnlMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpnlMainPanel
            // 
            this.gpnlMainPanel.AutoSize = true;
            this.gpnlMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gpnlMainPanel.BackColor = System.Drawing.Color.Transparent;
            this.gpnlMainPanel.Controls.Add(this.ucAdminSideBar1);
            this.gpnlMainPanel.Controls.Add(this.ucTopPanel1);
            this.gpnlMainPanel.Controls.Add(this.pnlContent);
            this.gpnlMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpnlMainPanel.FillColor = System.Drawing.Color.Transparent;
            this.gpnlMainPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.gpnlMainPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gpnlMainPanel.Location = new System.Drawing.Point(0, 0);
            this.gpnlMainPanel.Name = "gpnlMainPanel";
            this.gpnlMainPanel.Size = new System.Drawing.Size(1253, 858);
            this.gpnlMainPanel.TabIndex = 0;
            // 
            // ucAdminSideBar1
            // 
            this.ucAdminSideBar1.BackColor = System.Drawing.Color.Transparent;
            this.ucAdminSideBar1.Location = new System.Drawing.Point(0, 92);
            this.ucAdminSideBar1.Name = "ucAdminSideBar1";
            this.ucAdminSideBar1.Size = new System.Drawing.Size(197, 766);
            this.ucAdminSideBar1.TabIndex = 0;
            // 
            // ucTopPanel1
            // 
            this.ucTopPanel1.AutoSize = true;
            this.ucTopPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucTopPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucTopPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTopPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucTopPanel1.Name = "ucTopPanel1";
            this.ucTopPanel1.Size = new System.Drawing.Size(1253, 91);
            this.ucTopPanel1.TabIndex = 20;
            this.ucTopPanel1.userID = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(198, 92);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1055, 766);
            this.pnlContent.TabIndex = 4;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // frmTerraZon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1253, 858);
            this.Controls.Add(this.gpnlMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTerraZon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerraZon";
            this.Load += new System.EventHandler(this.frmTerraZon_Load);
            this.gpnlMainPanel.ResumeLayout(false);
            this.gpnlMainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Admin.ucAdminSideBar ucAdminSideBar1;
        public Guna.UI2.WinForms.Guna2GradientPanel gpnlMainPanel;
        public System.Windows.Forms.Panel pnlContent;
        public ucTopPanel ucTopPanel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}