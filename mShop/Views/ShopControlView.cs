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
        private Dictionary<string, string> _productList = new Dictionary<string, string>() {
            { "Proszek do prania","Ariel" },
            { "Mydło w płynie","Biały skunks"},
            { "Mydełko","Fa"},
            { "Tarka do kartofli","Fackelman"},
            { "Komputer Krzyśka", "Apple Inc."}
        };

        public ShopControlView()
        {
            InitializeComponent();
            Type = ViewType.Shop;
            UpdateProductsList(_productList);
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

        public void UpdateProductsList(Dictionary<string, string> list)
        {

            int y = 50;
            foreach (var x in list.ToList().GetRange(1, 2))
            {
                var control = new ProductControl(x.Key, x.Value);
                control.Location = new System.Drawing.Point(0, y);
                this.Controls.Add(control);
                y += 37;
            }
        }
    }
}
