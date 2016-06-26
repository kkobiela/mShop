using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop
{
    public class ShoppingCart
    {
        private Dictionary<products_in_shop, int> cart = new Dictionary<products_in_shop, int>();

        public bool AddProduct(products_in_shop product, int quantity)
        {
            int exist = cart.Where(item => item.Key.Id == product.Id).ToList().Count;
            if (exist == 0)
            {
                cart.Add(product, quantity);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProduct(products_in_shop product)
        {
            return cart.Remove(product);

        }

        public bool UpdateProductQuantity(products_in_shop product, int newQuantity)
        {
            if(cart.ContainsKey(product))
            {
                if (newQuantity > 0)
                {
                    cart[product] = newQuantity;
                    return true;
                }
                else return false;
                
            }
            return false;
        }

        public Dictionary<products_in_shop, int> GetProducts()
        {
            return cart;
        }
    }
}
