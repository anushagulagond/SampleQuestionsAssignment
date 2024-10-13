using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestionsAssignment
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Account(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public decimal Deposit(decimal amount)
        {
            try {
                if (amount > 0) {
                    Balance = Balance + amount;
                }
                else
                {
                    throw new ArgumentException("Deposit Amount must be positive");
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Balance;
        }
        public decimal Withdraw(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Withdrawal amount must be positive");
                }
                else if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds");
                }
                else
                {
                    Balance = Balance - amount;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Balance;
        }

    }
    public class Q24Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Deposit\n2.Withdraw\nEnter the choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the account number");
                    string AccNum = Console.ReadLine();
                    Console.WriteLine("Enter the balance");
                    decimal Balance = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the amount to be deposit");
                    decimal Amount = decimal.Parse(Console.ReadLine());
                    Account account = new Account(AccNum, Balance);
                    Balance = account.Deposit(Amount);
                    Console.WriteLine("Balance amount " + Balance);
                    break;
                case 2:
                    Console.WriteLine("Enter the account number");
                    string AccountNum = Console.ReadLine();
                    Console.WriteLine("Enter the balance");
                    decimal Balance2 = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the amount to be withdraw");
                    decimal Amount2 = decimal.Parse(Console.ReadLine());
                    Account account2 = new Account(AccountNum, Balance2);
                    Balance2 = account2.Withdraw(Amount2);
                    Console.WriteLine("Balance amount " + Balance2);
                    break;
                Default: Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
