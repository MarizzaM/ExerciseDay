using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ExerciseDay
{
    public class DishEventArgs : EventArgs
    {
        public string DishName { get; set; }
    }
    public class Waiter
    {


    }

    public class Kitchen
    {
        public event EventHandler<DishEventArgs> DishReady;

        public void OnDishReady(string dishName)
        {
            if (DishReady != null)
            {
                DishReady.Invoke(this, new DishEventArgs { DishName = dishName });
            }
        }
        public void PrepareDish()
        {
            Console.WriteLine("Preparing dish...");
            OnDishReady("Salad");
        }
    }

    class Program
    {
        public static void DishReadyEventHandler(object sender, DishEventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine($"Serving the {e.DishName} to the customers");
        }

        static void Main(string[] args)
        {
            Kitchen k = new Kitchen();
            Waiter w = new Waiter();

            k.DishReady += DishReadyEventHandler;
        }
    }
}
