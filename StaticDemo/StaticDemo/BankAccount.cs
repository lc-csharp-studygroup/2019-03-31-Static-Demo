using System;
using System.Collections.Generic;
using System.Text;

namespace StaticDemo
{
    class BankAccount
    {
        public static decimal InterestRate { get; set; }

        public decimal Balance { get; set; }

        public static void Withdrawal(decimal amount)
        {
            if (Balance > amount)
            {
                Balance - amount; 
            }
        }
    }
}
