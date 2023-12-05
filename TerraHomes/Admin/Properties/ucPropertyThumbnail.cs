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
    public partial class ucPropertyThumbnail : UserControl
    {
        public ucPropertyThumbnail()
        {
            InitializeComponent();
        }
        public event EventHandler btnViewClick;

        private void btnView_Click(object sender, EventArgs e)
        {
            btnViewClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
