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

namespace TerraHomes.Admin.Agents
{
    public partial class ucAddNewAccount : UserControl
    {
        public int userId {  get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string usertype { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string imageSource {  get; set; }
        public ucAddNewAccount()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for basic email validation
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, emailPattern);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imageSource = openFileDialog.FileName;
                pbProfilePic.ImageLocation = imageSource;
            }
            openFileDialog.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsValidEmail(txtEmail.Text) && txtPassword.Text.Length >= 8)
                {
                    string password = DataSecure.Encrypt(txtPassword.Text);
                    UsersDB.InsertNewUser(txtUsername.Text, password, txtFirstName.Text, txtLastName.Text, txtEmail.Text, cbType.SelectedItem.ToString(), this.imageSource);

                    MessageBox.Show("New account has been added!");
                }
                else
                {
                    MessageBox.Show("Invalid Details Detected:\nMake sure to avoid invalidating the following:\n1.Email address.\n2.Password (must be 8 characters.)");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
