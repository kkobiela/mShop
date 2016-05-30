using mShop.Models;
using mShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Presenters
{


    public class LoginControlPresenter : IPresenter
    {
        private LoginControlView _view;
        private Model _model;

        public LoginControlPresenter(Model model, LoginControlView view)
        {
            _view = view;
            _model = model;
            _view.Login += View_Login;
        }

        public void UpdateView(List<string> data)
        {
            throw new NotImplementedException();
        }

        public void UpdateView(string data)
        {
            throw new NotImplementedException();
        }

        private bool CorrectUsernameAndPassword(string username, string password)
        {
            username.Trim();
            password.Trim();
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void View_Login(object sender, LoginEventArgs e)
        {
            LoginControlView lc = sender as LoginControlView;
            if (lc != null)
            {
                if (CorrectUsernameAndPassword(e.Username, e.Password))
                {
                    _view.UpdateData();
                }
            }
        }




    }
}
