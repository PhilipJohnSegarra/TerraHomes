using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class AgentsPropertyDB
    {
        public static DCterrazonDataContext _dbContext = null;

        public static List<sp_GetAgentPropertiesResult> GetAgentsProperties()
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetAgentProperties().ToList<sp_GetAgentPropertiesResult>();
            }
        }
        public static void InsertNewAgentProperty(int agentID, int propId)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertAgentProperties(agentID, propId);
            }
        }
        public static void UpdateAgentProperty(int agentPropID, int agentID, int propID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_UpdateAgentProperties(agentPropID, agentID, propID);
            }
        }
        public static void DeleteAgentProperty(int agentPropID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_DeleteAgentsProperties(agentPropID);
            }
        }
    }
}
