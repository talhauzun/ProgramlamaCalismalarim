using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace taskTabanliProgramlama
{
    class Program
    {
        static int _value;
        static void Main(string[] args)
        {
            List<Task> deneme = new List<Task>{ Task.Run(() => Console.WriteLine("deneme")),
            Task.Run(() => Console.WriteLine("deneme2")),
            Task.Run(() => Console.WriteLine("deneme3")) };

            foreach (var item in deneme)
            {
                if (item.IsCompleted)
                {
                    Console.WriteLine(item.Status);
                } 
            }
            Console.WriteLine("test");

            Console.ReadKey();


            // paralel();
        }
        static void A()
        {
            // Add one.
            Interlocked.Add(ref Program._value, 1);
        }

        static void task2()
        {
            Thread thread1 = new Thread(new ThreadStart(A));
            Thread thread2 = new Thread(new ThreadStart(A));
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine(Program._value);

        }

        void task(string[] args)
        {
            long totalSize = 0;

            args = Environment.GetCommandLineArgs();
            if (args.Length == 1)
            {
                Console.WriteLine("There are no command line arguments.");
                return;
            }
            if (!Directory.Exists(args[1]))
            {
                Console.WriteLine("The directory does not exist.");
                return;
            }

            String[] files = Directory.GetFiles(args[1]);
            Parallel.For(0, files.Length,
                         index =>
                         {
                             FileInfo fi = new FileInfo(files[index]);
                             long size = fi.Length;
                             Interlocked.Add(ref totalSize, size);
                         });
            Console.WriteLine("Directory '{0}':", args[1]);
            Console.WriteLine("{0:N0} files, {1:N0} bytes", files.Length, totalSize);
        }

        static void paralel()
        {
            int[] nums = Enumerable.Range(0, 1000000).ToArray();
            long total = 0;

            // Use type parameter to make subtotal a long, not an int
            Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
            {
                subtotal += nums[j];
                return subtotal;
            },
                (x) => Interlocked.Add(ref total, x)
            );

            Console.WriteLine("The total is {0:N0}", total);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
