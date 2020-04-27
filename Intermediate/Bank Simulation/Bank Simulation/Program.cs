using System;
using System.Collections.Generic;

namespace Bank_Simulation
{
    public class BankAccount
    {

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name)
        {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw should be positive");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                var withdrawal = new Transaction(-amount, date, note);
                allTransactions.Add(withdrawal);
            }
        }
    }

    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            var account = new BankAccount("Siddhant");

            Console.WriteLine("Your account is created sucessfully");
            Console.WriteLine("----Welcome to our online banking portal-----");
            Console.WriteLine("Enter 1 to check your account," +
                "Enter 2 to Deposit amount" +
                "Enter 3 to withdraw amount" +
                "Enter 4 to check balance" +
                "Enter 5 to exit");

            var toExit = true;
            while (toExit == true)
            {
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
                        break;
                    case 2:
                        Console.WriteLine("Enter your ammount,press enter & your note");
                        var AD = Convert.ToInt32(Console.ReadLine()); //AD is amount to deposit
                        var ND = Console.ReadLine();
                        account.MakeDeposit(AD, DateTime.Now, ND);
                        break;
                    case 3:
                        Console.WriteLine("Enter your ammount,press enter & your note");
                        var AW = Convert.ToInt32(Console.ReadLine()); //AW is amout to withdraw
                        var NW = Console.ReadLine(); //NW is note od withdraw
                        account.MakeWithdrawal(AW, DateTime.Now, NW);
                        break;
                    case 4:
                        Console.WriteLine("Now the balance is " + account.Balance);
                        break;
                    case 5:
                        goto label;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
            }
            label:
            Console.WriteLine("Thanks for banking with us");
        }
    }
}
