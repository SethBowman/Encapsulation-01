using System;

namespace EncapsulationInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var mAcct = new BankAccount(400);

            var bal = mAcct.GetBalance();
            Console.WriteLine("Balance:");
            Console.WriteLine($"${bal}");

            bal = mAcct.Deposit(2500);
            Console.WriteLine("(+2500) Balance after deposit:");
            Console.WriteLine($"${bal}");

            bal = mAcct.Withdraw(250);
            Console.WriteLine("(-250) Balance after withdrawal:");
            Console.WriteLine($"${bal}");
        }
    }
}
