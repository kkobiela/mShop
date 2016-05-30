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

        public IPresenter CurrentPresenter { get; set; }

        public MainPresenter(Model model, MainView view)
        {
            _model = model;
            _view = view;
            _view.Presenter = this;
            _view.InitializeLoginView();
        }

        public void InitializePresenter(IView view)
        {
            switch (view.Type)
            {
                case Views.Type.Login:
                    CurrentPresenter = new LoginControlPresenter(_model, (LoginControlView)view);
                    break;
                case Views.Type.User:
                    break;
                default:
                    break;
            }
        }
    }
}
