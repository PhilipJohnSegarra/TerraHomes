using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.AgentsView.Dashboard
{
    public partial class AgentDashboard : UserControl
    {
        public int userID { get; set; }
        public AgentDashboard()
        {
            InitializeComponent();
        }
    }
}
