using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop
{
    public class ShoppingCart
    {
        private Dictionary<products_in_shop, int> _cart = new Dictionary<products_in_shop, int>();

        public void AddProduct(products_in_shop product, int quantity)
        {
            if(_cart.ContainsKey(product))
            {
                _cart[product] = quantity;
            }
            else
            {
                _cart.Add(product, quantity);
            }
        }

        public int ProductQuantity(products_in_shop product) => _cart.ContainsKey(product) ? _cart[product] : 0;

        public bool RemoveProduct(products_in_shop product) => _cart.Remove(product);

        public Dictionary<products_in_shop, int> GetProducts() => _cart;
    }
}
