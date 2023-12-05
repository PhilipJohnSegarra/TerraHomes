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
    public partial class ucProperties : UserControl
    {
        public ucProperties()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            
        }

        private void ucProperties_Load(object sender, EventArgs e)
        {
            btnListView.Checked = true;
            ucAddNewProperty1.Visible = false;
            ucViewProperty1.Visible = false;

            AddFlowPanelData();
        }

        private void btnListView_CheckChanged(object sender, EventArgs e)
        {
            if (btnListView.Checked)
            {
                dgvProperties.BringToFront(); dgvProperties.Visible = true;
                flpProperties.SendToBack(); flpProperties.Visible = false;
                ucAddNewProperty1.Visible = false;
            }
            else
            {
                dgvProperties.SendToBack(); dgvProperties.Visible = false;
                flpProperties.BringToFront(); flpProperties.Visible = true;
                ucAddNewProperty1.Visible = false;
            }
        }

        private void btnNewProperty_Click(object sender, EventArgs e)
        {
            ucAddNewProperty1.BringToFront();
            ucAddNewProperty1.Visible = true;
        }

        private void AddFlowPanelData()
        {
            int[] nums = { 1, 2, 3, 4 };

            foreach (int num in nums)
            {
                ucPropertyThumbnail propertyThumbnail = new ucPropertyThumbnail();
                propertyThumbnail.Width = 308;
                propertyThumbnail.Height = 376;
                propertyThumbnail.BackColor = Color.Transparent;

                propertyThumbnail.btnViewClick += PropertyThumbnail_btnViewClick;

                flpProperties.Controls.Add(propertyThumbnail);
            }
        }

        private void PropertyThumbnail_btnViewClick(object sender, EventArgs e)
        {
            ucViewProperty1.BringToFront();
            ucViewProperty1.Visible = true;
        }
    }
}
