using System;
using System.Collections.Generic;
using System.IO;


class Hisdfstogram
{
    static void Main(string[] args)
    {

        StreamWriter writer = new StreamWriter("test.csv");
        using (writer)
        {
            int counter = 1;
            int broqch = 0;
            int[] statistics = new int[100];
            int[] range = new int[10000];
            Random newrandom = new Random();
            for (int i = 0; i < range.Length; i++)
            {
                range[i] = newrandom.Next(1, 101);
            }
            for (int i = 1; i < 101; i++)
            {
                for (int j = 0; j < 10000; j++)
                {
                    if (range[j] == i)
                    {
                        counter++;
                    }
                    if (counter == 10)
                    {
                        broqch++;
                        counter = 0;
                    }

                }
                Console.Write("{0,4}", "\'" + i + "\'");
                Console.Write(broqch+":");
                statistics[i-1] = broqch;
                writer.Write(i + ",");
                writer.Write(broqch);
                for (int t = 0; t < broqch; t++)
                {
                    Console.Write('*');
                }
                writer.WriteLine();
                Console.WriteLine();
                counter = 0;
                broqch = 0;
            }
        }
    }
}
    


        
    

        
    



