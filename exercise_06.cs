using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciseDay
{
    class Program
    {
        //a)
        //public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);

        //b)
        public class CalcEventArgs : EventArgs
        {
            public double number1 { get; set; }
            public double number2 { get; set; }
        }

        static void Main(string[] args)
        {

        }
    }
}
