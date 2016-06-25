using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Views
{
    public class SelectedProductArgs : EventArgs
    {
        public products_in_shop Product { get; private set; }
        public SelectedProductArgs(products_in_shop product)
        {
            Product = product;
        }
    }
}
