using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes
{
    public partial class UserControl1 : UserControl
    {
        frmTerraZon terraZon;
        DCterrazonDataContext db;
        public UserControl1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            terraZon = new frmTerraZon();
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
            var users = from user in db.Users
                        where user.Username == txtUsername.Text && user.Password == txtPassword.Text
                        select user;

            if(users.Any())
            {
                this.Parent.Hide();
                terraZon.Show();
            }
            else
            {
                MessageBox.Show("Account Does Not Exist");
            }

        }
    }
}
