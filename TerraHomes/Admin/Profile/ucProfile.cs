using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace TerraHomes.Admin.Profile
{
    public partial class ucProfile : UserControl
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string usertype { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string imageSource { get; set; }
        List<sp_GetAllUsersResult> users;
        public ucProfile()
        {
            InitializeComponent();
            users = UsersDB.GetAllUsers();
        }

        private void ucProfile_Load(object sender, EventArgs e)
        {
            EnableInfoEditing(false);
            EnableAccountEditing(false);
            Loadprofile();
        }
        private void Loadprofile()
        {
            var currentUser = from user in users
                              where user.UserID == this.userId
                              select user;
            this.firstName = currentUser.FirstOrDefault().Firstname;
            this.lastName = currentUser.FirstOrDefault().Lastname;
            this.email = currentUser.FirstOrDefault().Email;
            this.usertype = currentUser.FirstOrDefault().UserType;
            this.username = currentUser.FirstOrDefault().Username;
            this.password = currentUser.FirstOrDefault().Password;
            this.imageSource = currentUser.FirstOrDefault().imageURL;

            txtFirstName.Text = this.firstName;
            txtLastName.Text = this.lastName;
            txtEmail.Text = this.email;
            cbType.SelectedIndex = (this.usertype != "admin")? 1 : 0;
            txtUsername.Text = this.username;
            txtPassword.Text = this.password;
            pbProfilePic.ImageLocation = this.imageSource;
            lblFullName.Text = this.lastName + ", " + this.firstName;
            lblUsertype.Text = this.usertype;
        }
        private void EnableInfoEditing(bool enable)
        {
            btnSaveChanges.Visible = enable;
            btnCancel.Visible = enable;
            txtFirstName.Enabled = enable;
            txtLastName.Enabled = enable;
            txtEmail.Enabled = enable;
            cbType.Enabled = enable;
            
        }
        private void EnableAccountEditing(bool enable)
        {
            btnSaveAccountSettings.Visible = enable;
            btnCancelChanges.Visible = enable;
            txtUsername.Enabled = enable;
            txtPassword.Enabled = enable;
            txtConfirmPass.Enabled = enable;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableInfoEditing(true);
            EnableAccountEditing(false);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            EnableAccountEditing(true);
            EnableInfoEditing(false);
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceImagePath = openFileDialog.FileName;
                pbProfilePic.ImageLocation = sourceImagePath;
                this.imageSource = sourceImagePath;
            }
            openFileDialog.Dispose();
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pbProfilePic.ImageLocation = null;
            this.imageSource = "";
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                UsersDB.UpdateUserInfo(this.userId, txtFirstName.Text, txtLastName.Text, txtEmail.Text, cbType.Text, this.imageSource);
                MessageBox.Show("Profile Updated Successfully");
                EnableInfoEditing(false);
                lblFullName.Text = txtLastName.Text + ", " + txtFirstName.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Loadprofile();
            EnableInfoEditing(false);
        }

        private void btnSaveAccountSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text != "" && txtPassword.Text == txtConfirmPass.Text && txtConfirmPass.Text.Length >= 8)
                {
                    UsersDB.UpdateUserAccount(this.userId, txtUsername.Text, DataSecure.Encrypt(txtConfirmPass.Text));
                    MessageBox.Show("Account Updated Successfully");
                    EnableAccountEditing(false);
                }
                else
                {
                    MessageBox.Show("Fill ensure that the following are satisfied:\n1. Username is not empty.\n2. Password is at least 8 characters.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            Loadprofile();
            EnableAccountEditing(false);
        }
    }
}
