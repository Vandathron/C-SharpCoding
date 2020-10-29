using System;

using PureCSharp.EventHandlers;
using PureCSharp.Events;

namespace PureCSharp
{
    public delegate void WorkPerformer(int h, string name);
    class Program
    {
        static void Main(string[] args)
        {

            //WorkPerformer del = new WorkPerformer(First);
            //WorkPerformer del2 = new WorkPerformer(Second);
            //del(3, "");
            //Console.WriteLine("Hello World!");

            Worker worker = new Worker();
            Manager manager = new Manager();
            Fam fam = new Fam();

            worker.WorkPerformed += new EventHandler<WorkerEventArgs>(fam.Worker_WorkPerformed);

            worker.WorkPerformed += manager.Worker_WorkPerformed;
            worker.WorkCompleted += manager.Worker_Completed;
            worker.WorkCompleted += fam.Worker_Completed;

            worker.DoWork(work: new WorkerEventArgs(5, WorkType.GOLF));
            Console.WriteLine("Called first");

            StoreWorker storeWorker = new StoreWorker();

            StoreA storeA = new StoreA();
            StoreB storeB = new StoreB();

            storeWorker.storeVisited += storeA.StoreVisitedPerformed;
            storeWorker.storeVisited += storeB.StoreVisitedPerformed;

            storeWorker.VisitStore(5);

        }


        static void First(int h, string name)
        {
            Console.WriteLine("First called");
        }


        static void Second(int h, string name)
        {
            Console.WriteLine("second called");
        }

    }
}
