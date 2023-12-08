using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class PropertiesDB
    {
        public static DCterrazonDataContext _dbContext = null;

        public static List<sp_GetPropertiesResult> GetProperties()
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetProperties().ToList<sp_GetPropertiesResult>();
            }
        }

        public static void InsertNewProperty(string propname, string address, string description, string type, string status, decimal price, string size)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertProperties(propname, address, description, type, status, price, size);
            }
        }
        public static void UpdateProperty(int propID, string propname, string address, string description, string type, string status, decimal price, string size, int ownerID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_UpdateProperties(propID, propname, address, description, type, status, price, size, ownerID);
            }
        }
        public static void DeleteProperty(int propID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_DeleteProperties(propID);
            }
        }
    }
}
