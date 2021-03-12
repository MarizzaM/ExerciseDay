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
        static object key = new object();
        static void DoctorTreatment() {

            Monitor.Enter(key);
            Console.WriteLine("Waiting for my turn...");
            Monitor.Pulse(key);
            Console.WriteLine("Getting treatment...");
            NurseCheck();
            Monitor.Exit(key);
        }
        static void NurseCheck()
        {
            Monitor.Enter(key);
            Console.WriteLine("Nurse is checking...");
            Thread.Sleep(5_000);
            Monitor.Pulse(key);
            Console.WriteLine("Next patient please!");
            Monitor.Exit(key);
        }

        static void Main(string[] args)
        {
            new Thread(() => { DoctorTreatment(); }).Start();
            new Thread(() => { DoctorTreatment(); }).Start();
            new Thread(() => { DoctorTreatment(); }).Start();
        }
    }
}
