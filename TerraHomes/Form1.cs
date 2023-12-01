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
    public partial class frmStartUp : Form
    {
        bool isDragging;
        UserControl1 ucLogIn;
        ucSignUp ucSignUp;
        UCtopButtons ucTopButtonsForLogin;
        UCtopButtons ucTopButtonsForSignUp;
        User users = new User();
        DCterrazonDataContext db = new DCterrazonDataContext();
        public frmStartUp()
        {
            InitializeComponent();
            isDragging = false;
            this.DoubleBuffered = true;

            //Initialize User Control : LOG IN
            ucLogIn = new UserControl1();
            ucLogIn.Location = new System.Drawing.Point(0, 0);
            ucLogIn.Height = 735;
            ucLogIn.Width = 1100;
            


            //Initialize User Control : SIGN UP
            ucSignUp = new ucSignUp();
            ucSignUp.Location = new System.Drawing.Point(0, 0);
            ucSignUp.Height = 735;
            ucSignUp.Width = 1100;


            //Initialize User Control : Top Buttons (for LogIn)
            ucTopButtonsForLogin = new UCtopButtons();
            ucTopButtonsForLogin.Location = new System.Drawing.Point(this.Width - 232, 0);
            ucTopButtonsForLogin.Height = 45;
            ucTopButtonsForLogin.Width = 232;
            ucTopButtonsForLogin.BackColor = System.Drawing.Color.Transparent;

            //Initialize User Control : Top Buttons (for SignUp)
            ucTopButtonsForSignUp = new UCtopButtons();
            ucTopButtonsForSignUp.Location = new System.Drawing.Point(this.Width - 232, 0);
            ucTopButtonsForSignUp.Height = 45;
            ucTopButtonsForSignUp.Width = 232;
            ucTopButtonsForSignUp.BackColor = System.Drawing.Color.Transparent;

            ucLogIn.Controls.Add(ucTopButtonsForLogin);
            ucSignUp.Controls.Add(ucTopButtonsForSignUp);
        }

        private void frmStartUp_Load(object sender, EventArgs e)
        {
            //Adds the user controls when the form loads
            //this.Controls.Add(ucLogIn);
            //this.Controls.Add(ucSignUp);
            List<sp_GetDataResult> data = UsersDB.GetData();
            if(data.Count > 0)
            {
                this.Controls.Clear();
                this.Controls.Add(ucLogIn);
                this.Controls.Add(ucSignUp);
            }
            else
            {
                this.Controls.Clear();
                this.Controls.Add(ucSignUp);
                this.Controls.Add(ucLogIn);
                ucSignUp.llLogIn.Enabled = false;
            }
        }
    }
}
