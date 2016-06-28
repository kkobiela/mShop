using mShop.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Constants
{
    public static class ConstantTexts
    {
        


        public static string ShopName { get; } = "mShop";
        public static string Login { get; } = "Login:";
        public static string Password { get; } = "Password:";
        public static string BtnSearch { get; } = "Search";
        public static string LbQuantity { get; } = "Quantity:";
        public static string WrongUsernameOrPassword { get; } = "Wrong username or password.";
        public static string CannotFindProducts { get; } = "Unable to find products that meet given criteria.";
        public static string Error { get; } = "Error";
        public static string Sell { get; } = "Sell";
        public static string Name { get; } = "Name";
        public static string Brand { get; } = "Brand";
        public static string Category { get; } = "Category";
        public static string VegetablesAndFruits { get; } = "Vegetables/Fruits";
        public static string Drinks { get; } = "Drinks";
        public static string DomesticDetergents { get; } = "Domestic detergents";
        public static string Others { get; } = "Others";
        public static Dictionary<string, string> Categories { get { return _categories; } }
        private static Dictionary<string, string> _categories = new Dictionary<string, string>
        {
            {VegetablesAndFruits,  "warzywa_owoce"},
            {Drinks, "napoje"},
            {DomesticDetergents, "chemia"},
            {Others, "inne"}

        };

        public static string DoYouWantToSellXItemsForX { get; } = "Do you want to sell {0} item(s) for {1}";
        public static string PLN { get; } = "zł";
        public static string ConfirmTransaction { get; } = "Confirm transaction";
        public static string CannotAddZeroProducts { get; } = "Cannot add 0 products.";
        public static string CartIsEmpty { get; } = "Cart is empty.\nAdd something to cart.";
    }
}
