using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2_SpecialValue
{
    class Program
    {
        private static bool trueForFlag = false;
        private static int mod;
        private static int maxmod;
        private static int path;
        private static int countForPath;
        private static int countForHowManytimesIteratePath;

        static void Main(string[] args)
        {



            int countOfRows;
            int[][] jagetArrayWithNumbers;
            FillingJaggedArrayWithNumber(out countOfRows, out jagetArrayWithNumbers);

            PathTheAbsoluteValue(countOfRows, jagetArrayWithNumbers);
            Console.WriteLine(maxmod);
        }

        private static void PathTheAbsoluteValue(int countOfRows, int[][] jagetArrayWithNumbers)
        {
            trueForFlag = false;
            mod = 0;
            maxmod = 0;
            path = 0;
            countForPath = 0;
            countForHowManytimesIteratePath = 0;
            for (int row = 0; row < countOfRows; row++)
            {
                for (; path < jagetArrayWithNumbers[row].Length; )
                {
                    if (path < 0)
                    {
                        path = 1;
                        row = -1;
                        countForHowManytimesIteratePath = 0;
                        break;
                    }
                    if (jagetArrayWithNumbers[row][path] >= 0)
                    {
                        path = jagetArrayWithNumbers[row][path];
                        if (row == countOfRows - 1)
                        {
                            if (jagetArrayWithNumbers[row][path] == path && row == (countOfRows - 1))
                            {
                                countForHowManytimesIteratePath = 0;
                                path = 1;
                                row = -1;
                                break;
                            }

                            path = jagetArrayWithNumbers[row][path];
                            row = -1;
                            countForHowManytimesIteratePath++;
                            break;
                        }
                        countForHowManytimesIteratePath++;
                        break;
                    }
                    countForPath++;
                    countForHowManytimesIteratePath++;
                    if (jagetArrayWithNumbers[row][path] < 0)
                    {
                        mod = jagetArrayWithNumbers[row][path] % jagetArrayWithNumbers[row][path] - jagetArrayWithNumbers[row][path] + countForHowManytimesIteratePath;
                        if (mod > maxmod)
                        {
                            maxmod = mod;
                        }
                        path = countForPath;
                        row = 0;
                        countForHowManytimesIteratePath = 0;
                        if (path == jagetArrayWithNumbers[0].Length)
                        {
                            trueForFlag = true;
                            break;
                        }

                    }
                }
                if (trueForFlag)
                {
                    break;
                }
            }
        }

        private static void FillingJaggedArrayWithNumber(out int countOfRows, out int[][] jagetArrayWithNumbers)
        {

            countOfRows = int.Parse(Console.ReadLine());
            jagetArrayWithNumbers = new int[countOfRows][];
            for (int row = 0; row < countOfRows; row++)
            {
                var numberOfString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                jagetArrayWithNumbers[row] = new int[numberOfString.Length];

                for (int columb = 0; columb < numberOfString.Length; columb++)
                {
                    jagetArrayWithNumbers[row][columb] = int.Parse(numberOfString[columb]);
                }
            }
        }
    }
}

