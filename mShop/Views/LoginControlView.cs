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
using mShop.Constants;

namespace mShop.Views
{
    public partial class LoginControlView : UserControl, ILoginView, IView
    {
        public LoginControlView()
        {
            InitializeComponent();
            Type = ViewType.Login;
            tbLogin.Text = "Karol_Bok";
            tbPassword.Text = "bok";
        }

        public ViewType Type { get; set; }

        public event EventHandler<LoginEventArgs> Login;

        public void SetError(string info)
        {
            MessageBox.Show(info, ConstantTexts.Error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void UpdateData()
        {
            throw new NotImplementedException();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //if(btn != null)
            //{
                Login?.Invoke(this, new LoginEventArgs(tbLogin.Text, tbPassword.Text));
            //}
        }

        private void EnterKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
