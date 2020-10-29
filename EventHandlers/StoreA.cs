using System;
using System.Collections.Generic;
using System.Text;

using PureCSharp.Events;

namespace PureCSharp.EventHandlers
{
    public class StoreA
    {
        internal void StoreVisitedPerformed(object sender, ShoppingArgs e)
        {
            Console.WriteLine("Right from StoreA: Shop {0} has been visited", e.StoreName);
        }
    }
}
