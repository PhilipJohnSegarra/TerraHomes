using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerraHomes
{
    public class PropertyImagesDB
    {
        public static DCterrazonDataContext _dbContext = null;

        public static List<sp_GetPropertyImagesResult> GetPropertyImages()
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                return _dbContext.sp_GetPropertyImages().ToList<sp_GetPropertyImagesResult>();
            }
        }
        public static void InsertNewPropertyImages(int propertyID, string imageURL)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_InsertPropertyImages(propertyID, imageURL);
            }
        }
        public static void UpdatePropertyImages(int imageID, int propertyID, string imageURL)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_UpdatePropertyImages(imageID, propertyID, imageURL);
            }
        }
        public static void DeletePropertyImages(int imageID)
        {
            using(_dbContext = new DCterrazonDataContext())
            {
                _dbContext.sp_DeletePropertyImages(imageID);
            }
        }
    }
}
