using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Laptop_Shop
{
    class Battery
    {
        private string model;
        private double life;

        public string Model
        {
            get {return this.model; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid battery model");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public double Life
        {
            get { return this.life; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Battery life can't be negative!");
                }
                else
                {
                    this.life = value;
                }
            }
        }

        public Battery(string model, double life)
        {
            this.model = model;
            this.life = life;
        }

        public override string ToString()
        {
 	        return String.Format("battery model: {0}\nbattery life: {1} hours", this.Model, this.Life);
        }
    }
}
