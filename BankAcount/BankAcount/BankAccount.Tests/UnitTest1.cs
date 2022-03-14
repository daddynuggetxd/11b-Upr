using NUnit.Framework;
using BankAccount;
using System;

namespace BankAccount.Tests
{
    [TestFixture]
    public class BankAccountTest
    {
        [Test]

        public void AccountInitializeWithPositiveValue()
        {
            BankAccount account = new BankAccount(2000m);

            Assert.AreEqual(2000m, account.Balance);
        }

        [Test]
        public void DepositShouldAddMoney()
        {
            BankAccount account = new BankAccount();

            account.Deposit(50);

            Assert.IsTrue(account.Balance == 50);
        }

        [Test]
        public void CreditShouldAddMoney()
        {  BankAccount account = new BankAccount();

            account.Credit(50);

            Assert.IsTrue(account.Balance == 50);
        }
        [Test]

        public void IncreaseShouldAddPercentageToTheBalance()
        {
            BankAccount account = new BankAccount(1000);

            account.Increase(10);

            Assert.IsTrue(account.Balance == 1100);
        }

        [Test]
        public void BonusShouldBeWorkingProperly()
        {
            BankAccount account1 = new BankAccount(1100);
            BankAccount account2 = new BankAccount(2100);
            BankAccount account3 = new BankAccount(3100);

            account1.Bonus();
            account2.Bonus();
            account3.Bonus();

            Assert.IsTrue(account1.Balance == 1200);
            Assert.IsTrue(account2.Balance == 2300);
            Assert.IsTrue(account3.Balance == 3400);
        }
        [Test]

public void PaymentForCreditShouldThrowArgumentExceptionWhenNotEnoughMoney()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(200));
        }

        [Test]
        
public void PaymentForCreditShouldThrowArgumentExceptionWhenPaymentIsNegative()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(-10));
        }
        [Test]
        
public void PaymentForCreditShouldThrowArgumentExceptionWhenPaymentIsZero()
        {
            BankAccount account = new BankAccount(20);
            Assert.Throws<ArgumentException>(() => account.PaymentForCredit(0));
        }
    }
}