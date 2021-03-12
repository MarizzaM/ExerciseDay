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
        public delegate void D1(string s1, string s2);

        public delegate double D2(double d1, double d2);

        static void F1(string s1, string s2)
        {
            Console.WriteLine(s1);
            Thread.Sleep(10_000);
            Console.WriteLine(s2);
        }
        static void F2(D1 f, string s1, string s2)
        {
            f(s1, s2);

        }

        static void F3(D2 f, double d1, double d2)
        {
            f(d1, d2);
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(()=> F2(F1, "Downloading file...", "Completed"));
            t.Start();

            ThreadPool.QueueUserWorkItem((o) =>  F3((d1, d2) => d1 * d2, 7, 7));
        }
    }
}
