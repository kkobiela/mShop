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
        private int _currentPage = 0;

        public PageChangerControl()
        {
            InitializeComponent();
        }

        public event EventHandler<PageChangedArgs> PageChanged;

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            _currentPage += 1;
            PageChanged?.Invoke(this, new PageChangedArgs(_currentPage));
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (_currentPage > 0)
            {
                _currentPage -= 1;
                PageChanged?.Invoke(this, new PageChangedArgs(_currentPage));
            }
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
