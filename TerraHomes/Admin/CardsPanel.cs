using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin
{
    public class CardsControl
    {
        string Title { get; set; }
        int Data { get; set; }
        object Amount { get; set; }
        int LocationX { get; set; }
        int LocationY { get; set; }
        public CardsControl(string title, int Data, object Amount, int locationX, int locationY)
        {
            this.Title = title;
            this.Data = Data;
            this.Amount = Amount;
            this.LocationX = locationX;
            this.LocationY = locationY;
        }
        public Control InitializeComponent()
        {
            Guna2CustomGradientPanel pnl = new Guna2CustomGradientPanel();
            Label lblTitle = new Label();
            Label lblData = new Label();
            Label lblAmount = new Label();

            pnl.Width = 202; pnl.Height = 144;
            pnl.BackColor = Color.Transparent;
            pnl.BorderRadius = 7;
            //pnl.FillColor = Color.FromArgb(79,59,43);
            //pnl.FillColor2 = Color.FromArgb(164, 149, 138);
            pnl.FillColor = Color.FromArgb(71, 100, 99);
            pnl.FillColor2 = Color.FromArgb(79, 59, 43);
            pnl.FillColor3 = Color.FromArgb(31,38,53);
            pnl.FillColor4 = Color.FromArgb(79, 67, 43);
            //pnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            pnl.BorderRadius = 4;
            pnl.Location = new Point(LocationX, LocationY);
            pnl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 4);
            pnl.ShadowDecoration.Enabled = true;

            lblTitle.Font = new Font("Fredoka", 12F, FontStyle.Regular);
            //lblTitle.ForeColor = Color.FromArgb(57, 57, 57);
            lblTitle.ForeColor = Color.White;
            lblTitle.Text = Title;
            lblTitle.Width = pnl.Width;
            lblTitle.Height = 20;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Location = new Point(0, pnl.Height / 3 - lblTitle.Height - 5);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblData.Font = new Font("Fredoka", 32F, FontStyle.Regular);
            //lblData.ForeColor = Color.FromArgb(79, 59, 43);
            lblData.ForeColor = Color.White;
            lblData.Text = Data.ToString();
            lblData.Width = pnl.Width;
            lblData.Height = 46;
            lblData.BackColor = Color.Transparent;
            lblData.Location = new Point(0, pnl.Height / 2 - lblData.Height + 20);
            lblData.TextAlign = ContentAlignment.MiddleCenter;

            lblAmount.Font = new Font("Fredoka", 10F, FontStyle.Regular);
            //lblAmount.ForeColor = Color.FromArgb(37, 37, 37);
            lblAmount.ForeColor = Color.White;
            lblAmount.Text = Amount.ToString();
            lblAmount.Width = pnl.Width;
            lblAmount.Height = 20;
            lblAmount.Location = new Point(0, pnl.Height - lblAmount.Height - 20);
            lblAmount.BackColor = Color.Transparent;
            lblAmount.TextAlign = ContentAlignment.MiddleCenter;



            

            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(lblData);
            pnl.Controls.Add(lblAmount);
            pnl.Anchor = AnchorStyles.Top| AnchorStyles.Bottom;
            pnl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);

            return(pnl);
        }
    }
}
