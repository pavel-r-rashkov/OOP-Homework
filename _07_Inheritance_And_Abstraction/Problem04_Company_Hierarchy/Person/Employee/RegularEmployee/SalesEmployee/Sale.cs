using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_Company_Hierarchy.Person.Employee.RegularEmployee.SalesEmployee
{
    class Sale : ISale
    {
        private string productName;
        private DateTime saleDate;
        private decimal productPrice;

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name can't be null or empty");
                }
                else
                {
                    this.productName = value;
                }
            }
        }

        public DateTime SaleDate
        {
            get { return this.saleDate; }
        }

        public decimal ProductPrice
        {
            get
            {
                return this.productPrice;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("product price can't be negative");
                }
                else
                {
                    this.productPrice = value;
                }
            }
        }

        public Sale(string name, decimal price)
        {
            this.ProductName = name;
            this.ProductPrice = price;
            this.saleDate = DateTime.Now;
        }

        public override string ToString()
        {
            return String.Format("Product name: {0}, Price: {1}, Date: {2}",
                this.ProductName, this.ProductPrice, this.SaleDate);
        }
    }
}
