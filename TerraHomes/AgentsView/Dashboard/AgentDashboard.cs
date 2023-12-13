using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        public AgentDashboard(int userID)
        {
            InitializeComponent();

            this.userID = userID;
            _properties = PropertiesDB.GetProperties();
            _transactions = TransactionsDB.GetTransactions();
            

            PropertiesSoldData();
            RevenueLineGraph();
            ShowTransactions();
        }

        private void PropertiesSoldData()
        {
            var agentSoldCount = TransactionsDB.GetAgentSoldCount(this.userID);
            lblPropSold.Text = agentSoldCount.First().SoldCount.ToString();
            lblAmountSold.Text = Convert.ToDouble(agentSoldCount.First().TotalAmount).ToString("C", CultureInfo.GetCultureInfo("en-US"));

            var agentRentedCount = TransactionsDB.GetAgentRentedCount(this.userID);
            lblPropRented.Text = agentRentedCount.First().RentedCount.ToString();
            lblAmountRented.Text = Convert.ToDouble(agentRentedCount.First().Total_Amount).ToString("C", CultureInfo.GetCultureInfo("en-US"));

            var agentAvailableCount = TransactionsDB.GetAgentAvailableCount(this.userID);
            lblAvailable.Text = agentAvailableCount.First().AvailableCount.ToString();

            var agentPendingCount = TransactionsDB.GetAgentPendingCount(this.userID);
            lblPending.Text = agentPendingCount.First().PendingCount.ToString();
        }
        private void ShowTransactions()
        {
            dgvTransactions.DataSource = TransactionsDB.GetAgentTransactions(this.userID).ToList();
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
