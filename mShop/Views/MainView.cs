using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using mShop.Views;
using mShop.Presenters;

namespace mShop
{
    public partial class MainView : Form
    {
        //private LoginControl loginControl;
        public MainPresenter Presenter{ get; set;}
        public MainView()
        {
            InitializeComponent();
        }
    
        public void InitializeLoginView()
        {
            LoginViewControl loginViewControl = new LoginViewControl();
            loginViewControl.Location = new System.Drawing.Point(125, 65);
            loginViewControl.Name = "loginControl";
            loginViewControl.Size = new System.Drawing.Size(150, 150);
            loginViewControl.TabIndex = 0;
            Controls.Add(loginViewControl);
            Presenter.InitializePresenter(loginViewControl);        
        }

    }
}
