using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_Bank.Customers;

namespace Problem02_Bank.Accounts
{
    class LoanAccount : Account
    {
        public LoanAccount(Customer cust, decimal balance, decimal interest)
            :base(cust, balance, interest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if(this.BankCustomer.NoLoanInterestTime() >= months)
            {
                return this.Balance;
            }
            else
            {
                return this.Balance * (1 + this.Interest * months - this.BankCustomer.NoLoanInterestTime());
            }
        }
    }
}
