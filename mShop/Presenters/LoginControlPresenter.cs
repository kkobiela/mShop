using mShop.Models;
using mShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mShop.Constants;

namespace mShop.Presenters
{


    public class LoginControlPresenter : IPresenter
    {
        private LoginControlView _view;
        private Model _model;

        public event EventHandler<ViewChangedArgs> ViewChanged;

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
            if (!string.IsNullOrEmpty(username))
            {
                if (_model.UserExists(username, password))
                {
                    return true;
                }
            }
            return false;
        }

        void View_Login(object sender, LoginEventArgs e)
        {
            LoginControlView lc = sender as LoginControlView;
            if (lc != null)
            {
                if (CorrectUsernameAndPassword(e.Username, e.Password))
                {
                    _model.Login = e.Username;
                    _model.Password = e.Password;
                    ViewChangedArgs args = new ViewChangedArgs(ViewType.Shop);
                    ViewChanged?.Invoke(this, args);
                }
                else
                {
                    _view.SetError(ConstantTexts.WrongUsernameOrPassword);
                }
            }
        }

    }
}
