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
    public partial class ProductControl : UserControl
    {
        private ShopControlView _parent;

        public ProductControl(string name, string brand, int quantity, ShopControlView parent)
        {
            InitializeComponent();
            this.tbName.Text = name;
            this.tbBrand.Text = brand;
            this.lbAvailableQuantity.Text = quantity.ToString();
            _parent = parent;
        }

        private void cbProduct_CheckedChanged(object sender, EventArgs e)
        {
            _parent.ProductSelected();
        }
    }
}
