using System;
using System.Globalization;
using TratamentoDeExcecoes.Entities;
using TratamentoDeExcecoes.Entities.Exceptions;

namespace TratamentoDeExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Inicial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine("");
            Console.WriteLine("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.Withdraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }




        }
    }
}