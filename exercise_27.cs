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
        //a) Continue-with

        //b)
        static void Main(string[] args)
        {
            Task<string> str = Task<string>.Run(() =>
            {
                return "Welcome";
            }).ContinueWith((Task<string> result) =>
            {
                return result.Result + "\nGood Night";
            });
            Console.WriteLine($"{str.Result}");
        }

        //c) TaskContinuationOptions.OnlyOnFaulted
    }
}
