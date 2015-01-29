using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Square_Root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if(number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Number cannot be null");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Number cannot be less than 0");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Number is not in the correct format");
            }  
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
