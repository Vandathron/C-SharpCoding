using System;
using System.Collections.Generic;
using System.Text;

using PureCSharp.Events;

namespace PureCSharp.EventHandlers
{
    public class Manager
    {

        public void Worker_WorkPerformed(object sender, WorkerEventArgs e)
        {
            Console.WriteLine("Received: {0} on {1} by Manager", e.hours, e.WorkType);
        }

        public void Worker_Completed(object sender, EventArgs e)
        {
            Console.WriteLine("Completed: on Manager");
        }
    }
}
