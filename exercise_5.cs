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

        public class Customer
        {
            public string Name { get; set; }
            public double MyBalance { get; set; }

        }

        public class BankEventArgs : EventArgs
        {
            public double Balance { get; set; }
        }

        //methods 
        static void WithdrawsMoney(object sender, BankEventArgs e)
        {
            e.Balance = e.Balance - (double)sender;
            Console.WriteLine($"- {sender}/n Balance: {e.Balance}");     
        }

        private static event EventHandler<BankEventArgs> invocationMethodsList;
        // events
        private static void FireWithdrawsMoney(double Balance, double amount)
        {
            Thread.Sleep(1000);

            if (invocationMethodsList != null)
            {
                invocationMethodsList(amount,
                    new BankEventArgs { Balance = Balance});
            }
        }
        static void Main(string[] args)
        {
            Customer c = new Customer { Name = "Moshe", MyBalance = 100_000 };
            do
            {
                Console.Write("Please enter the amount you want to withdraw ");
                double value = Convert.ToInt32(Console.ReadLine());
                invocationMethodsList = null;
                invocationMethodsList += WithdrawsMoney;
                FireWithdrawsMoney(c.MyBalance, value);
                c.MyBalance -= value;
            }
            while (c.MyBalance > 0);

            Console.WriteLine("Oops...");
        }
    }
}
