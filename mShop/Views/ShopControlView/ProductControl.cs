using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mShop.Constants;

namespace mShop.Views
{
    public partial class ProductControl : UserControl
    {
        public event Action<products_in_shop, int> ProductChecked;
        private products_in_shop _item;

        public ProductControl(products_in_shop item, int checkedItemQuantity)
        {
            InitializeComponent();
            this.tbName.Text = item.Name;
            this.tbBrand.Text = item.Brand;
            this.lbAvailableQuantity.Text = item.Quantity.ToString();
            this.numericUpDownQuantity.Value = checkedItemQuantity;
            this.numericUpDownQuantity.Maximum = item.Quantity;
            this.labelPrice.Text = item.Price.ToString() + ConstantTexts.PLN;
            _item = item;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);
            if (quantity > 0)
            {
                ProductChecked?.Invoke(_item, quantity);
            }
            else
            {
                MessageBox.Show(Constants.ConstantTexts.CannotAddZeroProducts,Constants.ConstantTexts.Error,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void EnterKeyPressAddToCart(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAddToCart_Click(sender, e);
            }
        }
    }
}
