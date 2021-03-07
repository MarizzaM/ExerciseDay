using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDay
{
    
    class Program
    {
        static Random random = new Random();

        static List<int> MyWhere(List<int> list, Func<int, bool> whereFunc)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if (whereFunc(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= 100; i++) {
                numbers.Add(random.Next(0, 50));
            }

            List<int> result_list_a = MyWhere(numbers, x => x < 10);
            result_list_a.ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            List<int> result_list_b = MyWhere(numbers, x => x % 3 == 0);
            result_list_b.ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            List<int> result_list_c = MyWhere(numbers, x => x % 2 == 0 && x > 20);
            result_list_c.ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            IEnumerable<int> sort = numbers.OrderBy(x=>x);
            List<int> result_list_d = sort.ToList();
            result_list_d.ForEach(x => Console.Write($"{x} "));

        }
    }
}
