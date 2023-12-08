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
        public UserControl1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
            db = new DCterrazonDataContext();
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
                MessageBox.Show("Account Does Not Exist or Username and Password are incorrect");
            }
            

        }
    }
}
