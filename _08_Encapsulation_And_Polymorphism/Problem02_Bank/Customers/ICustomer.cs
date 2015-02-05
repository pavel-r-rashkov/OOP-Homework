using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Bank.Customers
{
    interface ICustomer
    {
        string Name { get; set; }
        int NoLoanInterestTime();
        int HalfMortageInterestTime();
    }
}
