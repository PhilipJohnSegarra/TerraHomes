using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            txtFirstName.Clear();
            txtLastName.Clear();
            txtNewUserName.Clear();
            txtNewEmail.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for basic email validation
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsValidEmail(txtNewEmail.Text) && txtNewPassword.Text.Length >= 8 && txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    UsersDB.InsertNewUser(txtNewUserName.Text, DataSecure.Encrypt(txtConfirmPassword.Text), txtFirstName.Text, txtLastName.Text, txtNewEmail.Text, "Admin", null);
                    this.SendToBack();
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtNewUserName.Clear();
                    txtNewEmail.Clear();
                    txtNewPassword.Clear();
                    txtConfirmPassword.Clear();
                    MessageBox.Show("Account Created Successfully");
                }
                else
                {
                    MessageBox.Show("Invalid Details Detected:\nMake sure to avoid invalidating the following:\n1.Email address.\n2.Password (must be 8 characters.)");
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
