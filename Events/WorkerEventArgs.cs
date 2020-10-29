using System;
using System.Collections.Generic;
using System.Text;

namespace PureCSharp.Events
{
    public class WorkerEventArgs: EventArgs
    {
        public int hours { get; set; }
        public WorkType WorkType { get; set; }

        public WorkerEventArgs(int h, WorkType w)
        {
            hours = h;
            WorkType = w;
        }
    }
}
