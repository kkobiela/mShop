using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mShop.Models;
using System.Collections.Generic;
using mShop.Views;



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
    }
}
