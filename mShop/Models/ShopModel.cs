using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.EntityClient;
using System.Transactions;
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

        #region Get produstc from shop

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
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == currentShop && item.Category == productCategory).ToList();
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

        #endregion    

        #region Get products from Warehouse

        public List<products_in_warehouse> GetProductsFromWarehouse(int W_id)
        {
            try
            {
                var products = db.products_in_warehouse.Where(item => item.W_Id == W_id).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsFromWarehouseByName(int W_id, string productName)
        {
            try
            { 
                var products = db.products_in_warehouse.Where(item => item.W_Id == W_id && item.Name.Contains(productName)).ToList();
                return products;
             }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsFromWarehouseByBrand(int W_id, string productName)
        {
            try
            { 
                var products = db.products_in_warehouse.Where(item => item.W_Id == W_id && item.Brand.Contains(productName)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsFromWarehouseByBarcode(int W_id, string productBarcode)
        {
            try
            { 
                var products = db.products_in_warehouse.Where(item => item.W_Id == W_id && item.Barcode.Contains(productBarcode)).ToList();
                return products;
            }
            catch
            {
                return null;
            }


        }

        public List<products_in_warehouse> GetProductsFromWarehouseByCategory(int W_id, string productCategory)
        {
            try
            { 
                var products = db.products_in_warehouse.Where(item => item.W_Id == W_id && item.Category == productCategory).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        public bool CompleteOrder(ShoppingCart shoppingCart)
        {
            bool result = false;
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    foreach (var product in shoppingCart)
                    {
                        if (product.Value > 0)
                        {
                            var orginal = db.Products_Shops.SingleOrDefault(item => item.S_Id == currentShop && item.P_Id == product.Key.Id);
                            orginal.Quantity -= product.Value;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    db.SaveChanges();
                    transaction.Complete();
                    result = true;
                }
                catch
                {
                    result = false;
                }
            }
            return result;

        }
    }
}
