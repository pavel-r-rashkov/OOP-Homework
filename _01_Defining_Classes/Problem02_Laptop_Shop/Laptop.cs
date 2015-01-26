using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manufactorer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private int hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public string Model
        {
            get { return this.model; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid model name!");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufactorer
        {
            get { return this.manufactorer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufactorer name!");
                }
                else
                {
                    this.manufactorer = value;
                }
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid processor name!");
                }
                else
                {
                    this.processor = value;
                }
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid ram value!");
                }
                else
                {
                    this.ram = value;
                }
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid graphics card name!");
                }
                else
                {
                    this.graphicsCard = value;
                }
            }
        }

        public int Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid hdd value!");
                }
                else
                {
                    this.hdd = value;
                }
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid screen name!");
                }
                else
                {
                    this.screen = value;
                }
            }
        }

        public Battery Battery { get; set; }

        // mandatory properties only
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        // laptop properties only
        public Laptop(string model, decimal price, string manufactorer, string processor, int ram, string gCard, int hdd, string screen)
            :this(model, price)
        {
            this.Manufactorer = manufactorer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = gCard;
            this.Hdd = hdd;
            this.Screen = screen;
        }

        // laptop + battery properties
        public Laptop(string model, decimal price, string manufactorer, string processor, int ram, string gCard, int hdd, string screen, string batteryModel, double batteryLife)
            :this(model, price, manufactorer, processor, ram, gCard, hdd, screen)
        {
            this.Battery = new Battery(batteryModel, batteryLife);
        }

        public override string ToString()
        {
            string result = String.Format("model: {0}\n", this.Model);
            if(this.Manufactorer != null)
            {
                result += String.Format("manufactorer: {0}\n", this.Manufactorer);
            }
            if (this.Processor != null)
            {
                result += String.Format("processor: {0}\n", this.Processor);
            }
            if (this.Ram != 0)
            {
                result += String.Format("RAM: {0} GB\n", this.Ram);
            }
            if (this.GraphicsCard != null)
            {
                result += String.Format("graphics card: {0}\n", this.GraphicsCard);
            }
            if (this.Hdd != 0)
            {
                result += String.Format("HDD: {0}GB SSD\n", this.Hdd);
            }
            if (this.Screen != null)
            {
                result += String.Format("screen: {0}\n", this.Screen);
            }
            if (this.Battery != null)
            {
                result += this.Battery.ToString() + "\n";
            }
            result += String.Format("price: {0:0.00} lv.\n", this.Price);
            return result;
        }
    }
}
