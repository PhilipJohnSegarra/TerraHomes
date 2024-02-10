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
    public partial class UserControl1 : UserControl
    {
        frmTerraZon terraZon;
        DCterrazonDataContext db;
        AgentsForm agentform;
        frmForgotPassword frmForgotPassword;
        public UserControl1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
            db = new DCterrazonDataContext();

            ucAdminSignUp1.BringToFront();
            AdminOrAgent();
        }
        private void AdminOrAgent()
        {
            ucAdminSignUp1.rbtnAdmin.Click += RbtnAdmin_Click;
            ucAdminSignUp1.rbtnAgent.Click += RbtnAgent_Click;
        }

        private void RbtnAgent_Click(object sender, EventArgs e)
        {
            ucAdminSignUp1.Visible = false;
            llSignUp.Enabled = false;
        }

        private void RbtnAdmin_Click(object sender, EventArgs e)
        {
            ucAdminSignUp1.Visible = false;
            llSignUp.Enabled = true;
        }

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            this.SendToBack();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                var users = from user in db.Users
                            where user.Username == txtUsername.Text && user.Password == DataSecure.Encrypt(txtPassword.Text)
                            select user;

                if (users.First().UserType == "Admin")
                {
                    this.Parent.Hide();
                    terraZon = new frmTerraZon(users.First().UserID);
                    terraZon.ucTopPanel1.userID = users.First().UserID;
                    terraZon.Show();
                }
                else if (users.First().UserType == "Agent")
                {
                    this.Parent.Hide();
                    agentform = new AgentsForm(users.First().UserID);
                    agentform.ucTopPanel1.userID = users.First().UserID;
                    agentform.agentDashboard.userID = users.First().UserID;
                    agentform.Show();

                }
                else if(!users.Any())
                {
                    MessageBox.Show("Account Does Not Exist or Username and Password are incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgotPassword = new frmForgotPassword();
            frmForgotPassword.ShowDialog();
        }
    }
}
