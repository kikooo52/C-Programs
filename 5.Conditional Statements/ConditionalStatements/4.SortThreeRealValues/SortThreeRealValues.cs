using System;

class SortThreeRealValues
{
    static void Main()
    {
        Console.Write("Enter num1:");
        int Num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter num2:");
        int Num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter num3:");
        int Num3 = int.Parse(Console.ReadLine());

        if (Num1 > Num2)
        {
            if (Num1 > Num3)
            {
                if (Num3 > Num2)
                {
                    Console.WriteLine("{0},{1},{2}",Num2,Num3,Num1);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", Num3, Num2, Num1);
                }
            }
            else
            {
                Console.WriteLine("{0},{1},{2}", Num2, Num1, Num3);
            }
        }
        else
        {
            if (Num2 > Num3)
            {
                if (Num3 > Num1)
                {
                    Console.WriteLine("{0},{1},{2}", Num1, Num3, Num2);
                }
                else
                {
                    Console.WriteLine("{0},{1},{2}", Num3, Num1, Num2);
                }

                return;
            }
            else 
            {
                Console.WriteLine("{0},{1},{2}",Num1,Num2,Num3);
            }
           
        }

    }
} 