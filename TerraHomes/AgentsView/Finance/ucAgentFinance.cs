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

namespace TerraHomes.AgentsView.Finance
{
    public partial class ucAgentFinance : UserControl
    {
        public int userID { get; set; }
        List<sp_GetPropertiesResult> _properties;
        List<sp_GetTransactionsResult> _transactions;
        public ucAgentFinance()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            _properties = PropertiesDB.GetProperties();
            _transactions = TransactionsDB.GetTransactions();

            ShowRevenue();
            ShowFinancialSummary();
            ShowTransactions();
            lblYear.Text = cbYear.Text;
            lblYear2.Text = cbYear.Text;
        }
        private void ShowRevenue()
        {
            barRevenue.DataPoints.Clear();
            var LineRevenue = from transacs in _transactions
                              where Convert.ToDateTime(transacs.Date).Year == Convert.ToInt16(cbYear.Text) && transacs.AgentID == this.userID
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
                barRevenue.DataPoints.Add(month, (double)amount);
                monthIndex++;
            }

            revenueChart.Update();
        }
        private void ShowFinancialSummary()
        {
            var TotalRevenue = Convert.ToDouble(_transactions
                .Where(d => Convert.ToDateTime(d.Date).Year == Convert.ToInt32(cbYear.Text))
                .Where(a => a.AgentID == this.userID)
                .Sum(t => t.Amount));
            lblTotalRevenue.Text = TotalRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            double totalCommission = TotalRevenue * .05D;

            lblTotalCommissiom.Text = totalCommission.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            var propSales = from transacs in _transactions
                            where Convert.ToDateTime(transacs.Date).Year == Convert.ToInt32(cbYear.Text) && transacs.AgentID == this.userID
                            join props in _properties on transacs.PropertyID equals props.PropertyID
                            group transacs by props.Type into props
                            select new
                            {
                                propType = props.Key,
                                Sum = props.Sum(t => t.Amount)
                            };
            foreach (var prop in propSales.ToList())
            {
                if (prop.propType == "For Sale")
                {
                    lblPropSold.Text = Convert.ToDouble(prop.Sum).ToString("C", CultureInfo.GetCultureInfo("en-US"));
                }
                else if (prop.propType == "For Rent")
                {
                    lblPropRented.Text = Convert.ToDouble(prop.Sum).ToString("C", CultureInfo.GetCultureInfo("en-US"));
                }
                else if (prop.propType == "Others")
                {
                    lblOthers.Text = Convert.ToDouble(prop.Sum).ToString("C", CultureInfo.GetCultureInfo("en-US"));
                }
            }
        }
        private void ShowTransactions()
        {
            dgvTransactions.DataSource = TransactionsDB.GetAgentTransactions(this.userID).ToList();
        }
        private void ucAgentFinance_Load(object sender, EventArgs e)
        {
            ShowRevenue();
            ShowFinancialSummary();
            ShowTransactions();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowRevenue();
            ShowFinancialSummary();
            ShowTransactions();
            lblYear.Text = cbYear.Text;
            lblYear2.Text = cbYear.Text;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRevenue();
            ShowFinancialSummary();
            ShowTransactions();
        }
    }
}
