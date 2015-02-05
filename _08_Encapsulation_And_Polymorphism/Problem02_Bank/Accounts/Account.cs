using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_Bank.Customers;

namespace Problem02_Bank.Accounts
{
    abstract class Account : IAccount
    {
        Customer bankCustomer;
        decimal balance;
        decimal interest;

        public Customer BankCustomer
        {
            get
            {
                return this.bankCustomer;
            }
            set
            {
                this.bankCustomer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Balance can't be negative");
                }
                else
                {
                    this.balance = value;
                }
            }
        }
        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest can't be negative");
                }
                else
                {
                    this.interest = value;
                }
            }
        }

        protected Account(Customer cust, decimal balance, decimal interest)
        {
            this.BankCustomer = cust;
            this.Balance = balance;
            this.Interest = interest;
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public abstract decimal CalculateInterest(int months);
    }
}
