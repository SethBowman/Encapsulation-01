using System;
namespace EncapsulationInClass
{
    public class BankAccount
    {
        private double _balance;

        public BankAccount(double amount)
        {
            _balance = amount;
        }

        public double Deposit(double amount)
        {
            return _balance += amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public double Withdraw(double amount)
        {
            return _balance -= amount;
        }
    }
}
