using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraHomes.Admin;
using TerraHomes.Admin.Agents;
using TerraHomes.Admin.Finance;
using TerraHomes.Admin.Properties;

namespace TerraHomes
{
    public partial class frmTerraZon : Form
    {
        public int UserID {  get; set; }
        ucAdminDashboard dashboard;
        ucFinance finance;
        public ucProperties properties;
        ucAgents agents;
        public frmTerraZon(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.DoubleBuffered = true;

            //Instantiate the User Controls for content
            dashboard = new ucAdminDashboard();
            properties = new ucProperties();
            finance = new ucFinance();
            agents = new ucAgents();
            properties.userID = UserID;

            //Initialize its properties
            properties.Dock = DockStyle.Fill; properties.Visible = true;
            finance.Dock = DockStyle.Fill; finance.Visible = true;
            dashboard.Dock = DockStyle.Fill; dashboard.Visible = true;
            agents.Dock = DockStyle.Fill; agents.Visible = true;

            //Add the user controls to the panel content
            this.pnlContent.Controls.Add(dashboard);
            this.pnlContent.Controls.Add(properties);
            this.pnlContent.Controls.Add(finance);
            this.pnlContent.Controls.Add(agents);

            //Add the events
            ucAdminSideBar1.DashboardButtonClicked += Sidebar_DashboardButtonClicked;
            ucAdminSideBar1.FinanceButtonClicked += UcAdminSideBar1_FinanceButtonClicked;
            ucAdminSideBar1.PropertiesButtonClicked += UcAdminSideBar1_PropertiesButtonClicked;
            ucAdminSideBar1.AgentsButtonClicked += UcAdminSideBar1_AgentsButtonClicked;


            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void UcAdminSideBar1_AgentsButtonClicked(object sender, EventArgs e)
        {
            agents.BringToFront();
            this.pnlContent.Refresh();
        }

        private void UcAdminSideBar1_PropertiesButtonClicked(object sender, EventArgs e)
        {          
            properties.BringToFront();
            this.pnlContent.Refresh();
        }

        private void UcAdminSideBar1_FinanceButtonClicked(object sender, EventArgs e)
        {
            finance.BringToFront();
            this.pnlContent.Refresh();
        }

        private void Sidebar_DashboardButtonClicked(object sender, EventArgs e)
        {

            dashboard.BringToFront();
            this.pnlContent.Refresh();
        }

        private void frmTerraZon_Load(object sender, EventArgs e)
        {
            dashboard.BringToFront();
            this.pnlContent.Refresh();
        }
    }
}
