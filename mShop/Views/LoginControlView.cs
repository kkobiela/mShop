using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mShop.Presenters;

namespace mShop.Views
{
    public partial class LoginControlView : UserControl, ILoginView, IView
    {
        public LoginControlView()
        {
            InitializeComponent();
            Type = Type.Login;
        }

        public Type Type { get; set; }

        public event EventHandler<LoginEventArgs> Login;

        public void SetError()
        {
            throw new NotImplementedException();
        }

        public void UpdateData()
        {
            throw new NotImplementedException();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if(btn != null)
            {
                Login?.Invoke(this, new LoginEventArgs(tbLogin.Text, tbPassword.Text));
            }
        }

    }
}
