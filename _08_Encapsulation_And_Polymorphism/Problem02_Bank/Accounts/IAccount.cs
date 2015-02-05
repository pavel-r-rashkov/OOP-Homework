using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_Bank.Customers;

namespace Problem02_Bank.Accounts
{
    interface IAccount
    {
        Customer BankCustomer { get; set; }
        decimal Balance { get; }
        decimal Interest { get; set; }
        void Deposit(decimal amount);
        decimal CalculateInterest(int months);
    }
}
