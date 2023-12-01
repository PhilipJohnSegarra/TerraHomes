using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class UsersDB
    {
        public static DCterrazonDataContext DB = null;

        //THIS METHOD GETS THE DATA FROM THE USERS TO SEE IF THERE ARE EXEISTING USERS
        public static List<sp_GetDataResult> GetData()
        {
            DB = new DCterrazonDataContext();
            List<sp_GetDataResult> Data = DB.sp_GetData().ToList<sp_GetDataResult>();
            return Data;
        }

        public static void InsertNewAdmin(User userTBL, string email, string username, string password)
        {
            DB = new DCterrazonDataContext();
            DB.sp_InsertSignUp(email, username, password);
        }
    }
}
