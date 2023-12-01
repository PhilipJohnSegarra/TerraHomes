using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraHomes.Admin.Finance;

namespace TerraHomes.Admin
{
    public partial class ucAdminSideBar : UserControl
    {
        public ucAdminSideBar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public event EventHandler DashboardButtonClicked;
        public event EventHandler FinanceButtonClicked;


        public void gtbnDashboard_Click(object sender, EventArgs e)
        {
            DashboardButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        public void gbtnFinance_Click(object sender, EventArgs e)
        {
            FinanceButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
