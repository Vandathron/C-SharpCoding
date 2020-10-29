using System;
using System.Collections.Generic;
using System.Text;

namespace PureCSharp.Events
{
    public class ShoppingArgs:EventArgs
    {
        public int StoreId;

        public string StoreName;

        public ShoppingArgs(int storeId, string storeName)
        {
            StoreId = storeId;
            StoreName = storeName;
        }
    }
}
