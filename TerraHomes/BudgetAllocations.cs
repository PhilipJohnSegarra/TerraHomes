using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class BudgetAllocations
    {
        public static DCterrazonDataContext _dbContext = null;
        public static List<sp_GetBudgetsAllocationsResult> GetBudgets()
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetBudgetsAllocations().ToList();
            }
        }
        public static void InsertBudget(string sector, decimal amount, DateTime date)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertBudgetAllocation(sector, amount, date);
            }
        }
        public static List<sp_GetBudgetSummaryResult> GetBudgetSummary(int year)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetBudgetSummary(year).ToList();
            }
        }
    }
}
