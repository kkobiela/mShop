using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mShop.Cart
{
    public partial class ShoppingCartControlView : UserControl
    {
        products_in_shop _item;
        public int Id { get { return _item.Id; } }
        public ShoppingCartControlView()
        {
            InitializeComponent();
        }

        public ShoppingCartControlView(products_in_shop item, int quantity) : this()
        {
            tbItem.Text = item.Name + " - " + item.Brand + " - " + quantity; 
        }

        public void UpdateQuantity(products_in_shop item, int quantity)
        {
            tbItem.Text = item.Name + " - " + item.Brand + " - " + quantity;
        }
    }
}
