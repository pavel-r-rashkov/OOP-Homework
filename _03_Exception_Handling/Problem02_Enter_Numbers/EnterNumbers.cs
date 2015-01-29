using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Enter_Numbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            int? lastNumber = null;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int currentNumber = ReadNumber(10, 50);
                    if(lastNumber != null && currentNumber <= lastNumber)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    lastNumber = currentNumber;
                }                   
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Number cannot be null, enter again:");
                    i--;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Number out of range, enter again:");
                    i--;
                }   
                catch (OverflowException ex)
                {
                    Console.WriteLine("Overflow, enter again:");
                    i--;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Number is not in the correct format, enter again:");
                    i--;
                }                   
            }
        }

        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return number;
        }
    }
}
