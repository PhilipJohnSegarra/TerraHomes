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
    public partial class frmTransaction : Form
    {
        public int userID {  get; set; }
        public int propID { get; set; }
        public string propertyName { get; set; }
        public string address { get; set; }
        public string desc { get; set; }
        public List<string> Images { get; set; }
        public double price { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string size { get; set; }
        public int? agentID { get; set; }
        public List<sp_GetCustomersResult> customers = null;
        public frmTransaction(int propId)
        {
            InitializeComponent();
            this.propID = propId;

            customers = CustomersDB.GetCustomers();
            chbExisting.Checked = false;
            cbCustomers.SelectedIndex = -1;

            GetProperty();
            DisplayProperty();
            //GetCustomer();
        }
        //GETS THE CUSTOMER OF A SOLD OR RENTED PROPERTY
        private void GetCustomer()
        {
            var findProp = from prop in TransactionsDB.GetTransactions()
                           where prop.PropertyID == this.propID
                           select prop;
            if (findProp.Any())
            {
                chbExisting.Checked = !false;
                cbCustomers.SelectedValue = findProp.FirstOrDefault().CustomerID;
            }
            else
            {
                return;
            }
        }
        private void GetProperty()
        {
            var targetProperty = from prop in PropertiesDB.GetProperties()
                                 where prop.PropertyID == this.propID
                                 select prop;
            if (targetProperty.Any())
            {
                this.propertyName = targetProperty.FirstOrDefault().PropertyName;
                this.address = targetProperty.FirstOrDefault().Address;
                this.desc = targetProperty.FirstOrDefault().Description;
                this.price = (double)targetProperty.FirstOrDefault().Price;
                this.agentID = (targetProperty.FirstOrDefault().OwnerID != null)? targetProperty.FirstOrDefault().OwnerID : this.userID;
                this.type = targetProperty.FirstOrDefault().Type;
                this.status = targetProperty.FirstOrDefault().Status;
                this.size = targetProperty.FirstOrDefault().Size;
            }
        }
        private void frmTransaction_Load(object sender, EventArgs e)
        {
            var customersAll = from customer in customers
                            select new
                            {
                                ID = customer.CustomerID,
                                Fullname = customer.Firstname + " " + customer.Lastname
                            };

            cbCustomers.DisplayMember = "Fullname";
            cbCustomers.ValueMember = "ID";
            cbCustomers.DataSource = customersAll.ToList();
            cbCustomers.SelectedIndex = -1;
            cbCustomers.Enabled = false;
        }
        private void DisplayProperty()
        {
            txtPropertyName.Text = this.propertyName;
            txtPropertyId.Text = this.propID.ToString();
            txtPropertyDesc.Text = this.desc;
            txtPropertyAddress.Text = this.address;
            txtPropertyPrice.Text = this.price.ToString();
        }
        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbExisting.Checked)
            {
                var targetCustomer = from customer in customers
                                     where customer.CustomerID == (int)cbCustomers.SelectedValue
                                     select customer;
                txtCustFname.Text = targetCustomer.FirstOrDefault().Firstname;
                txtCustLname.Text = targetCustomer.FirstOrDefault().Lastname;
                txtCustAddress.Text = targetCustomer.FirstOrDefault().Address;
                txtCustEmail.Text = targetCustomer.FirstOrDefault().Email;
                txtCustPhone.Text = targetCustomer.FirstOrDefault().Phone;
            }
        }

        private void chbExisting_CheckedChanged(object sender, EventArgs e)
        {
            if (chbExisting.Checked)
            {
                cbCustomers.Enabled = true;
                txtCustFname.ReadOnly = true;
                txtCustLname.ReadOnly = true;
                txtCustAddress.ReadOnly = true;
                txtCustEmail.ReadOnly = true;
                txtCustPhone.ReadOnly = true;
            }
            else
            {
                cbCustomers.SelectedIndex = -1;
                cbCustomers.Enabled = !true; 
                txtCustFname.ReadOnly = !true; txtCustFname.Clear();
                txtCustLname.ReadOnly = !true; txtCustLname.Clear();
                txtCustAddress.ReadOnly = !true; txtCustAddress.Clear();
                txtCustEmail.ReadOnly = !true; txtCustEmail.Clear();
                txtCustPhone.ReadOnly = !true; txtCustPhone.Clear();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            chbExisting.Checked = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (chbExisting.Checked)
                {
                    string title = "Confirm Transaction";
                    string message = "Are you sure that you want to proceed?";
                    DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        TransactionsDB.InsertNewTransaction(dtpTransacDateTime.Value, (int)this.agentID, (int)cbCustomers.SelectedValue, this.propID, (decimal)this.price, "Approved");

                        if (this.type == "For Rent")
                        {
                            PropertiesDB.UpdateProperty(this.propID, this.propertyName, this.address, this.desc, this.type, "Rented", (decimal)this.price, this.size, (int)this.agentID);
                        }
                        else if (this.type == "For Sale")
                        {
                            PropertiesDB.UpdateProperty(this.propID, this.propertyName, this.address, this.desc, this.type, "Sold", (decimal)this.price, this.size, (int)this.agentID);
                        }
                        else
                        {
                            PropertiesDB.UpdateProperty(this.propID, this.propertyName, this.address, this.desc, this.type, "Sold", (decimal)this.price, this.size, (int)this.agentID);
                        }
                    }
                    else if(result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (!chbExisting.Checked)
                {
                    CustomersDB.InsertNewCustomer(txtCustFname.Text, txtCustLname.Text, txtCustEmail.Text, txtCustPhone.Text, txtCustAddress.Text);
                    var latestCustomer = from cust in CustomersDB.GetCustomers()
                                         where cust.CustomerID == CustomersDB.GetCustomers().Max(i => i.CustomerID)
                                         select cust;
                    TransactionsDB.InsertNewTransaction(dtpTransacDateTime.Value, Convert.ToInt32(this.agentID), latestCustomer.First().CustomerID, this.propID, Convert.ToDecimal(txtPropertyPrice.Text), "Approved");

                    if (this.type == "For Rent")
                    {
                        PropertiesDB.UpdateProperty(this.propID, this.propertyName, this.address, this.desc, this.type, "Rented", (decimal)this.price, this.size, (int)this.agentID);
                    }
                    else if (this.type == "For Sale")
                    {
                        PropertiesDB.UpdateProperty(this.propID, this.propertyName, this.address, this.desc, this.type, "Sold", (decimal)this.price, this.size, (int)this.agentID);
                    }
                    else
                    {
                        PropertiesDB.UpdateProperty(this.propID, this.propertyName, this.address, this.desc, this.type, "Sold", (decimal)this.price, this.size, (int)this.agentID);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
