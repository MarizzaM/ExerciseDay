using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDay
{
    class Program
    {
        public delegate int D(int number1, int number2);
        static int Add(int x, int y) {
            return x + y;
        }
        static void PrintInvokeResult(D f, int x, int y)
        {
            int result = f(x, y);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            PrintInvokeResult(Add, 5, 9);
        }
    }
}
