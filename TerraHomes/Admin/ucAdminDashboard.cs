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
            DonutGraph();
            lblYear.Text = DateTime.Now.Year.ToString();
        }
        private void PropertiesSoldData()
        {
            List<sp_PropertiesSoldResult> propSold = PropertiesDB.GetPropertiesSold();
            lblPropSold.Text = propSold.First().SoldCount.ToString();
            lblAmountPropSold.Text= Convert.ToDouble(propSold.First().AmountSold).ToString("C", CultureInfo.GetCultureInfo("en-US"));

            List<sp_PropertiesRentedResult> propRented = PropertiesDB.GetPropertiesRented();
            lblPropRented.Text = propRented.First().SoldCount.ToString();
            lblAmountPropRented.Text = Convert.ToDouble(propRented.First().AmountSold).ToString("C", CultureInfo.GetCultureInfo("en-US"));

            List<sp_CountAvailableResult> availableProps = PropertiesDB.CountAvailable();
            lblAvailable.Text = availableProps.First().Column1.ToString();

            //var propAvailable = from prop in _properties
            //                    where prop.Status == "Available"
            //                    select _properties.Count();

            //lblAvailable.Text = propAvailable.FirstOrDefault().ToString();

            var propPending = from prop in _properties
                              where prop.Status == "Pending"
                              select prop;
            lblPending.Text = propPending.ToList().Count().ToString();
        }
        private void ShowTransactions()
        {
            //dgvTransactions.DataSource = _transactions.ToList();
            var transactions = from transacs in _transactions
                               join agent in UsersDB.GetAllUsers() on transacs.AgentID equals agent.UserID
                               join customer in CustomersDB.GetCustomers() on transacs.CustomerID equals customer.CustomerID
                               select new
                               {
                                   TransactionID = transacs.TransactionID,
                                   Date = transacs.Date,
                                   Agent = agent.Firstname + " " + agent.Lastname,
                                   Customer = customer.Firstname + " " + customer.Lastname,
                                   PropertyID = transacs.PropertyID,
                                   Amount = transacs.Amount
                               };
            dgvTransactions.DataSource = transactions.ToList();
        }

        private void RevenueLineGraph()
        {
            RevenueDataset.DataPoints.Clear();
            var LineRevenue = from transacs in _transactions
                              where Convert.ToDateTime(transacs.Date).Year == DateTime.Now.Year
                              group transacs by Convert.ToDateTime(transacs.Date).Month into transactions
                              select new
                              {
                                  Month = transactions.Key,
                                  Amount = transactions.Sum(t => t.Amount)
                              };

            string[] months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun","Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
            int monthIndex = 1;
            List<Tuple<string, double>> MonthlyData = new List<Tuple<string, double>>();
            foreach (var month in months)
            {
                decimal? amount = 0L;
                foreach(var transacs in LineRevenue)
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
        private void ProfitLineGraph()
        {

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        }
        private void DonutGraph()
        {
            var propSales = from transacs in _transactions
                            where Convert.ToDateTime(transacs.Date).Year == DateTime.Now.Year
                            join props in _properties on transacs.PropertyID equals props.PropertyID
                            group transacs by props.Type into props
                            select new
                            {
                                propType = props.Key,
                                Count = props.Count()
                            };
            OccupancyRatePie.DataPoints.Clear();
            foreach (var prop in propSales.ToList())
            {
                if (prop.propType == "For Sale")
                {
                    OccupancyRatePie.DataPoints.Add("Property Sales", prop.Count);
                }
                else if (prop.propType == "For Rent")
                {
                    OccupancyRatePie.DataPoints.Add("Property Rented", prop.Count);
                }
                else if (prop.propType == "Others")
                {
                    OccupancyRatePie.DataPoints.Add("Others", prop.Count);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            _properties = PropertiesDB.GetProperties();
            _transactions = TransactionsDB.GetTransactions();

            RevenueLineGraph();
            PropertiesSoldData();
            ShowTransactions();
            DonutGraph();
            lblYear.Text = DateTime.Now.Year.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}