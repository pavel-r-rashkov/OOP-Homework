using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_PC_Catalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if(String.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Invalid component name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Details { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid component price!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details)
            :this(name, price)
        {
            this.Details = details;
        }

        public override string ToString()
        {
            string result = "----------------------\n";
            result += String.Format("{0}: {1:0.00} BGN", this.Name, this.Price);
            if(!String.IsNullOrEmpty(this.Details))
            {
                result += "\ndetails: " + this.Details;
            }
            return result;
        }
    }
}
