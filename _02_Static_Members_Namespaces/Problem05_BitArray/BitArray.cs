using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_BitArray
{
    class BitArray
    {
        public byte[] bits;

        public BitArray(int size)
        {
            if(size < 1 || size > 100000)
            {
                throw new ArgumentException("bits's count should be between 1 and 100 000");
            }
            bits = new byte[size];
        }

        public byte this[int index]
        {
            get { return this.bits[bits.Length - 1 - index]; }
            set 
            { 
                if(value != 1 && value != 0)
                {
                    throw new ArgumentException("bit value must be 1 or 0");
                }
                this.bits[bits.Length - 1 - index] = value;
            }
        }

        public override string ToString()
        {
            return this.ToDecimal().ToString();
        }

        private ulong ToDecimal()
        {
            ulong result = 0;
            foreach(byte bit in bits)
            {
                result = result * 2 + bit;
            }
            return result;
        }
    }
}
