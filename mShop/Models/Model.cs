using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Models
{
    public class Model
    {
       public bool UserExists(string username, string password)
       {
            using (var db = new mshopEntities(username, password))
            {
                try
                {
                    db.SetCommandTimeOut(1);
                    db.Database.Connection.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    db.SetCommandTimeOut(100);
                }
            }
       }
    }
}
