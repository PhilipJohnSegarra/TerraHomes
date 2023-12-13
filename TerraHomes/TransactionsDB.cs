using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class TransactionsDB
    {
        public static DCterrazonDataContext _dbContext = null;

        public static List<sp_GetTransactionsResult> GetTransactions()
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetTransactions().ToList<sp_GetTransactionsResult>();
            }
        }
        public static void InsertNewTransaction(DateTime date, int agentID, int customerID, int propertyID, decimal amount, string status)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertTransactions(date, agentID, customerID, propertyID, amount, status);
            }
        }
        public static void UpdateTransaction(int transactioID, DateTime date, int agentID, int customerID, int propertyID, decimal amount, string status)
        {
            using(_dbContext= new DCterrazonDataContext())
            {
                _dbContext.sp_UpdateTransactions(transactioID, date, agentID, customerID, propertyID, amount, status);
            }
        }
        public static void DeleteTransaction(int transactionID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_DeleteTransactions(transactionID);
            }
        }
        public static List<sp_GetAgentSoldCountResult> GetAgentSoldCount(int agentID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetAgentSoldCount(agentID).ToList<sp_GetAgentSoldCountResult>();
            }
        }
        public static List<sp_GetAgentRentedCountResult> GetAgentRentedCount(int agentID)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetAgentRentedCount(agentID).ToList<sp_GetAgentRentedCountResult>();
            }
        }
        public static List<sp_GetAgentAvailableCountResult> GetAgentAvailableCount(int agentID)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetAgentAvailableCount(agentID).ToList<sp_GetAgentAvailableCountResult>();
            }
        }
        public static List<sp_GetAgentPendingCountResult> GetAgentPendingCount(int agentID)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetAgentPendingCount(agentID).ToList<sp_GetAgentPendingCountResult>();
            }
        }
        public static List<sp_GetAgentTransactionsResult> GetAgentTransactions(int agentID)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetAgentTransactions(agentID).ToList<sp_GetAgentTransactionsResult>();
            }
        }
    }
}
