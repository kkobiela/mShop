using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Views
{

    public class LoginEventArgs : EventArgs
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public LoginEventArgs(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    interface ILoginView
    {
        event EventHandler<LoginEventArgs> Login;
    }
}
