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
            Console.WriteLine(bal);

            mAcct.Deposit(2500);
            bal = mAcct.GetBalance();
            Console.WriteLine("Balance after deposit:");
            Console.WriteLine(bal);
          

            mAcct.Withdraw(250);
            bal = mAcct.GetBalance();
            Console.WriteLine("Balance after withdrawal:");
            Console.WriteLine(bal);
          
        }
    }
}
