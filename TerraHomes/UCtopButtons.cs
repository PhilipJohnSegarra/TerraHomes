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
    public partial class UCtopButtons : UserControl
    {
        public UCtopButtons()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent is Form parentForm)
            {
                parentForm.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
