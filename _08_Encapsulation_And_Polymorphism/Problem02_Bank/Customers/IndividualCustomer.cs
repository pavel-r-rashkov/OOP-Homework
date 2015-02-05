using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Bank.Customers
{
    class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name)
            :base(name)
        {
        }

        public override int NoLoanInterestTime()
        {
            return 3;
        }

        public override int HalfMortageInterestTime()
        {
            return 6;
        }
    }
}
