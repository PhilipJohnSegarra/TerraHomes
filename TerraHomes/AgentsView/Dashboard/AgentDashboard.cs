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
            DonutGraph();
            lblYear.Text = DateTime.Now.Year.ToString();

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
        private void DonutGraph()
        {
            var propSales = from transacs in _transactions
                            where Convert.ToDateTime(transacs.Date).Year == DateTime.Now.Year && transacs.AgentID == this.userID
                            join props in _properties on transacs.PropertyID equals props.PropertyID
                            group transacs by props.Type into props
                            select new
                            {
                                propType = props.Key,
                                Count = props.Count()
                            };
            OccupancyDoughnut.DataPoints.Clear();
            foreach (var prop in propSales.ToList())
            {
                if (prop.propType == "For Sale")
                {
                    OccupancyDoughnut.DataPoints.Add("Property Sales", prop.Count);
                }
                else if (prop.propType == "For Rent")
                {
                    OccupancyDoughnut.DataPoints.Add("Property Rented", prop.Count);
                }
                else if (prop.propType == "Others")
                {
                    OccupancyDoughnut.DataPoints.Add("Others", prop.Count);
                }
            }

            occupancyPie.Update();
        }
        private void RevenueLineGraph()
        {
            RevenueDataset.DataPoints.Clear();
            var LineRevenue = from transacs in _transactions
                              where Convert.ToDateTime(transacs.Date).Year == DateTime.Now.Year && transacs.AgentID == this.userID
                              group transacs by Convert.ToDateTime(transacs.Date).Month into transactions
                              select new
                              {
                                  Month = transactions.Key,
                                  Amount = transactions.Sum(t => t.Amount)
                              };

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int monthIndex = 1;
            List<Tuple<string, double>> MonthlyData = new List<Tuple<string, double>>();
            foreach (var month in months)
            {
                decimal? amount = 0L;
                foreach (var transacs in LineRevenue)
                {
                    if (transacs.Month == monthIndex)
                    {
                        amount = transacs.Amount;
                    }
                }
                RevenueDataset.DataPoints.Add(month, (double)amount);
                monthIndex++;
            }

            revenueChart.Datasets.Add(RevenueDataset);

            revenueChart.Update();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PropertiesSoldData();
            RevenueLineGraph();
            ShowTransactions();
            DonutGraph();
            lblYear.Text = DateTime.Now.Year.ToString();

        }
    }
}
