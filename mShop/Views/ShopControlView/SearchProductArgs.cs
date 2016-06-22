using System;

namespace mShop.Views
{
    public class SearchProductArgs : EventArgs
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public SearchProductArgs(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
}