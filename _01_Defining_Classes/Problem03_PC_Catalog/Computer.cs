using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_PC_Catalog
{
    class Computer
    {
        private string name;
        private decimal price;
        private List<Component> components = new List<Component>();

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid component name!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public decimal Price { get{ return this.price; } }

        public Computer(string name, params Component[] list)
        {
            this.Name = name;
            decimal total = 0;

            foreach(var item in list)
            {
                total += item.Price;
                this.components.Add(item);
            }
            this.price = total;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(String.Format("====================================\nname: {0}\n", this.Name));
            foreach(var component in this.components)
            {
                result.Append(component.ToString() + "\n");
            }
            result.Append("----------------------\n");
            result.Append(String.Format("price: {0:0.00} BGN", this.price));
            return result.ToString();
        }
    }
}
