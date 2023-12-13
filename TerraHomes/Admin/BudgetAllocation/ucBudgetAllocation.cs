using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin.BudgetAllocation
{
    public partial class ucBudgetAllocation : UserControl
    {
        public ucBudgetAllocation()
        {
            InitializeComponent();
        }
        private void ResetFields()
        {
            cbSector.SelectedIndex = -1;
            txtAmount.Clear();
            dtpDate.Value = DateTime.Now;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ResetFields();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                BudgetAllocations.InsertBudget(cbSector.Text, Convert.ToDecimal(txtAmount.Text), dtpDate.Value);
                MessageBox.Show("Budget Allocated Successfully!");
                ResetFields();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Ignore the key press event
            }
        }
    }
}
