using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_BitArray
{
    class BitArrayTest
    {
        static void Main(string[] args)
        {
            BitArray a = new BitArray(8);
            a[7] = 1;
            Console.WriteLine(a);
        }
    }
}
