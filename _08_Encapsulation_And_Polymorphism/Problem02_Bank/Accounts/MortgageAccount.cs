using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_Bank.Customers;

namespace Problem02_Bank.Accounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(Customer cust, decimal balance, decimal interest)
            :base(cust, balance, interest)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            int halfInterest = this.BankCustomer.HalfMortageInterestTime();
            if (halfInterest >= months)
            {
                return this.Balance * (1 + (this.Interest / 2) * months);
            }
            else
            {
                return this.Balance * (1 + this.Interest * (months - halfInterest)) +
                    this.Balance * ((this.Interest / 2) * halfInterest);
            }
        }
    }
}
