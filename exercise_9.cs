using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ExerciseDay
{
    class Program
    {
        static void LongOperation() {
            for (int i = 0; i < 1_000_000_000; i++) { 
            
            }
            Console.WriteLine("Done");
        }

        static void Main(string[] args)
        {
            List<Thread> five_treads = new List<Thread>();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i <= 5; i++) {
                LongOperation();
            }
            Console.WriteLine("The total time elapsed using 5 LongOperations is: {0} ms\n", stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Stop();

            //The total time elapsed using 5 LongOperations is: 34324 ms


            stopwatch.Reset();
            stopwatch.Start();

            Thread t = new Thread(() => {
                for (int i = 1; i <= 5; i++)
                {
                    LongOperation();
                }
            });

            t.Start();
            five_treads.Add(t);

            foreach (var item in five_treads)
            {
                item.Join();
            }
            Console.WriteLine("The total time elapsed using 5 threads is: {0} ms\n", stopwatch.Elapsed.TotalMilliseconds);
            stopwatch.Stop();

            //The total time elapsed using 5 threads is: 23400 ms

        }
    }
}
