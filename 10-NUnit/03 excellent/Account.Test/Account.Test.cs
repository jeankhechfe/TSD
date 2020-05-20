using NUnit.Framework;
using System;

namespace Account.Test
{
    [TestFixture]
    public class AccountTest
    {
        [Test]
        public void SeedIncrement_Test()
        {
            //TODO: accountNumberSeed is incremented after each Account initialization
            int x = Account.accountNumberSeed;
        	new Account();
        	Assert.That(Account.accountNumberSeed, Is.EqualTo(x + 1));
        }

        [Test]
        public void EmptyConstructor_Test()
        {
            //TODO: account initialized with empty constructor returns Balance equal to 0 and Owner as empty string
            Account account = new Account();
			Assert.That(account.Balance, Is.EqualTo(0));
            Assert.That(account.Owner, Is.EqualTo(""));
        }

        [Test]
        public void Deposit_Test()
        {
            //TODO: Deposit method increases Balance with given amount
            Account account = new Account();
        	account.Deposit(1000);
        	Assert.That(account.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void NotEmptyConstructor_Test()
        {
            //TODO: account initialized with not empty constructor returns Balance equal to initialBalance and Owner equal to given name
            Account account = new Account("jean", 1000);
			Assert.That(account.Owner, Is.EqualTo("jean"));
			Assert.That(account.Balance, Is.EqualTo(1000));
        }

        [Test]
        public void DepositException_Test()
        {
            //TODO: negative amount parameter passed to Deposit method throws ArgumentOutOfRangeException exception
            Account account = new Account();
        	Assert.Throws<ArgumentOutOfRangeException>(delegate { account.Deposit(-1); });
        }

        [Test]
        public void Withdraw_Test()
        {
            //TODO: Withdraw method decreases Balance with given amount
            Account account = new Account("jean", 1000);
        	account.Withdraw(200);
        	Assert.That(account.Balance, Is.EqualTo(800));
        }

        [Test]
        public void WithDrawExceptionOutOfRange_Test()
        {
            //TODO: negative amount parameter passed to Withdraw method throws ArgumentOutOfRangeException exception
            Account account = new Account();
        	Assert.Throws<ArgumentOutOfRangeException>(delegate { account.Withdraw(-1); });
        }

        [Test]
        public void WithDrawExceptionInvalidOperation_Test()
        {
            //TODO: amount parameter greater than Balance passed to Withdraw method throws InvalidOperationException exception
            Account account = new Account("jean", 1000);
            Assert.Throws<InvalidOperationException>(delegate { account.Withdraw(2000); });
        }
    }
}