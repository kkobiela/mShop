using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop
{
    public class ShoppingCart
    {
        private List<products_in_shop> cart = new List<products_in_shop>();

        public bool AddProduct(products_in_shop product)
        {
            int exist = cart.Where(item => item.Id == product.Id).ToList().Count;
            if (exist == 0)
            {
                cart.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProduct(int productID)
        {
            foreach(var product in cart)
            {
                if(product.Id == productID)
                {
                    cart.Remove(product);
                    return true;
                }
            }
            return false;

        }

        public bool UpdateProductQuantity(int productID, int quantity)
        {
            foreach(var product in cart)
            {
                if(product.Id == productID)
                {
                    if (quantity > 0)
                    {
                        product.Quantity = quantity;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public List<products_in_shop> GetProducts()
        {
            return cart;
        }
    }
}
