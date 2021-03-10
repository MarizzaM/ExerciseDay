using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDay
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            names.Add("Liam");
            names.Add("Noah");
            names.Add("Oliver");
            names.Add("William");
            names.Add("Elijah");
            names.Add("James");
            names.Add("Benjamin");
            names.Add("Lucas");
            names.Add("Mason");
            names.Add("Ethan");

            List<string> result_list_a = names.FindAll(x  => x.Length > 4);
            result_list_a.ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            List<string> result_list_b = names.FindAll(x => x.Contains("a"));
            result_list_b.ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            IEnumerable<string> sort = names.OrderBy(x => x);
            List<string> result_list_c = sort.ToList();
            result_list_c.ForEach(x => Console.Write($"{x} "));
        }
    }
}
