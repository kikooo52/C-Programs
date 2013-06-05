using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BiggerThanItsTwoNeighbors
{
    class BiggerThanItsTwoNeighbors
    {
        private static int[] array = { 1, 2, 3, 2, 4, 43, 6, };
        private static int positionelement;
        private static int counter;
        private static int leftNumber; 
        private static int rightNumer;

        private static int counterPlaceOnElement(int[] array, int counter)
        {
            if (array[0] == positionelement || array[array.Length - 1] == positionelement)
            {
                Console.WriteLine("Number {0} has only one neighbor!", positionelement); return 0;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (positionelement == array[i])
                    {
                        counter = i;
                    }
                }
               
            }
            return counter;
        }
        static int GetMax(int checkNumber)
        {
            return positionelement > leftNumber ? positionelement : checkNumber;
        }
        private static void PrintNumber(int bigNumber)
        {
            if (positionelement == bigNumber)
            {
                Console.WriteLine("This element is bigger than its two neighbors ");
            }
            else
            {
                Console.WriteLine("This element is slmaler than its two neighbors ");
            }
        }
        static void Main(string[] args)
        {

            Console.Write("Enter element of position in array:");
            positionelement = int.Parse(Console.ReadLine());
            counter = counterPlaceOnElement(array, counter);
            if (counter == 0)
            {
                return;
            }           
            leftNumber = array[counter - 1];
            rightNumer = array[counter + 1];
            int biggerNumber = GetMax(leftNumber);
            biggerNumber = GetMax(rightNumer);
            PrintNumber(biggerNumber);
        }
    }
}
