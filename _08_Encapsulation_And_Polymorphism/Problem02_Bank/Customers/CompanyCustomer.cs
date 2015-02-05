using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Bank.Customers
{
    class CompanyCustomer : Customer
    {
        public CompanyCustomer(string name)
            :base(name)
        {
        }

        public override int NoLoanInterestTime()
        {
            return 2;
        }

        public override int HalfMortageInterestTime()
        {
            return 12;
        }
    }
}
