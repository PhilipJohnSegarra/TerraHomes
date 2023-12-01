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
    public partial class ucTopPanel : UserControl
    {
        public ucTopPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
