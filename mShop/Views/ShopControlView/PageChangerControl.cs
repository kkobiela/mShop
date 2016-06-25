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
    public partial class PageChangerControl : UserControl
    {
        public event EventHandler<PageChangedArgs> PageChanged;

        private int _currentPage = 0;
        private int _maxNumberOfPages = 0;
        public int MaxNumberOfPages {
            get { return _maxNumberOfPages; }
            set {
                _maxNumberOfPages = value;
                ChangeMaxPageLabel(value);
            }
        }

        public PageChangerControl()
        {
            InitializeComponent();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPage < MaxNumberOfPages - 1)
            {
                _currentPage += 1;
                ChangeCurrentPageLabel(_currentPage);
                PageChanged?.Invoke(this, new PageChangedArgs(_currentPage));
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 0)
            {
                _currentPage -= 1;
                ChangeCurrentPageLabel(_currentPage);
                PageChanged?.Invoke(this, new PageChangedArgs(_currentPage));
            }
        }

        private void ChangeCurrentPageLabel(int pageNumber)
        {
            var pages = labelPages.Text.Split('/');
            pages[0] = (pageNumber+1).ToString();
            labelPages.Text = pages[0] + '/' + pages[1];
        }

        public void ChangeMaxPageLabel(int pageNumber)
        {
            var pages = labelPages.Text.Split('/');
            pages[1] = (pageNumber).ToString();
            labelPages.Text = pages[0] + '/' + pages[1];
        }
    }

    public class PageChangedArgs
    {
        public int CurrentPage { get; private set; }
        public PageChangedArgs(int currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}
