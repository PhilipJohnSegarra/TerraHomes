﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraHomes.Admin.Finance;

namespace TerraHomes.Admin
{
    public partial class ucAdminSideBar : UserControl
    {
        frmStartUp frmStartUp;
        public ucAdminSideBar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public event EventHandler DashboardButtonClicked;
        public event EventHandler FinanceButtonClicked;
        public event EventHandler PropertiesButtonClicked;
        public event EventHandler AgentsButtonClicked;
        public event EventHandler ProfileButtonClicked;


        private void gtbnDashboard_Click(object sender, EventArgs e)
        {
            DashboardButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void gbtnFinance_Click(object sender, EventArgs e)
        {
            FinanceButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void gbtnProperties_Click(object sender, EventArgs e)
        {
            PropertiesButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void gbtnAgents_Click(object sender, EventArgs e)
        {
            AgentsButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            frmStartUp = new frmStartUp();
            frmStartUp.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProfileButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
