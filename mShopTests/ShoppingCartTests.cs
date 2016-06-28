using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mShop.Models;
using mShop;

using System.Threading.Tasks;
using System.Collections.Generic;

namespace mShopTests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void AddNewProduct()
        {
            //arrange
            products_in_shop product = new products_in_shop();
            product.Id = 5;
            product.Quantity = 4;

            int quantity = 5;

            ShoppingCart shoppingCart = new ShoppingCart();
            KeyValuePair<products_in_shop, int> expectedKeyValue = new KeyValuePair<products_in_shop, int>(product, quantity);
            
            //act
            shoppingCart.AddProduct(product, quantity);

            //assert
            foreach (var item in shoppingCart)
            {
                Assert.AreEqual(expectedKeyValue, item);
            }
            
        }

        [TestMethod]
        public void RemoveProduct()
        {
            //arrange
            products_in_shop product = new products_in_shop();
            product.Id = 5;
            product.Quantity = 4;

            int quantity = 5;

            ShoppingCart shoppingCart = new ShoppingCart();
            KeyValuePair<products_in_shop, int> expectedKeyValue = new KeyValuePair<products_in_shop, int>(product, quantity);

            int expectedCount = 0;

            //act
            shoppingCart.AddProduct(product, quantity);
            shoppingCart.RemoveProduct(expectedKeyValue.Key);
            //assert
            Assert.AreEqual(expectedCount, shoppingCart.Count);
        }

       

    }
}
