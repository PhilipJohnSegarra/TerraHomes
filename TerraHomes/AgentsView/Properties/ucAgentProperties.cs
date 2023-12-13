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

            ShowProperties();
            AddFlowPanelData();

            cbType.SelectedIndex = 0;
            cbStatus.SelectedIndex = 0;
        }

        private void ucAgentProperties_Load(object sender, EventArgs e)
        {
            btnListView.Checked = true;
            ucViewProperty1.Visible = false;
            ucSellProperty1.Visible = false;
            ShowProperties();
            AddFlowPanelData();
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
                                   where prop.OwnerID == this.userID
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
                                       AgentID = prop.OwnerID,
                                       Agent = (data != null) ? $"{data.Firstname} {data.Lastname}" : "No Agent"
                                   };

            if (cbType.Text == "All" && cbStatus.Text == "All")
            {
                dgvProperties.DataSource = AllPropAndAgents.ToList();
                if (dgvProperties.Columns.Contains("PropertyName"))
                {
                    dgvProperties.Columns["PropertyName"].HeaderText = "Property Name";
                }
                if (dgvProperties.Columns.Contains("AgentID"))
                {
                    dgvProperties.Columns["AgentID"].Visible = false;
                }
            }
            else if (!String.IsNullOrEmpty(cbType.Text) && cbStatus.Text == "All")
            {
                var filteredProps = from prop in AllPropAndAgents
                                    where prop.Type == cbType.Text && prop.AgentID == this.userID
                                    select prop;

                dgvProperties.DataSource = filteredProps.ToList();
            }
            else if (cbType.Text == "All" && !String.IsNullOrEmpty(cbStatus.Text))
            {
                var filteredProps = from prop in AllPropAndAgents
                                    where prop.Status == cbStatus.Text && prop.AgentID == this.userID
                                    select prop;

                dgvProperties.DataSource = filteredProps.ToList();
            }
            else
            {
                var filteredProps = from prop in AllPropAndAgents
                                    where prop.Type == cbType.Text && prop.Status == cbStatus.Text && prop.AgentID == this.userID
                                    select prop;

                dgvProperties.DataSource = filteredProps.ToList();
            }
        }
        private void AddFlowPanelData()
        {
            flpProperties.Controls.Clear();
            if (cbType.Text == "All" && cbStatus.Text == "All")
            {
                foreach (var prop in allProperties.Where(a => a.OwnerID == this.userID))
                {
                    List<string> images = new List<string>();
                    var propImages = from i in allPropertiesImages
                                     where i.PropertyID == prop.PropertyID
                                     select i.ImageURL;

                    foreach (var img in propImages)
                    {
                        images.Add(img.ToString());
                    }

                    ucPropertyThumbnail propertyThumbnail = new ucPropertyThumbnail(prop.PropertyID, prop.PropertyName, prop.Address, prop.Description, images, prop.Price, prop.Type, prop.Status, prop.OwnerID, prop.Size);
                    propertyThumbnail.Width = 308;
                    propertyThumbnail.Height = 376;
                    propertyThumbnail.BackColor = Color.Transparent;

                    propertyThumbnail.btnViewClick += PropertyThumbnail_btnViewClick;

                    flpProperties.Controls.Add(propertyThumbnail);
                }
            }
            else if (!String.IsNullOrEmpty(cbType.Text) && cbStatus.Text == "All")
            {
                var filteredProps = from prop in allProperties
                                    where prop.Type == cbType.Text
                                    select prop;
                foreach (var prop in filteredProps.Where(a => a.OwnerID == this.userID))
                {
                    List<string> images = new List<string>();
                    var propImages = from i in allPropertiesImages
                                     where i.PropertyID == prop.PropertyID
                                     select i.ImageURL;

                    foreach (var img in propImages)
                    {
                        images.Add(img.ToString());
                    }

                    ucPropertyThumbnail propertyThumbnail = new ucPropertyThumbnail(prop.PropertyID, prop.PropertyName, prop.Address, prop.Description, images, prop.Price, prop.Type, prop.Status, prop.OwnerID, prop.Size);
                    propertyThumbnail.Width = 308;
                    propertyThumbnail.Height = 376;
                    propertyThumbnail.BackColor = Color.Transparent;

                    propertyThumbnail.btnViewClick += PropertyThumbnail_btnViewClick;

                    flpProperties.Controls.Add(propertyThumbnail);
                }
            }
            else if (cbType.Text == "All" && !String.IsNullOrEmpty(cbStatus.Text))
            {
                var filteredProps = from prop in allProperties
                                    where prop.Status == cbStatus.Text
                                    select prop;
                foreach (var prop in filteredProps.Where(a => a.OwnerID == this.userID))
                {
                    List<string> images = new List<string>();
                    var propImages = from i in allPropertiesImages
                                     where i.PropertyID == prop.PropertyID
                                     select i.ImageURL;

                    foreach (var img in propImages)
                    {
                        images.Add(img.ToString());
                    }

                    ucPropertyThumbnail propertyThumbnail = new ucPropertyThumbnail(prop.PropertyID, prop.PropertyName, prop.Address, prop.Description, images, prop.Price, prop.Type, prop.Status, prop.OwnerID, prop.Size);
                    propertyThumbnail.Width = 308;
                    propertyThumbnail.Height = 376;
                    propertyThumbnail.BackColor = Color.Transparent;

                    propertyThumbnail.btnViewClick += PropertyThumbnail_btnViewClick;

                    flpProperties.Controls.Add(propertyThumbnail);
                }
            }
            else
            {
                var filteredProps = from prop in allProperties
                                    where prop.Type == cbType.Text && prop.Status == cbStatus.Text
                                    select prop;
                foreach (var prop in filteredProps.Where(a => a.OwnerID == this.userID))
                {
                    List<string> images = new List<string>();
                    var propImages = from i in allPropertiesImages
                                     where i.PropertyID == prop.PropertyID
                                     select i.ImageURL;

                    foreach (var img in propImages)
                    {
                        images.Add(img.ToString());
                    }

                    ucPropertyThumbnail propertyThumbnail = new ucPropertyThumbnail(prop.PropertyID, prop.PropertyName, prop.Address, prop.Description, images, prop.Price, prop.Type, prop.Status, prop.OwnerID, prop.Size);
                    propertyThumbnail.Width = 308;
                    propertyThumbnail.Height = 376;
                    propertyThumbnail.BackColor = Color.Transparent;

                    propertyThumbnail.btnViewClick += PropertyThumbnail_btnViewClick;

                    flpProperties.Controls.Add(propertyThumbnail);
                }
            }
        }

        private void PropertyThumbnail_btnViewClick(object sender, EventArgs e)
        {
            if (sender is ucPropertyThumbnail thumbnail)
            {
                ucViewProperty1.propID = thumbnail.propID;
                ucViewProperty1.txtPropertyId.Text = ucViewProperty1.propID.ToString();
                ucViewProperty1.txtPropertyName.Text = thumbnail.propertyName;
                ucViewProperty1.txtPropertyAddress.Text = thumbnail.address;
                ucViewProperty1.txtPropertyDesc.Text = thumbnail.desc;
                ucViewProperty1.txtPropertySize.Text = thumbnail.size;
                ucViewProperty1.txtPropertyPrice.Text = thumbnail.price.ToString();
                ucViewProperty1.cbType.Text = thumbnail.type;
                ucViewProperty1.cbPropertyStatus.Text = thumbnail.status;
                ucViewProperty1.cbAssignees.Text = thumbnail.assignedTo;
                ucViewProperty1.images = thumbnail.Images;
                ucViewProperty1.cbAssignees.Text = thumbnail.assignedTo.ToString();
                if (thumbnail.Images.Any())
                {
                    ucViewProperty1.pbPropertyImages.ImageLocation = ucViewProperty1.images.ToArray()[0];
                }
                else
                {
                    ucViewProperty1.pbPropertyImages.ImageLocation = null;
                }

            }
            ucViewProperty1.BringToFront();
            ucViewProperty1.Visible = true;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProperties();
            AddFlowPanelData();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProperties();
            AddFlowPanelData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowProperties();
            AddFlowPanelData();
        }
    }
}
