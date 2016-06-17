using mShop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Presenters
{
    public interface IPresenter
    {
        void UpdateView(string data);
        void UpdateView(List<string> data);

        event EventHandler<ViewChangedArgs> ViewChanged;

        
    }

    public class ViewChangedArgs : EventArgs
    {
       public ViewType ViewType { get; private set; }
       public ViewChangedArgs(ViewType viewType)
        {
            ViewType = viewType;
        }
    }
}
