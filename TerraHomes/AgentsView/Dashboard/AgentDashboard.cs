using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.AgentsView.Dashboard
{
    public partial class AgentDashboard : UserControl
    {
        public int userID { get; set; }
        List<sp_GetPropertiesResult> _properties;
        List<sp_GetTransactionsResult> _transactions;

        public AgentDashboard()
        {
            InitializeComponent();
            _properties = PropertiesDB.GetProperties();
            _transactions = TransactionsDB.GetTransactions();

            PropertiesSoldData();
            RevenueLineGraph();
            ShowTransactions();
        }

        private void PropertiesSoldData()
        {
            List<sp_PropertiesSoldResult> propSold = PropertiesDB.GetPropertiesSold();
            lblPropSold.Text = propSold.First().SoldCount.ToString();
            lblAmountSold.Text = propSold.First().AmountSold.ToString();

            List<sp_PropertiesRentedResult> propRented = PropertiesDB.GetPropertiesRented();
            lblPropRented.Text = propRented.First().SoldCount.ToString();
            lblAmountRented.Text = propRented.First().AmountSold.ToString();

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PropertiesSoldData();
            RevenueLineGraph();
            ShowTransactions();
        }
    }
}
