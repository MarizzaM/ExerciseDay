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

            List<int> list = new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13 };
//a
            Thread t = new Thread(() => {
                Console.WriteLine("Hello world");
            });
            t.Start();
//b
            Thread t1 = new Thread(() => {
                Console.WriteLine(list.Find(x => x==13));
            });

            t1.Start();
        }
    }
}
