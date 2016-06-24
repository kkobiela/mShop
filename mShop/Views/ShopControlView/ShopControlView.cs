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
        public event EventHandler<SearchProductArgs> SearchProduct;
        public event Action Logout;

        private int _currentPage = 0;
        private int _maxNumberOfPages = 0;

        public void ChangeCurrentPage(object sender, PageChangedArgs e)
        {
            _currentPage = sender != null ? e.CurrentPage : 0;
            ForceUpdateProductsList?.Invoke();
        }

        public ShopControlView()
        {
            InitializeComponent();
            Type = ViewType.Shop;
            pageChangerControl.PageChanged += ChangeCurrentPage;
        }

        public ViewType Type { get; set; }

        public void SetError(string info)
        {
            throw new NotImplementedException();
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

        public void UpdateCart(List<products_in_shop> list)
        {

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
            _maxNumberOfPages = MaxNumberOfPages(list.Count);
            SetMaxNumberOfPages();
            int controlsToAdd = Constants.ConstantValues.NumberOfControlsOnPage;

            if ((_currentPage+1) * controlsToAdd > list.Count)
            {
                int controlsOnLastPage = list.Count % Constants.ConstantValues.NumberOfControlsOnPage;
                controlsToAdd = controlsOnLastPage;
                _currentPage = _maxNumberOfPages -1;
            }

            int y = 0;
            foreach (var x in list.ToList().GetRange(_currentPage * Constants.ConstantValues.NumberOfControlsOnPage, controlsToAdd))
            {
                var control = new ProductControl(x.Name, x.Brand);
                control.Location = new System.Drawing.Point(0, y);
                gbProductsList.Controls.Add(control);
                y += Constants.ConstantValues.ProductControlMargin;
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
            pageChangerControl.Controls[0].Text = _maxNumberOfPages.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProductArgs args = new SearchProductArgs(tbSearchProductName.Text, cbSearchCategory.Text);
            SearchProduct?.Invoke(this, args);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout?.Invoke();
        }
    }
}
