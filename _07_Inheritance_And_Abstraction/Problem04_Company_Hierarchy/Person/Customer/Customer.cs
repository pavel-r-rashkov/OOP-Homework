using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Customer
{
    class Customer : Person, ICustomer
    {
        private decimal purchaseAmount;

        public decimal PurchaseAmount
        {
            get
            {
                return this.purchaseAmount;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Purchase amount can't be negative");
                }
                else
                {
                    this.purchaseAmount = value;
                }
            }
        }

        public Customer(int id, string fname, string lname , decimal amount)
            :base(id, fname, lname)
        {
            this.PurchaseAmount = amount;
        }

        public override string ToString()
        {
            return base.ToString() + "\nPurchase amount: " + this.PurchaseAmount;
        }
    }
}
