using System;

namespace mShop.Views
{

    public enum SearchItemType
    {
        Name,
        Brand,
        Category
    }
    public class SearchItemArgs : EventArgs
    {
        public string Value { get; private set; }
        public SearchItemType Type { get; private set; }
        public SearchItemArgs(string value, SearchItemType type)
        {
            Value = value;
            Type = type;
        }
    }
}