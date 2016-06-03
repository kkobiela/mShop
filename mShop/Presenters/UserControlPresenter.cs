using mShop.Models;
using mShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Presenters
{
    class UserControlPresenter : IPresenter
    {
        public event EventHandler ViewChanged;
        private UserControlView _view;
        private Model _model;

        public UserControlPresenter(Model model, UserControlView view)
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
