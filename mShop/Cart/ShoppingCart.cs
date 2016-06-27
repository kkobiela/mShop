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

        public void AddProduct(products_in_shop product, int quantity)
        {
            if(cart.ContainsKey(product))
            {
                cart[product] = quantity;
                Console.WriteLine("dziala??");
            }
            else
            {
                cart.Add(product, quantity);
            }

        }

        public int ProductQuantity(products_in_shop product) => cart.ContainsKey(product) ? cart[product] : 0;

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
                    Console.WriteLine("dz");
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
