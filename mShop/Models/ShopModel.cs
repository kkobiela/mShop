using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.EntityClient;
namespace mShop.Models
{
    public class ShopModel
    {
        private int? currentShop;
        private mshopEntities db;
        public List<products_in_shop> TemporaryProductsData { get; set; } = null;


        public ShopModel(mshopEntities database, int? cS)
        {
            db = database;
            currentShop = cS;
        }

        public List<products_in_shop> GetProducts()
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == currentShop).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsByBarcode(string productBarcode)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == currentShop && item.Barcode.Contains(productBarcode)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsByBrand(string productBrand)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == currentShop && item.Brand.Contains(productBrand)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsByCategory(string productCategory)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == currentShop && item.Category.Contains(productCategory)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsByName(string productName)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == currentShop && item.Name.Contains(productName)).ToList();
               
                return products;
            }
            catch
            {
                return null;
            }
        }

        private bool BuyProduct(int Product_Id, int quantity)
        {
            try
            {
                if (quantity > 0)
                {
                    var orginal = db.Products_Shops.SingleOrDefault(item => item.S_Id == currentShop && item.P_Id == Product_Id);
                    orginal.Quantity -= quantity;
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool CompleteOrder()
        {
            return true;
        }
    }
}
