using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace StatisticsGenerator
{
    public class RandomStatisticsGenerator
    {
        private double[] randomNumbers;
        private double[] statistics;
        private string[] overwritefile;

        public RandomStatisticsGenerator(int numbersCount, int numbersRange)
        {
            statistics = new double[numbersRange];
            randomNumbers = new double[numbersCount];
        }
        public void GenerateRandomStatistics()
        {
            Random random = new Random();
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(1, statistics.Length + 1);
            }
            int counterchars = 0;
            int counterdigit = 0;
            for (int i = 1; i < statistics.Length + 1; i++)
            {
                for (int j = 0; j < randomNumbers.Length; j++)
                {
                    if (randomNumbers[j] == i)
                    {
                        counterdigit++;
                    }
                    if (counterdigit == 10)
                    {
                        counterchars++;
                        counterdigit = 0;
                    }
                }
                statistics[i - 1] = counterchars;
                counterchars = 0;
                counterdigit = 0;
            }
        }
        public void PrintStatisticsToConsole()
        {
            for (int i = 0; i < statistics.Length; i++)
            {
                Console.Write("for " + i + " are found :");
                Console.Write("{0,4}", statistics[i] + ":");
                for (int t = 0; t < statistics[i]; t++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public void WriteStatisticsToCsvFile(string file)
        {
            if (File.Exists(file))
            {
                try
                {
                    File.Delete(file);
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            
            using (StreamWriter writer = new StreamWriter(file))
            {
                for (int i = 0; i < statistics.Length; i++)
                {
                    writer.Write((i + 1) + ",");
                    writer.Write(statistics[i]);
                    writer.WriteLine();
                }
            }
        }
    }
}
