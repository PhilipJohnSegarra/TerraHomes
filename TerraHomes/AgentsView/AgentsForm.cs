using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraHomes.Admin.Profile;
using TerraHomes.AgentsView.Dashboard;
using TerraHomes.AgentsView.Finance;
using TerraHomes.AgentsView.Properties;

namespace TerraHomes.Agents
{
    public partial class AgentsForm : Form
    {
        public int userID {  get; set; }
        public AgentDashboard agentDashboard;
        public ucAgentFinance agentFinance;
        public ucAgentProperties agentProperties;
        public ucProfile profile;
        public AgentsForm(int UserID)
        {
            InitializeComponent();
            this.userID = UserID;

            agentDashboard = new AgentDashboard(this.userID);
            agentFinance = new ucAgentFinance();
            agentProperties = new ucAgentProperties();
            profile = new ucProfile();
            profile.userId = this.userID;
            agentFinance.userID = this.userID;

            agentDashboard.userID = UserID;
            agentFinance.userID = UserID;
            agentProperties.userID = UserID;
            agentProperties.ucSellProperty1.CurrentUserId = UserID;

            agentDashboard.Dock = DockStyle.Fill;
            agentFinance.Dock = DockStyle.Fill;
            agentProperties.Dock = DockStyle.Fill;
            profile.Dock = DockStyle.Fill;

            this.pnlContent.Controls.Add(agentDashboard);
            this.pnlContent.Controls.Add(agentFinance);
            this.pnlContent.Controls.Add(agentProperties);
            this.pnlContent.Controls.Add(profile);

            agentSideBar1.btnDashboardClick += AgentSideBar1_btnDashboardClick;
            agentSideBar1.btnFinancelick += AgentSideBar1_btnFinancelick;
            agentSideBar1.btnPropertiesClick += AgentSideBar1_btnPropertiesClick;
            agentSideBar1.btnProfileClick += AgentSideBar1_btnProfileClick;

            agentDashboard.BringToFront();
            this.pnlContent.Refresh();
        }

        private void AgentSideBar1_btnProfileClick(object sender, EventArgs e)
        {
            profile.BringToFront();
            this.pnlContent.Refresh();
        }

        private void AgentSideBar1_btnPropertiesClick(object sender, EventArgs e)
        {
            agentProperties.BringToFront();
            this.pnlContent.Refresh();
        }

        private void AgentSideBar1_btnFinancelick(object sender, EventArgs e)
        {
            agentFinance.BringToFront();
            this.pnlContent.Refresh();
        }

        private void AgentSideBar1_btnDashboardClick(object sender, EventArgs e)
        {
            agentDashboard.BringToFront();
            this.pnlContent.Refresh();
        }

        private void AgentsForm_Load(object sender, EventArgs e)
        {
            ucTopPanel1.userID = this.userID;
        }
    }
}
