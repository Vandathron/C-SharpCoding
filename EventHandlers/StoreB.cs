using System;
using System.Collections.Generic;
using System.Text;

using PureCSharp.Events;

namespace PureCSharp.EventHandlers
{
    public class StoreB
    {
        internal void StoreVisitedPerformed(object sender, ShoppingArgs e)
        {
            Console.WriteLine("Right from StoreB: Shop {0} has been visited", e.StoreName);
        }
    }
}
