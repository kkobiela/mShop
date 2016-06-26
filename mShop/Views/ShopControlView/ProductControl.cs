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
        public event Action<products_in_shop, int> ProductChecked;
        private products_in_shop _item;

        public ProductControl(products_in_shop item, bool isChecked)
        {
            InitializeComponent();
            this.tbName.Text = item.Name;
            this.tbBrand.Text = item.Brand;
            this.lbAvailableQuantity.Text = item.Quantity.ToString();
            this.cbProduct.Checked = isChecked;
            _item = item;
        }

        private void cbProduct_CheckedChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);
            ProductChecked?.Invoke(_item, quantity);
        }
    }
}
