using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ExerciseDay
{
    class Program
    {
        public static async Task WriteToTextToFile()
        {
            using (StreamReader sr = new StreamReader(@"c:\temp\WriteTextAsync.txt"))
            {
                Console.WriteLine(await sr.ReadToEndAsync()) ;
                Thread.Sleep(2);
            }
        }

        static void Main(string[] args)
        {
            Task task = WriteToTextToFile();
            task.Wait();
        }
    }
}

