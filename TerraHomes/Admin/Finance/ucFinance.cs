using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraHomes.Admin.Finance
{
    public partial class ucFinance : UserControl
    {
        List<sp_GetPropertiesResult> _properties;
        List<sp_GetTransactionsResult> _transactions;
        BudgetAllocation.frmBudgetAllocation frmBudgetAllocation;
        public ucFinance()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            _properties = PropertiesDB.GetProperties();
            _transactions = TransactionsDB.GetTransactions();

            AutoScroll = true;

            lblyear.Text = cbYear.Text;
            lblYear2.Text = cbYear.Text;

            ShowRevenueGraph();
            ShowBudget();
            ShowFinancialSummary();
            ShowDoughnutData();
        }
        private void ShowRevenueGraph()
        {
            barRevenueDataset.DataPoints.Clear();
            barExpensesDataset.DataPoints.Clear();

            //ADD THE DATAPOINTS FOR THE REVENUE
            var LineRevenue = from transacs in _transactions
                              where Convert.ToDateTime(transacs.Date).Year == Convert.ToInt16(cbYear.Text)
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
                barRevenueDataset.DataPoints.Add(month, (double)amount);
                monthIndex++;
            }

            //ADD THE DATAPOINTS FOR THE EXPENSES
            //var yearlyExpenses = from expense in BudgetAllocations.GetBudgets()
            //                     where Convert.ToDateTime(expense.DateAdded).Year == Convert.ToInt32(cbYear.Text)
            //                     group expense by expense.DateAdded into expenses
            //                     select new
            //                     {
            //                         Month = expenses.Key,
            //                         TotalAmount = Convert.ToDouble(expenses.Sum(a => a.AmountAllocated))
            //                     };
            int index = 0;
            foreach (var month in months)
            {
                double amount = 0L;
                foreach (var expenses in BudgetAllocations.GetBudgetSummary(Convert.ToInt32(cbYear.Text)).ToList())
                {
                    if (CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName((int)expenses.Months) == month)
                    {
                        amount += (double)expenses.TotalAmount;
                    }
                }
                barExpensesDataset.DataPoints.Add(month, (double)amount);
                amount = 0L;
                index++;
            }


            FinanceChart.Update();
        }
        private void ShowBudget()
        {
            dgvBudgetAllocation.DataSource = BudgetAllocations.GetBudgets().ToList();
        }
        private void ShowFinancialSummary()
        {
            //SHOW THE EXPENSES PER SECTOR PER YEAR
            var yearlyExpenses = from expense in BudgetAllocations.GetBudgets()
                                 where Convert.ToDateTime(expense.DateAdded).Year == Convert.ToInt32(cbYear.Text)
                                 group expense by expense.Sector into expenses
                                 select new
                                 {
                                     Sector = expenses.Key,
                                     TotalAmount = Convert.ToDouble(expenses.Sum(a => a.AmountAllocated)).ToString("C", CultureInfo.GetCultureInfo("en-US"))
                                 };
            dgvExpenses.DataSource = yearlyExpenses.ToList();

            //SHOW THE TOTAL REVENUE
            var TotalRevenue = Convert.ToDouble(_transactions
                .Where(d => Convert.ToDateTime(d.Date).Year == Convert.ToInt32(cbYear.Text))
                .Sum(t => t.Amount));
            lblTotalRevenue.Text = TotalRevenue.ToString("C", CultureInfo.GetCultureInfo("en-US"));

            //SHOW THE TOTAL EXPENSES PER YEAR
            var TotalExpenses = Convert.ToDouble(BudgetAllocations.GetBudgets()
                .Where(d => Convert.ToDateTime(d.DateAdded).Year == Convert.ToInt32(cbYear.Text))
                .Sum(t => t.AmountAllocated));
            lblTotalExpenses.Text = TotalExpenses.ToString("C", CultureInfo.GetCultureInfo("en-US"));
            
            //SHOW TOTAL PROFIT
            double profit = TotalRevenue - TotalExpenses;
            string formattedProfit = profit >= 0
            ? profit.ToString("C", CultureInfo.GetCultureInfo("en-US")) // Positive or zero
            : "-$" + Math.Abs(profit).ToString("0.00", CultureInfo.GetCultureInfo("en-US")); // Negative

            lblProfit.Text = formattedProfit;

            //SHOW THE THREE TYPES OF REVENUE
            var propSales = from transacs in _transactions
                            where Convert.ToDateTime(transacs.Date).Year == Convert.ToInt32(cbYear.Text)
                            join props in _properties on transacs.PropertyID equals props.PropertyID
                            group transacs by props.Type into props
                            select new
                            {
                                propType = props.Key,
                                Sum = props.Sum(t => t.Amount)
                            };
            RevenueDoughnut.DataPoints.Clear();
            foreach ( var prop in propSales.ToList())
            {
                if(prop.propType == "For Sale")
                {
                    lblPropSales.Text = Convert.ToDouble(prop.Sum).ToString("C", CultureInfo.GetCultureInfo("en-US"));
                    RevenueDoughnut.DataPoints.Add("Property Sales", Convert.ToDouble(prop.Sum));
                }
                else if(prop.propType == "For Rent")
                {
                    lblRentals.Text = Convert.ToDouble(prop.Sum).ToString("C", CultureInfo.GetCultureInfo("en-US"));
                    RevenueDoughnut.DataPoints.Add("Property Rented", Convert.ToDouble(prop.Sum));
                }
                else if(prop.propType == "Others")
                {
                    lblOthers.Text = Convert.ToDouble(prop.Sum).ToString("C", CultureInfo.GetCultureInfo("en-US"));
                    RevenueDoughnut.DataPoints.Add("Others", Convert.ToDouble(prop.Sum));
                }
            }
            ExpensesBreakdownChart.Update();
        }
        private void ShowDoughnutData()
        {
           // expensesDoughnut.DataPoints.Clear();
           // var yearlyExpenses = from expense in BudgetAllocations.GetBudgets()
           //                      where Convert.ToDateTime(expense.DateAdded).Year == Convert.ToInt32(cbYear.Text)
           //                      group expense by expense.Sector into expenses
           //                      select new
           //                      {
           //                          Sector = expenses.Key,
           //                          TotalAmount = Convert.ToDouble(expenses.Sum(a => a.AmountAllocated))
           //                      };
           //foreach(var expense in yearlyExpenses.ToList())
           // {
           //     expensesDoughnut.DataPoints.Add(expense.Sector, (double)expense.TotalAmount);
           // }

           // ExpensesBreakdownChart.Update();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmBudgetAllocation = new BudgetAllocation.frmBudgetAllocation();
            frmBudgetAllocation.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowRevenueGraph();
            ShowBudget();
            ShowFinancialSummary();
            ShowDoughnutData();
            lblyear.Text = cbYear.Text;
            lblYear2.Text = cbYear.Text;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRevenueGraph();
            ShowFinancialSummary();
            ShowDoughnutData();
            lblyear.Text = cbYear.Text;
            lblYear2.Text = cbYear.Text;
        }
    }
}
