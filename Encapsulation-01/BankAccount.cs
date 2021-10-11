using System;
namespace EncapsulationInClass
{
    public class BankAccount
    {
        private double _balance = 0;

        public BankAccount(double amount)
        {
            _balance = amount;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
    }
}
