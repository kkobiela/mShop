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
        public event Action ForceUpdateProductsList;
        public event Action<products_in_shop, int> ProductChecked;
        public event EventHandler<SearchItemArgs> SearchProduct;
        public event Action Logout;

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
            ProductChecked?.Invoke(item, quantity);
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
            MessageBox.Show(info);
        }

        public void UpdateData()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductsList(List<products_in_shop> list)
        {
            DeleteAllProductControls();
            AddProductControls(list);
        }

        public void UpdateCart(Dictionary<products_in_shop, int> list)
        {
            if (list != null)
            {
                int y = 0;
                foreach (var x in list)
                {
                    TextBox product = new TextBox();
                    product.Enabled = false;
                    product.BorderStyle = BorderStyle.None;
                    product.Text = x.Key.Name + " - " + x.Key.Brand + " - " + x.Value;
                    product.Size = new Size(300, 20);
                    product.Location = new System.Drawing.Point(0, y);
                    panelCart.Controls.Add(product);
                    y += Constants.ConstantValues.ProductInCartMargin;
                }
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

        private void AddProductControls(List<products_in_shop> list)
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
                    var control = new ProductControl(item);
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

        }
    }
}
