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
        //a) ManualResetEvent
        //b)
        static void Main(string[] args)
        {
            int max = 3;
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < max; i++)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    Thread.Sleep(5_000);
                }, TaskCreationOptions.LongRunning));
            }

            Task.WaitAll(tasks.ToArray());

            for (int i = 0; i < max; i++)
            {
                while (!tasks[i].IsCompleted) 
                {
                    Thread.Sleep(1);
                }
            }
            Console.WriteLine("all tasks are done");
        }

        //c)
                //while (!t.IsCompleted) 
                //{
                //    Thread.Sleep(1);
                //}

}
}

