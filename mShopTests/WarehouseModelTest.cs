using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mShop.Models;
using System.Collections.Generic;
using mShop.Views;
using mShop;

namespace mShopTests
{
    [TestClass]
    public class WarehouseModelTest
    {
        [TestMethod]
        public void GetProductsByName()
        {
            //arrange
            int expectedGoodValue = 5;
            int expectedBadValue = 0;
            string correctProductName = "Big Milk";
            string wrongProductName = "Syd";
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsByName(correctProductName).Count;
            int bad  = model.WarehouseModel.GetProductsByName(wrongProductName).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsByCategory()
        {
            //arrange
            int expectedGoodValue = 12;
            int expectedBadValue = 0;
            string correctProductCategory = "chemia";
            string wrongProductCategory = "zla";
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsByCategory(correctProductCategory).Count;
            int bad = model.WarehouseModel.GetProductsByCategory(wrongProductCategory).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsByBrand()
        {
            //arrange
            int expectedGoodValue = 5;
            int expectedBadValue = 0;
            string correctProductBrand = "Algida";
            string wrongProductBrand = "zlaMarka";
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsByBrand(correctProductBrand).Count;
            int bad = model.WarehouseModel.GetProductsByBrand(wrongProductBrand).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProducts()
        {
            //arrange
            int expectedGoodValue = 82;
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProducts().Count;

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
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsByBarcode(correctProductBarcode).Count;
            int bad = model.WarehouseModel.GetProductsByBarcode(wrongProductBarcode).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromShopByName()
        {
            //arrange
            int expectedGoodValue = 2;
            int expectedBadValue = 0;
            string correctProductName = "Winog";
            string wrongProductName = "Syd";
            int S_Id = 6;
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsFromShopByName(S_Id, correctProductName).Count;
            int bad = model.WarehouseModel.GetProductsFromShopByName(S_Id, wrongProductName).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromShopByCategory()
        {
            //arrange
            int expectedGoodValue = 5;
            int expectedBadValue = 0;
            string correctProductCategory = "inna";
            string wrongProductCategory = "Syd";
            int S_Id = 6;
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsFromShopByCategory(S_Id, correctProductCategory).Count;
            int bad = model.WarehouseModel.GetProductsFromShopByCategory(S_Id, wrongProductCategory).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromShopByBrand()
        {
            //arrange
            int expectedBadValue = 0;
            int expectedGoodValue = 1;
            string correctProductBrand = "OMO";
            string wrongProductBrand = "zlaMarka";
            int S_Id = 6;
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsFromShopByBrand(S_Id, correctProductBrand).Count;
            int bad = model.WarehouseModel.GetProductsFromShopByBrand(S_Id, wrongProductBrand).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromShop()
        {
            //arrange
            int expectedGoodValue = 7;
            int expectedBadValue = 0;
            int S_Id = 1;
            int S2_Id = 11;
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsFromShop(S_Id).Count;
            int bad = model.WarehouseModel.GetProductsFromShop(S2_Id).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }

        [TestMethod]
        public void GetProductsFromShopByBarcode()
        {
            //arrange
            int expectedGoodValue = 1;
            int expectedBadValue = 0;
            string correctProductBarcode = "0017333905650";
            string wrongProductBarcode = "1100333905650";
            int S_Id = 9;
            Model model = new Model();
            string login = "Hanna_Hanslik";
            string password = "hanslik";
            model.Login = login;
            model.Password = password;
            model.OpenConnection(ConnectionType.Warehouse);

            //act
            int good = model.WarehouseModel.GetProductsFromShopByBarcode(S_Id, correctProductBarcode).Count;
            int bad  = model.WarehouseModel.GetProductsFromShopByBarcode(S_Id, wrongProductBarcode).Count;


            //assert
            Assert.AreEqual(expectedGoodValue, good);
            Assert.AreEqual(expectedBadValue, bad);
        }
    }
}
