using System.Collections.Generic;
using System;

namespace Account
{
    public class Account
    {
        public static int accountNumberSeed = 1234567890;
        private List<Transaction> allTransactions = new List<Transaction>();
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                return GetBalance();
            }
        }

        //hint: Balance should be counted as sum of all transactions
        private decimal GetBalance()
        {
            //TODO implement
            decimal totalBalance = 0;
            foreach(Transaction transaction in allTransactions)
				totalBalance += transaction.Amount;
            return totalBalance;
        }

        public Account(string name, decimal initialBalance)
        {
            //TODO implement
            accountNumberSeed++;
			Owner = name;
			Transaction transaction = new Transaction(initialBalance);
			allTransactions.Add(transaction);
        }

        public Account()
        {
            //TODO implement
            accountNumberSeed++;
            Owner = "";
        }

        public void Deposit(decimal amount)
        {
            //TODO implement
            if (amount < 0)
				throw new ArgumentOutOfRangeException("Amount can't be negative..");
            Transaction transaction = new Transaction(amount);
			allTransactions.Add(transaction);
        }

        public void Withdraw(decimal amount)
        {
            //TODO implement
            if (amount < 0)
				throw new ArgumentOutOfRangeException("Amount can't be negative..");
            if (amount > Balance)
				throw new InvalidOperationException("Amount can't be greater than balance..");
            Transaction transaction = new Transaction(-amount);
			allTransactions.Add(transaction);
        }
    }
}
