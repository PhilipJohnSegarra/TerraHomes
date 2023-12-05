using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TerraHomes
{
    public class UsersDB
    {
        public static DCterrazonDataContext _dbContext = null;


        //THIS METHOD GETS THE DATA FROM THE USERS TO SEE IF THERE ARE EXEISTING USERS
        public static List<sp_GetDataResult> GetData()
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetData().ToList<sp_GetDataResult>();
            }

        }

        public static void InsertNewAdmin(string email, string username, string password)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertSignUp(email, username, password);
            }
        }

        public static List<sp_GetUsersResult> GetUsers()
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetUsers().ToList<sp_GetUsersResult>();
            }
        }
        public static void InsertNewUser(string username, string password,string firstname, string lastname, string email, string usertype)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertUsers(username, password, firstname, lastname, email, usertype);
            }
        }
        public static void UpdateUser(int id, string username, string password, string firstname, string lastname, string email, string usertype)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_UpdateUsers(id, username, password, firstname, lastname, email, usertype);
            }
        }
        public static void DeleteUser(int id)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_DeleteUsers(id);
            }
        }
    }
}
