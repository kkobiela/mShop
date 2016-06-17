using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Views
{

    public enum ViewType
    {
        Login,
        Shop
    }

    public interface IView
    {
        ViewType Type { get; set; }
        void UpdateData();
        void SetError();
    }
}
