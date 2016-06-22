using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Data;

namespace mShop.Models
{
    public enum ConnectionType {
        Shop,
        Warehouse
        } 

    public class Model
    {
        private mshopEntities db;
        private string loginuser = "Login_User";
        private string loginpassword = "login";

        #region Properties

        public string Login{ private get; set;}
        public string Password { private get; set; }

        public ShopModel ShopModel { get; private set; }
        public WarehouseModel WarehouseModel {get; private set;}

        #endregion

        public bool OpenConnection(ConnectionType connectionType)
        {
            try
            {
                db = new mshopEntities(Login, Password);
                db.Database.Connection.Open();

                if (connectionType == ConnectionType.Shop)
                {
                    ShopModel = new ShopModel(db, GetUserShopId(Login));
                }
                else if (connectionType == ConnectionType.Warehouse)
                {
                    WarehouseModel = new WarehouseModel(db, GetUserWarehouseId(Login));
                }

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }

        }

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

        private int? GetUserShopId(string login)
        {
            using (var db = new mshopEntities(loginuser, loginpassword))
            {
                try
                {
                    var user = db.Users.Where(item => item.Login == login).ToList();
                    int? shopId = user[0].S_Id;
                    return shopId;
                }
                catch(Exception e)
                {
                    throw new NotImplementedException();
                }
            }
        }

        private int GetUserWarehouseId(string login)
        {
            using (var db = new mshopEntities(loginuser, loginpassword))
            {
                try
                {
                    int user = Convert.ToUInt16(db.Users.Where(item => item.Login == login).Select(item => item.W_Id));
                    return user;
                }
                catch
                {
                    return 0;
                }
            }
        }

        public string GetWorkingPlaceOfUser(string login)
        {
            using (var db = new mshopEntities(loginuser, loginpassword))
            {
                try
                {
                    string query = "CALL work_place('" + login + "');";
                    string s = db.Database.SqlQuery<string>(query).ToString();
                    return s;
                }
                catch
                {
                    return null;
                }               
            }
                
        }
    }
}
