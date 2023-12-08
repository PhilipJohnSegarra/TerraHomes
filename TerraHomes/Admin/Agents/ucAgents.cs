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
        List<sp_GetAllUsersResult> allUsers;
        public ucAgents()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void ucAgents_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUsersPanel();

            btnListView.Checked = true;
            ucAddNewAccount1.Visible = false;
            ucModifyAccount1.Visible = false;
        }
        private void LoadUsers()
        {
            allUsers = UsersDB.GetAllUsers();
            if (cbUsertype.Text == "All")
            {
                dgvUsers.DataSource = allUsers;
            }
            else
            {
                var filteredUsers = from user in allUsers
                                    where user.UserType == cbUsertype.Text
                                    select user;

                dgvUsers.DataSource = filteredUsers.ToList();
            }
        }
        private void LoadUsersPanel()
        {
            FLPusers.Controls.Clear();
            allUsers = UsersDB.GetAllUsers();
            if (cbUsertype.Text == "All")
            {
                foreach (var user in allUsers)
                {
                    ucAgentsThumbnail agentsThumbnail = new ucAgentsThumbnail(user.UserID, user.Username, user.Password, user.Firstname, user.Lastname, user.Email, user.UserType, user.imageURL);
                    agentsThumbnail.Width = 308; agentsThumbnail.Height = 350;
                    agentsThumbnail.BackColor = Color.Transparent;

                    FLPusers.Controls.Add(agentsThumbnail);
                }
            }
            else
            {
                var filteredUsers = from user in allUsers
                                    where user.UserType == cbUsertype.Text
                                    select user;

                foreach (var user in filteredUsers)
                {
                    ucAgentsThumbnail agentsThumbnail = new ucAgentsThumbnail(user.UserID, user.Username, user.Password, user.Firstname, user.Lastname, user.Email, user.UserType, user.imageURL);
                    agentsThumbnail.Width = 308; agentsThumbnail.Height = 350;
                    agentsThumbnail.BackColor = Color.Transparent;

                    FLPusers.Controls.Add(agentsThumbnail);
                }
            }
        }

        private void btnListView_CheckedChanged(object sender, EventArgs e)
        {
            if (btnListView.Checked)
            {
                dgvUsers.BringToFront(); dgvUsers.Visible = true;
                FLPusers.SendToBack(); FLPusers.Visible = false;
            }
            else
            {
                dgvUsers.SendToBack(); dgvUsers.Visible = false;
                FLPusers.BringToFront(); FLPusers.Visible = true;
            }
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            ucAddNewAccount1.BringToFront();
            ucAddNewAccount1.Visible = true;
            ucAddNewAccount1.lblAction.Text = "Add an Account";
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            ucModifyAccount1.BringToFront();
            ucModifyAccount1.Visible = true;
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            ucModifyAccount1.BringToFront();
            ucModifyAccount1.Visible = true;
        }

        private void cbUsertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUsersPanel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            LoadUsersPanel();
        }
    }
}
