using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_Bank.Customers;

namespace Problem02_Bank.Accounts
{
    class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer cust, decimal balance, decimal interest)
            :base(cust, balance, interest)
        {
        }

        // returns false on unsuccessful withdraw
        public bool Withdraw(decimal amount)
        {
            if(amount > this.Balance)
            {
                return false;
            }
            else
            {
                this.Balance -= amount;
                return true;
            }
        }

        public override decimal CalculateInterest(int months)
        {
            if(this.Balance >= 0 && this.Balance < 1000)
            {
                return this.Balance;
            }
            else
            {
                return this.Balance * (1 + this.Interest * months);
            }
        }
    }
}
