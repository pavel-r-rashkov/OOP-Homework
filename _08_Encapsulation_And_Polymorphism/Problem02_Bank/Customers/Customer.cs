using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Bank.Customers
{
    abstract class Customer : ICustomer
    {
        protected string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Customer name ");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public Customer(string name)
        {
            this.Name = name;
        }

        public abstract int NoLoanInterestTime();
        public abstract int HalfMortageInterestTime();
    }
}
