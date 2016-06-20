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
        public ProductControl(string name, string brand)
        {
            InitializeComponent();
            this.tbName.Text = name;
            this.tbBrand.Text = brand;
        }
    }
}
