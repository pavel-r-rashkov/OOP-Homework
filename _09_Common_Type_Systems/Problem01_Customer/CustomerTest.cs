namespace Problem01_Customer
{
    using System;

    class CustomerTest
    {
        static void Main(string[] args)
        {
            Customer sashko = new Customer("First", "Middle", "Last", 1212123344, "address", "02 23 23 23",
                "p@p.bg", CustomerType.Diamond);

            sashko.AddPayment(new Payment("payment", 12M));
            sashko.AddPayment(new Payment("pay", 13.132M));
 
            Customer goshko = (Customer)sashko.Clone();
            Console.WriteLine(sashko.CompareTo(goshko));

            Console.WriteLine(sashko);
        }
    }
}
