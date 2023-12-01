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
using TerraHomes.Admin.Finance;

namespace TerraHomes
{
    public partial class frmTerraZon : Form
    {
        public frmTerraZon()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            ucAdminSideBar1.DashboardButtonClicked += Sidebar_DashboardButtonClicked;
            ucAdminSideBar1.FinanceButtonClicked += UcAdminSideBar1_FinanceButtonClicked;

            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void UcAdminSideBar1_FinanceButtonClicked(object sender, EventArgs e)
        {

            this.pnlContent.Controls.Clear();

            ucFinance finance = new ucFinance();
            finance.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(finance);
        }

        private void Sidebar_DashboardButtonClicked(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();

            ucAdminDashboard dashboard = new ucAdminDashboard();
            dashboard.Dock = DockStyle.Fill;
            //dashboard.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top;
            this.pnlContent.Controls.Add(dashboard);
            this.pnlContent.Refresh();
        }

        private void frmTerraZon_Load(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();

            ucAdminDashboard dashboard = new ucAdminDashboard();
            dashboard.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(dashboard);
            this.pnlContent.Refresh();
        }
    }
}
