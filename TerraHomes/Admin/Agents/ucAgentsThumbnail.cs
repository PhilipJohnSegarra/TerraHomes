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
    public partial class ucAgentsThumbnail : UserControl
    {
        public int userID {  get; set; }
        public string username { get; set; }
        public string password {  get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string userType { get; set; }
        public string imageURL { get; set; }
        public ucAgentsThumbnail(int userID, string username, string password, string firstName, string lastName, string email, string userType, string imageURL)
        {
            InitializeComponent();
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.userType = userType;
            this.imageURL = imageURL;

            lblName.Text = this.firstName + " " + lastName;
            lblID.Text = this.userID.ToString();
            lblEmail.Text = this.email;
            lblUserType.Text = this.userType;
        }
        public event EventHandler btnSeemoreClick;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            btnSeemoreClick?.Invoke(this, EventArgs.Empty);
        }

        private void ucAgentsThumbnail_Load(object sender, EventArgs e)
        {
            this.guna2PictureBox1.ImageLocation = this.imageURL;
        }
    }
}
