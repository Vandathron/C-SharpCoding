using System;
using System.Collections.Generic;
using System.Text;

namespace PureCSharp.Events
{
    public enum WorkType
    {
        SKIP,
        GOLF,
        DANCE
    };


    public class Worker
    {
        public event EventHandler<WorkerEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;
        public void DoWork(WorkerEventArgs work)
        {
            var hours = work.hours;
            for (int i = 0; i <= hours; i++)
            {
                work.hours = i+1;
                OnWorkPerformed(work);
                
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed( WorkerEventArgs work)
        {
            if(WorkPerformed != null)
            {
                WorkPerformed(this, work);
            }
        }

        protected virtual void OnWorkCompleted()
        {
            if (WorkCompleted != null)
            {
                WorkCompleted(this, EventArgs.Empty);
            }
        }
    }
}
