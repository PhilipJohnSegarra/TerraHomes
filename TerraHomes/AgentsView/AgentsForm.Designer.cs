namespace TerraHomes.Agents
{
    partial class AgentsForm
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
            this.ucTopPanel1 = new TerraHomes.ucTopPanel();
            this.agentSideBar1 = new TerraHomes.AgentsView.AgentSideBar();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.ucTopPanel1.TabIndex = 21;
            this.ucTopPanel1.userID = 0;
            // 
            // agentSideBar1
            // 
            this.agentSideBar1.BackColor = System.Drawing.Color.Transparent;
            this.agentSideBar1.Location = new System.Drawing.Point(0, 92);
            this.agentSideBar1.Name = "agentSideBar1";
            this.agentSideBar1.Size = new System.Drawing.Size(197, 766);
            this.agentSideBar1.TabIndex = 22;
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(198, 92);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1055, 766);
            this.pnlContent.TabIndex = 23;
            // 
            // AgentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1253, 858);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.agentSideBar1);
            this.Controls.Add(this.ucTopPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgentsForm";
            this.Load += new System.EventHandler(this.AgentsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AgentsView.AgentSideBar agentSideBar1;
        public System.Windows.Forms.Panel pnlContent;
        public ucTopPanel ucTopPanel1;
    }
}