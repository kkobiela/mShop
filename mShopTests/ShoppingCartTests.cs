using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mShop.Models;
using mShop;

using System.Threading.Tasks;

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

            ShoppingCart shoppingCart = new ShoppingCart();
 
            bool expectedGoodValue = true;
            bool expectedBadValue = false;

            //act
            bool good = shoppingCart.AddProduct(product,5);
            bool bad = shoppingCart.AddProduct(product,5);

            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void RemoveProduct()
        {
            //arrange
            products_in_shop goodProduct = new products_in_shop();
            goodProduct.Id = 5;

            products_in_shop badProduct = new products_in_shop();
            badProduct.Id = 500;

            ShoppingCart shoppingCart = new ShoppingCart();

            bool expectedGoodValue = true;
            bool expectedBadValue = false;

            shoppingCart.AddProduct(goodProduct,10);

            //act

            bool good = shoppingCart.RemoveProduct(goodProduct);
            bool bad = shoppingCart.RemoveProduct(badProduct);

            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void UpdateProduct()
        {
            //arrange
            products_in_shop goodProduct = new products_in_shop();
            goodProduct.Id = 5;
            goodProduct.Quantity = 50;

            products_in_shop badProduct = new products_in_shop();
            badProduct.Id = 10;


            ShoppingCart shoppingCart = new ShoppingCart();

            bool expectedGoodValue = true;
            bool expectedBadValue = false;

            shoppingCart.AddProduct(goodProduct,50);

            //act

            bool good = shoppingCart.UpdateProductQuantity(goodProduct, 15);
            bool bad1 = shoppingCart.UpdateProductQuantity(goodProduct, -10);
            bool bad2 = shoppingCart.UpdateProductQuantity(badProduct, 10);

            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad1);
            Assert.AreEqual(expectedBadValue, bad2);
        }

    }
}
