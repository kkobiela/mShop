using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mShop.Views
{

    public enum Type
    {
        Login,
        User
    }

    public interface IView
    {
        Type Type { get; set; }
        void UpdateData();
        void SetError();
    }
}
