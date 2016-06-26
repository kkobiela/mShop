using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mShop.Models;
using System.Collections.Generic;
using mShop.Views;
using mShop;


namespace mShopTests
{
    [TestClass]
    public class ShopModelTest
    {
        [TestMethod]
        public void GetProductsByName()
        {
            //arrange
            int expectedGoodValue = 6;
            int expectedBadValue = 0;
            string correctProductName = "Myd";
            string wrongProductName = "Syd";
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good= model.ShopModel.GetProductsByName(correctProductName).Count;
            int bad = model.ShopModel.GetProductsByName(wrongProductName).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsByCategory()
        {
            //arrange
            int expectedGoodValue = 13;
            int expectedBadValue = 0;
            string correctProductCategory = "napoje";
            string wrongProductCategory = "zla";
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsByCategory(correctProductCategory).Count;
            int bad = model.ShopModel.GetProductsByCategory(wrongProductCategory).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsByBrand()
        {
            //arrange
            int expectedGoodValue = 9;
            int expectedBadValue = 0;
            string correctProductBrand = "warzywoland";
            string wrongProductBrand = "zlaMarka";
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsByBrand(correctProductBrand).Count;
            int bad = model.ShopModel.GetProductsByBrand(wrongProductBrand).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProducts()
        {
            //arrange
            int expectedGoodValue = 44;
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProducts().Count;

            //assert
            Assert.AreEqual(expectedGoodValue, good);
        }

        [TestMethod]
        public void GetProductsByBarcode()
        {
            //arrange
            int expectedGoodValue = 1;
            int expectedBadValue = 0;
            string correctProductBarcode = "0017333905650";
            string wrongProductBarcode = "1100333905650";
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsByBarcode(correctProductBarcode).Count;
            int bad = model.ShopModel.GetProductsByBarcode(wrongProductBarcode).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void CompleteOrder()
        {
            //arrange
            bool expectedGoodValue = true;
            bool expectedBadValue = false;

            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            ShoppingCart goodShoppingCart = new ShoppingCart();
            ShoppingCart badShoppingCart = new ShoppingCart();


            var products = model.ShopModel.GetProductsByName("Myd");

            foreach (var item in products)
            {
                goodShoppingCart.AddProduct(item, 1);
            }

            foreach (var item in products)
            {
                badShoppingCart.AddProduct(item, -1);
            }

            //act
            bool good = model.ShopModel.CompleteOrder(goodShoppingCart);
            bool bad =  model.ShopModel.CompleteOrder(badShoppingCart);

            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);

        }

        [TestMethod]
        public void GetProductsFromWarehouseByName()
        {
            //arrange
            int expectedGoodValue = 2;
            int expectedBadValue = 0;
            string correctProductName = "Winog";
            string wrongProductName = "Syd";
            int W_Id = 1;
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsFromWarehouseByName(W_Id,correctProductName).Count;
            int bad = model.ShopModel.GetProductsFromWarehouseByName(W_Id, wrongProductName).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromWarehouseByCategory()
        {
            //arrange
            int expectedGoodValue = 18;
            int expectedBadValue = 0;
            string correctProductCategory = "napoje";
            string wrongProductCategory = "Syd";
            int W_Id = 5;
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsFromWarehouseByCategory(W_Id, correctProductCategory).Count;
            int bad  = model.ShopModel.GetProductsFromWarehouseByCategory(W_Id, wrongProductCategory).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromWarehouseByBrand()
        {
            //arrange
            int expectedGoodValue = 5;
            int expectedBadValue = 0;
            string correctProductBrand = "Algida";
            string wrongProductBrand = "Syd";
            int W_Id = 5;
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsFromWarehouseByBrand(W_Id, correctProductBrand).Count;
            int bad =  model.ShopModel.GetProductsFromWarehouseByBrand(W_Id, wrongProductBrand).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromWarehouse()
        {
            //arrange
            int expectedGoodValue = 82;
            int expectedBadValue = 0;
            int W_Id = 5;
            int W2_Id = 6;
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsFromWarehouse(W_Id).Count;
            int bad = model.ShopModel.GetProductsFromWarehouse(W2_Id).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromWarehouseByBarcode()
        {
            //arrange
            int expectedGoodValue = 1;
            int expectedBadValue = 0;
            string correctProductBarcode = "0017333905650";
            string wrongProductBarcode = "1100333905650";
            int W_Id = 5;
            Model model = new Model();
            string login = "Karol_Bok";
            string password = "bok";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Shop);

            //act
            int good = model.ShopModel.GetProductsFromWarehouseByBarcode(W_Id, correctProductBarcode).Count;
            int bad = model.ShopModel.GetProductsFromWarehouseByBarcode(W_Id, wrongProductBarcode).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

    }
}
