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
    }
}
