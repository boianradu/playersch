using System;
using System.Threading;
using System.Threading.Tasks;


namespace evoke
{
    public class MyWorkerClass
    {
        public int ItemsProcessed { get; private set; }
        private readonly object _mutex = new object();

        public Task DoWorkAsync(int num)
        {
            return Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < num; i++)
                {
                    lock (_mutex)
                    {
                        ItemsProcessed++;
                    }
                }
            });
        }

        static void Main(string[] args)
        {
            var worker = new MyWorkerClass();
            var task1 = worker.DoWorkAsync(1000);
            var task2 = worker.DoWorkAsync(1000);
            Task.WaitAll(task1, task2);
            int N = 10;
            string S = "abcd";
            Occurances oc = new Occurances(N, S);
            Console.WriteLine(oc.CountC() + " occurances");
        }
    }
}
