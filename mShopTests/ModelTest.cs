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
            string username2 = "Karol_Bok";
            string password2 = "bok";
            Model model = new Model();

            //act
            bool onLogin2 = model.UserExists(username2, password2);

            //assert
            Assert.IsTrue(onLogin2);

        }

    }
}
