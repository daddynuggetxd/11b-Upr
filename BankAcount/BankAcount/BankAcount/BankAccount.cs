using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        public BankAccount(decimal amount = 0)
        {
            this.balance = amount;
        }


        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal cash)
        {
            this.balance += cash;
        }

        public void Credit(decimal cash)
        {
            this.balance += cash;
        }

        public void Increase(double percent)
        {
            this.balance += balance * ((decimal)percent / 100);
        }

        public void Bonus()
        {
            if (balance > 1000 && balance < 2000)
            {
                balance += 100;
            }

            else if (balance > 2000 && balance < 3000)
            {
                balance += 200;
            }

            else if (balance > 3000)
            {
                balance += 300;
            }
        }

        public void PaymentForCredit(decimal payment)
        {
            if (payment <= 0)
            {
                throw new ArgumentException("Payment cannot be zero or negative!");
            }
            if (this.Balance < payment)
            {
                throw new ArgumentException("Not enough money!");
               this.Balance -= payment;

            }
        }
    }
}
