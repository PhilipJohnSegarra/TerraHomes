using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin.Properties
{
    public partial class ucViewProperty : UserControl
    {
        public ucViewProperty()
        {
            InitializeComponent();
        }

        private void ucViewProperty_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtPropertyName.ReadOnly = false;
            txtPropertyAddress.ReadOnly = false;
            txtPropertyDesc.ReadOnly = false;
            txtPropertySize.ReadOnly = false;
            txtPropertyPrice.ReadOnly = false;
            cbAssignees.Enabled = true;
            cbPropertyStatus.Enabled = true;
            cbType.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void ucViewProperty_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
