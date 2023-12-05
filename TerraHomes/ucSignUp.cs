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
    public partial class ucSignUp : UserControl
    {
        public ucSignUp()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void llLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SendToBack();
            txtNewUserName.Clear();
            txtNewEmail.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                UsersDB.InsertNewAdmin(txtNewEmail.Text, txtNewUserName.Text, txtConfirmPassword.Text);
                MessageBox.Show("Account Created Successfully");
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
