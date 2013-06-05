using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ReadIntInvalidOrNegative
{
    class ReadIntInvalidOrNegative
    {
        private static double numberSqrt;

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number SQRT:");
                numberSqrt = double.Parse(Console.ReadLine());
                if (numberSqrt < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("Sqrt of number:{0}",numberSqrt = Math.Sqrt(numberSqrt));
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalit number");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Invalit number");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Invalit number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }      
    }
}
