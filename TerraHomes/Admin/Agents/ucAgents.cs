using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin.Agents
{
    public partial class ucAgents : UserControl
    {
        public ucAgents()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void ucAgents_Load(object sender, EventArgs e)
        {
            btnListView.Checked = true;
        }

        private void btnListView_CheckedChanged(object sender, EventArgs e)
        {
            if (btnListView.Checked)
            {
                dgvProperties.BringToFront(); dgvProperties.Visible = true;
                flpProperties.SendToBack(); flpProperties.Visible = false;
            }
            else
            {
                dgvProperties.SendToBack(); dgvProperties.Visible = false;
                flpProperties.BringToFront(); flpProperties.Visible = true;
            }
        }
    }
}
