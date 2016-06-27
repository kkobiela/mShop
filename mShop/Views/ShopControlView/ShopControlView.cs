using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mShop.Cart;

namespace mShop.Views
{
    public partial class ShopControlView : UserControl, IView
    {
        public event Action ForceUpdateProductsList;
        public event Action<products_in_shop, int> ProductAdded;
        public event Action<products_in_shop> ProductRemovedFromCart;
        public event EventHandler<SearchItemArgs> SearchProduct;
        public event Action SellProduct;
        public event Action Logout;
        public string LoginOfCurrentUser { set { tbLogin.Text = value; } }

        private int _currentPage = 0;
        private int _maxNumberOfPages = 0;

        public ViewType Type { get; set; }

        public ShopControlView()
        {
            InitializeComponent();
            Type = ViewType.Shop;
            pageChangerControl.PageChanged += ChangeCurrentPage;
            CreateSearchOptions();
        }

        public void ProductControl_ProductChecked(products_in_shop item, int quantity)
        {
            ProductAdded?.Invoke(item, quantity);
        }

        public void ChangeCurrentPage(object sender, PageChangedArgs e)
        {
            _currentPage = sender != null ? e.CurrentPage : 0;
            ForceUpdateProductsList?.Invoke();
        }

        public void SetError(string info)
        {
            throw new NotImplementedException();
        }

        public void SetSearchError(string info)
        {
            pageChangerControl.MaxNumberOfPages = 1;
            MessageBox.Show(info);
        }

        public void UpdateData()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductsList(Dictionary<products_in_shop, int> list)
        {
            DeleteItemsInControl(gbProductsList);
            AddProductControls(list);
        }

        public void UpdateCart(Dictionary<products_in_shop, int> list)
        {
            DeleteItemsInControl(panelCart);
            if (list != null)
            {
                int y = 0;
                foreach (var x in list)
                {
                    ShoppingCartControlView item = new ShoppingCartControlView(x.Key, x.Value);
                    item.Location = new System.Drawing.Point(0, y);
                    item.ProductRemovedFromCart += ShoppingCartControl_ProductRemovedFromCart;
                    panelCart.Controls.Add(item);
                    y += Constants.ConstantValues.ProductInCartMargin;
                }
            }
        }

        private void DeleteItemsInControl(Control ctrl)
        {
            int n = ctrl.Controls.Count;
            for (int i = 0; i < n; i++)
            {
                ctrl.Controls.Remove(ctrl.Controls[0]);
            }
        }

        private void DeleteAllProductControls()
        {
            int numberOfProducts = gbProductsList.Controls.Count;
            for (int i = 0; i < numberOfProducts; i++)
            {
                gbProductsList.Controls.Remove(gbProductsList.Controls[0]);
            }
        }

        private void AddProductControls(Dictionary<products_in_shop, int> list)
        {
            if (list != null)
            {
                _maxNumberOfPages = MaxNumberOfPages(list.Count);
                SetMaxNumberOfPages();
                int controlsToAdd = Constants.ConstantValues.NumberOfControlsOnPage;

                if ((_currentPage + 1) * controlsToAdd > list.Count)
                {
                    int controlsOnLastPage = list.Count % Constants.ConstantValues.NumberOfControlsOnPage;
                    controlsToAdd = controlsOnLastPage;
                    _currentPage = _maxNumberOfPages - 1;
                }

                int y = 0;
                foreach (var item in list.ToList().GetRange(_currentPage * Constants.ConstantValues.NumberOfControlsOnPage, controlsToAdd))
                {
                    var control = new ProductControl(item.Key, item.Value);
                    control.Location = new System.Drawing.Point(0, y);
                    control.ProductChecked += ProductControl_ProductChecked;
                    gbProductsList.Controls.Add(control);
                    y += Constants.ConstantValues.ProductControlMargin;
                }
            }
        }

        private int MaxNumberOfPages(int numberOfProducts)
        {
            int numberOfPages = (int)Math.Ceiling((double)numberOfProducts / (double)Constants.ConstantValues.NumberOfControlsOnPage);
            return numberOfPages;
        }

        private void SetMaxNumberOfPages()
        {
            pageChangerControl.MaxNumberOfPages = _maxNumberOfPages;
        }

        private void SetFirstPage()
        {
            _currentPage = 0;
            pageChangerControl.CurrentPage = _currentPage + 1;
        }

        private void CreateSearchOptions()
        {
            cbSearchCategory.Items.Add(Constants.ConstantTexts.Name);
            cbSearchCategory.Items.Add(Constants.ConstantTexts.Brand);
            cbSearchCategory.Items.Add(Constants.ConstantTexts.Category);
            cbSearchCategory.SelectedIndex = 0;

            cbCategory.Items.Add(Constants.ConstantTexts.VegetablesAndFruits);
            cbCategory.Items.Add(Constants.ConstantTexts.Drinks);
            cbCategory.Items.Add(Constants.ConstantTexts.DomesticDetergents);
            cbCategory.Items.Add(Constants.ConstantTexts.Others);
            cbCategory.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SetFirstPage();
            SearchItemArgs args = null;
            switch (cbSearchCategory.SelectedItem.ToString())
            {
                case "Name":
                    args = new SearchItemArgs(tbSearchProducts.Text, SearchItemType.Name);
                    break;
                case "Brand":
                    args = new SearchItemArgs(tbSearchProducts.Text, SearchItemType.Brand);
                    break;
                case "Category":
                    args = new SearchItemArgs(cbCategory.SelectedItem.ToString(), SearchItemType.Category);
                    break;
                default:
                    break;
            }
            if(args != null)
            { 
                SearchProduct?.Invoke(this, args);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout?.Invoke();
        }

        private void cbSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCategory.Visible = false;
            tbSearchProducts.Enabled = true;
            switch (cbSearchCategory.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    cbCategory.Visible = true;
                    tbSearchProducts.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            SellProduct?.Invoke();
        }

        public void ShoppingCartControl_ProductRemovedFromCart(products_in_shop item)
        {
            ProductRemovedFromCart?.Invoke(item);
        }
    }
}
