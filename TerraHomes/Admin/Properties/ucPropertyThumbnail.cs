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
    public partial class ucPropertyThumbnail : UserControl
    {
        public int propID {  get; set; }
        public string propertyName { get; set; }
        public string address { get; set; }
        public string desc { get; set; }
        public List<string> Images { get; set; }
        public decimal price { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string assignedTo { get; set; }
        public string size { get; set; }
        public ucPropertyThumbnail(int propID, string propertyName,string propAddress, string propdesc, List<string> images, decimal? price, string type, string status, int? ownerID, string size)
        {
            InitializeComponent();
            this.propID = propID;
            this.propertyName = propertyName;
            this.address = propAddress;
            this.desc = propdesc;
            this.Images = images;
            this.price = (decimal)price;
            this.type = type;
            this.status = status;
            this.size = size;

            //Get the agent that is assigned to the property
            var Users = from user in UsersDB.GetAllUsers()
                        where user.UserID == ownerID
                        select user;

            //if there is indeed an assignee, display, otherwise, leave blank
            if(Users.Any())
            {
                this.assignedTo = Users.FirstOrDefault().Firstname + " " + Users.FirstOrDefault().Lastname;
            }
            else
            {
                this.assignedTo = "No agent";
            }

            //Modify the labels according to the data from the PropertiesDB
            lblPropertyName.Text = this.propertyName;
            if (this.Images.Any())
            {
                pbPropImage.ImageLocation = this.Images.First();
            }
            else
            {
                pbPropImage.ImageLocation = null;
            }
            
            lblPrice.Text = this.price.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            lblType.Text = this.type.ToString();
            lblStatus.Text = this.status.ToString();
            lblOwner.Text = this.assignedTo;
        }
        public event EventHandler btnViewClick;

        private void btnView_Click(object sender, EventArgs e)
        {
            btnViewClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
