using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_Bank.Accounts;
using Problem02_Bank.Customers;

namespace Problem02_Bank
{
    class BankTest
    {
        static void Main(string[] args)
        {
            Customer cust = new IndividualCustomer("Pesho");
            //Customer cust = new CompanyCustomer("Pesho");

            //Account acc = new LoanAccount(cust, 100, 0.06M);
            //Account acc = new MortgageAccount(cust, 100, 0.06M);
            Account acc = new DepositAccount(cust, 1200, 0.06M);

            Console.WriteLine(acc.CalculateInterest(12));
        }
    }
}
