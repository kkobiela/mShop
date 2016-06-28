using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop
{
    public class ShoppingCart
    {
        private Dictionary<products_in_shop, int> _cart = new Dictionary<products_in_shop, int>();
        public int Count => _cart.Count;
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

        public void RemoveAll()
        {
            _cart = new Dictionary<products_in_shop, int>();
        }

        public int ProductQuantity(products_in_shop product) => _cart.ContainsKey(product) ? _cart[product] : 0;

        public bool RemoveProduct(products_in_shop product) => _cart.Remove(product);

        public Dictionary<products_in_shop, int> GetProducts() => _cart;

        public decimal TotalPrice => CalculateTotalPrice();

        private decimal CalculateTotalPrice()
        {
            decimal sum = 0m;
            foreach (var item in _cart)
            {
                sum += item.Key.Price*ProductQuantity(item.Key);
            }
            return sum;
        }

        public IEnumerator<KeyValuePair<products_in_shop, int>> GetEnumerator() => _cart.GetEnumerator();
        
    }
}
