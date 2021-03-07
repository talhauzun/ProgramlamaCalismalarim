using System;
using System.Threading;
using System.Threading.Tasks;

namespace projectV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Action<object> action = (object obj) =>
            {
                Console.WriteLine("Task ={0}  oject={1} Thread ={2}", Task.CurrentId, obj, Thread.CurrentThread.ManagedThreadId);
            };


            Task task1 = new Task(action, "alpha");

            Task task2 = Task.Factory.StartNew(action, "beta");

            task2.Wait();



            task1.Start();
            task1.Wait();









            Console.ReadKey();
        }
    }
}
