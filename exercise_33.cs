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
        static CancellationTokenSource tokenSource = new CancellationTokenSource();

        public static int MyTimer()
        {
            int count = 0;
            while (!tokenSource.IsCancellationRequested)
            {
                count++;
                Thread.Sleep(1_000);
            }
            return count;
        }
        static void Main(string[] args)
        {
            Task<int> t = new Task<int>(() =>
            {
               return MyTimer();
                tokenSource.Token.ThrowIfCancellationRequested();
            });

            t.Start();

            Console.ReadLine();

            tokenSource.Cancel();

            Console.WriteLine($" Timer is stopped : {t.Result}");
        }
    }
}

