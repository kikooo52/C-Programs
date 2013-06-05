using System;
using System.Linq;

namespace RefactorCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedValue = 10;
            int count = 100;
            bool isFound = false;
            int[] array = new int[count];
            int deliver = 10;

            for (int index = 0; index < count; index++ )
            {
                array[index] = index;
                if (index % deliver == 0)
                {
                    Console.WriteLine(array[index]);

                    if (array[index] == expectedValue)
                    {
                        isFound = true;
                        break;
                    }              
                }
                else
                {
                    Console.WriteLine(array[index]);            
                }
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
