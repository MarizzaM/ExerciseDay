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
        //a) the task.WaitAny method to wait for the one of a series of executing tasks to complete, don't care which task it is
        //b)
        static Random r = new Random();
        static void Main(string[] args)
        {
            var tasks = new Task[3];

            for (int i = 0; i < tasks.Length; i++)
            {
                int num = i + 1;
                tasks[i] = Task.Run(() =>
                {
                    int timeSleep = r.Next(5_000, 10_000);
                    Thread.Sleep(timeSleep);
                });
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                Task.WaitAny(tasks);
            }
            Console.WriteLine("One task is done!");
        }
    }
}

