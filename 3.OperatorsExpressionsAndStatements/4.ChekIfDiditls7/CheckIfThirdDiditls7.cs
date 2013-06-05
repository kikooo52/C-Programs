using System;

class ChekIfDiditls7
    {
        static void Main()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());

            int newNumber = (num / 100) % 10;          // 1723 / 100 = 
                                                      // 17 % 10 = 7 == 7 true
            if (newNumber == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


        }
    }

