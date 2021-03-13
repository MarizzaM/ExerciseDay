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
        static Random r = new Random();
        static void Main(string[] args)
        {
            //a)
            int num1 = 7;
            int num2 = 0;
            Task<int> t =Task<int>.Run(() => {
                return num1/num2;
            });

            // programm not faulted

            //b)
            
            //Console.WriteLine($" {num1} / {num2} = {t.Result}");
            //Unhandled Exception: System.AggregateException: One or more errors occurred. ---> System.DivideByZeroException: Attempted to divide by zero.

            //c)
            if (t.IsFaulted)
            {
                t.Exception.Handle(e =>
                {
                    Console.WriteLine("Cannot divide by zero");
                    Console.WriteLine(e);
                    return true;
                });
            }

            //d) 
            //AggregateException
        }
    }
}

