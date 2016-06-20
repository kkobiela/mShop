using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Models
{
    public class WarehouseModel
    {
        private int currentWarehouse;
        private mshopEntities db;

        public WarehouseModel(mshopEntities database, int cW)
        {
            db = database;
            currentWarehouse = cW;
        }

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
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Barcode == productBarcode).ToList();
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
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Brand == productBrand).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        public List<products_in_warehouse> GetProductsByCathegory(string productCathegory)
        {
            try
            {
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Category == productCathegory).ToList();
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
                List<products_in_warehouse> products = db.products_in_warehouse.Where(item => item.W_Id == currentWarehouse && item.Name == productName).ToList();
                return products;
            }
            catch
            {
                return null;
            }
        }

        
    }
}
