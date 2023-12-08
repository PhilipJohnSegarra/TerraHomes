using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class CustomersDB
    {
        public static DCterrazonDataContext _dbContext = null;

        public static List<sp_GetCustomersResult> GetCustomers()
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetCustomers().ToList<sp_GetCustomersResult>();
            }
        }
        public static void InsertNewCustomer(string fname, string lname, string email, string phone, string address)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertCustomers(fname, lname, email, phone, address);
            }
        }
        public static void UpdateCustomer(int customerID, string fname, string lname, string email, string phone, string address)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_UpdateCustomers(customerID, fname, lname, email, phone, address);
            }
        }
        public static void DeleteCustomer(int customerID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_DeleteCustomers(customerID);
            }
        }
    }
}
