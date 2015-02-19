namespace Problem01_Customer
{
    using System;

    class Payment : ICloneable
    {
        private string productName;
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
                    throw new ArgumentException("Poduct name can't be null or empty");
                }
                else
                {
                    this.productName = value;
                }
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return this.productPrice;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Product price can't negative");
                }
                else
                {
                    this.productPrice = value;
                }
            }
        }

        public Payment(string name, decimal price)
        {
            this.ProductName = name;
            this.ProductPrice = price;
        }

        public object Clone()
        {
            return new Payment(this.ProductName, this.productPrice);
        }

        public override string ToString()
        {
            return String.Format("Product: {0}, Price: {1}", this.ProductName, this.ProductPrice);
        }
    }
}
