using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BankAccount account = new BankAccount();
            Console.Write(BankAccount.InterestRate);
            account.Balance = 3000.00M;
            //account.Withdrawal(200.00M);
        }
    }
}
