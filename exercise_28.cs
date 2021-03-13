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
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                Console.WriteLine(DateTime.Now);
            }).ContinueWith((Task antecendent) =>
            {
                Console.WriteLine(DateTime.Now);
            }, TaskContinuationOptions.NotOnFaulted);

            t.Wait();
        }
    }
}
