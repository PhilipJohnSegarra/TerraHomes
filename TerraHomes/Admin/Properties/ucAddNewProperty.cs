using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin.Properties
{
    public partial class ucAddNewProperty : UserControl
    {
        List<string> imagePaths;
        public ucAddNewProperty()
        {
            InitializeComponent();
            imagePaths = new List<string>();
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
                imagePaths.Add(sourceImagePath);

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

                // Continue with other logic or handle the 'submit' action
                // For example, when the user submits, copy the image to the folder and store its name in the database
                // Here, 'sourceImagePath' holds the path of the selected image
                // Copy the image to the images folder, save the file name to the database, etc.
            }
            openFileDialog.Dispose();
        }

        private void btnClearImages_Click(object sender, EventArgs e)
        {
            foreach(Control c in flowLayoutPanel1.Controls)
            {
                PictureBox pictureBox = c as PictureBox;
                if (pictureBox != null)
                {
                    // Dispose the image and set it to null to release resources
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;

                    // Dispose the PictureBox itself
                    pictureBox.Dispose();
                };
            }
            flowLayoutPanel1.Controls.Clear();
            imagePaths.Clear();
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //RESET THE PAGE AND EMPTY ALL TEXTBOXES
            try
            {
                string mbText = "All data entered will be cleared, do you still want to proceed?";
                string Title = "Cancel Operation";
                if (MessageBox.Show(mbText, Title, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Visible = false;
                    this.SendToBack();
                    this.SendToBack();
                    txtPropertyName.Clear();
                    txtPropertyDesc.Clear();
                    txtPropertyAddress.Clear();
                    txtPropertySize.Clear();
                    txtPropertyPrice.Clear();
                    cbType.SelectedIndex = 0;
                    cbPropertyStatus.SelectedIndex = 0;

                    //Empty the panel that contains the images
                    foreach (Control c in flowLayoutPanel1.Controls)
                    {
                        PictureBox pictureBox = c as PictureBox;
                        if (pictureBox != null)
                        {
                            // Dispose the image and set it to null to release resources
                            pictureBox.Image.Dispose();
                            pictureBox.Image = null;

                            // Dispose the PictureBox itself
                            pictureBox.Dispose();
                        };
                    }
                    flowLayoutPanel1.Controls.Clear();
                }
                imagePaths.Clear();
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            //RESET THE PAGE AND EMPTY ALL TEXTBOXES
            try
            {
                string mbText = "All data entered will be cleared, do you still want to proceed?";
                string Title = "Cancel Operation";
                if (MessageBox.Show(mbText, Title, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    txtPropertyName.Clear();
                    txtPropertyDesc.Clear();
                    txtPropertyAddress.Clear();
                    txtPropertySize.Clear();
                    txtPropertyPrice.Clear();
                    cbType.SelectedIndex = 0;
                    cbPropertyStatus.SelectedIndex = 0;

                    //Empty the panel that contains the images
                    foreach (Control c in flowLayoutPanel1.Controls)
                    {
                        PictureBox pictureBox = c as PictureBox;
                        if (pictureBox != null)
                        {
                            // Dispose the image and set it to null to release resources
                            pictureBox.Image.Dispose();
                            pictureBox.Image = null;

                            // Dispose the PictureBox itself
                            pictureBox.Dispose();
                        };
                    }
                    flowLayoutPanel1.Controls.Clear();
                }
                imagePaths.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                decimal propPrice = Convert.ToDecimal(txtPropertyPrice.Text);
                PropertiesDB.InsertNewProperty(txtPropertyName.Text, txtPropertyAddress.Text, txtPropertyDesc.Text, cbType.Text, cbPropertyStatus.Text, propPrice, txtPropertySize.Text);
                var props = PropertiesDB.GetProperties();
                
                foreach (string pic in imagePaths)
                {
                    var latestProp = from prop in props
                                     where prop.PropertyID == props.Max(i => i.PropertyID)
                                     select prop;
                    //GET THE FILE NAME AND FILE EXTENSION
                    //string fileName = Path.GetFileName(pic);

                    //GET AND PREPARE THE DIRECTORY FOR 'Images' FOLDER
                    //string imagesFolderPath = @"C:\\Users\\phili\\source\\repos\\TerraHomes\\TerraHomes\\Images\\";
                    //string destinationImagePath = Path.Combine(imagesFolderPath, fileName);

                    //File.Copy(pic, destinationImagePath, true);

                    //INSERT THE fileName TO THE DATABASE
                    PropertyImagesDB.InsertNewPropertyImages(latestProp.First().PropertyID, pic);
                }

                MessageBox.Show("New Property Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
