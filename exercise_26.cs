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
            int num1 = 321654;
            int num2 = 6549875;
            Task<int> t = new Task<int>(() =>
            {

                return num1 + num2;
            });

            t.Start();

            Console.WriteLine($" {num1} + {num2} = {t.Result}");
        }
    }
}
