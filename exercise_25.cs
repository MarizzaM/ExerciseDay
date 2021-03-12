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
        // a) non threadpool threads
        // b)
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(10_000);
                Console.WriteLine("Have a nice day");
            }, TaskCreationOptions.LongRunning).Wait();

        }
    }
}
