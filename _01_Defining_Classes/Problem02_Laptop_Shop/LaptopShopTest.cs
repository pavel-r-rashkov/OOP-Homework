﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Laptop_Shop
{
    class LaptopShopTest
    {
        static void Main(string[] args)
        {
            // only mandatory props
            Laptop first = new Laptop("HP 250 G2", 699);
            Console.WriteLine(first.ToString());
            Console.WriteLine("============================");

            // only laptop props
            Laptop second = new Laptop("Lenovo Yoga 2 Pro", 2259, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8, "Intel HD Graphics 4400", 128, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display");
            Console.WriteLine(second.ToString());
            Console.WriteLine("============================");

            // Laptop + battery props
            Laptop third = new Laptop("Lenovo Yoga 2 Pro", 2259, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8, "Intel HD Graphics 4400", 128, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", "Li-Ion, 4-cells, 2550 mAh", 4.5);
            Console.WriteLine(third.ToString());
            Console.WriteLine("============================");
        }
    }
}
