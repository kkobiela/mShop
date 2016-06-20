﻿using System;
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

        private int currentPage = 0;

        public void ChangeCurrentPage(object sender, PageChangedArgs e)
        {
            currentPage = sender != null ? e.CurrentPage : 0;
            ForceUpdateProductsList?.Invoke();
        }

        public ShopControlView()
        {
            InitializeComponent();
            Type = ViewType.Shop;
            pageChangerControl.PageChanged += ChangeCurrentPage;
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

        public void UpdateProductsList(List<products_in_shop> list)
        {

            int y = 0;
            for(int i = 0; i<gbProductsList.Controls.Count; i++)
            {
                gbProductsList.Controls.Remove(gbProductsList.Controls[i]);
            }

            foreach (var x in list.ToList().GetRange(currentPage * 8, 8))
            {
                var control = new ProductControl(x.Name, x.Brand);
                control.Location = new System.Drawing.Point(0, y);
                this.gbProductsList.Controls.Add(control);
                y += 37;
            }
        }

        public event Action ForceUpdateProductsList;

        private void pageChangerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
