using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3_Kukata
{
    class Program
    {
        private static int directinIndex;
        private static int row;
        private static int col= 123213;
        private static string[,] danceCube;
        private static int numberOfDencer;
        private static string inputMove;

        static void Main(string[] args)
        {
            danceCube = new string[,]
                                  {{"RED","BLUE","RED"},
                                  {"BLUE","GREEN","BLUE"}, 
                                  {"RED","BLUE","RED"}};
            Console.WriteLine(Program.col);

            directinIndex = 0;
            row = 1;
            col = 1;
            numberOfDencer = int.Parse(Console.ReadLine());
            for (int j = 0; j < numberOfDencer; j++)
            {
                inputMove = Console.ReadLine().ToUpper();
                for (int i = 0; i < inputMove.Length; i++)
                {
                    if (inputMove[i] == 'L' || inputMove[i] == 'R')
                    {
                        GetDirection(i);
                    }
                    else
                    {
                        WalkDencer(i);
                    }

                }
                Console.WriteLine(danceCube[row, col]);
                col = 1;
                row = 1;
                directinIndex = 0;
            }
        }

        private static void WalkDencer(int i)
        {

            if (directinIndex == 0)  // up
            {
                row--;
                if (row == -1)
                {
                    row = 2;
                }
            }
            if (directinIndex == 1 || directinIndex == -3) // left
            {
                col--;
                if (col == -1)
                {
                    col = 2;
                }
            }
            if (directinIndex == 2 || directinIndex == -2) // down
            {
                row++;
                if (row == 3)
                {
                    row = 0;
                }
            }
            if (directinIndex == 3 || directinIndex == -1) // right
            {
                col++;
                if (col == 3)
                {
                    col = 0;
                }
            }
        }

        private static void GetDirection(int i)
        {
            if (inputMove[i] == 'L')
            {
                directinIndex++;
                if (directinIndex == 4)
                {
                    directinIndex = 0;
                }
            }
            if (inputMove[i] == 'R')
            {
                directinIndex--;
                if (directinIndex == -4)
                {
                    directinIndex = 0;
                }
            }
        }
    }
}