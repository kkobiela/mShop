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

        public ShopControlPresenter(Model model, ShopControlView view)
        {
            _view = view;
            _model = model;
        }

        public void UpdateView(List<string> data)
        {
            throw new NotImplementedException();
        }

        public void UpdateView(string data)
        {
            throw new NotImplementedException();
        }
    }
}
