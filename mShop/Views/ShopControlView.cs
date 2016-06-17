using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mShop.Views
{
    public partial class ShopControlView : UserControl, IView
    {
        public ShopControlView()
        {
            InitializeComponent();
            Type = ViewType.Shop;
        }

        public ViewType Type { get; set; }

        public void SetError()
        {
            throw new NotImplementedException();
        }

        public void UpdateData()
        {
            throw new NotImplementedException();
        }
    }
}
