using mShop.Constants;
using mShop.Extensions;
using mShop.Models;
using mShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Presenters
{
    class ShopControlPresenter : IPresenter
    {
        public event EventHandler<ViewChangedArgs> ViewChanged;
        private ShopControlView _view;
        private Model _model;
        private ShoppingCart _cart = new ShoppingCart();

        public ShopControlPresenter(Model model, ShopControlView view)
        {
            _view = view;
            _model = model;
            _model.OpenConnection(ConnectionType.Shop);
            _view.ForceUpdateProductsList += UpdateProductsList;
            _view.SearchProduct += View_SearchProduct;
            _view.Logout += View_Logout;
            _view.ProductAdded += View_ProductChecked;
            _view.ProductRemovedFromCart += View_ProductRemovedFromCart;
            _view.LoginOfCurrentUser = _model.Login;
            _view.SellProduct += View_SellProducts;
        }


        private void View_SellProducts()
        {
            if (_cart.Count <= 0) return;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(ConstantTexts.DoYouWantToSellXItemsForX, _cart.Count, _cart.TotalPrice);
            sb.Append(ConstantTexts.PLN);
            if (_view.IsTransactionOk(sb.ToString()))
            {
                _model.ShopModel.CompleteOrder(_cart);
                _cart.RemoveAll();
                RefreshView();
            }
        }

        private void View_ProductChecked(products_in_shop item, int quantity)
        {
            if(quantity > 0 && quantity <= item.Quantity)
            { 
                _cart.AddProduct(item, quantity);
            }
            _view.UpdateCart(_cart.GetProducts());
        }

        private void View_SearchProduct(object sender, SearchItemArgs e)
        {
            List<products_in_shop> data = null;
            switch (e.Type)
            {
                case SearchItemType.Name:
                    data = _model.ShopModel.GetProductsByName(e.Value);
                    break;
                case SearchItemType.Brand:
                    data = _model.ShopModel.GetProductsByBrand(e.Value);
                    break;
                case SearchItemType.Category:
                    data = _model.ShopModel.GetProductsByCategory(ConstantTexts.Categories[e.Value]);
                    break;
                default:
                    break;
            }
            if(data.Count > 0)
            {
                _model.ShopModel.TemporaryProductsData = data;
                var dict = CompareWithCartAndReturnDictionary(data);
                _view.UpdateProductsList(dict);
            }
            else
            {
                _model.ShopModel.TemporaryProductsData = null;
                _view.UpdateProductsList(null);
                _view.SetSearchError(ConstantTexts.CannotFindProducts);
            }
        }

        private void View_Logout()
        {
            _model.Login = "";
            _model.Password = "";
            _model.CloseConnection();
            ViewChanged?.Invoke(this, new ViewChangedArgs(ViewType.Login));
        }

        public void UpdateView(List<string> data)
        {
            throw new NotImplementedException();
        }

        private void RefreshView()
        {
            _model.ShopModel.TemporaryProductsData = _model.ShopModel.GetProducts();
            UpdateProductsList();
            _view.UpdateCart(_cart.GetProducts());
        }
        
        public void UpdateProductsList()
        {
            var data = CompareWithCartAndReturnDictionary(_model.ShopModel.TemporaryProductsData);
            _view.UpdateProductsList(data);
        }

        public void UpdateView(string data)
        {
            throw new NotImplementedException();
        }

        private Dictionary<products_in_shop, int> CompareWithCartAndReturnDictionary(List<products_in_shop> list)
        {
            var data = new Dictionary<products_in_shop, int>();
            foreach (var item in list)
            {
                data.Add(item, ProductQuantityInCart(item));
            }
            return data;
        }

        private void View_ProductRemovedFromCart(products_in_shop item)
        {
            _cart.RemoveProduct(item);
            UpdateProductsList();
            _view.UpdateCart(_cart.GetProducts());
        }

        private bool IsInCart(products_in_shop item) => _cart.GetProducts().ContainsKey(item);
        private int ProductQuantityInCart(products_in_shop item) => _cart.ProductQuantity(item);
    }
}
