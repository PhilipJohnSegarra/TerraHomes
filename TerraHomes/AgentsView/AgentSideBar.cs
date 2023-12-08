using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.AgentsView
{
    public partial class AgentSideBar : UserControl
    {
        public AgentSideBar()
        {
            InitializeComponent();
        }
        public event EventHandler btnDashboardClick;
        public event EventHandler btnFinancelick;
        public event EventHandler btnPropertiesClick;
        public event EventHandler btnProfileClick;

        private void gbtnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboardClick?.Invoke(this, EventArgs.Empty);
        }

        private void gbtnFinance_Click(object sender, EventArgs e)
        {
            btnFinancelick?.Invoke(this, EventArgs.Empty);
        }

        private void gbtnProperties_Click(object sender, EventArgs e)
        {
            btnPropertiesClick?.Invoke(this, EventArgs.Empty);
        }

        private void gbtnProfile_Click(object sender, EventArgs e)
        {
            btnProfileClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
