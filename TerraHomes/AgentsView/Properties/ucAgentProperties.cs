using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraHomes.Admin.Properties;

namespace TerraHomes.AgentsView.Properties
{
    public partial class ucAgentProperties : UserControl
    {
        public int userID { get; set; }
        List<sp_GetPropertiesResult> allProperties = null;
        List<sp_GetAllUsersResult> allUsers = null;
        List<sp_GetPropertyImagesResult> allPropertiesImages = null;
        public ucAgentProperties()
        {
            InitializeComponent();
            this.allProperties = PropertiesDB.GetProperties();
            this.allUsers = UsersDB.GetAllUsers();
            this.allPropertiesImages = PropertyImagesDB.GetPropertyImages();
        }

        private void ucAgentProperties_Load(object sender, EventArgs e)
        {
            btnListView.Checked = true;
            ucViewProperty1.Visible = false;
            ucSellProperty1.Visible = false;
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

        private void btnSellProperty_Click(object sender, EventArgs e)
        {
            ucSellProperty1.Visible = true; ucSellProperty1.BringToFront();
        }

        private void ShowProperties()
        {
            var AllPropAndAgents = from prop in allProperties
                                   join agent in allUsers on prop.OwnerID equals agent.UserID into joinedData
                                   from data in joinedData.DefaultIfEmpty()
                                   select new
                                   {
                                       ID = prop.PropertyID,
                                       PropertyName = prop.PropertyName,
                                       Address = prop.Address,
                                       Description = prop.Description,
                                       Type = prop.Type,
                                       Status = prop.Status,
                                       Price = prop.Price,
                                       Size = prop.Size,
                                       Agent = (data != null) ? $"{data.Firstname} {data.Lastname}" : "No Agent"
                                   };

            if (String.IsNullOrEmpty(cbType.Text) && String.IsNullOrEmpty(cbStatus.Text))
            {
                dgvProperties.DataSource = AllPropAndAgents.ToList();
                if (dgvProperties.Columns.Contains("PropertyName"))
                {
                    dgvProperties.Columns["PropertyName"].HeaderText = "Property Name";
                }
            }
            else if (!String.IsNullOrEmpty(cbType.Text) && String.IsNullOrEmpty(cbStatus.Text))
            {
                var filteredProps = from prop in AllPropAndAgents
                                    where prop.Type == cbType.Text
                                    select prop;

                dgvProperties.DataSource = filteredProps.ToList();
            }
            else if (String.IsNullOrEmpty(cbType.Text) && !String.IsNullOrEmpty(cbStatus.Text))
            {
                var filteredProps = from prop in AllPropAndAgents
                                    where prop.Status == cbStatus.Text
                                    select prop;

                dgvProperties.DataSource = filteredProps.ToList();
            }
            else
            {
                var filteredProps = from prop in AllPropAndAgents
                                    where prop.Type == cbType.Text && prop.Status == cbStatus.Text
                                    select prop;

                dgvProperties.DataSource = filteredProps.ToList();
            }
        }
    }
}
