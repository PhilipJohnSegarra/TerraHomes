using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.AgentsView.Properties
{
    public partial class ucSellProperty : UserControl
    {
        public int CurrentUserId { get; set; }
        public int propertyId {  get; set; }
        public string propertyName { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public decimal? price { get; set; }
        public string Type { get; set; }
        public string size { get; set; }
        List<sp_GetPropertiesResult> properties = null;
        public ucSellProperty()
        {
            InitializeComponent();
            properties = PropertiesDB.GetProperties();
        }

        private void txtPropertyId_TextChanged(object sender, EventArgs e)
        {
            if(txtPropertyId.Text == "")
            {
                ClearAllFields();
            }
            else
            {
                var targetProp = from prop in properties
                                 where prop.PropertyID == Convert.ToInt32(txtPropertyId.Text)
                                 select prop;
                if (targetProp.Any())
                {
                    this.propertyName = targetProp.First().PropertyName;
                    this.address = targetProp.First().Address;
                    this.description = targetProp.First().Description;
                    this.price = targetProp.First().Price;
                    this.Type = targetProp.First().Type;
                    this.size = targetProp.First().Size;

                    txtPropertyName.Text = this.propertyName;
                    txtPropertyAddress.Text = this.address;
                    txtPropertyDesc.Text = this.description;
                    txtPropertyPrice.Text = this.price.ToString();
                }
                else
                {
                    ClearAllFields() ;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false; this.SendToBack();
        }
        private void ClearAllFields()
        {
            txtPropertyName.Clear();
            txtPropertyAddress.Clear();
            txtPropertyDesc.Clear();
            txtPropertyPrice.Clear();
        }

        private void btnAddTransac_Click(object sender, EventArgs e)
        {
            try
            {
                //CustomersDB.InsertNewCustomer(txtCustFname.Text, txtCustLname.Text, txtCustEmail.Text, txtCustPhone.Text, txtCustAddress.Text);
                var latestCustomer = from cust in CustomersDB.GetCustomers()
                                     where cust.CustomerID == CustomersDB.GetCustomers().Max(i => i.CustomerID)
                                     select cust;
                TransactionsDB.InsertNewTransaction(dtpTransacDateTime.Value, this.CurrentUserId, latestCustomer.First().CustomerID, this.propertyId, Convert.ToDecimal(txtPropertyPrice.Text), "Approved");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ucSellProperty_Load(object sender, EventArgs e)
        {

        }

        private void txtPropertyId_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPropertyId.Text == "")
            {
                ClearAllFields();
            }
            else
            {
                var targetProp = from prop in properties
                                 where prop.PropertyID == Convert.ToInt32(txtPropertyId.Text)
                                 select prop;
                if (targetProp.Any())
                {
                    this.propertyId = targetProp.First().PropertyID;
                    this.propertyName = targetProp.First().PropertyName;
                    this.address = targetProp.First().Address;
                    this.description = targetProp.First().Description;
                    this.price = targetProp.First().Price;
                    this.Type = targetProp.First().Type;
                    this.size = targetProp.First().Size;

                    txtPropertyName.Text = this.propertyName;
                    txtPropertyAddress.Text = this.address;
                    txtPropertyDesc.Text = this.description;
                    txtPropertyPrice.Text = this.price.ToString();
                }
                else
                {
                    ClearAllFields();
                }
            }
        }
    }
}
