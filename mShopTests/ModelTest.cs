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
            string username2 = "Karol_Bok";
            string password2 = "bok";
            Model model = new Model();

            //act
            bool onLogin = model.UserExists(username, correctPassword);
            bool onFail = model.UserExists(username, wrongPassword);
            bool onLogin2 = model.UserExists(username2, password2);

            //assert
            Assert.AreEqual(expectedOnLogin, onLogin);
            Assert.AreEqual(expectedOnFail, onFail);
            Assert.AreEqual(expectedOnLogin, onLogin2);

        }

    }
}
