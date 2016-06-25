using mShop.Constants;
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
                _view.UpdateProductsList(data);
            }
            else
            {
                _model.ShopModel.TemporaryProductsData = null;
                //_view.UpdateProductsList(null);
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
        
        public void UpdateProductsList()
        {
            _view.UpdateProductsList(_model.ShopModel.TemporaryProductsData);
        }

        public void UpdateView(string data)
        {
            throw new NotImplementedException();
        }

    }
}
