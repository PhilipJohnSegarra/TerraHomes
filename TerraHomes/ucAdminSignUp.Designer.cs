namespace TerraHomes
{
    partial class ucAdminSignUp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.rbtnAgent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Font = new System.Drawing.Font("Fredoka Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))));
            this.rbtnAdmin.Location = new System.Drawing.Point(280, 169);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(81, 28);
            this.rbtnAdmin.TabIndex = 0;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // rbtnAgent
            // 
            this.rbtnAgent.AutoSize = true;
            this.rbtnAgent.Font = new System.Drawing.Font("Fredoka Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))));
            this.rbtnAgent.Location = new System.Drawing.Point(474, 169);
            this.rbtnAgent.Name = "rbtnAgent";
            this.rbtnAgent.Size = new System.Drawing.Size(79, 28);
            this.rbtnAgent.TabIndex = 1;
            this.rbtnAgent.TabStop = true;
            this.rbtnAgent.Text = "Agent";
            this.rbtnAgent.UseVisualStyleBackColor = true;
            // 
            // ucAdminSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnAgent);
            this.Controls.Add(this.rbtnAdmin);
            this.Name = "ucAdminSignUp";
            this.Size = new System.Drawing.Size(851, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rbtnAdmin;
        public System.Windows.Forms.RadioButton rbtnAgent;
    }
}
