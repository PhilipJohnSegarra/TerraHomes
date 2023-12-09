using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using TheArtOfDevHtmlRenderer.Adapters.Entities;

namespace TerraHomes.Admin
{
    public partial class ucAdminDashboard : UserControl
    {
        List<sp_GetPropertiesResult> _properties;
        List<sp_GetTransactionsResult> _transactions;
        public ucAdminDashboard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            _properties = PropertiesDB.GetProperties();
            _transactions = TransactionsDB.GetTransactions();

            AutoScroll = true;

            //AddCardsPanel();

            RevenueLineGraph();
            PropertiesSoldData();
            ShowTransactions();
        }
        private void PropertiesSoldData()
        {
            List<sp_PropertiesSoldResult> propSold = PropertiesDB.GetPropertiesSold();
            lblPropSold.Text = propSold.First().SoldCount.ToString();
            lblAmountPropSold.Text= propSold.First().AmountSold.ToString();

            List<sp_PropertiesRentedResult> propRented = PropertiesDB.GetPropertiesRented();
            lblPropRented.Text = propRented.First().SoldCount.ToString();
            lblAmountPropRented.Text = propRented.First().AmountSold.ToString();

            List<sp_CountAvailableResult> availableProps = PropertiesDB.CountAvailable();
            lblAvailable.Text = availableProps.First().Column1.ToString();

            //var propAvailable = from prop in _properties
            //                    where prop.Status == "Available"
            //                    select _properties.Count();

            //lblAvailable.Text = propAvailable.FirstOrDefault().ToString();

            var propPending = from prop in _properties
                              where prop.Status == "Pending"
                              select _properties.Count();
            lblPending.Text = propPending.FirstOrDefault().ToString();
        }
        private void ShowTransactions()
        {
            dgvTransactions.DataSource = _transactions.ToList();
        }

        private void RevenueLineGraph()
        {
            revenueChart.Datasets.Clear();
            var LineRevenue = from transacs in _transactions
                              group transacs by transacs.Date into transactions
                              orderby transactions.Min(t => t.Date) ascending
                              select transactions;

            foreach (var transacs in LineRevenue)
            {
                RevenueDataset.DataPoints.Add(transacs.First().Date.ToString(), (double)transacs.First().Amount);
            }

            //revenueChart.PaletteCustomColors.PointFillColors.AddRange(new System.Drawing.Color[] { color });
            //revenueChart.PaletteCustomColors.PointBorderColors.AddRange(new System.Drawing.Color[] { color });
            //RevenueDataset.FillColor = Color.FromArgb(79, 59, 43);

            //RevenueDataset.BorderWidth = 1;
            //RevenueDataset.PointBorderWidth = 0;
            //RevenueDataset.PointRadius = 3;

            revenueChart.Datasets.Add(RevenueDataset);

            revenueChart.Update();
        }
        private void ProfitLineGraph(int num1, int num2, string label,Random r)
        {

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ProfitDataset.Label = label;

            ProfitDataset.DataPoints.Add(months[0], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[1], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[2], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[3], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[4], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[5], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[6], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[7], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[8], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[9], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[10], r.Next(num1, num2));
            ProfitDataset.DataPoints.Add(months[11], r.Next(num1, num2));

            //revenueChart.PaletteCustomColors.BorderColors.AddRange(new System.Drawing.Color[] { Color.Blue });
            //revenueChart.PaletteCustomColors.PointFillColors.AddRange(new System.Drawing.Color[] { color });
            //revenueChart.PaletteCustomColors.PointBorderColors.AddRange(new System.Drawing.Color[] { color });
            //ProfitDataset.FillColor = Color.FromArgb(79, 59, 43);

            //ProfitDataset.BorderWidth = 1;
            //ProfitDataset.PointBorderWidth = 0;
            //ProfitDataset.PointRadius = 3;


            revenueChart.Datasets.Add(ProfitDataset);

            revenueChart.Update();
        }
        private void DonutGraph()
        {
            string[] months = { "Property Sales", "Rentals", "Others" };
            var r = new Random();
            var donutDataSet1 = new Guna.Charts.WinForms.GunaDoughnutDataset();
            donutDataSet1.DataPoints.Add(months[0], r.Next(1, 1000));
            donutDataSet1.DataPoints.Add(months[1], r.Next(1, 1000));
            donutDataSet1.DataPoints.Add(months[2], r.Next(1, 1000));
            //donutDataSet.FillColors.AddRange(new System.Drawing.Color[] { Color.FromArgb(79, 59, 43) });
            //donutDataSet.BorderWidth = 2;
            //donutDataSet.BorderColors.AddRange(new System.Drawing.Color[] { Color.White });
            occupancyPie.Datasets.Add(donutDataSet1);
            occupancyPie.Update();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            RevenueLineGraph();
            PropertiesSoldData();
            ShowTransactions();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        //private Control CardControl(string title, int Data, object Amount, int locationX, int locationY)
        //{
        //    Guna2GradientPanel pnl = new Guna2GradientPanel();
        //    Label lblTitle = new Label();
        //    Label lblData = new Label();
        //    Label lblAmount = new Label();

        //    lblTitle.Font = new Font("Fredoka", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        //    lblTitle.ForeColor = Color.FromArgb(57, 57, 57);
        //    lblTitle.Text = title;
        //    lblTitle.Width = pnl.Width;
        //    lblTitle.Height = 20;
        //    lblTitle.BackColor = Color.Transparent;
        //    lblTitle.Location = new Point(0, pnl.Height / 3 - lblTitle.Height + 10);
        //    lblTitle.TextAlign = ContentAlignment.MiddleCenter;

        //    lblData.Font = new Font("Fredoka", 32F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        //    lblData.ForeColor = Color.FromArgb(65, 63, 63);
        //    lblData.Text = Data.ToString();
        //    lblData.Width = pnl.Width;
        //    lblData.Height = 46;
        //    lblData.Location = new Point(0, pnl.Height / 2 - lblData.Height + 45);
        //    lblData.TextAlign = ContentAlignment.MiddleCenter;

        //    lblAmount.Font = new Font("Fredoka", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
        //    lblData.ForeColor = Color.FromArgb(37, 37, 37);
        //    lblAmount.Location = new Point(0, pnl.Height - lblData.Height + 50);
        //    lblAmount.Text = Amount.ToString();
        //    lblAmount.Width = pnl.Width;
        //    lblAmount.Height = 20;
        //    lblAmount.TextAlign = ContentAlignment.MiddleCenter;



        //    pnl.Width = 202; pnl.Height = 144;
        //    pnl.BackColor = Color.Transparent;
        //    pnl.BorderRadius = 7;
        //    pnl.FillColor = Color.FromArgb(255, 255, 255);
        //    pnl.FillColor2 = Color.FromArgb(164, 149, 138);
        //    pnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
        //    pnl.BorderRadius = 4;
        //    pnl.Location = new Point(locationX, locationY);
        //    pnl.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 4);
        //    pnl.ShadowDecoration.Enabled = true;

        //    pnl.Controls.Add(lblTitle);
        //    pnl.Controls.Add(lblData);
        //    pnl.Controls.Add(lblAmount);

        //    return pnl;
        //}
    }
}