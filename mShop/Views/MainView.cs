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
        public MainPresenter Presenter{ get; set;}
        public MainView()
        {
            InitializeComponent();
        }
    
        public void InitializeLoginView()
        {
            string controlName = "viewControl";
            RemoveViewControl(controlName);
            LoginControlView viewControl = new LoginControlView();
            viewControl.Name = "viewControl";
            viewControl.Location = new System.Drawing.Point(0, 0);
            //viewControl.Size = new System.Drawing.Size(150, 150);
            viewControl.TabIndex = 0;
            Controls.Add(viewControl);
            Presenter.InitializePresenter(viewControl);
        }

        public void InitializeUserView()
        {
            string controlName = "viewControl";
            RemoveViewControl(controlName);
            ShopControlView viewControl = new ShopControlView();
            viewControl.Name = "viewControl";
            viewControl.Location = new System.Drawing.Point(0, 0);
            //viewControl.Size = new System.Drawing.Size(150, 150);
            viewControl.TabIndex = 0;
            Controls.Add(viewControl);
            Presenter.InitializePresenter(viewControl);
        }

        private void RemoveViewControl(string controlName)
        {
            foreach (Control item in this.Controls)
            {
                if(item.Name == controlName)
                {
                    Controls.Remove(item);
                }
            }
        }

    }
}
