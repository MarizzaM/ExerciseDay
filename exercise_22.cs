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
        //static ManualResetEvent host = new ManualResetEvent(false);
        static AutoResetEvent host = new AutoResetEvent(false);

        static void EnterClub() {
            host.WaitOne();
            Console.WriteLine("Waiting fo enter...");
            Thread.Sleep(3000);
            host.Set();
        }

        static void ClouseDoor()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Welcome");
            host.Set();
        }


        static void Main(string[] args)
        {
            Thread t = new Thread(() => {
                for (int i = 1; i <= 50; i++)
                {
                    EnterClub();
                   
                }
            });

            t.Start();

            Thread t1 = new Thread(() => {
                for (int i = 1; i <= 50; i++)
                {
                    ClouseDoor();

                }
            });
            t1.Start();

            //Thread.Sleep(3000);

            //host.Set();

        }
    }
}
