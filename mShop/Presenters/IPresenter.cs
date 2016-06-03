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

        event EventHandler ViewChanged;

        
    }

    class ViewChangedArgs : EventArgs
    {
       // Views.Type 
    }
}
