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
    public partial class ucModifyAccount : UserControl
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string usertype { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string imageSource { get; set; }
        List<sp_GetAllUsersResult> allUsers = null;
        public ucModifyAccount()
        {
            InitializeComponent();
        }

        private void ucModifyAccount_Load(object sender, EventArgs e)
        {

        }
        

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            allUsers = UsersDB.GetAllUsers();

            if(txtUserID.Text != "")
            {
                var targetUser = from user in allUsers
                                 where user.UserID == Convert.ToInt32(txtUserID.Text)
                                 select user;
                if (targetUser.Any())
                {
                    btnSubmit.Enabled = true;
                    btnDelete.Enabled = true;
                    
                    this.userId = targetUser.FirstOrDefault().UserID;
                    this.firstName = targetUser.FirstOrDefault().Firstname;
                    this.lastName = targetUser.FirstOrDefault().Lastname;
                    this.email = targetUser.FirstOrDefault().Email;
                    this.usertype = targetUser.FirstOrDefault().UserType;
                    this.username = targetUser.FirstOrDefault().Username;
                    this.password = targetUser.FirstOrDefault().Password;
                    this.imageSource = targetUser.FirstOrDefault().imageURL;

                    txtEmail.Text = this.email;
                    txtFirstName.Text = this.firstName;
                    txtLastName.Text = this.lastName;
                    txtUsername.Text = this.username;
                    txtPassword.Text = this.password;
                    cbType.Text = targetUser.FirstOrDefault().UserType;
                    pbProfilePic.ImageLocation = targetUser.FirstOrDefault().imageURL;
                }
                else if (!targetUser.Any())
                {
                    ClearAllFields();
                    pbProfilePic.ImageLocation = null;
                    btnSubmit.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }                      
            else if (txtUserID.Text == "")
            {
                ClearAllFields();
                pbProfilePic.ImageLocation = null;
                btnSubmit.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        private void ClearAllFields()
        {
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cbType.SelectedIndex = 0;
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press event
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            this.SendToBack();
            this.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                UsersDB.UpdateUser(this.userId, txtUsername.Text, DataSecure.Encrypt(txtPassword.Text), txtFirstName.Text, txtLastName.Text, txtEmail.Text, cbType.Text, pbProfilePic.ImageLocation);

                MessageBox.Show("User Account Update Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            this.SendToBack();
            this.Visible = false;
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pbProfilePic.ImageLocation = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("This can't be undone, do you want to continue?", "Delete Account", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    UsersDB.DeleteUser(this.userId);
                    ClearAllFields();
                    MessageBox.Show("User account has been deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucModifyAccount_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                txtUserID.Text = this.userId.ToString();
            }
            else
            {
                txtUserID.Text = "";
            }
            
        }
    }
}
