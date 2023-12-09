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
        //Returns the full users table
        public static List<sp_GetAllUsersResult> GetAllUsers()
        {
            using(_dbContext= new DCterrazonDataContext())
            {
                return _dbContext.sp_GetAllUsers().ToList<sp_GetAllUsersResult>();
            }
        }
        //Inserts a new user to the users table
        public static void InsertNewUser(string username, string password,string firstname, string lastname, string email, string usertype, string imageURL)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertUsers(username, password, firstname, lastname, email, usertype, imageURL);
            }
        }
        //Updates a specified user on the users table
        public static void UpdateUser(int id, string username, string password, string firstname, string lastname, string email, string usertype, string imageURL)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_UpdateUsers(id, username, password, firstname, lastname, email, usertype,imageURL);
            }
        }
        //Deletes a specified user from the users table
        public static void DeleteUser(int id)
        {
            using (_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_DeleteUsers(id);
            }
        }

    }
}
