using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin.Properties
{
    public partial class ucViewProperty : UserControl
    {
        public int userID {  get; set; }
        public int propID { get; set; }
        public List<string> images { get; set; }
        public List<string> newimages { get; set; }
        int count = 0;
        List<sp_GetAllUsersResult> users = null;
        public ucViewProperty()
        {
            InitializeComponent();
            users = UsersDB.GetAllUsers();
            newimages = new List<string>();

            btnAddImage.Enabled = false;
            btnClearImages.Enabled = false;
        }
        public void EnableUpdating()
        {
            txtPropertyName.ReadOnly = false;
            txtPropertyAddress.ReadOnly = false;
            txtPropertyDesc.ReadOnly = false;
            txtPropertySize.ReadOnly = false;
            txtPropertyPrice.ReadOnly = false;
            cbAssignees.Enabled = true;
            cbPropertyStatus.Enabled = true;
            cbType.Enabled = true;

            btnSubmit.Enabled = true;
            btnReset.Enabled = true;

            btnAddImage.Enabled = !false;
            btnClearImages.Enabled = !false;

            MessageBox.Show("You may begin updating the information below!\n\nHowever, changing and adding of images requires you to \ndelete and add the current property.");
        }

        private void ucViewProperty_Load(object sender, EventArgs e)
        {
            var agents = from agent in UsersDB.GetAllUsers()
                         where agent.UserType == "Agent"
                         select new
                         {
                             ID = agent.UserID,
                             FullName = agent.Firstname +" "+agent.Lastname
                         };
            cbAssignees.DisplayMember = "Fullname";
            cbAssignees.ValueMember = "ID";
            cbAssignees.DataSource = agents.ToList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string[] imagepaths = images.ToArray();
            btnPrevious.Enabled = true;
            
            if (count < imagepaths.Length-1)
            {
                count++;
                pbPropertyImages.ImageLocation = imagepaths[count];
                
            }
            else
            {
                count = 0;
                pbPropertyImages.ImageLocation = imagepaths[count];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            txtPropertyName.Clear();
            txtPropertyAddress.Clear();
            txtPropertyDesc.Clear();
            txtPropertySize.Clear();
            txtPropertyPrice.Clear();
            cbAssignees.Enabled = false;
            cbPropertyStatus.Enabled = false;
            cbType.Enabled = false;
            pbPropertyImages.ImageLocation = null;
            txtPropertyId.Text = "";
            this.SendToBack();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EnableUpdating();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Confirm property update?") == DialogResult.OK)
                {
                    PropertiesDB.UpdateProperty(this.propID, txtPropertyName.Text, txtPropertyAddress.Text, txtPropertyDesc.Text, cbType.Text, cbPropertyStatus.Text, Convert.ToDecimal(txtPropertyPrice.Text), txtPropertySize.Text, (int)cbAssignees.SelectedValue);

                    foreach (string paths in this.newimages)
                    {
                        PropertyImagesDB.InsertNewPropertyImages(this.propID, paths);
                    }

                    MessageBox.Show("Property has been updated");

                    txtPropertyName.ReadOnly = true;
                    txtPropertyAddress.ReadOnly = true;
                    txtPropertyDesc.ReadOnly = true;
                    txtPropertySize.ReadOnly = true;
                    txtPropertyPrice.ReadOnly = true;
                    cbAssignees.Enabled = false;
                    cbPropertyStatus.Enabled = false;
                    cbType.Enabled = false;

                    btnSubmit.Enabled = false;
                    btnReset.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtPropertyId.Text != "")
            {
                var editProp = from prop in PropertiesDB.GetProperties()
                               where prop.PropertyID == Convert.ToInt32(txtPropertyId.Text)
                               select prop;

                if (editProp.Any())
                {
                    this.propID = editProp.First().PropertyID;
                    var editPropImages = from propimg in PropertyImagesDB.GetPropertyImages()
                                         where propimg.PropertyID == Convert.ToInt32(txtPropertyId.Text)
                                         select propimg.ImageURL;
                    this.images = editPropImages.ToList();
                    pbPropertyImages.ImageLocation = this.images.First();


                    txtPropertyName.Text = editProp.First().PropertyName;
                    txtPropertyAddress.Text = editProp.First().Address;
                    txtPropertyDesc.Text = editProp.First().Description;
                    txtPropertySize.Text = editProp.First().Size;
                    txtPropertyPrice.Text = editProp.First().Price.ToString();
                    cbAssignees.Text = editProp.First().OwnerID.ToString();
                    cbPropertyStatus.Text = editProp.First().Status;
                    cbType.Text = editProp.First().Type;
                }
                else if (!editProp.Any())
                {
                    txtPropertyName.Clear();
                    txtPropertyAddress.Clear();
                    txtPropertyDesc.Clear();
                    txtPropertySize.Clear();
                    txtPropertyPrice.Clear();
                    cbAssignees.Text = "";
                    cbPropertyStatus.Text = "";
                    cbType.Text = "";
                    pbPropertyImages.ImageLocation = null;
                }
            }
            else
            {
                txtPropertyName.Clear();
                txtPropertyAddress.Clear();
                txtPropertyDesc.Clear();
                txtPropertySize.Clear();
                txtPropertyPrice.Clear();
                cbAssignees.Text = "";
                cbPropertyStatus.Text = "";
                cbType.Text = "";
                pbPropertyImages.ImageLocation = null;
            }
        }

        private void ucViewProperty_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            string[] imagepaths = images.ToArray();
            btnNext.Enabled = true;
            
            if(count > 0)
            {
                count--;
                pbPropertyImages.ImageLocation = imagepaths[count];
                
            }
            else
            {
                count = imagepaths.Length-1;
                pbPropertyImages.ImageLocation = imagepaths[count];
            }
        }

        private void cbAssignees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPropertyId_TextChanged(object sender, EventArgs e)
        {
            if(txtPropertyId.Text != "")
            {
                var editProp = from prop in PropertiesDB.GetProperties()
                               where prop.PropertyID == Convert.ToInt32(txtPropertyId.Text)
                               select prop;

                if (editProp.Any())
                {
                    this.propID = editProp.First().PropertyID;
                    var editPropImages = from propimg in PropertyImagesDB.GetPropertyImages()
                                         where propimg.PropertyID == Convert.ToInt32(txtPropertyId.Text)
                                         select propimg.ImageURL;
                    this.images = editPropImages.ToList();
                    if (editPropImages.Any())
                    {
                        pbPropertyImages.ImageLocation = this.images.First();
                    }
                    else
                    {
                        pbPropertyImages.ImageLocation = null;
                    }
                    txtPropertyName.Text = editProp.First().PropertyName;
                    txtPropertyAddress.Text = editProp.First().Address;
                    txtPropertyDesc.Text = editProp.First().Description;
                    txtPropertySize.Text = editProp.First().Size;
                    txtPropertyPrice.Text = editProp.First().Price.ToString();
                    cbAssignees.Text = editProp.First().OwnerID.ToString();
                    cbPropertyStatus.Text = editProp.First().Status;
                    cbType.Text = editProp.First().Type;
                }
                else if (!editProp.Any())
                {
                    txtPropertyName.Clear();
                    txtPropertyAddress.Clear();
                    txtPropertyDesc.Clear();
                    txtPropertySize.Clear();
                    txtPropertyPrice.Clear();
                    cbAssignees.Text = "";
                    cbPropertyStatus.Text = "";
                    cbType.Text = "";
                    pbPropertyImages.ImageLocation = null;
                }
            }
            else
            {
                txtPropertyName.Clear();
                txtPropertyAddress.Clear();
                txtPropertyDesc.Clear();
                txtPropertySize.Clear();
                txtPropertyPrice.Clear();
                cbAssignees.Text = "";
                cbPropertyStatus.Text = "";
                cbType.Text = "";
                pbPropertyImages.ImageLocation = null;
            }
        }

        private void txtPropertyId_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allowing digits, and control keys like Back, Delete, etc.
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the key press event
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string title = "Comfirm";
                string Message = "This property will be deleted permanently, \n continue?";
                DialogResult result = MessageBox.Show(Message, title, MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    PropertyImagesDB.DeleteAllPropImages(this.propID);
                    
                    PropertiesDB.DeleteProperty(this.propID);

                    this.Visible = false;
                    txtPropertyName.Clear();
                    txtPropertyAddress.Clear();
                    txtPropertyDesc.Clear();
                    txtPropertySize.Clear();
                    txtPropertyPrice.Clear();
                    cbAssignees.Enabled = false;
                    cbPropertyStatus.Enabled = false;
                    cbType.Enabled = false;
                    pbPropertyImages.ImageLocation = null;
                    txtPropertyId.Text = "";
                    this.SendToBack();

                    MessageBox.Show("Property has been deleted from the database");
                }
                else if(result == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                newimages.Add(sourceImagePath);

                // Create a PictureBox to display the selected image before copying
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 222; // Set a suitable width for the picture box
                pictureBox.Height = 196; // Set a suitable height for the picture box
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust picture box size mode as needed
                pictureBox.BackColor = Color.Black;

                // Set the image directly from the source path to the PictureBox
                pictureBox.Image = Image.FromFile(sourceImagePath);

                // Add the PictureBox to the FlowLayoutPanel to display the image
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
            openFileDialog.Dispose();
        }

        private void btnClearImages_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                PictureBox pictureBox = c as PictureBox;
                if (pictureBox != null)
                {
                    // Dispose the image and set it to null to release resources
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                    pictureBox.ImageLocation = null;

                    // Dispose the PictureBox itself
                    pictureBox.Dispose();
                };
            }
            flowLayoutPanel1.Controls.Clear();
            newimages.Clear();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction newtransaction = new frmTransaction(this.propID);
            newtransaction.userID = this.userID;
            newtransaction.ShowDialog();
        }
    }
}
