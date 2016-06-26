using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Models
{
    public class WarehouseModel
    {
        private int? currentWarehouse;
        private mshopEntities db;

        public WarehouseModel(mshopEntities database, int? cW)
        {
            db = database;
            currentWarehouse = cW;
        }

        #region Get products from Warehouse

        public List<products_in_warehouse> GetProducts()
        {
            try
            {
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsByBarcode(string productBarcode)
        {
            try
            {
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Barcode.Contains(productBarcode)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsByBrand(string productBrand)
        {
            try
            {
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Brand.Contains(productBrand)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsByCategory(string productCategory)
        {
            try
            {
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Category == productCategory).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsByName(string productName)
        {
            try
            {
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Name.Contains(productName)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Get products from Shop

        public List<products_in_shop> GetProductsFromShop(int S_Id)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == S_Id).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsFromShopByBarcode(int S_Id, string productBarcode)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == S_Id && item.Barcode.Contains(productBarcode)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsFromShopByBrand(int S_Id, string productBrand)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == S_Id && item.Brand.Contains(productBrand)).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsFromShopByCategory(int S_Id, string productCategory)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == S_Id && item.Category == productCategory).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_shop> GetProductsFromShopByName(int S_Id, string productName)
        {
            try
            {
                List<products_in_shop> products = db.products_in_shop.Where(item => item.S_Id == S_Id && item.Name.Contains(productName)).ToList();

                return products;
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
