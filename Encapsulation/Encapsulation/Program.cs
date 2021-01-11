﻿using System;

namespace Encapsulation
{
    class Program
    {
        class BankAccount
        {
            private double balance = 0;
            public void Deposit(double n)
            {
                balance += n;
            }
            public void Withdraw(double n)
            {
                balance -= n;
            }
            public double GetBalance()
            {
                return balance;
            }
        }
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            b.Deposit(199);
            b.Withdraw(42);
            Console.WriteLine(b.GetBalance());
        }
    }
}
