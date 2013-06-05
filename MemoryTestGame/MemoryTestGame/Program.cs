using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MemoryTestGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On each turn you will be given a new number (1 - 20) that you have to remember");
        Console.WriteLine("All previous number will be displayed as well");
        Console.WriteLine("You have to memorize the new number and type it together with the old ones" +
            " (on seperate lines)");
        Console.Write("Press Enter to start:");
        Console.ReadLine();
 
        bool inputMatch = true;
        int[] list = new int[100];
        Random randGenerator = new Random();
        int numbersCount = 0;
 
        while (inputMatch)
        {
            int newNumber = randGenerator.Next(1, 20);       //generate new number
            list[numbersCount] = newNumber;
 
            for (int i = 0; i <= numbersCount; i++)         //print number sequence
            {
                Console.Write(list[i] + " ");
            }
            Thread.Sleep(2500);
            Console.Clear();                                //clear content
 
            Console.WriteLine("Type the numbers on new lines:");
            for (int i = 0; i <= numbersCount; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input != list[i])
                {
                    inputMatch = false;
                    break;
                }
            }
 
            numbersCount++;
        }
        Console.WriteLine("You managed to guess {0} numbers", numbersCount-1);
 
    }
        }
    }

