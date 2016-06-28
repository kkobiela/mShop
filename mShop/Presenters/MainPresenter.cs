using mShop.Models;
using mShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Presenters
{
    public class MainPresenter
    {
        private Model _model;
        private MainView _view;
        private Dictionary<ViewType, Action> ViewsDict;

        public IPresenter CurrentPresenter { get; set; }

        public MainPresenter(Model model, MainView view)
        {
            _model = model;
            _view = view;
            _view.Presenter = this;
            _view.InitializeLoginView();

            ViewsDict = new Dictionary<ViewType, Action>
            {
                {ViewType.Login, _view.InitializeLoginView},
                {ViewType.Shop, _view.IntializeShopview}
                
            };
        }


        public void InitializePresenter(IView view)
        {
            switch (view.Type)
            {
                case Views.ViewType.Login:
                    CurrentPresenter = new LoginControlPresenter(_model, (LoginControlView)view);
                    CurrentPresenter.ViewChanged += ViewChanged;
                    break;
                case Views.ViewType.Shop:
                    CurrentPresenter = new ShopControlPresenter(_model, (ShopControlView)view);
                    CurrentPresenter.ViewChanged += ViewChanged;
                    break;
                default:
                    break;
            }
        }

        private void ViewChanged(object sender, ViewChangedArgs e)
        {
            ViewsDict[e.ViewType].Invoke();
        }
    }
}
