using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerraHomes.Agents;

namespace TerraHomes
{
    public partial class ucTopPanel : UserControl
    {
        public int userID {  get; set; }
        List<sp_GetAllUsersResult> users;
        frmStartUp frmStartUp;
        public ucTopPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void ucTopPanel_Load(object sender, EventArgs e)
        {
            users = UsersDB.GetAllUsers();

            var currentUser = from user in users
                          where user.UserID == this.userID
                          select user;
            btnProfile.Text = currentUser.First().Firstname + " " + currentUser.First().Lastname;
            lbluserType.Text = currentUser.First().UserType;
            pbProfilePic.ImageLocation = currentUser.First().imageURL;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            frmStartUp = new frmStartUp();
            frmStartUp.ShowDialog();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
