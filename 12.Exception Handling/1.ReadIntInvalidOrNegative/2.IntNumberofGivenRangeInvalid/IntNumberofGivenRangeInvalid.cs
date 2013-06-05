using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IntNumberofGivenRangeInvalid
{
    class IntNumberofGivenRangeInvalid
    {
        private static int startNumber = 1;
        private static int endNumber = 100;
        private static int tenNumbers;

        static void Main(string[] args)
        {
            try
            {
                readNumberStartEnd();
            }
            catch (FormatException)
            {
                Console.WriteLine("Not an integer number");
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Not in the scope of integer");         
            }
            catch (Exception)
            {
                Console.WriteLine("The program have to work in rang of 1 to 100 and sequence a1 < a2");
            }
        }
        private static void readNumberStartEnd()
        {
            Console.WriteLine("Enter number in rang {0} to {1}", startNumber, endNumber);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter ten numbers {0}:", i);
            tenNumbers = int.Parse(Console.ReadLine());
            if (tenNumbers < 1 || tenNumbers > 100)
            {
                throw new Exception();
            }
            if (tenNumbers >= startNumber)
            {
                startNumber = tenNumbers;
            }
            else
            {
                throw new Exception();
            }
            }
        }
    }
}

    

    
