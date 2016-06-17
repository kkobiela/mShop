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
            ConnectDB();
        }
    
        public void InitializeLoginView()
        {
            string controlName = "viewControl";
            RemoveViewControl(controlName);
            LoginControlView viewControl = new LoginControlView();
            viewControl.Name = "viewControl";
            viewControl.Location = new System.Drawing.Point(125, 65);
            viewControl.Size = new System.Drawing.Size(150, 150);
            viewControl.TabIndex = 0;
            Controls.Add(viewControl);
            Presenter.InitializePresenter(viewControl);
        }

        public void InitializeUserView()
        {
            string controlName = "viewControl";
            RemoveViewControl(controlName);
            UserControlView viewControl = new UserControlView();
            viewControl.Name = "viewControl";
            viewControl.Location = new System.Drawing.Point(125, 65);
            viewControl.Size = new System.Drawing.Size(150, 150);
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

        public void ConnectDB()
        {
            using (var db = new mshopEntities("root", "asd"))
            {
                db.Database.Connection.Open();
            }
        }
    }
}
