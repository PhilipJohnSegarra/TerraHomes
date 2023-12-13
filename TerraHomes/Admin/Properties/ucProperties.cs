using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin.Properties
{
    public partial class ucProperties : UserControl
    {
        List<sp_GetPropertiesResult> allProperties = null;
        List<sp_GetAllUsersResult> allUsers = null;
        List<sp_GetPropertyImagesResult> allPropertiesImages = null;
        public int userID { get; set; }
        public ucProperties()
        {
            InitializeComponent();
            this.allProperties = PropertiesDB.GetProperties();
            this.allUsers = UsersDB.GetAllUsers();
            this.allPropertiesImages = PropertyImagesDB.GetPropertyImages();

            this.DoubleBuffered = true;
            
        }

        private void ucProperties_Load(object sender, EventArgs e)
        {
            btnListView.Checked = true;
            ucAddNewProperty1.Visible = false;
            ucViewProperty1.Visible = false;
            ucViewProperty1.userID = this.userID;

            cbType.SelectedIndex = 0; cbStatus.SelectedIndex = 0;

            AddFlowPanelData();
            ShowProperties();
        }
        //This method shows the Properties according to the Type and Status
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

            if(cbType.Text == "All" && cbStatus.Text == "All")
            {
                dgvProperties.DataSource = AllPropAndAgents.ToList();
                if (dgvProperties.Columns.Contains("PropertyName"))
                {
                    dgvProperties.Columns["PropertyName"].HeaderText = "Property Name";
                }
            }
            else if(!String.IsNullOrEmpty(cbType.Text) && cbStatus.Text == "All")
            {
                var filteredProps = from prop in AllPropAndAgents
                                    where prop.Type == cbType.Text
                                    select prop;

                dgvProperties.DataSource = filteredProps.ToList();
            }
            else if (cbType.Text == "All" && !String.IsNullOrEmpty(cbStatus.Text))
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
            flpProperties.Controls.Clear();
            if (cbType.Text == "All" && cbStatus.Text == "All")
            {
                foreach (var prop in allProperties)
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
                foreach (var prop in filteredProps)
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
                foreach (var prop in filteredProps)
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
                foreach (var prop in filteredProps)
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
            if(sender is ucPropertyThumbnail thumbnail)
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

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            this.allProperties = null;
            ShowProperties();
        }

        private void cbStatus_TextChanged(object sender, EventArgs e)
        {
            //this.allProperties = null;
            //ShowProperties();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            this.allProperties = PropertiesDB.GetProperties();
            this.allUsers = UsersDB.GetAllUsers();
            this.allPropertiesImages = PropertyImagesDB.GetPropertyImages();

            AddFlowPanelData();
            ShowProperties();
        }

        private void cbType_SelectedIndexPropertyChanged(object sender, EventArgs e)
        {
            //this.allProperties = null;
            ShowProperties();

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.allProperties = null;
            ShowProperties();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowProperties();
            AddFlowPanelData();
        }

        private void cbStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowProperties();
            AddFlowPanelData();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ucViewProperty1.BringToFront();
            ucViewProperty1.Visible = true;
            ucViewProperty1.txtPropertyId.ReadOnly = false;
            ucViewProperty1.txtPropertyName.ReadOnly = false;
            ucViewProperty1.txtPropertyAddress.ReadOnly = false;
            ucViewProperty1.txtPropertyDesc.ReadOnly = false;
            ucViewProperty1.txtPropertySize.ReadOnly = false;
            ucViewProperty1.txtPropertyPrice.ReadOnly = false;
            ucViewProperty1.cbAssignees.Enabled = true;
            ucViewProperty1.cbPropertyStatus.Enabled = true;
            ucViewProperty1.cbType.Enabled = true;

            ucViewProperty1.btnSubmit.Enabled = true;
            ucViewProperty1.btnReset.Enabled = true;

            MessageBox.Show("You may begin updating the information below!\n\nHowever, changing and adding of images requires you to \ndelete and add the current property.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ucViewProperty1.BringToFront();
            ucViewProperty1.Visible = true;
            ucViewProperty1.txtPropertyId.ReadOnly = false;
            ucViewProperty1.txtPropertyName.ReadOnly = false;
            ucViewProperty1.txtPropertyAddress.ReadOnly = false;
            ucViewProperty1.txtPropertyDesc.ReadOnly = false;
            ucViewProperty1.txtPropertySize.ReadOnly = false;
            ucViewProperty1.txtPropertyPrice.ReadOnly = false;
            ucViewProperty1.cbAssignees.Enabled = true;
            ucViewProperty1.cbPropertyStatus.Enabled = true;
            ucViewProperty1.cbType.Enabled = true;

            ucViewProperty1.btnSubmit.Enabled = true;
            ucViewProperty1.btnReset.Enabled = true;
        }
    }
}
