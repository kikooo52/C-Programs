using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    class Guitar
    {
        private static int beginTone;
        private static int maxTone;
        private static int countTone;
        private static int[] toneOfGuitar;
        private static int[,] posibleTone;

        static void Main(string[] args)
        {
            Console.Write("Enter beginTone:");
            beginTone = int.Parse(Console.ReadLine());

            Console.Write("Enter maxTone:");
            maxTone = int.Parse(Console.ReadLine());
            Console.Write("Enter count of changes in the tone of the guitar:");
            countTone = int.Parse(Console.ReadLine());
            toneOfGuitar = new int[countTone];
            for (int i = 0; i < toneOfGuitar.Length; i++)
            {
                Console.Write("Enter each tons:");
                toneOfGuitar[i] = int.Parse(Console.ReadLine());
            }
            CheckAllValue();
            Console.WriteLine(PrintMaxValue());
        }
        private static void CheckAllValue()
        {
            posibleTone = new int[toneOfGuitar.Length+1, maxTone+1];
            posibleTone[0, beginTone] = 1;
            for (int row = 1; row < posibleTone.GetLength(0); row++)
            {
                for (int col = posibleTone.GetLength(1)-1; col >= 0; col--)
                {
                    if (posibleTone[row - 1, col] == 1)
                    {

                        if (col - toneOfGuitar[row - 1]  >= 0)
                        {
                            posibleTone[row, col - toneOfGuitar[row - 1]] = 1;
                        }
                        if ( col + toneOfGuitar[row - 1] <= maxTone)
                        {
                            posibleTone[row, col + toneOfGuitar[row - 1]] = 1;
                        }
                    }
                }
            }        
        }

         static int PrintMaxValue()
        {
            for (int coll = posibleTone.GetLength(1) - 1; coll >= 0; coll--)
            {
                if (posibleTone[posibleTone.GetLength(0) - 1, coll] == 1)
                {
                    return coll;
                }               
            }
           return -1;
        }
    }
}
