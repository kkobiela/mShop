//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products_Warehouses
    {
        public int P_Id { get; set; }
        public int W_Id { get; set; }
        public int Quantity { get; set; }
        public int PW_Id { get; set; }
    
        public virtual Products Products { get; set; }
        public virtual Warehouses Warehouses { get; set; }
    }
}
