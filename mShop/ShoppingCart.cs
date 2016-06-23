using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop
{
    public class ShoppingCart
    {
        public List<products_in_shop> SCart { get; private set;} = new List<products_in_shop>();

        public bool AddNewProduct(products_in_shop product)
        {
            int exist = SCart.Where(item => item.Id == product.Id).ToList().Count;
            if (exist == 0)
            {
                SCart.Add(product);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProduct(int productID)
        {
            foreach(var product in SCart)
            {
                if(product.Id == productID)
                {
                    SCart.Remove(product);
                    return true;
                }
            }
            return false;

        }

        public bool UpdateProdactQuantity(int productID, int quantity)
        {
            foreach(var product in SCart)
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
    }
}
