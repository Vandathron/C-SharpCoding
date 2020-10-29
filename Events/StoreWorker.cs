using System;
using System.Collections.Generic;
using System.Text;

namespace PureCSharp.Events
{
    public class StoreWorker
    {
        public EventHandler<ShoppingArgs> storeVisited;

        public void VisitStore(int noOfStores)
        {
            for (int i = 0; i < noOfStores; i++)
            {
                var storeToVisit = new ShoppingArgs(i, $"Store-{i + 1}");
                StoreVisited(storeToVisit);
            }
        }

        private void StoreVisited(ShoppingArgs ea)
        {
            storeVisited(this, ea);
        }
    }
}
