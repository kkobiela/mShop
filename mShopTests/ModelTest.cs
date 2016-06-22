using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mShop.Models;

namespace mShopTests
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void UserExistsTest()
        {
            //arrange
            bool expectedOnLogin = true;
            bool expectedOnFail = false;
            string correctPassword = "";
            string wrongPassword = "wrong";
            string username = "root";
            Model model = new Model();

            //act
            bool onLogin = model.UserExists(username, correctPassword);
            bool onFail = model.UserExists(username, wrongPassword);

            //assert
            Assert.AreEqual(expectedOnLogin, onLogin);
            Assert.AreEqual(expectedOnFail, onFail);

        }

    }
}
